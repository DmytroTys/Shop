﻿using System;
using System.Collections.Generic;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategorys => appDBContent.Category; 
    }
}
