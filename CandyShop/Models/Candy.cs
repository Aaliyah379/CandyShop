﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class Candy
    {
        public int CandyId { get; set; }
        public string Name { get; set;}
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailurl { get; set;}
        public bool IsOnSale { get; set; }
        public bool isOnStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        }
    }

