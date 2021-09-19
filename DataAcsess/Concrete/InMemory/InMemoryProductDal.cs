﻿using DataAcsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcsess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
             new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnıtePrice=15,UnıtsInStock=15},
             new Product {ProductId = 2,CategoryId =1,ProductName = "Kamera", UnıtePrice = 500, UnıtsInStock = 3},
             new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnıtePrice=1500,UnıtsInStock=2},
             new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnıtePrice=150,UnıtsInStock=65},
             new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnıtePrice=85,UnıtsInStock=1}
            };
        }
        //>= Lambda
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delate(Product product)
        {
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId==p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //aynı ıslem singleofdefault bir tane arar verdıgımız p degeri takma ad
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId== product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId ==categoryId).ToList();
        }

        public void Update(Product product)
        {
            // gonderdıgım urun ıd' sıne sahıp olan ulistedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnıtePrice = product.UnıtePrice;
            productToUpdate.UnıtsInStock = product.UnıtsInStock;
            
        }
    }
}