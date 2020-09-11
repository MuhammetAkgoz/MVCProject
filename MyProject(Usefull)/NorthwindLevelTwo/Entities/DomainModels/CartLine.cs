﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entites.Abstract;
using Entities.Concreate;

namespace Entities.DomainModels
{
    public class CartLine:IDomainModel
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
