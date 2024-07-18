﻿using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services.Contracts;

namespace StoreApp.Components
{
    public class ProductSummary : ViewComponent
    {
        private readonly IServiceManager _manager;

        public ProductSummary(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            // return the number of products in the database , all of them without exception
            return _manager.ProductService.GetAllProducts(false).Count().ToString();
        }


    }
}
