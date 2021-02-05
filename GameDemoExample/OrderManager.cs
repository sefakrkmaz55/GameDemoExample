using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoExample
{
    class OrderManager:IOrderService
    {
        public void SaleProduct(Products products)
        {
            Console.WriteLine("Satış işlemi başarı ile tamamlandı");
            Console.WriteLine("Satın alınan ürün: " + products.ProductName);
        }
    }
}
