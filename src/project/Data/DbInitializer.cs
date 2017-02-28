using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProductContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Category[]
            {
            new Category{Name= "Laptops"},
            new Category{Name= "Smart Phones"},
            new Category{Name= "Desktops"},
            new Category{Name= "Network"}
            };
            foreach (Category c in categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();

            var products = new Product[]
            {
            new Product{Name="Product1", Price="100", CategoryID=1},
            new Product{Name="Product2", Price="150", CategoryID=4},
            new Product{Name="Product3", Price="500", CategoryID=2},
            new Product{Name="Product4", Price="180", CategoryID=1},
            new Product{Name="Product5", Price="240", CategoryID=3},
            new Product{Name="Product6", Price="10", CategoryID=2},
            new Product{Name="Product7", Price="80", CategoryID=1}
            };
            foreach (Product s in products)
            {
                context.Products.Add(s);
            }
            context.SaveChanges();

            var photos = new Photo[]
            {
            new Photo{Name="Photo1",ImgUrl="01.jpg",ProductID=1},
            new Photo{Name="Photo2",ImgUrl="02.jpg",ProductID=1},
            new Photo{Name="Photo3",ImgUrl="03.jpg",ProductID=1},
            new Photo{Name="Photo4",ImgUrl="04.jpg",ProductID=1},
            new Photo{Name="Photo5",ImgUrl="blue.jpg",ProductID=7},
            new Photo{Name="Photo6",ImgUrl="blue.jpg",ProductID=2},
            new Photo{Name="Photo7",ImgUrl="blue.jpg",ProductID=6},
            new Photo{Name="Photo8",ImgUrl="blue.jpg",ProductID=3},
            new Photo{Name="Photo9",ImgUrl="blue.jpg",ProductID=5},
            new Photo{Name="Photo10",ImgUrl="red.jpg",ProductID=3},
            new Photo{Name="Photo11",ImgUrl="purple.jpg",ProductID=2},
            new Photo{Name="Photo12",ImgUrl="blue.jpg",ProductID=4},
            new Photo{Name="Photo13",ImgUrl="red.jpg",ProductID=2}
            };
            foreach (Photo e in photos)
            {
                context.Photos.Add(e);
            }
            context.SaveChanges();
        }
    }
}
