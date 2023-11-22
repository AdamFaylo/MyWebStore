using MyProject.API.Context;
using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;

namespace MyProject.API.Repositories.Implementation
{
    public class LogoImageRepository : RepositoryBase<LogoImage>, ILogoImageRepository
    {
        public LogoImageRepository(MainContext context) : base(context)
        {

        }

    }
}
