using Ninject.Modules;
using RegistrationAngular.Service;

namespace RegistrationAngular.Modules
{
    public class SubjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ISubjectService>().To<SubjectService>();
        }
         
    }
}