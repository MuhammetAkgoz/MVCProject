using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entites.Abstract;

namespace Entities.DomainModels
{
    public class Cart:IDomainModel
    {
        public Cart()
        {
            CartLines=new List<CartLine>();
        }
        public List<CartLine> CartLines { get; set; }

      
    }
}
