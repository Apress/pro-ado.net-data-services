using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Services.Client;
using ClientConsoleApp.NorthwindDataService;
using System.Net;
using System.IO;
using System.Xml;

namespace ClientConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            NorthwindEntities entities = new NorthwindEntities(new Uri("http://localhost:1101/Northwind.svc/"));
            /*DataServiceQuery<Customers> customers = entities.CreateQuery<Customers>("/Customers");
            
            foreach (Customers c in customers)
            {
                Console.WriteLine(String.Format("Customer ID : {0}, Company Name {1}", c.CustomerID, c.CompanyName));
            }
            */

            //NorthwindEntities entities = new NorthwindEntities(new Uri("http://localhost:1101/Northwind.svc/"));
            //NorthwindEntities entities = new NorthwindEntities(new Uri("http://localhost:1101/Northwind.svc/"));

            //ADD Entity
            /*Customers customer = new Customers();
            customer.CustomerID = "TEST1";
            customer.CompanyName = "Testing Corp Inc";
            customer.ContactName = "Joe Smith";
            customer.ContactTitle = "President";
            customer.Address = "4000 Telegraph Avenue, Suite 600";
            customer.City = "Berkeley";
            customer.Region = "CA";
            customer.PostalCode = "94705 ";
            customer.Country = "USA";

            entities.AddObject("Customers", customer);
            DataServiceResponse response = entities.SaveChanges();

            if (response.IsBatchResponse == true)
            {


            }*/

            //Update
            /*Customers testCustomer = entities.Execute<Customers>(new Uri("Customers('TEST1')", UriKind.Relative)).FirstOrDefault();
            testCustomer.ContactName = "Joe Bloggs";

            entities.UpdateObject(testCustomer);
            DataServiceResponse response = entities.SaveChanges();

            if (response.IsBatchResponse == true)
            {


            }*/

            //Delete
            Customers customer = entities.Execute<Customers>(new Uri("Customers('TEST1')", UriKind.Relative)).FirstOrDefault();
 
            entities.DeleteObject(customer);
            DataServiceResponse response = entities.SaveChanges();

            if (response.IsBatchResponse == true)
            {


            }



            Customers customer1 =entities.Customers.Where(c => c.CustomerID == "ALFKI").FirstOrDefault();
            
            

            Console.ReadLine();

            /*DataServiceContext service = new DataServiceContext( new Uri("http://localhost:1101/Northwind.svc"));
            IEnumerable<Suppliers> suppliers = service.Execute<Suppliers>(new Uri("Suppliers?$orderby=Country", UriKind.Relative));

            foreach (Suppliers supplier in suppliers)
            {
                Console.WriteLine(String.Format("Supplier ID : {0}, Supplier Name : {1}, City : {2}, Country : {3}", supplier.SupplierID, supplier.CompanyName, supplier.City, supplier.Country));
            }*/

            //DataServiceContext service = new DataServiceContext( new Uri("http://localhost:1101/Northwind.svc"));
            //DataServiceQuery<Suppliers> query = service.CreateQuery<Suppliers>("/Suppliers").AddQueryOption("$orderby", "Country");

            //DataServiceContext service = new DataServiceContext(new Uri("http://localhost:1101/Northwind.svc"));
            //IEnumerable<Suppliers> suppliers = service.Execute<Suppliers>(new Uri("Suppliers?$orderby=Country", UriKind.Relative));


            //HttpWebRequest request =
            //(HttpWebRequest)WebRequest.Create(
            //"http://localhost:1101/Northwind.svc/Customers('ALFKI')");

            //request.Method = "GET";

            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //StreamReader reader = new StreamReader(response.GetResponseStream());
            //XmlDocument xmlResult = new XmlDocument();
            //xmlResult.Load(reader);
            //response.Close();

            //Console.WriteLine(xmlResult.OuterXml);

            //Console.ReadLine();

        }
    }
}
