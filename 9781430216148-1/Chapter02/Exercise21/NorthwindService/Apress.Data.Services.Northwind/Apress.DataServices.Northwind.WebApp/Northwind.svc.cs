using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace Apress.DataServices.Northwind.WebApp
{
    // Verbose Errors
    [System.ServiceModel.ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    [System.Data.Services.MimeType("CustomerOrders", "text/html")]
    public class Northwind : DataService< NorthwindEntities >
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(IDataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);

            // Turn on Verbose errors
             config.UseVerboseErrors = true;
            /*
              Restrict maximum expands allowed
            config.MaxExpandDepth = 2;
            config.MaxExpandCount = 2;
             */
        }

       [WebGet]
       public IEnumerable<string> CountryList()
       {
           var countryNames = (from c in this.CurrentDataSource.Customers
                               select c.Country).Distinct();


           return countryNames;
       }

       [SingleResult]
       [WebGet]
       public IQueryable<string> CustomerOrders()
       {
           var orderCounts = 
             (from c in this.CurrentDataSource.Customers 
             select new {c.CustomerID, c.CompanyName, c.ContactName, 
             OrderCount = c.Orders.Count()}).OrderByDescending(o => o.OrderCount); 
       
           string customerOrderRanking = "";

           foreach(var orderCount in orderCounts)
           {
               customerOrderRanking += String.Format("Customer ID : {0}, Customer Name : {1}, Contact Name : {2}, Orders : {3} <br>", 
                                 orderCount.CustomerID, orderCount.CompanyName, orderCount.ContactName, orderCount.OrderCount);
           }

           return new string[]
           {
                "<html>" +
                   "<head><title>Customer Ranking</title></head>" +
                   "<body><h1>Customer Ranking</h1>" + 
                   customerOrderRanking + 
                "</body></html>"
           }.AsQueryable();
       }
   
      [WebGet]
      public IQueryable<Suppliers> SuppliersByCountry(string country)
      {
          return this.CurrentDataSource.Suppliers.Where(s => s.Country == country);
      }

    /*
      [WebInvoke]
      public void UpdateSupplierCountry(string supplierID, string country)
      {

          Suppliers supplier = this.CurrentDataSource.Suppliers.Where("SupplierID", new ObjectParameter("@SupplierID", supplierID)).First();

          if (supplier != null)
          {
              supplier.Country = country;
              this.CurrentDataSource.SaveChanges();
          }

      }


       // Query interceptors, change interceptors and service operations go here.
       [ChangeInterceptor("Suppliers")]
       public void OnCustomersChange(Suppliers supplier, UpdateOperations action)
       {
           Regex objAlphaPattern = new Regex("[^a-zA-Z]");

           if (action == UpdateOperations.Change)
           {
               //Catch that Contact name has alpha chars only
               if (!new Regex("[^a-zA-Z]").IsMatch(supplier.ContactName))
               {
                   throw new ApplicationException("Contact name must contain alpha characters only");
               }
           }
       }
    
   
       [QueryInterceptor("Customers")]
       public Expression<Func<Customers,bool>> OnQueryingCustomers()
       {
           //Only return customers from USA
           return c => c.Country == "USA";
       }
        */

       /// <summary>
       /// Handle the exception that is thrown back to the caller
       /// </summary>
       /// <param name="args"></param>
       protected override void HandleException(HandleExceptionArgs args)
       {
           base.HandleException(args);
       }
    
    }
}
