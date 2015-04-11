﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindDAO.Entity
{
    public class Categories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public Categories()
        {

        }

        public Categories(int CategoryId)
        {
            this.CategoryId = CategoryId;
        }
    }
}
