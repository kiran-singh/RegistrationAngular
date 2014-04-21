using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using RegistrationAngular.Models;

namespace RegistrationAngular.Repository
{
    public class SubjectRepository : RepositoryBase<Subject>
    {
        public override IQueryable<Subject> GetAll()
        {
            return new EnumerableQuery<Subject>(new List<Subject>
            {
                new Subject{ Id = 1, Name = "Physics", BgColour = Color.Green },
                new Subject{ Id = 1, Name = "Chemistry", BgColour = Color.Red },
                new Subject{ Id = 1, Name = "Maths", BgColour = Color.Blue },
                new Subject{ Id = 1, Name = "Economics", BgColour = Color.Purple },
                new Subject{ Id = 1, Name = "Geography", BgColour = Color.Yellow },
                new Subject{ Id = 1, Name = "English", BgColour = Color.Brown },
            }.AsEnumerable());
        }
    }
}