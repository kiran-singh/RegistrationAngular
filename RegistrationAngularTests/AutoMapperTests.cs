using System;
using System.Linq;
using AutoMapper;
using NUnit.Framework;

namespace RegistrationAngularTests
{
    [TestFixture]
    public class AutoMapperTests
    {
        [Test]
        public void Lambda_List_ResultAsExpected()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            // Use method syntax to apply a lambda expression to each element
            // of the words array. 
            int shortestWordLength = words.Min(x => x.Length);
            Console.WriteLine(shortestWordLength);

            // Compare the following code that uses query syntax.
            // Get the lengths of each word in the words array.
            var query = from w in words
                        select w.Length;
            // Apply the Min method to execute the query and get the shortest length.
            int shortestWordLength2 = query.Min();
            Console.WriteLine(shortestWordLength2);
        }

        [Test]
        public void CheckInModel_ServiceModelMap_ResultAsExpected()
        {
            // Arrange
            Mapper.CreateMap<ServiceModel, CheckInModel>()
                //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Number.ToString()))
                .ForMember(dest => dest.Action, opt => opt.ResolveUsing<CheckInResolver>())
                .ForMember(dest=>dest.Name, opt=>opt.Ignore());

            Mapper.CreateMap<DomainModel, CheckInModel>()   //.ConvertUsing<DomainToCheckInConverter>();
                .ForMember(dest => dest.Action, opt => opt.ResolveUsing<CheckInResolver>());

            Mapper.AssertConfigurationIsValid();

            // Act
            var actual = Mapper.Map<ServiceModel, CheckInModel>(new ServiceModel
            {
                CheckIn = new DateTime()
            });
            var domainActual = Mapper.Map<DomainModel, CheckInModel>(new DomainModel());

            // Assert
            Console.WriteLine("Name: {0}", actual.Name);
            Assert.AreEqual("check out", actual.Action);
            Assert.AreEqual("check in", domainActual.Action);
        }
    }

    public class DomainToCheckInConverter : TypeConverter<DomainModel, CheckInModel>
    {
        private readonly ICustomFormatter _customFormatter;

        public DomainToCheckInConverter(ICustomFormatter customFormatter)
        {
            _customFormatter = customFormatter;
        }

        protected override CheckInModel ConvertCore(DomainModel source)
        {
            return new CheckInModel();
        }
    }

    public class CheckInResolver : ValueResolver<ICheckIn, string>
    {
        protected override string ResolveCore(ICheckIn source)
        {
            return source.CheckIn.HasValue ? "check out" : "check in";
        }
    }

    public class CheckInModel
    {
        public string Action { get; set; }
        public string Name { get; set; }
    }

    public class ServiceModel : ICheckIn
    {
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public int Number { get; set; }
    }

    public interface ICheckIn
    {
        DateTime? CheckIn { get; set; }
        DateTime? CheckOut { get; set; }
    }

    public class DomainModel : ICheckIn
    {
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string Name { get; set; }
    }
}