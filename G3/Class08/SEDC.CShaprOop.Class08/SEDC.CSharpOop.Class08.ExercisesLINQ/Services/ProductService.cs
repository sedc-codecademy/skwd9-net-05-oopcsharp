﻿using SEDC.CSharpOop.Class08.ExercisesLINQ.Classes;
using System.Collections.Generic;

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
        //Search products by category // return all products from given category
        //Filter products by price range(from min to max) // return all products that fall in the given price range
        //Find products by part of name // get all products that consist the part in their names
        //Get only products ids // return only the ids of the products
        //Get product price // get the price of the product - give the id as parameter
        //Get cheapest product // return the cheapest product
        //Get most expensive product // return the most expensive one
        //Add product // create method to add product to the list of products
        //Remove product // and a method to remove it - use id as parameter
        //Don't forget to create class Product
    }
}
