﻿using System;
using System.Collections.Generic;

namespace DatabaseFirst
{
    public partial class Category
    {
        public Category()
        {
            FilmCategories = new HashSet<FilmCategory>();
        }

        public byte CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<FilmCategory> FilmCategories { get; set; }
    }
}
