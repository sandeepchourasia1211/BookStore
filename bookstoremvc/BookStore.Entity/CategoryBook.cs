﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entity
{
    public class CategoryBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CategoryId { get; set; }

    }
}
