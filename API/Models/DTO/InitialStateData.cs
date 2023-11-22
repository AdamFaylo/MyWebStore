﻿using MyProject.API.Models;
using MyProject.API.Repositories.Abstract;

namespace API.Models.DTO
{
    internal class InitialStateData
    {

        private InitialStateData()
        {

        }

        public List<Cart> Cart { get; private set; }
        public List<Category> Categories { get; private set; }
        public List<Color> Colors { get; private set; }
        public List<Customer> Customer { get; private set; }
        public List<Department> Department { get; private set; }
        public List<GalleryImage> GalleryImage { get; private set; }
        public List<Order> Order { get; private set; }
        public List<OrderItem> GrderItem { get; private set; }
        public List<Payment> Payment { get; private set; }
        public List<Product> Products { get; private set; }
        public List<ShippingAddress> shippingAddress { get; private set; }
        public List<Size> Sizes { get; private set; }
        public List<SubCategory> SubCategories { get; private set; }

        internal static InitialStateData Create(

            ICartRepository cartRepository,
            ICategoryRepository categoryRepo,
            IColorsRepository colorsRepo,
            ICustomerRepository customerRepo,
            IDepartmentRepository departmentRepo,
            IGalleryImageRepository galleryImageRepo,
            IOrderRepository orderRepo,
            IOrderItemRepository orderItemRepo,
            IPaymentRepository paymentRepo,
            IProductRepository productRepo,
            IShippingAddressRepository shippingAddressRepo,
            ISizeRepository sizeRepo,
            ISubCategoryRepository subCategoryRepo
            )
        {
            InitialStateData initialStateData = new InitialStateData();

            initialStateData.Cart = cartRepository.FindAll().ToList();
            initialStateData.Categories = categoryRepo.FindAll().ToList();
            initialStateData.Colors = colorsRepo.FindAll().ToList();
            initialStateData.Customer = customerRepo.FindAll().ToList();
            initialStateData.Department = departmentRepo.FindAll().ToList();
            initialStateData.GalleryImage = galleryImageRepo.FindAll().ToList();
            initialStateData.GrderItem = orderItemRepo.FindAll().ToList();
            initialStateData.Payment = paymentRepo.FindAll().ToList();
            //initialStateData.Products = productRepo.FindAll().ToList();
            initialStateData.shippingAddress = shippingAddressRepo.FindAll().ToList();
            initialStateData.Sizes = sizeRepo.FindAll().ToList();
            //initialStateData.SubCategories = subCategoryRepo.FindAll().ToList();

            return initialStateData;
        }
    }
}