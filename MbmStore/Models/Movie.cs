﻿using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{ 
    public class Movie: Product
    {
        // properties
        public string Director { get; set; }
        public short Released { get; set; }

        // constructors
        public Movie() { } 

        public Movie(string title, decimal price, int productID) : base(productID, title, price) { }

        public Movie(string title, decimal price, string imageUrl, string director, int productID) : base(productID, title, price)
        {
            ImageUrl = imageUrl;
            Director = director;
        }
    }
}