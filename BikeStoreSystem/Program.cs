using BikeStoreSystem.Data;
using BikeStoreSystem.Models;

namespace BikeStoreSystem;

internal class Program
{
    static void Main(string[] args)
    {
        ApplicationDbContext db = new();
        //====================== 1==================
        /*var categories = db.Categories.ToList();

        foreach (var category in categories)
        {
            Console.WriteLine(
                $"Categry id => {category.CategoryId} " +
                $"Name => {category.CategoryName}");
        }

        //================== 2 ====================
        var firstProduct = db.Products.FirstOrDefault();

          if (firstProduct != null)
          {
              Console.WriteLine(
                  $"ID => {firstProduct.ProductId}, " +
                  $"Name => {firstProduct.ProductName}, " +
                  $"Price => {firstProduct.ListPrice}"
              );
          }
          else
          {
              Console.WriteLine("-------- No Found ---------");
          }

        //==================== 3 ==================

        var product = db.Products.Find(3);

        if (product != null)
        {
            Console.WriteLine(
                $"ID => {product.ProductId}, " +
                $"Name => {product.ProductName}, " +
                $"Price => {product.ListPrice}"
            );
        }
        else
        {
            Console.WriteLine("--------- Not Found----------");
        }

        //================= 4 ========================
        var products = db.Products
            .Where(p => p.ModelYear == 2018)
            .ToList();

        foreach (var product in products)
        {
            Console.WriteLine(
                $"Product id => {product.ProductId} - " +
                $"Name => {product.ProductName} - " +
                $"Model Year => {product.ModelYear}"
            );
        }

        // ============== 5 ====================
         var customer = db.Customers.Find(4);

         if (customer != null)
         {
             Console.WriteLine(
                 $"Customer id => {customer.CustomerId}, " +
                 $"Name  => {customer.FirstName} {customer.LastName}, " +
                 $"Email => {customer.Email}"
             );
         }
         else
         {
             Console.WriteLine("------- Not Found -----------");
         }


        // ============== 6 =================
          var products = db.Products
       .Select(p => new
       {
           ProductName = p.ProductName,
           BrandName = p.Brand.BrandName
       })
       .ToList();

          foreach (var product in products)
          {
              Console.WriteLine(
                  $"Product => {product.ProductName}  " +
                  $"Brand => {product.BrandName}"
              );
          }

        //=============== 7 ===================
         var count = db.Products
        .Count(p => p.CategoryId == 6);

         Console.WriteLine($"Number of Products: {count}");


        // =============== 8 ==================

         var total = db.Products
        .Where(p => p.CategoryId == 6)
        .Sum(p => p.ListPrice);

         Console.WriteLine($"Total List Price => {total}");
        
        
        // ============= 9 =================
         var average = db.Products
        .Average(p => p.ListPrice);

         Console.WriteLine($"Average List Price => {average}");
        */

        //================ 10 ===============
        var orders = db.Orders
        .Where(o => o.OrderStatus == 4)
        .ToList();

        foreach (var order in orders)
        {
            Console.WriteLine(
                $"Order id => {order.OrderId} " +
                $"Status => {order.OrderStatus} " +
                $"Date => {order.OrderDate}"
            );
        }
    }
}
