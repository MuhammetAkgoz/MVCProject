using System;
using System.Collections.Generic;
using System.Text;
using Core.Entites.Abstract;

namespace Entities.Dtos
{
    public class ProductDetail:IDto
    {
        //Product tablosu ile ürünler tablosu bir araya getirilmiş gibi.
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string CategoryName { get; set; }
    }
}
