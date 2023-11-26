using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyProject.API.Models;
using MyProject.API.Models.Enums;


namespace MyProject.API.Context
{
    public class MainContext : IdentityDbContext
    {
        public MainContext(DbContextOptions<MainContext> _options)
            : base(_options)
        {
        }

        public DbSet<Cart> Cart { get; set; }
        public DbSet<LogoImage> LogoImage { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<GalleryImage> GalleryImage { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ShippingAddress> ShippingAddress { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //User 
            modelBuilder.Entity<User>().HasData(
             new User { ID = 1, FirstName = "Adam", LastName = "Faylo", EmailAddress = "adam@gmail.com", UserName = "adam", Password = "12346578", Type = UserType.Admin },
             new User { ID = 2, FirstName = "Eran", LastName = "BenDahan", EmailAddress = "eran@gmail.com", UserName = "eran", Password = "87654321", Type = UserType.Unknown },
             new User { ID = 3, FirstName = "Roman", LastName = "Coco", EmailAddress = "roman@gmail.com", UserName = "rom", Password = "55555555", Type = UserType.Readonly }
                );

            modelBuilder.Entity<User>()
                    .HasOne(e => e.Cart)
                    .WithOne(e => e.User)
                    .HasForeignKey<Cart>(e => e.UserID)
                    .IsRequired();

            modelBuilder.Entity<Cart>()
                .HasKey(c => c.CartId);



            modelBuilder.Entity<Product>()
                .Property(p => p.AddedOn)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Cart>().HasData(
                new Cart { CartId = 1, UserID = 1, CartType = 1 },
                new Cart { CartId = 2, UserID = 2, CartType = 2 }
                );

            //Logo
            modelBuilder.Entity<LogoImage>().HasData(
             new LogoImage { ID = 1, Logo = "https://i.imgur.com/OeC6gqG.jpg", Alt = "Logo vanes site" }

                );
            //Payment
            modelBuilder.Entity<Payment>().HasData(
             new Payment { ID = 1, Amount = 29.90m, PaymentDate = DateTime.UtcNow.AddDays(-1), OrderID = 1 },
             new Payment { ID = 2, Amount = 39.90m, PaymentDate = DateTime.UtcNow.AddDays(-2), OrderID = 2 }
                );
            //Sizes -
            modelBuilder.Entity<Size>().HasData(
             new Size { ID = 1, SizeName = "XS", ProductID = 1 },
             new Size { ID = 2, SizeName = "S", ProductID = 2 },
             new Size { ID = 3, SizeName = "M", ProductID = 3 }
                );
            //OrderItem
            modelBuilder.Entity<OrderItem>().HasData(
             new OrderItem { ID = 1, Quantity = 2, ProductID = 1, CartID = 1, OrderId = 1 },
             new OrderItem { ID = 2, Quantity = 8, ProductID = 2, CartID = 2, OrderId = 2 }
                );



            //Orders -
            modelBuilder.Entity<Order>().HasData(
             new Order { OrderId = 1, IsPaid = true, CustomerID = 1, OrderDate = DateTime.Now.AddDays(-1), CartId = 1, ShippingAddressID = 1, },
             new Order { OrderId = 2, IsPaid = false, CustomerID = 2, OrderDate = DateTime.Now.AddDays(-2), CartId = 2, ShippingAddressID = 2, }
                );
            //modelBuilder.Entity<Order>()
            //    .HasOne(o => o.Cart)          // An order has one cart
            //    .WithMany(c => c.Orders)      // A cart can have many orders
            //    .HasForeignKey(o => o.CartID) // Define the foreign key property
            //    .IsRequired();

            base.OnModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);

            //Customer -
            modelBuilder.Entity<Customer>().HasData(
             new Customer { ID = 1, FirstName = "Adam", LastName = "Faylo", Mail = "ed.mil.86@gmail.com" },
             new Customer { ID = 2, FirstName = "Ray", LastName = "Faylo", Mail = "ray.faylo@gmail.com" }
           );

            //Types -
            modelBuilder.Entity<Department>().HasData(
             new Department { ID = 1, Name = "Man" },
             new Department { ID = 2, Name = "Ladies" },
             new Department { ID = 3, Name = "Kids" }
                );
            //Category 
            modelBuilder.Entity<Category>().HasData(
             //MAN
             new Category { ID = 1, Name = "Shoes" },
             new Category { ID = 2, Name = "Garments" },
             new Category { ID = 3, Name = "Accessories" },
             //LADIES
             new Category { ID = 4, Name = "Shoes" },
             new Category { ID = 5, Name = "Garments" },
             new Category { ID = 6, Name = "Accessories" },
             //KIDS
             new Category { ID = 7, Name = "Shoes" },
             new Category { ID = 8, Name = "Garments" },
             new Category { ID = 9, Name = "Accessories" }

           );
            //SubCategory
            modelBuilder.Entity<SubCategory>().HasData(

             new SubCategory { ID = 1, CategoryID = 1, SubCategoryName = "Sneakers" },
             new SubCategory { ID = 2, CategoryID = 2, SubCategoryName = "T-Shirts" },
             new SubCategory { ID = 3, CategoryID = 2, SubCategoryName = "Pants" },
             new SubCategory { ID = 4, CategoryID = 3, SubCategoryName = "ACC" },
             //-------------------------------------------------------------------------
             new SubCategory { ID = 5, CategoryID = 4, SubCategoryName = "Sneakers" },
             new SubCategory { ID = 6, CategoryID = 5, SubCategoryName = "T-Shirts" },
             new SubCategory { ID = 7, CategoryID = 5, SubCategoryName = "Pants" },
             new SubCategory { ID = 8, CategoryID = 6, SubCategoryName = "ACC" },
             //--------------------------------------------------------------------------
             new SubCategory { ID = 9, CategoryID = 7, SubCategoryName = "Sneakers" },
             new SubCategory { ID = 10, CategoryID = 8, SubCategoryName = "T-Shirts" },
             new SubCategory { ID = 11, CategoryID = 8, SubCategoryName = "Pants" },
             new SubCategory { ID = 12, CategoryID = 9, SubCategoryName = "ACC" }

                );

            modelBuilder.Entity<Product>()
                .Property(p => p.AddedOn)
                .HasDefaultValueSql("getDate()");

            // //Product - 
            modelBuilder.Entity<Product>().HasData(

                //--------------------------------------------------MAN--------------------------------------------------------//
                new Product { ID = 1, DepartmentID = 1, SubCategoryID = 1, ProductName = "Sneakers001", Price = 299.90M },
                new Product { ID = 2, DepartmentID = 1, SubCategoryID = 1, ProductName = "Sneakers002", Price = 359.90M },
                new Product { ID = 3, DepartmentID = 1, SubCategoryID = 1, ProductName = "Sneakers003", Price = 59.90M },
                new Product { ID = 4, DepartmentID = 1, SubCategoryID = 2, ProductName = "T-Shirts001", Price = 89.90M },
                new Product { ID = 5, DepartmentID = 1, SubCategoryID = 2, ProductName = "T-Shirts002", Price = 29.90M },
                new Product { ID = 6, DepartmentID = 1, SubCategoryID = 2, ProductName = "T-Shirts003", Price = 29.90M },
                new Product { ID = 7, DepartmentID = 1, SubCategoryID = 3, ProductName = "Pants001", Price = 29.90M },
                new Product { ID = 8, DepartmentID = 1, SubCategoryID = 3, ProductName = "Pants002", Price = 29.90M },
                new Product { ID = 9, DepartmentID = 1, SubCategoryID = 3, ProductName = "Pants003", Price = 29.90M },
                new Product { ID = 10, DepartmentID = 1, SubCategoryID = 4, ProductName = "ACC001", Price = 299.90M },
                new Product { ID = 11, DepartmentID = 1, SubCategoryID = 4, ProductName = "ACC002", Price = 59.90M },
                new Product { ID = 12, DepartmentID = 1, SubCategoryID = 4, ProductName = "ACC003", Price = 89.90M },

                //--------------------------------------------------LADIES--------------------------------------------------------//

                new Product { ID = 13, DepartmentID = 2, SubCategoryID = 5, ProductName = "Sneakers001", Price = 299.90M, },
                new Product { ID = 14, DepartmentID = 2, SubCategoryID = 5, ProductName = "Sneakers002", Price = 359.90M },
                new Product { ID = 15, DepartmentID = 2, SubCategoryID = 5, ProductName = "Sneakers003", Price = 59.90M },
                new Product { ID = 16, DepartmentID = 2, SubCategoryID = 6, ProductName = "T-Shirts001", Price = 89.90M },
                new Product { ID = 17, DepartmentID = 2, SubCategoryID = 6, ProductName = "T-Shirts002", Price = 29.90M },
                new Product { ID = 18, DepartmentID = 2, SubCategoryID = 6, ProductName = "T-Shirts003", Price = 29.90M },
                new Product { ID = 19, DepartmentID = 2, SubCategoryID = 7, ProductName = "Pants001", Price = 29.90M },
                new Product { ID = 20, DepartmentID = 2, SubCategoryID = 7, ProductName = "Pants002", Price = 29.90M },
                new Product { ID = 21, DepartmentID = 2, SubCategoryID = 7, ProductName = "Pants003", Price = 29.90M },
                new Product { ID = 22, DepartmentID = 2, SubCategoryID = 8, ProductName = "ACC", Price = 29.90M },
                new Product { ID = 23, DepartmentID = 2, SubCategoryID = 8, ProductName = "ACC", Price = 29.90M },
                new Product { ID = 24, DepartmentID = 2, SubCategoryID = 8, ProductName = "ACC", Price = 29.90M },


                //--------------------------------------------------KIDS--------------------------------------------------------//
                new Product { ID = 25, DepartmentID = 3, SubCategoryID = 9, ProductName = "Sneakers001", Price = 299.90M, },
                new Product { ID = 26, DepartmentID = 3, SubCategoryID = 9, ProductName = "Sneakers002", Price = 359.90M },
                new Product { ID = 27, DepartmentID = 3, SubCategoryID = 9, ProductName = "Sneakers003", Price = 59.90M },
                new Product { ID = 28, DepartmentID = 3, SubCategoryID = 10, ProductName = "T-Shirts001", Price = 89.90M },
                new Product { ID = 29, DepartmentID = 3, SubCategoryID = 10, ProductName = "T-Shirts002", Price = 29.90M },
                new Product { ID = 30, DepartmentID = 3, SubCategoryID = 10, ProductName = "T-Shirts003", Price = 29.90M },
                new Product { ID = 31, DepartmentID = 3, SubCategoryID = 12, ProductName = "ACC001", Price = 299.90M, },
                new Product { ID = 32, DepartmentID = 3, SubCategoryID = 12, ProductName = "ACC002", Price = 59.90M },
                new Product { ID = 33, DepartmentID = 3, SubCategoryID = 12, ProductName = "ACC003", Price = 89.90M }


                );

            modelBuilder.Entity<GalleryImage>()
             .HasOne(p => p.Product)
             .WithMany(g => g.GalleryImage)
             .HasForeignKey(s => s.ID);

            //Colors 
            modelBuilder.Entity<Color>().HasData(
              new Color { ID = 1, Name = "White", ProductID = 1 },
              new Color { ID = 2, Name = "Black", ProductID = 2 },
              new Color { ID = 3, Name = "Blue", ProductID = 2 }
                );
            //ShippingAddress 
            modelBuilder.Entity<ShippingAddress>().HasData(
              new ShippingAddress { ID = 1, Address = "Nahal oz", City = "NewYork", Region = "Center", PostalCode = "51819", Country = "Israel" },
              new ShippingAddress { ID = 2, Address = "Baryehoda", City = "Hollywood", Region = "Center", PostalCode = "51819", Country = "Israel" }
             );

            //GalleryImage 
            modelBuilder.Entity<GalleryImage>().HasData(

              //------------------------------------------------MAN-------------------------------------------------------//
              //-------------------Shoes-------------------//
              new GalleryImage { ID = 1, ProductID = 1, ImageURL = "https://i.imgur.com/x3U6jKx.jpg", Alt = "man", Title = "shoes for man" },
              new GalleryImage { ID = 2, ProductID = 2, ImageURL = "https://i.imgur.com/LnQGteX.jpg", Alt = "man", Title = "shoes for man" },
              new GalleryImage { ID = 3, ProductID = 3, ImageURL = "https://i.imgur.com/v3SN2Vo.jpg", Alt = "man", Title = "shoes for man" },
              //--------------------T-SHIRTS----------------------//
              new GalleryImage { ID = 4, ProductID = 4, ImageURL = "https://i.imgur.com/CVmmzhU.jpg", Alt = "man", Title = "shoes for man" },
              new GalleryImage { ID = 5, ProductID = 5, ImageURL = "https://i.imgur.com/LGfzcug.jpg", Alt = "man", Title = "shoes for man" },
              new GalleryImage { ID = 6, ProductID = 6, ImageURL = "https://i.imgur.com/P3XGF8p.jpg", Alt = "man", Title = "shoes for man" },
              //-------------------trousers----------------//
              new GalleryImage { ID = 7, ProductID = 7, ImageURL = "https://i.imgur.com/oPlSrbz.jpg", Alt = "man", Title = "shoes pastel color for man" },
              new GalleryImage { ID = 8, ProductID = 8, ImageURL = "https://i.imgur.com/0oZ7MrE.jpg", Alt = "man", Title = "shoes pink for man" },
              new GalleryImage { ID = 9, ProductID = 9, ImageURL = "https://i.imgur.com/UczdMkv.jpg", Alt = "man", Title = "shoes pink for man" },
              //---------------------acc-----------------//
              new GalleryImage { ID = 10, ProductID = 10, ImageURL = "https://i.imgur.com/qpalZ7J.jpg", Alt = "man", Title = "shoes for man" },
              new GalleryImage { ID = 11, ProductID = 11, ImageURL = "https://i.imgur.com/Qd0hKEe.jpg", Alt = "man", Title = "shoes for man" },
              new GalleryImage { ID = 12, ProductID = 12, ImageURL = "https://i.imgur.com/vPXZfwu.jpg", Alt = "man", Title = "shoes for man" },

              //--------------------------------------------------LADIES--------------------------------------------------------//
              //-------------------Shoes-------------------//
              new GalleryImage { ID = 13, ProductID = 13, ImageURL = "https://i.imgur.com/A4b2kSN.jpg", Alt = "woman_shoes", Title = "shoes pastel color for woman" },
              new GalleryImage { ID = 14, ProductID = 14, ImageURL = "https://i.imgur.com/z1zF5F0.jpg", Alt = "woman_shoes", Title = "shoes pink for woman" },
              new GalleryImage { ID = 15, ProductID = 15, ImageURL = "https://i.imgur.com/GYkO0dn.jpg", Alt = "woman_shoes", Title = "shoes pink for woman" },
              //-------------------T-SHIRTS-----------------//
              new GalleryImage { ID = 16, ProductID = 16, ImageURL = "https://i.imgur.com/yKIuCZN.jpg", Alt = "woman", Title = "T-SHIRT for woman" },
              new GalleryImage { ID = 17, ProductID = 17, ImageURL = "https://i.imgur.com/rgMPyCg.jpg", Alt = "woman", Title = "T-SHIRT for woman" },
              new GalleryImage { ID = 18, ProductID = 18, ImageURL = "https://i.imgur.com/IkeJGoS.jpg", Alt = "woman", Title = "T-SHIRT for woman" },
              //--------------------trousers---------------//
              new GalleryImage { ID = 19, ProductID = 19, ImageURL = "https://i.imgur.com/NhR4kFB.jpg", Alt = "woman_trousers", Title = "trousers for woman" },
              new GalleryImage { ID = 20, ProductID = 20, ImageURL = "https://i.imgur.com/4xStoKp.jpg", Alt = "woman_trousers", Title = "trousers for woman" },
              new GalleryImage { ID = 21, ProductID = 21, ImageURL = "https://i.imgur.com/n3TMOZI.jpg", Alt = "woman_trousers", Title = "trousers for woman" },
              //-------------------acc----------------//
              new GalleryImage { ID = 22, ProductID = 22, ImageURL = "https://i.imgur.com/KuAG5Ae.jpg", Alt = "woman_acc", Title = "acc for woman" },
              new GalleryImage { ID = 23, ProductID = 23, ImageURL = "https://i.imgur.com/5Mp82QF.jpg", Alt = "woman_acc", Title = "acc pink for woman" },
              new GalleryImage { ID = 24, ProductID = 24, ImageURL = "https://i.imgur.com/VvOHI60.jpg", Alt = "woman_acc", Title = "acc pink for woman" },

              //------------------------------------------------KIDS-------------------------------------------------------//
              new GalleryImage { ID = 25, ProductID = 25, ImageURL = "https://i.imgur.com/mtgc2Kl.jpg", Alt = "kids", Title = "shoes for kids" },
              new GalleryImage { ID = 26, ProductID = 26, ImageURL = "https://i.imgur.com/IMMWY3v.jpg", Alt = "kids", Title = "shoes for kids" },
              new GalleryImage { ID = 27, ProductID = 27, ImageURL = "https://i.imgur.com/bFZSTKa.jpg", Alt = "kids", Title = "shoes for kids" },
              //------------------T-SHIRTS------------------//
              new GalleryImage { ID = 28, ProductID = 28, ImageURL = "https://i.imgur.com/VXSGhtq.jpg", Alt = "kids", Title = "shoes for kids" },
              new GalleryImage { ID = 29, ProductID = 29, ImageURL = "https://i.imgur.com/ugyS15L.jpg", Alt = "kids", Title = "shoes for kids" },
              new GalleryImage { ID = 30, ProductID = 30, ImageURL = "https://i.imgur.com/FcuvIH4.jpg", Alt = "kids", Title = "shoes for kids" },
              //-------------------ACC------------------//
              new GalleryImage { ID = 31, ProductID = 31, ImageURL = "https://i.imgur.com/hFBMhA1.jpg", Alt = "kids", Title = "shoes for kids" },
              new GalleryImage { ID = 32, ProductID = 32, ImageURL = "https://i.imgur.com/OeC6gqG.jpg", Alt = "kids", Title = "shoes for kids" },
              new GalleryImage { ID = 33, ProductID = 33, ImageURL = "https://i.imgur.com/P0vlF79.jpg", Alt = "kids", Title = "shoes for kids" }
              //------------------------------------------//


           );
        }
    }
}