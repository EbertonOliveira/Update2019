﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SalesWebMvc.Models
{
    public class Departments
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        public Departments()
        {

        }

        public Departments(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
