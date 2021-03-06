﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderFood.Core;

namespace OrderFood.Pages.Restaurants
{
    public class DetailModelModel : PageModel
    {
        public Restaurant Restaurant { get; set; }
        public void OnGet(int RestaurantId,string RestaurantLoc, string RestaurantName)
        {
            Restaurant = new Restaurant();
            Restaurant.Id = RestaurantId;
            Restaurant.Name = RestaurantName;
            Restaurant.Location = RestaurantLoc;
        }
    }
}