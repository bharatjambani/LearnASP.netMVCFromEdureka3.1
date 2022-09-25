using System.Collections.Generic;
using System.Linq;

namespace LearnASP.netMVCFromEdureka3._1.Models
{
    public class ProductsInMemoryRepo : IStoreRepository
    {
        static List<Product> products = new List<Product>
        {

            new Product
            {
                ProductID=1,Name="Chess Board",Category="Chess"
                ,Description="Brown Chess Board"
                ,Price=20.3m
            },

            new Product
            {
                ProductID=10,Name="Chess Board Black",Category="Chess"
                ,Description="Black Chess Board"
                ,Price=20.3m
            },

              //https://www.google.com/url?sa=i&url=https%3A%2F%2Fshopee.ph%2F-Filtered-Dreams-Printed-Artwork-i.2494212.2403709528&psig=AOvVaw1Ab6fdkXluRq6n7ijqywO1&ust=1613241650272000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLj8o87_5O4CFQAAAAAdAAAAABAd
          
             new Product
            {
                ProductID=2,Name="Chess Notes",Category="Chess",Description="Chess Notes",Price=210.3m
            },

              new Product
            {
                  //https://www.google.com/url?sa=i&url=https%3A%2F%2Froyalthaiart.com%2Fproduct%2Fpeacock-artwork%2F&psig=AOvVaw1Ab6fdkXluRq6n7ijqywO1&ust=1613241650272000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLj8o87_5O4CFQAAAAAdAAAAABAO
                ProductID=3,
                  Name="Chess Timer",
                  Category="Chess"
                  ,Description="Chess Timer "
                  ,Price=10.3m
            },

            new Product
            {
                ProductID=4,Name="Ball",Category="Cricket"
                ,Description="Leather Ball"
                ,Price=20.3m
            },

            new Product
            {
                ProductID=15,Name="Ball Tennis",Category="Cricket"
                ,Description="TesnnisBall"
                ,Price=20.3m
            },
              //https://www.google.com/url?sa=i&url=https%3A%2F%2Fshopee.ph%2F-Filtered-Dreams-Printed-Artwork-i.2494212.2403709528&psig=AOvVaw1Ab6fdkXluRq6n7ijqywO1&ust=1613241650272000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLj8o87_5O4CFQAAAAAdAAAAABAd
          
             new Product
            {
                ProductID=5,Name="Bat",
                 Category="Cricket",Description="Bat with Sticket",Price=210.3m
            },

              new Product
            {
                  //https://www.google.com/url?sa=i&url=https%3A%2F%2Froyalthaiart.com%2Fproduct%2Fpeacock-artwork%2F&psig=AOvVaw1Ab6fdkXluRq6n7ijqywO1&ust=1613241650272000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLj8o87_5O4CFQAAAAAdAAAAABAO
                ProductID=6,
                  Name="Stumps",
                  Category="Cricket"
                  ,Description="3 Stumps Along with bails"
                  ,Price=10.3m
            },

            new Product
            {
                ProductID=7,Name="Soccer Ball",Category="Soccer"
                ,Description="Soccer Ball"
                ,Price=20.3m
            },
              //https://www.google.com/url?sa=i&url=https%3A%2F%2Fshopee.ph%2F-Filtered-Dreams-Printed-Artwork-i.2494212.2403709528&psig=AOvVaw1Ab6fdkXluRq6n7ijqywO1&ust=1613241650272000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLj8o87_5O4CFQAAAAAdAAAAABAd
          
             new Product
            {
                ProductID=8,Name="Soccer Cards",
                 Category="Soccer",Description="Soccer Cards",Price=210.3m
            },

              new Product
            {
                  //https://www.google.com/url?sa=i&url=https%3A%2F%2Froyalthaiart.com%2Fproduct%2Fpeacock-artwork%2F&psig=AOvVaw1Ab6fdkXluRq6n7ijqywO1&ust=1613241650272000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLj8o87_5O4CFQAAAAAdAAAAABAO
                ProductID=9,
                  Name="Net",
                  Category="Soccer"
                  ,Description="Soccer Net"
                  ,Price=10.3m
            },

        };

        IEnumerable<Product> IStoreRepository.Products => products;

    }
}
