﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable] //atrubute in c#
   public class Product
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
