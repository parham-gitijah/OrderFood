using System;
using System.Collections.Generic;
using System.Text;

namespace OrderFoods.Core
{
    public partial class Restaurant
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Id { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
