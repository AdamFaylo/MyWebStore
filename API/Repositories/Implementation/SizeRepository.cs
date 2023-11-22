using MyProject.API.Context;
using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;

namespace MyProject.API.Repositories.Implementation
{
    public class SizeRepository : RepositoryBase<Size>, ISizeRepository
    {
        public SizeRepository(MainContext context) : base(context)
        {
        }
    }

}
