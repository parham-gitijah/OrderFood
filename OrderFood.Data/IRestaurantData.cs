
using OrderFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();


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



        public IEnumerable<Restaurant> GetAll()
        {
            return  from r in restaurants
                   orderby r.Name
                   select r;

        }
    } }

