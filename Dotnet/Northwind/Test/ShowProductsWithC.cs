using ENV;
using ENV.Data;
using Firefly.Box;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Northwind.Test
{
    public class ShowProductsWithC : UIControllerBase
    {
        public readonly Models.Products products = new Models.Products();   
        public ShowProductsWithC()
        {
            From = products;
            Where.Add(products.ProductName.StartsWith("C"));

        }

        public void Run()
        {
            Execute();
        }

        protected override void OnLoad()
        {
            View = () => new Views.ShowProductsWithCView(this);
        }
    }
}