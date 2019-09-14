using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OrderFood.Core;
using OrderFood.Data;

namespace OrderFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        public string Message { get; set; }
        public IRestaurantData RestaurantData;
        public IEnumerable<Restaurant> Restaurants { get; set; }
        [BindProperty(SupportsGet=true)]
        public string search_name { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            RestaurantData = restaurantData;
        }
        public void OnGet()
        {
            Message = "Hello World!";
            Restaurants = RestaurantData.GetRestaurantsByName(search_name);
        }
    }
}