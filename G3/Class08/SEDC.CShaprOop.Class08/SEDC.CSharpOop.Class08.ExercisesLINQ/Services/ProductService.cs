using SEDC.CSharpOop.Class08.ExercisesLINQ.Classes;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.CSharpOop.Class08.ExercisesLINQ.Services
{
    public class ProductService
    {
        private List<Product> Products { get; set; } = new List<Product>
        {
            new Product() { Name =  "Keyboard", Price = 100, Category = Category.ItEquipment },
            new Product() { Name =  "Mouse", Price = 150, Category = Category.ItEquipment },
            new Product() { Name =  "Headphones", Price = 80, Category = Category.ItEquipment },
            new Product() { Name =  "Microphone", Price = 220, Category = Category.ItEquipment },
            new Product() { Name =  "Camera", Price = 1000, Category = Category.ItEquipment },
            new Product() { Name =  "Hp-580", Price = 20000, Category = Category.LapTop },
            new Product() { Name =  "Lenovo G200", Price = 18500, Category = Category.LapTop },
            new Product() { Name =  "Hp ProBook", Price = 12000, Category = Category.LapTop },
            new Product() { Name =  "Acer S1200", Price = 28000, Category = Category.LapTop },
            new Product() { Name =  "Dell MS300", Price = 74000, Category = Category.LapTop },
            new Product() { Name =  "Office 1", Price = 10200, Category = Category.PC },
            new Product() { Name =  "Office 2", Price = 12400, Category = Category.PC },
            new Product() { Name =  "Gaming", Price = 22000, Category = Category.PC },
            new Product() { Name =  "Ultra Gaming", Price = 32200, Category = Category.PC },
            new Product() { Name =  "Ultra Ultra Gaming", Price = 61600, Category = Category.PC },
            new Product() { Name =  "Alienware", Price = 128000, Category = Category.PC },
            new Product() { Name =  "Samsung Proview", Price = 56200, Category = Category.TV },
            new Product() { Name =  "LG LG420MQ8", Price = 32000, Category = Category.TV },
            new Product() { Name =  "SONY Plasma", Price = 18000, Category = Category.TV },
            new Product() { Name =  "SONY RW78OS", Price = 179999, Category = Category.TV },
            new Product() { Name =  "Samsung Oval", Price = 247999, Category = Category.TV }
        };

        //Add product // create method to add product to the list of products
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        //Remove product // and a method to remove it - use id as parameter
        public bool RemoveProduct(Product product)
        {
            int count = Products.Count; // 33
            Products.Remove(product); // remove product
            bool isRemoved = count != Products.Count; // 33 != 32 // prev count != current count
            return isRemoved;
        }

        //Search products by category // return all products from given category
        public List<Product> SearchProductsByCategory(Category category)
        {
            List<Product> products = Products.Where(product => product.Category == category).ToList();
            return products;
        }

        //Filter products by price range(from min to max) // return all products that fall in the given price range
        public List<Product> FilterProductsByPriceRange(int min, int max)
        {
            List<Product> products = Products.Where(product => product.Price >= min && product.Price <= max).ToList();
            return products;
        }

        //Find products by part of name // get all products that consist the part in their names
        public List<Product> FilterProductsByNamePart(string namePart)
        {
            //string a = "Trajan Stevkovski";
            //string b = "vkovs";
            //bool res = a.Contains(b); // Does string b is contained in string a
            List<Product> products = Products.Where(product => 
                product.Name.ToLower()
                    .Contains(namePart.ToLower())).ToList();
            return products;
        }

        //Get only products names // return only the names of the products
        public List<string> GetProductNames()
        {
            List<string> names = Products.Select(product => product.Name).ToList();
            return names;
        }

        //Get product price // get the price of the product - give the name as parameter
        public int GetProductPrice(string name)
        {
            // using where
            //Product searchedProduct = Products
            //    .Where(product => product.Name.ToLower() == name.ToLower())
            //    .FirstOrDefault();
            Product product = Products // null
                .FirstOrDefault(product => product.Name.ToLower() == name.ToLower());

            if(product == null)
            {
                return -1;
            }

            return product.Price;
        }

        //Get cheapest product // return the cheapest product
        public Product GetCheapestProduct()
        {
            Product product1 = new Product();
            int cheapestPrice = Products[0].Price;
            foreach(Product product in Products)
            {
                if(cheapestPrice >= product.Price)
                {
                    product1 = product;
                    cheapestPrice = product.Price;
                }
            }

            return product1;
        }

        public Product GetCheapestProductLINQ()
        {
            return Products.OrderBy(product => product.Price).FirstOrDefault();
        }

        //Get most expensive product // return the most expensive one
        public Product GetMostExpensiveProduct()
        {
            return Products.OrderBy(product => product.Price).LastOrDefault();
        }
    }
}
