using ASPProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProjekat.DataAccess
{
    public static class InitialData
    {
        
        public static List<Role> Roles = new List<Role>
        {
            new Role
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                Name = "User"
            },
            new Role
            {
                Id = 2,
                CreatedAt = DateTime.Now,
                Name = "Admin"
            }
        };

        public static List<RoleUseCase> RoleUseCases = new List<RoleUseCase>
        {
            new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 1
            },
            new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 3
            },
            new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 4
            },
             new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 7
            },
            new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 9
            },
            new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 10
            },
            new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 6
            },
            new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 8
            },
            new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 13
            },
            new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 11
            },
            new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 15
            },
            new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 16
            },
            new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 19
            },
            new RoleUseCase
            {
                RoleId = 1,
                UseCaseId = 28
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 1
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 2
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 3
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 4
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 5
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 6
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 7
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 8
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 9
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 10
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 11
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 12
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 13
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 14
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 15
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 16
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 17
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 18
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 19
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 20
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 21
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 22
            },
             new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 23
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 24
            },
             new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 25
            },
              new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 26
            },
                new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 27
            },
            new RoleUseCase
            {
                RoleId = 2,
                UseCaseId = 28
            },
        };

        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                FirstName = "John",
                LastName = "Smith",
                Email = "johnsmith@gmail.com",
                Password = "$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu",
                RoleId = 1
            },
            new User
            {
                Id = 2,
                CreatedAt = DateTime.Now,
                FirstName = "Mike",
                LastName = "Legend",
                Email = "mikelegend@gmail.com",
                Password = "$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu",
                RoleId = 1
            },
            new User
            {
                Id = 3,
                CreatedAt = DateTime.Now,
                FirstName = "Maria",
                LastName = "Jameson",
                Email = "mariajameson@gmail.com",
                Password = "$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu",
                RoleId = 1
            },
            new User
            {
                Id = 4,
                CreatedAt = DateTime.Now,
                FirstName = "Julia",
                LastName = "Williams",
                Email = "juliawilliams@gmail.com",
                Password = "$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu",
                RoleId = 1
            },
            new User
            {
                Id = 5,
                CreatedAt = DateTime.Now,
                FirstName = "Michele",
                LastName = "Roberts",
                Email = "micheleroberts@gmail.com",
                Password = "$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu",
                RoleId = 1
            },
            new User
            {
                Id = 6,
                CreatedAt = DateTime.Now,
                FirstName = "Anastasija",
                LastName = "Jokovic",
                Email = "anastasija@gmail.com",
                Password = "$2a$11$hPsl4hFksFlOiMv5bSBT8eJ23/PShHt3ixygI9V.LYqw6nQwDn4Zu",
                RoleId = 2
            }
        };

        public static List<Category> Categories = new List<Category>
        {
            new Category
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                CategoryName = "Table",
                ParentCategoryId = null
            },
            new Category
            {
                Id = 2,
                CreatedAt = DateTime.Now,
                CategoryName = "Bed",
                ParentCategoryId = null
            },
            new Category
            {
                Id = 3,
                CreatedAt = DateTime.Now,
                CategoryName = "Chair",
                ParentCategoryId = null
            },
            new Category
            {
                Id = 4,
                CreatedAt = DateTime.Now,
                CategoryName = "Decoration",
                ParentCategoryId = null
            },
            new Category
            {
                Id = 5,
                CreatedAt = DateTime.Now,
                CategoryName = "Dining table",
                ParentCategoryId = 1
            },
            new Category
            {
                Id = 6,
                CreatedAt = DateTime.Now,
                CategoryName = "Coffee table",
                ParentCategoryId = 1
            },
            new Category
            {
                Id = 9,
                CreatedAt = DateTime.Now,
                CategoryName = "Single bed",
                ParentCategoryId = 2
            },
            new Category
            {
                Id = 10,
                CreatedAt = DateTime.Now,
                CategoryName = "Duble bed",
                ParentCategoryId = 2
            },
            new Category
            {
                Id = 11,
                CreatedAt = DateTime.Now,
                CategoryName = "Sofa",
                ParentCategoryId = 2
            },
            new Category
            {
                Id = 12,
                CreatedAt = DateTime.Now,
                CategoryName = "Two-seater",
                ParentCategoryId = 2
            },
            new Category
            {
                Id = 13,
                CreatedAt = DateTime.Now,
                CategoryName = "Three-seater",
                ParentCategoryId = 2
            },
            new Category
            {
                Id = 14,
                CreatedAt = DateTime.Now,
                CategoryName = "Dining chair",
                ParentCategoryId = 3
            },
            new Category
            {
                Id = 15,
                CreatedAt = DateTime.Now,
                CategoryName = "Computer chair",
                ParentCategoryId = 3
            },
            new Category
            {
                Id = 16,
                CreatedAt = DateTime.Now,
                CategoryName = "Office chair",
                ParentCategoryId = 3
            },
            new Category
            {
                Id = 19,
                CreatedAt = DateTime.Now,
                CategoryName = "Wardrobe",
                ParentCategoryId = null
            },
            new Category
            {
                Id = 20,
                CreatedAt = DateTime.Now,
                CategoryName = "Shelf",
                ParentCategoryId = null
            },
            new Category
            {
                Id = 21,
                CreatedAt = DateTime.Now,
                CategoryName = "Bookshelf",
                ParentCategoryId = 20
            },
            new Category
            {
                Id = 22,
                CreatedAt = DateTime.Now,
                CategoryName = "Wall shelf",
                ParentCategoryId = 20
            }
        };

        public static List<Specification> Specifications = new List<Specification>
        {
            new Specification
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                SpecificationName = "Width"
            },
            new Specification
            {
                Id = 2,
                CreatedAt = DateTime.Now,
                SpecificationName = "Height"
            },
            new Specification
            {
                Id = 3,
                CreatedAt = DateTime.Now,
                SpecificationName = "Length"
            },
            new Specification
            {
                Id = 4,
                CreatedAt = DateTime.Now,
                SpecificationName = "Depth"
            },
            new Specification
            {
                Id = 5,
                CreatedAt = DateTime.Now,
                SpecificationName = "Color"
            }
        };

        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                ProductName = "Cheney coffee table",
                Description = "This coffee table with glass surface will" +
                               " elevate the look of your space. It is perfect for luxury homes.",
                CategoryId = 6
            },
            new Product
            {
                Id = 2,
                CreatedAt = DateTime.Now,
                ProductName = "Aula coffee table",
                Description = "Golden details on this table makes it look really refined" +
                               "and we are sure that this is the right choice if you are looking for something simple yet effective.",
                CategoryId = 6
            },
            new Product
            {
                Id = 3,
                CreatedAt = DateTime.Now,
                ProductName = "Andreson coffee table",
                Description = "Made of solid wood with fine details and a smooth surface, the Andreson coffee table brings a classic charm to your room.",
                CategoryId = 6
            },
            new Product
            {
                Id = 4,
                CreatedAt = DateTime.Now,
                ProductName = "Haku dining table",
                Description = "Haku is dining table for 6 persons. As gold and glass are erfect match, we are sure that this table will be perfect in any type of home.",
                CategoryId = 5
            },
            new Product
            {
                Id = 5,
                CreatedAt = DateTime.Now,
                ProductName = "Mora dining table",
                Description = "Mora is dining table for 4 persons. ",
                CategoryId = 5
            },
            new Product
            {
                Id = 6,
                CreatedAt = DateTime.Now,
                ProductName = "Marcel bookshelf",
                Description = "White bookshelf gives you so much freedom to decorate it in any way you like! You can store books, magazines or any type of decoration pieces.",
                CategoryId = 21
            },
            new Product
            {
                Id = 7,
                CreatedAt = DateTime.Now,
                ProductName = "Markus office chair",
                Description = "Adjust the height and angle of this chair to make you comfortable during the working day. The mesh backrest leaks air, so you won't heat the chair even when the workload increases.",
                CategoryId = 16
            },
            new Product
            {
                Id = 8,
                CreatedAt = DateTime.Now,
                ProductName = "Jaku dining chair",
                Description = " Description for jaku dinning chair",
                CategoryId = 14
            },
            new Product
            {
                Id = 9,
                CreatedAt = DateTime.Now,
                ProductName = "Kooper double bed",
                Description = "Fransoa double bed is so comfortable that you will want to stay in it as long as possible every morning",
                CategoryId = 10
            },
             new Product
            {
                Id = 10,
                CreatedAt = DateTime.Now,
                ProductName = "Bourbon wardrobe",
                Description = "Description for bourbon wardrobe",
                CategoryId = 19
            },
             new Product
            {
                Id = 11,
                CreatedAt = DateTime.Now,
                ProductName = "Keaton wardrobe",
                Description = "Description for keaton wardrobe",
                CategoryId = 19
            },
              new Product
            {
                Id = 12,
                CreatedAt = DateTime.Now,
                ProductName = "Haru two seater sofa",
                Description = "Description for Haru two seater sofa",
                CategoryId = 12
            },
            new Product
            {
                Id = 13,
                CreatedAt = DateTime.Now,
                ProductName = "Kooper two seater sofa",
                Description = "Description for Kooper two seater sofa",
                CategoryId = 12
            },
            new Product
            {
                Id = 14,
                CreatedAt = DateTime.Now,
                ProductName = "Lottie three seater sofa",
                Description = "Description for Kooper Lottie seater sofa",
                CategoryId = 13
            },
            new Product
            {
                Id = 15,
                CreatedAt = DateTime.Now,
                ProductName = "Faces wall set",
                Description = "Description for Faces wall set",
                CategoryId = 4
            },
             new Product
            {
                Id = 16,
                CreatedAt = DateTime.Now,
                ProductName = "Florals wall set",
                Description = "Description for Florals wall set",
                CategoryId = 4
            },
              new Product
            {
                Id = 17,
                CreatedAt = DateTime.Now,
                ProductName = "Leyla wall shelf",
                Description = "Description for Leyla wall shelf",
                CategoryId = 22
            },
              new Product
            {
                Id = 18,
                CreatedAt = DateTime.Now,
                ProductName = "Besley single bed",
                Description = "Description for Besley single bed",
                CategoryId = 9
            },
                new Product
            {
                Id = 19,
                CreatedAt = DateTime.Now,
                ProductName = "Harlow corner sofa",
                Description = "Description for Harlow corner sofa",
                CategoryId = 11
            }
        };

        public static List<ProductSpecification> ProductSpecifications = new List<ProductSpecification>
        {
            new ProductSpecification
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                ProductId = 1,
                SpecificationId = 1,
                SpecificationValue = "55cm"
            },
            new ProductSpecification
            {
                Id = 2,
                CreatedAt = DateTime.Now,
                ProductId = 1,
                SpecificationId = 3,
                SpecificationValue = "90cm"
            },
            new ProductSpecification
            {
                Id = 3,
                CreatedAt = DateTime.Now,
                ProductId = 1,
                SpecificationId = 2,
                SpecificationValue = "45cm"
            },
            new ProductSpecification
            {
                Id = 4,
                CreatedAt = DateTime.Now,
                ProductId = 2,
                SpecificationId = 1,
                SpecificationValue = "40cm"
            },
            new ProductSpecification
            {
                Id = 5,
                CreatedAt = DateTime.Now,
                ProductId = 2,
                SpecificationId = 3,
                SpecificationValue = "50cm"
            },
            new ProductSpecification
            {
                Id = 6,
                CreatedAt = DateTime.Now,
                ProductId = 2,
                SpecificationId = 2,
                SpecificationValue = "45cm"
            },
            new ProductSpecification
            {
                Id = 7,
                CreatedAt = DateTime.Now,
                ProductId = 3,
                SpecificationId = 1,
                SpecificationValue = "60cm"
            },
            new ProductSpecification
            {
                Id = 8,
                CreatedAt = DateTime.Now,
                ProductId = 3,
                SpecificationId = 3,
                SpecificationValue = "95cm"
            },
            new ProductSpecification
            {
                Id = 9,
                CreatedAt = DateTime.Now,
                ProductId = 3,
                SpecificationId = 2,
                SpecificationValue = "50cm"
            },
            new ProductSpecification
            {
                Id = 10,
                CreatedAt = DateTime.Now,
                ProductId = 4,
                SpecificationId = 1,
                SpecificationValue = "80cm"
            },
            new ProductSpecification
            {
                Id = 11,
                CreatedAt = DateTime.Now,
                ProductId = 4,
                SpecificationId = 3,
                SpecificationValue = "180cm"
            },
            new ProductSpecification
            {
                Id = 12,
                CreatedAt = DateTime.Now,
                ProductId = 4,
                SpecificationId = 2,
                SpecificationValue = "75cm"
            },
            new ProductSpecification
            {
                Id = 13,
                CreatedAt = DateTime.Now,
                ProductId = 5,
                SpecificationId = 1,
                SpecificationValue = "900cm"
            },
            new ProductSpecification
            {
                Id = 14,
                CreatedAt = DateTime.Now,
                ProductId = 5,
                SpecificationId = 3,
                SpecificationValue = "180cm"
            },
            new ProductSpecification
            {
                Id = 15,
                CreatedAt = DateTime.Now,
                ProductId = 5,
                SpecificationId = 2,
                SpecificationValue = "75cm"
            },
            new ProductSpecification
            {
                Id = 16,
                CreatedAt = DateTime.Now,
                ProductId = 6,
                SpecificationId = 1,
                SpecificationValue = "80cm"
            },
            new ProductSpecification
            {
                Id = 17,
                CreatedAt = DateTime.Now,
                ProductId = 6,
                SpecificationId = 2,
                SpecificationValue = "150cm"
            },
            new ProductSpecification
            {
                Id = 18,
                CreatedAt = DateTime.Now,
                ProductId = 6,
                SpecificationId = 1,
                SpecificationValue = "30cm"
            },
            new ProductSpecification
            {
                Id = 19,
                CreatedAt = DateTime.Now,
                ProductId = 9,
                SpecificationId = 1,
                SpecificationValue = "160cm"
            },
            new ProductSpecification
            {
                Id = 20,
                CreatedAt = DateTime.Now,
                ProductId = 9,
                SpecificationId = 3,
                SpecificationValue = "200cm"
            },
            new ProductSpecification
            {
                Id = 21,
                CreatedAt = DateTime.Now,
                ProductId = 9,
                SpecificationId = 1,
                SpecificationValue = "45cm"
            },
            new ProductSpecification
            {
                Id = 22,
                CreatedAt = DateTime.Now,
                ProductId = 10,
                SpecificationId = 2,
                SpecificationValue = "80cm"
            },
            new ProductSpecification
            {
                Id = 23,
                CreatedAt = DateTime.Now,
                ProductId = 10,
                SpecificationId = 1,
                SpecificationValue = "200cm"
            },
            new ProductSpecification
            {
                Id = 24,
                CreatedAt = DateTime.Now,
                ProductId = 10,
                SpecificationId = 4,
                SpecificationValue = "50cm"
            },
            new ProductSpecification
            {
                Id = 25,
                CreatedAt = DateTime.Now,
                ProductId = 11,
                SpecificationId = 2,
                SpecificationValue = "80cm"
            },
            new ProductSpecification
            {
                Id = 26,
                CreatedAt = DateTime.Now,
                ProductId = 11,
                SpecificationId = 1,
                SpecificationValue = "200cm"
            },
            new ProductSpecification
            {
                Id = 27,
                CreatedAt = DateTime.Now,
                ProductId = 11,
                SpecificationId = 4,
                SpecificationValue = "50cm"
            },
            new ProductSpecification
            {
                Id = 28,
                CreatedAt = DateTime.Now,
                ProductId = 12,
                SpecificationId = 1,
                SpecificationValue = "120cm"
            },
            new ProductSpecification
            {
                Id = 29,
                CreatedAt = DateTime.Now,
                ProductId = 13,
                SpecificationId = 1,
                SpecificationValue = "120cm"
            },
            new ProductSpecification
            {
                Id = 30,
                CreatedAt = DateTime.Now,
                ProductId = 14,
                SpecificationId = 1,
                SpecificationValue = "200cm"
            },
            new ProductSpecification
            {
                Id = 31,
                CreatedAt = DateTime.Now,
                ProductId = 18,
                SpecificationId = 1,
                SpecificationValue = "120cm"
            },
            new ProductSpecification
            {
                Id = 32,
                CreatedAt = DateTime.Now,
                ProductId = 18,
                SpecificationId = 3,
                SpecificationValue = "200cm"
            },
            new ProductSpecification
            {
                Id = 33,
                CreatedAt = DateTime.Now,
                ProductId = 19,
                SpecificationId = 1,
                SpecificationValue = "240cm"
            }
        };

        public static List<Price> Prices = new List<Price>
        {
            new Price
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                ProductId = 1,
                PriceValue = 90.99m
            },
            new Price
            {
                Id = 2,
                CreatedAt = DateTime.Now,
                ProductId = 2,
                PriceValue = 85.99m
            },
            new Price
            {
                Id = 3,
                CreatedAt = DateTime.Now,
                ProductId = 3,
                PriceValue = 156.99m
            },
            new Price
            {
                Id = 4,
                CreatedAt = DateTime.Now,
                ProductId = 4,
                PriceValue = 275.99m
            },
            new Price
            {
                Id = 5,
                CreatedAt = DateTime.Now,
                ProductId = 5,
                PriceValue = 350.99m
            },
            new Price
            {
                Id = 6,
                CreatedAt = DateTime.Now,
                ProductId = 6,
                PriceValue = 132.99m
            },
            new Price
            {
                Id = 7,
                CreatedAt = DateTime.Now,
                ProductId = 7,
                PriceValue = 230.99m
            },
            new Price
            {
                Id = 8,
                CreatedAt = DateTime.Now,
                ProductId = 8,
                PriceValue = 62.99m
            },
            new Price
            {
                Id = 9,
                CreatedAt = DateTime.Now,
                ProductId = 9,
                PriceValue = 355.99m
            },
            new Price
            {
                Id = 10,
                CreatedAt = DateTime.Now,
                ProductId = 10,
                PriceValue = 210.99m
            },
            new Price
            {
                Id = 11,
                CreatedAt = DateTime.Now,
                ProductId = 11,
                PriceValue = 250.99m
            },
            new Price
            {
                Id = 12,
                CreatedAt = DateTime.Now,
                ProductId = 12,
                PriceValue = 195.99m
            },
            new Price
            {
                Id = 13,
                CreatedAt = DateTime.Now,
                ProductId = 13,
                PriceValue = 155.99m
            },
            new Price
            {
                Id = 14,
                CreatedAt = DateTime.Now,
                ProductId = 14,
                PriceValue = 195.99m
            },
            new Price
            {
                Id = 15,
                CreatedAt = DateTime.Now,
                ProductId = 15,
                PriceValue = 50.99m
            },
            new Price
            {
                Id = 16,
                CreatedAt = DateTime.Now,
                ProductId = 16,
                PriceValue = 68.99m
            },
            new Price
            {
                Id = 17,
                CreatedAt = DateTime.Now,
                ProductId = 17,
                PriceValue = 129.99m
            },
            new Price
            {
                Id = 18,
                CreatedAt = DateTime.Now,
                ProductId = 18,
                PriceValue = 205.99m
            },
            new Price
            {
                Id = 19,
                CreatedAt = DateTime.Now,
                ProductId = 19,
                PriceValue = 399.99m
            },
        };

        public static List<Image> Images = new List<Image>
        {
            new Image
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                Path = "cheney-coffee-table.jpg",
                Alt = "Image for product 1",
                ProductId = 1
            },
            new Image
            {
                Id = 2,
                CreatedAt = DateTime.Now,
                Path = "aula-coffee-table.jpg",
                Alt = "Image for product 2",
                ProductId = 2
            },
            new Image
            {
                Id = 3,
                CreatedAt = DateTime.Now,
                Path = "anderson-set-coffee-tables.jpg",
                Alt = "Image for product 3",
                ProductId = 3
            },
            new Image
            {
                Id = 4,
                CreatedAt = DateTime.Now,
                Path = "haku-dining-table.jpg",
                Alt = "Image for product 4",
                ProductId = 4
            },
            new Image
            {
                Id = 5,
                CreatedAt = DateTime.Now,
                Path = "mora-dinning-table.jpg",
                Alt = "Image for product 5",
                ProductId = 5
            },
            new Image
            {
                Id = 6,
                CreatedAt = DateTime.Now,
                Path = "marcel-bookcase.jpg",
                Alt = "Image for product 6",
                ProductId = 6
            },
            new Image
            {
                Id = 7,
                CreatedAt = DateTime.Now,
                Path = "markus-office-chair.jpg",
                Alt = "Image for product 7",
                ProductId = 7
            },
            new Image
            {
                Id = 8,
                CreatedAt = DateTime.Now,
                Path = "jaku-dining-chair.jpg",
                Alt = "Image for product 8",
                ProductId = 8
            },
            new Image
            {
                Id = 9,
                CreatedAt = DateTime.Now,
                Path = "kooper-kingsize-bed.jpg",
                Alt = "Image for product 9",
                ProductId = 9
            },
            new Image
            {
                Id = 10,
                CreatedAt = DateTime.Now,
                Path = "bourbon-wardrobe.jpg",
                Alt = "Image for product 10",
                ProductId = 10
            },
            new Image
            {
                Id = 11,
                CreatedAt = DateTime.Now,
                Path = "keaton-wardrobe.jpg",
                Alt = "Image for product 11",
                ProductId = 11
            },
            new Image
            {
                Id = 12,
                CreatedAt = DateTime.Now,
                Path = "haru-two-seater-sofa.jpg",
                Alt = "Image for product 12",
                ProductId = 12
            },
            new Image
            {
                Id = 13,
                CreatedAt = DateTime.Now,
                Path = "kooper-two-seater-sofa.jpg",
                Alt = "Image for product 13",
                ProductId = 13
            },
            new Image
            {
                Id = 14,
                CreatedAt = DateTime.Now,
                Path = "lottie-three-seater-sofa.jpg",
                Alt = "Image for product 14",
                ProductId = 14
            },
            new Image
            {
                Id = 15,
                CreatedAt = DateTime.Now,
                Path = "faces-wall-set.jpg",
                Alt = "Image for product 15",
                ProductId = 15
            },
            new Image
            {
                Id = 16,
                CreatedAt = DateTime.Now,
                Path = "florals-wall-set.jpg",
                Alt = "Image for product 16",
                ProductId = 16
            },
            new Image
            {
                Id = 17,
                CreatedAt = DateTime.Now,
                Path = "leyla-wall-shelf.jpg",
                Alt = "Image for product 17",
                ProductId = 17
            },
            new Image
            {
                Id = 18,
                CreatedAt = DateTime.Now,
                Path = "besley-single-bed.jpg",
                Alt = "Image for product 18",
                ProductId = 18
            },
            new Image
            {
                Id = 19,
                CreatedAt = DateTime.Now,
                Path = "harlow-corner-sofa.jpg",
                Alt = "Image for product 19",
                ProductId = 19
            },
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                OrderNumber = new Random().Next(1000000, 9999999),
                UserId = 6,
                Address = "Address 1",
                City = "CIty 1",
                Country = "Country 1",
                Phone = "0666665522"
            }
        };

        public static List<OrderItem> OrderItems = new List<OrderItem>
        {
            new OrderItem
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                OrderId = 1,
                ProductId = 1,
                Quantity = 2
            }
        };

        public static List<Cart> Carts = new List<Cart>
        {
            new Cart
            {
                Id = 1,
                UserId = 6,
                ProductId = 3,
                Quantity = 3,
                CreatedAt = DateTime.Now
            },
            new Cart
            {
                Id = 2,
                UserId = 6,
                ProductId = 5,
                Quantity = 6,
                CreatedAt = DateTime.Now
            }
        };
    }
}
