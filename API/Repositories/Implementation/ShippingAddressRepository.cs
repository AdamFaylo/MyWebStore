using MyProject.API.Context;
using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;

namespace MyProject.API.Repositories.Implementation
{
    public class ShippingAddressRepository : RepositoryBase<ShippingAddress>, IShippingAddressRepository
    {
        public ShippingAddressRepository(MainContext context) : base(context)
        {
        }
    }

}
