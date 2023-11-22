using MyProject.API.Context;
using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;

namespace MyProject.API.Repositories.Implementation
{
    public class ColorsRepository : RepositoryBase<Color>, IColorsRepository
    {
        public ColorsRepository(MainContext context) : base(context)
        {
        }
    }

}
