using API.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using MyProject.API.Repositories.Abstract;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class InitialStateController : Controller
    {
        private readonly ICartRepository _cartRepo;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IColorsRepository _colorsRepo;
        private readonly ICustomerRepository _customerRepo;
        private readonly IDepartmentRepository _departmentRepo;
        private readonly IGalleryImageRepository _galleryImageRepo;
        private readonly IOrderRepository _orderRepo;
        private readonly IOrderItemRepository _orderItemRepo;
        private readonly IPaymentRepository _paymentRepo;
        private readonly IProductRepository _productRepo;
        private readonly IShippingAddressRepository _shippingAddressRepo;
        private readonly ISizeRepository _sizeRepo;
        private readonly ISubCategoryRepository _subCategoryRepo;

        public InitialStateController(
            ICartRepository _cartRepo,
            ICategoryRepository _categoryRepo,
            IColorsRepository _colorsRepo,
            ICustomerRepository _customerRepo,
            IDepartmentRepository _departmentRepo,
            IGalleryImageRepository _galleryImageRepo,
            IOrderRepository _orderRepo,
            IOrderItemRepository _orderItemRepo,
            IPaymentRepository _paymentRepo,
            IProductRepository _productRepo,
            IShippingAddressRepository _shippingAddressRepo,
            ISizeRepository _sizeRepo,
            ISubCategoryRepository _subCategoryRepo

            )
        {
            this._cartRepo = _cartRepo ?? throw new ArgumentNullException(nameof(_cartRepo));
            this._categoryRepo = _categoryRepo ?? throw new ArgumentNullException(nameof(_categoryRepo));
            this._colorsRepo = _colorsRepo ?? throw new ArgumentNullException(nameof(_colorsRepo));
            this._customerRepo = _customerRepo ?? throw new ArgumentNullException(nameof(_customerRepo));
            this._departmentRepo = _departmentRepo ?? throw new ArgumentNullException(nameof(_departmentRepo));
            this._galleryImageRepo = _galleryImageRepo ?? throw new ArgumentNullException(nameof(_galleryImageRepo));
            this._orderRepo = _orderRepo ?? throw new ArgumentNullException(nameof(_orderRepo));
            this._orderItemRepo = _orderItemRepo ?? throw new ArgumentNullException(nameof(_orderItemRepo));
            this._paymentRepo = _paymentRepo ?? throw new ArgumentNullException(nameof(_paymentRepo));
            this._productRepo = _productRepo ?? throw new ArgumentNullException(nameof(_productRepo));
            this._shippingAddressRepo = _shippingAddressRepo ?? throw new ArgumentNullException(nameof(_shippingAddressRepo));
            this._sizeRepo = _sizeRepo ?? throw new ArgumentNullException(nameof(_sizeRepo));
            this._subCategoryRepo = _subCategoryRepo ?? throw new ArgumentNullException(nameof(_subCategoryRepo));
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            InitialStateData result = InitialStateData.Create(
            _cartRepo,
            _categoryRepo,
            _colorsRepo,
            _customerRepo,
            _departmentRepo,
            _galleryImageRepo,
            _orderRepo,
            _orderItemRepo,
            _paymentRepo,
            _productRepo,
            _shippingAddressRepo,
            _sizeRepo,
            _subCategoryRepo

                );

            return Ok(result);
        }
    }
}
