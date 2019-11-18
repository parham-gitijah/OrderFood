
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
<<<<<<< HEAD
        
=======


        

<<<<<<< HEAD
sassdasdadasadsdasdasassdasd
=======
sassdasdadas
>>>>>>> parent of 1c9c0e2... Merge branch 'master' into Test1


>>>>>>> b2ce6602d06bec88d54c5be0b9c5ef3107a76077
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


        //


        public IEnumerable<Restaurant> GetRestaurantsByName(string name=null)
        {
            return  from r in restaurants where(string.IsNullOrEmpty(name) || r.Name.StartsWith(name, StringComparison.InvariantCultureIgnoreCase) || r.Name.Equals(""))
                   orderby r.Name
                   select r;

        }
        public IEnumerable<Restaurant> GetRestaurantById(int id)
        {
            return from r in restaurants
                   where (r.Id==id)
                   orderby r.Id
                   select r;
            

        }
    } }

