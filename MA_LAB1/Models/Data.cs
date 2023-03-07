using System.Numerics;
using System.Xml.Linq;

namespace MA_LAB1.Models
{
    public class Data
    {

        public static void LoadData(IApplicationBuilder application)
        {
            TruckRouteDBContext context = application.ApplicationServices
                          .CreateScope().ServiceProvider.GetRequiredService<TruckRouteDBContext>();

            context.Users.AddRange(
                 new Account {
                 Fname ="Ziang",
                 Lname = "Wang",
                 Email = "Ilovedotnet@gmail.com",
                 Phone = "991565888",
                 Password = "123",
                 CPassword = "123"
                 }
            
            );

            context.Routes.AddRange(
                 new Route {
                 route_name = "Shortest Time",
                 r_length = "300",
                 r_pay_per_km = "3.4"
                 },
                 new Route
                  {
                      route_name = "Real-time traffic",
                      r_length = "400",
                      r_pay_per_km = "3.6"
                  },
                 new Route
                   {
                       route_name = "Least traffic lights",
                       r_length = "420",
                       r_pay_per_km = "4.5"
                   },
                 new Route
                    {
                        route_name = "Take the highway as much as possible",
                        r_length = "450",
                        r_pay_per_km = "4.7"
                    },
                 new Route
                     {
                         route_name = "Try to stay off the highway",
                         r_length = "470",
                         r_pay_per_km = "4.9"
                     }

            );

            context.Trucks.AddRange(
                 new Truck {
                 t_model = "F-250",
                 t_make = "Ford",
                 RouteID = 1
                 },
                 new Truck
                 {
                     t_model = "2500",
                     t_make = "RAM",
                     RouteID = 2
                 },
                 new Truck
                 {
                     t_model = "1500",
                     t_make = "GMC Sierra",
                     RouteID = 3
                 },
                 new Truck
                 {
                     t_model = "1500",
                     t_make = "Chevrolet Silverado",
                     RouteID = 4
                 },
                 new Truck
                 {
                     t_model = "Frontier",
                     t_make = "Nissan",
                     RouteID = 5
                 }

            );
            context.SaveChanges();


        }

    }
}
