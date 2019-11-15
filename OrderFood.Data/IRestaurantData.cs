
using OrderFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderFood.Data
{
    public interface IRestaurantData
    {

        IEnumerable<Restaurant> GetRestaurantsByName(string s);




        asdasd

    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant
                {
                    Id=1,Name="Pong",Location="Vasagatan", Cuisine=Restaurant.CuisineType.None
                 }, new Restaurant
                {
                    Id=2,Name="Romi",Location="Solna", Cuisine=Restaurant.CuisineType.Indian
                 },
                new Restaurant
                {
                    Id=3,Name="Texas",Location="Huddinge", Cuisine=Restaurant.CuisineType.Mexican
                 }
            };
        }



        public IEnumerable<Restaurant> GetRestaurantsByName(string name=null)
        {
            return  from r in restaurants where(string.IsNullOrEmpty(name) || r.Name.StartsWith(name, StringComparison.InvariantCultureIgnoreCase) || r.Name.Equals(""))
                   orderby r.Name
                   select r;

        }
    } }

