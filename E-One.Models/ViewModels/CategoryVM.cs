﻿using System;
using System.Collections.Generic;
using System.Text;

namespace E_One.Models.ViewModels
{
    public class CategoryVM
    {
        public IEnumerable<Category> Categories { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
