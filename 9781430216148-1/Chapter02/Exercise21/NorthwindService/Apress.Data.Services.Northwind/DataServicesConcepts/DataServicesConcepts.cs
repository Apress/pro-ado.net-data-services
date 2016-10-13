using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NorthwindModel;
using System.Data.Services.Client;
using System.Net;
using System.IO;

namespace DataServicesConcepts
{
    public partial class frmDataServicesConcepts : Form
    {
        public frmDataServicesConcepts()
        {
            InitializeComponent();
            //serviceUri = new Uri(@"http://localhost:1101/Northwind.svc/");
            serviceUri = new Uri(@"http://adonet-data-poc/NorthwindDataService/Northwind.svc/");
            sbResult = new StringBuilder();
        }

        private Uri serviceUri = null;
        private StringBuilder sbResult = null;

        #region LINQ Query Operations
        private void logicalOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {

                NorthwindEntities entities = new NorthwindEntities(serviceUri);
                entities.MergeOption = MergeOption.AppendOnly;

                var query = from c in entities.CreateQuery<Customers>("Customers")
                            where c.Country == "USA" && c.Region == "WA" || c.Region == "OR"
                            orderby c.CompanyName descending
                            select c;

                sbResult.Append("LINQ to REST query: [Load customers in the State of Washington in the USA] \r\n");
                sbResult.Append("                    from c in entities.CreateQuery<Customers>(\"Customers\")\r\n");
                sbResult.Append("                    where c.Country == \"USA\" && c.Region == \"WA\" || c.Region == \"OR\" \r\n");
                sbResult.Append("                    orderby c.CompanyName descending;\r\n");
                sbResult.Append("\r\n");
                sbResult.Append("URI String: ");
                sbResult.Append("\r\n");
                sbResult.Append("                   " + query.ToString());
                sbResult.Append("\r\n");

                sbResult.Append("RESULTS\r\n");
                sbResult.Append("====================================================\r\n");
                
                foreach (Customers c in query)
                {
                    sbResult.Append(String.Format("Customer ID = {0}, Customer Name = {1}, Country = {2}, City = {3}, Region = {4} \r\n", c.CustomerID, c.CompanyName, c.Country, c.City, c.Region));
                }

                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Eror : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }

        }

        private void stringOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {
                NorthwindEntities entities = new NorthwindEntities(serviceUri);
                entities.MergeOption = MergeOption.AppendOnly;

                var query = from p in entities.CreateQuery<Products>("Products")
                            where p.ProductName.StartsWith("P")
                            orderby p.ProductName descending
                            select p;

                sbResult.Append("LINQ to REST query:  [Load products begining with \"P\"] \r\n");
                sbResult.Append("                    from p in entities.CreateQuery<Products>(\"Products\")\r\n");
                sbResult.Append("                    where p.ProductName.StartsWith(\"P\") \r\n");
                sbResult.Append("                    orderby p.ProductName descending;\r\n");
                sbResult.Append("\r\n");
                sbResult.Append("URI String: ");
                sbResult.Append("\r\n");
                sbResult.Append("                   " + query.ToString());
                sbResult.Append("\r\n");

                sbResult.Append("RESULTS\r\n");
                sbResult.Append("====================================================\r\n");

                foreach (Products p in query)
                {
                    sbResult.Append(String.Format("Product ID = {0}, Product Name = {1} \r\n", p.ProductID, p.ProductName));
                }

                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Error : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {
                NorthwindEntities entities = new NorthwindEntities(serviceUri);
                entities.MergeOption = MergeOption.AppendOnly;

                var qry = from o in entities.CreateQuery<Orders>("Orders")
                          where o.OrderDate >= new DateTime(1997, 1, 1).Date && o.OrderDate <= new DateTime(1997, 12, 31).Date 
                          select o;
                

                sbResult.Append("LINQ to REST query: [Load all 2007 orders] \r\n");
                sbResult.Append("\r\n");
                sbResult.Append("                    from o in entities.CreateQuery<Orders>(\"Orders\")\r\n");
                sbResult.Append("                    where o.OrderDate >= new DateTime(1997, 1, 1).Date && o.OrderDate <= new DateTime(1997, 12, 31).Date \r\n");
                sbResult.Append("\r\n");
                sbResult.Append("URI String: ");
                sbResult.Append("\r\n");
                sbResult.Append("                   " + qry.ToString());
                sbResult.Append("\r\n");
                sbResult.Append("RESULTS\r\n");
                sbResult.Append("====================================================\r\n");

                foreach(Orders o in qry)
                {
                    sbResult.Append(String.Format("Order ID = {0}, Order Date = {1} \r\n", o.OrderID, o.OrderDate));
                }

                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Error : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }
        }

        private void mathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {
                NorthwindEntities entities = new NorthwindEntities(serviceUri);
                entities.MergeOption = MergeOption.AppendOnly;


                var qry = from p in entities.CreateQuery<Products>("Products")
                          where  (p.UnitsOnOrder + p.UnitsInStock) < p.ReorderLevel
                          select p;



                sbResult.Append("LINQ to REST query: [Load all Products that total inventory is less than the reorder level] \r\n");
                sbResult.Append("\r\n");
                sbResult.Append("                    from p in entities.CreateQuery<Products>(\"Products\")\r\n");
                sbResult.Append("                    where  (p.UnitsOnOrder + p.UnitsInStock) < p.ReorderLevel \r\n");
                sbResult.Append("\r\n");
                sbResult.Append("URI String: ");
                sbResult.Append("\r\n");
                sbResult.Append("                   " + qry.ToString());
                sbResult.Append("\r\n");
                sbResult.Append("RESULTS\r\n");
                sbResult.Append("====================================================\r\n");

                foreach (Products p in qry)
                {
                    //Get the associated product category
                    entities.LoadProperty(p, "Categories");
                    sbResult.Append(String.Format("Product ID = {0}, Product Name = {1}, Product Category {2}, Units On Order = {3}, Units In Stock {4}, Reorder Level {5}\r\n", p.ProductID, p.ProductName, p.Categories.CategoryName, p.UnitsOnOrder, p.UnitsInStock, p.ReorderLevel));
                }

                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Error : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {
                NorthwindEntities entities = new NorthwindEntities(serviceUri);
                entities.MergeOption = MergeOption.AppendOnly;

                /*
                 * 
                 * var query = from e in entities.Entity

                 where e is Culture

                select e;

                or var query = entities.Entity.Where(e => e is Culture);
                 * */

                sbResult.Append("LINQ to REST query: ");
                sbResult.Append("   Not Supported ");


                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Error : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }
        }

        private void sortingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pagingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void expandingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {
                NorthwindEntities entities = new NorthwindEntities(serviceUri);
                entities.MergeOption = MergeOption.AppendOnly;

                var query = from p in entities.CreateQuery<Products>("Products")
                            where p.ProductName.StartsWith("P")
                            orderby p.ProductName descending
                            select p;

                sbResult.Append("LINQ to REST query:  [Load products begining with \"P\"] \r\n");
                sbResult.Append("                    from p in entities.CreateQuery<Products>(\"Products\")\r\n");
                sbResult.Append("                    where p.ProductName.StartsWith(\"P\") \r\n");
                sbResult.Append("                    orderby p.ProductName descending;\r\n");
                sbResult.Append("\r\n");
                sbResult.Append("URI String: ");
                sbResult.Append("\r\n");
                sbResult.Append("                   " + query.ToString());
                sbResult.Append("\r\n");

                sbResult.Append("RESULTS\r\n");
                sbResult.Append("====================================================\r\n");

                foreach (Products p in query)
                {
                    sbResult.Append(String.Format("Product ID = {0}, Product Name = {1} \r\n", p.ProductID, p.ProductName));
                }

                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Error : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }
        }

        private void metaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        #endregion

        #region URI Query Operations

        private void typeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mathToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {
                NorthwindEntities entities = new NorthwindEntities(serviceUri);
                entities.MergeOption = MergeOption.AppendOnly;

                /*DataServiceContext context = new DataServiceContext(serviceUri);
                DataServiceQuery qry = context.CreateQuery<Orders>("/Products?$filter=(");

                sbResult.Append("URI query: [Load all 2007 orders] \r\n");
                sbResult.Append("\r\n");
                sbResult.Append("                   " + qry.ToString());
                sbResult.Append("\r\n");
                sbResult.Append("RESULTS\r\n");
                sbResult.Append("====================================================\r\n");


                var qry = from p in entities.CreateQuery<Products>("Products")
                          where (p.UnitsOnOrder + p.UnitsInStock) < p.ReorderLevel
                          select p;



                sbResult.Append("LINQ to REST query: [Load all Products that total inventory is less than the reorder level] \r\n");
                sbResult.Append("\r\n");
                sbResult.Append("                    from p in entities.CreateQuery<Products>(\"Products\")\r\n");
                sbResult.Append("                    where  (p.UnitsOnOrder + p.UnitsInStock) < p.ReorderLevel \r\n");
                sbResult.Append("\r\n");
                sbResult.Append("URI String: ");
                sbResult.Append("\r\n");
                sbResult.Append("                   " + qry.ToString());
                sbResult.Append("\r\n");
                sbResult.Append("RESULTS\r\n");
                sbResult.Append("====================================================\r\n");

                foreach (Products p in qry)
                {
                    //Get the associated product category
                    entities.LoadProperty(p, "Categories");
                    sbResult.Append(String.Format("Product ID = {0}, Product Name = {1}, Product Category {2}, Units On Order = {3}, Units In Stock {4}, Reorder Level {5}\r\n", p.ProductID, p.ProductName, p.Categories.CategoryName, p.UnitsOnOrder, p.UnitsInStock, p.ReorderLevel));
                }
                 * */

                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Error : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }
        }

        private void dateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {
                DataServiceContext context = new DataServiceContext(serviceUri);
                DataServiceQuery qry = context.CreateQuery<Orders>("/Orders?$filter=(year(OrderDate) eq 1997)");

                sbResult.Append("URI query: [Load all 2007 orders] \r\n");
                sbResult.Append("\r\n");
                sbResult.Append("                   " + qry.ToString());
                sbResult.Append("\r\n");
                sbResult.Append("RESULTS\r\n");
                sbResult.Append("====================================================\r\n");

                foreach (Orders o in qry)
                {
                    sbResult.Append(String.Format("Order ID = {0}, Order Date = {1} \r\n", o.OrderID, o.OrderDate));;
                    
                }
                

                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Error : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logicalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metaDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void expandingToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pagingToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sortingDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region CRUD Operations

        private void createCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {
                NorthwindEntities entities = new NorthwindEntities(serviceUri);
                entities.MergeOption = MergeOption.OverwriteChanges;

                Customers customer = null;

                //Check for whether customer exists with No HTTP 404 Error thrown
                DataServiceQuery<Customers> query = entities.CreateQuery<Customers>("/Customers?$filter=CustomerID eq 'APRES'");
                List<Customers> custs = query.ToList();
                if (custs.Count == 1)
                {
                    customer = custs[0];
                }


                //Bug here not returning entity even if this exists
                //Uri custUri = new Uri("/Customers('APRES')", UriKind.Relative);
                //
                //Check whether it already exists first
                //if (entities.TryGetEntity<Customers>(custUri, out customer))
                //{
                //    sbResult.Append("Customer already exists : APRES");
                //    sbResult.Append("\r\n");
                //}
                //else
                //{
                if (customer == null)
                {
                    //Insert new customer
                    customer = new Customers();
                    customer.CustomerID = "APRES";
                    customer.CompanyName = "Apress Inc";
                    customer.ContactName = "Joe Smith";
                    customer.ContactTitle = "President";
                    customer.Address = "2855 Telegraph Avenue, Suite 600";
                    customer.City = "Berkeley";
                    customer.Region = "CA";
                    customer.PostalCode = "94705 ";
                    customer.Country = "USA";

                    entities.AddToCustomers(customer);

                    sbResult.Append("Added Customer : APRES");
                    sbResult.Append("\r\n");
                }
                else
                {
                    //Update Customer
                    customer.CustomerID = "APRES";
                    customer.CompanyName = "Apress Inc";
                    customer.ContactName = "Bob Smith";
                    customer.ContactTitle = "President";
                    customer.Address = "2855 Telegraph Avenue, Suite 600";
                    customer.City = "Berkeley";
                    customer.Region = "CA";
                    customer.PostalCode = "94705 ";
                    customer.Country = "USA";
                    entities.UpdateObject(customer);

                    sbResult.Append("Updated Customer : APRES");
                    sbResult.Append("\r\n");
                }

                //Persist the changes
                DataServiceResponse dataServiceResponse = entities.SaveChanges();

                //Check for errors
                if (dataServiceResponse.BatchStatusCode == 0)
                {
                    HandleDataServiceResponse(dataServiceResponse, sbResult);
                }
                else
                {
                    //Query for customer
                    //Bug/Feature, another way of getting the first record
                    //customer = entities.CreateQuery<Customers>("/Customers('APRES')").First();
                    customer = (from c in entities.Customers
                                where c.CustomerID.Equals("APRES")
                                select c).SingleOrDefault();

                    sbResult.Append("RESULTS\r\n");
                    sbResult.Append("====================================================\r\n");

                    if (customer != null)
                    {
                        sbResult.Append(String.Format("Customer ID = {0}, Customer Name = {1}, Country = {2}, City = {3}, Region = {4} \r\n", customer.CustomerID, customer.CompanyName, customer.Country, customer.City, customer.Region));
                    }
                }

                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Error : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }

        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {
                NorthwindEntities entities = new NorthwindEntities(serviceUri);
                entities.MergeOption = MergeOption.OverwriteChanges;

                Customers customer = null;

                //Feature : First() or Single() returns an error need to use SingleOrDefault()
                //This returns an HTTP 404 error for blank
                //customer = (from c in entities.Customers
                //            where c.CustomerID.Equals("APRES")
                //            select c).SingleOrDefault();

                //Fails
                // customer = entities.Customers.Where(c => c.CustomerID == "APRESS").First();


                /*This works 
                  
                 var alfki = from c in entities.Customers
                            where c.CustomerID == "ALFKI"
                            select c;

                //Force materialization of results
                int r = alfki.AsEnumerable<Customers>().Count<Customers>();
                */

                //TryGetUri takes the absolute URI for a resource
                Uri custUri = new Uri("/Customers('ALFKI')", 
                UriKind.RelativeOrAbsolute);

                if (entities.TryGetEntity<Customers>(custUri, out customer))
                {
                    Console.WriteLine("Customer exists");
                }
                else
                {
                    Console.WriteLine("Customer doesn't exists");
                }



                DataServiceQuery<Customers> query = entities.CreateQuery<Customers>("/Customers?$filter=CustomerID eq 'APRES'");
                List<Customers> custs = query.ToList();
                if (custs.Count == 1)
                {
                    customer = custs[0];
                }

                if (customer == null)
                {
                    sbResult.Append("Customer APRES doesn't exist");
                    sbResult.Append("\r\n");
                }
                else
                {
                    //First way is to just delete the object
                    entities.DeleteObject(customer);


                    sbResult.Append("Deleted Customer : APRES");
                    sbResult.Append("\r\n");
                }

                //Persist the changes
                DataServiceResponse dataServiceResponse = entities.SaveChanges();

                //Check for errors
                if (dataServiceResponse.BatchStatusCode == 0)
                {
                    HandleDataServiceResponse(dataServiceResponse, sbResult);
                }
                else
                {
                    //Query for customer
                    //Bug/Feature, another way of getting the first record
                    //customer = entities.CreateQuery<Customers>("/Customers('APRES')").First();

                    query = entities.CreateQuery<Customers>("/Customers?$filter=CustomerID eq 'APRES'");
                    custs = query.ToList();
                    if (custs.Count == 1)
                    {
                        customer = custs[0];
                    }
                    else
                    {
                        customer = null;
                    }

                    sbResult.Append("RESULTS\r\n");
                    sbResult.Append("====================================================\r\n");

                    if (customer != null)
                    {
                        sbResult.Append(String.Format("Customer ID = {0}, Customer Name = {1}, Country = {2}, City = {3}, Region = {4} \r\n", customer.CustomerID, customer.CompanyName, customer.Country, customer.City, customer.Region));
                    }
                    else
                    {
                        sbResult.Append("Customer Deleted");
                    }
                }

                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Error : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Use the Create handler for this operation
            createCustomerToolStripMenuItem_Click(null, EventArgs.Empty);
        }


        private void deleteCustomerNotInContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {
                NorthwindEntities entities = new NorthwindEntities(serviceUri);
                entities.MergeOption = MergeOption.OverwriteChanges;

                //Just remove the customer without loading it first
                //Second way is detach the object
                Customers customer = Customers.CreateCustomers("APRES", "");
                entities.AttachTo("Customers", customer);
                entities.DeleteObject(customer);

                sbResult.Append("Deleted Customer without loading into Context: APRES");
                sbResult.Append("\r\n");

                //Persist the changes
                DataServiceResponse dataServiceResponse = entities.SaveChanges();

                //Check for errors
                if (dataServiceResponse.BatchStatusCode == 0)
                {
                    HandleDataServiceResponse(dataServiceResponse, sbResult);
                }
                else
                {
                    //Query for customer
                    //Bug/Feature, another way of getting the first record
                    //customer = entities.CreateQuery<Customers>("/Customers('APRES')").First();

                    var query = entities.CreateQuery<Customers>("/Customers?$filter=CustomerID eq 'APRES'");
                    List<Customers> custs = query.ToList();
                    if (custs.Count == 1)
                    {
                        customer = custs[0];
                    }
                    else
                    {
                        customer = null;
                    }

                    sbResult.Append("RESULTS\r\n");
                    sbResult.Append("====================================================\r\n");

                    if (customer != null)
                    {
                        sbResult.Append(String.Format("Customer ID = {0}, Customer Name = {1}, Country = {2}, City = {3}, Region = {4} \r\n", customer.CustomerID, customer.CompanyName, customer.Country, customer.City, customer.Region));
                    }
                    else
                    {
                        sbResult.Append("Customer Deleted");
                    }
                }

                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Error : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }
        }


        private void createCustomerAndOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        #endregion

        #region Advanced Concepts

        private void batchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {


                NorthwindEntities entities = new NorthwindEntities(serviceUri);
                entities.MergeOption = MergeOption.OverwriteChanges;

                List<Products> products = (from p in entities.Products 
                                where p.ProductID == 1 || p.ProductID == 2
                                select p).ToList();

                products[0].UnitPrice = 50;
                products[1].UnitPrice = 10;

                //Mark as Updated in entities
                entities.UpdateObject(products[0]);
                entities.UpdateObject(products[1]);

                //Save
                //DataServiceResponse response = entities.SaveChanges(SaveChangesOptions.Batch);

                /*
                
                //Delete the customer first
                //createCustomerToolStripMenuItem_Click(null, EventArgs.Empty);
                //Load all products
                entities.CreateQuery<Products>("/Products");

                Customers customer = entities.CreateQuery<Customers>("/Customers('APRES')").AsEnumerable().SingleOrDefault();

                //Add Order
                Orders order = Orders.CreateOrders(-99);
                order.RequiredDate = new DateTime(2010, 11, 01);
                order.Freight = 10;
                entities.AddToOrders(order);

                //Add Order Lines
                List<Order_Details> orderDetailsColl = new List<Order_Details>
                { 
                    new Order_Details(){Orders= order, Products = entities.Products.Where(p =>p.ProductName == "Chang").First(), Quantity=1, Discount=0.8F, UnitPrice=40},
                    new Order_Details(){Orders= order, Products = entities.Products.Where(p =>p.ProductName == "Tofu").First(), Quantity=10, Discount=0.7F, UnitPrice = 10 }
                     
                };

                //Add Order Lines to Order
                foreach (Order_Details od in orderDetailsColl)
                {
                    entities.AddToOrder_Details(od);
                    entities.AddLink(od.Products, "Order_Details", od);
                    entities.AddLink(order, "Order_Details", od);
                }

                //Add to Order to Customer
                customer.Orders.Add(order);
                entities.AddLink(customer, "Orders", order);

                //Persist the changes
                DataServiceResponse dataServiceResponse = entities.SaveChanges(SaveChangesOptions.Batch);

                */

                DataServiceResponse dataServiceResponse = entities.SaveChanges(SaveChangesOptions.Batch);
                /*
                sbResult.Append("Added Customer and related Orders: APRES");
                sbResult.Append("\r\n");

                //Check for errors
                if (dataServiceResponse.BatchStatusCode == 0)
                {
                    HandleDataServiceResponse(dataServiceResponse, sbResult);
                }
                else
                {
                    //Query for customer
                    //Bug/Feature, another way of getting the first record
                    //customer = entities.CreateQuery<Customers>("/Customers('APRES')").First();
                    customer = (from c in entities.Customers
                                where c.CustomerID.Equals("APRES")
                                select c).SingleOrDefault();

                    sbResult.Append("RESULTS\r\n");
                    sbResult.Append("====================================================\r\n");

                    if (customer != null)
                    {
                        sbResult.Append(String.Format("Customer ID = {0}, Customer Name = {1}, Country = {2}, City = {3}, Region = {4} \r\n", customer.CustomerID, customer.CompanyName, customer.Country, customer.City, customer.Region));
                    }
                    
                }*/

                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Error : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }
        }

        private void concurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {
                NorthwindEntities entities = new NorthwindEntities(serviceUri);
                entities.MergeOption = MergeOption.OverwriteChanges;

                //Get the first supplier
                Suppliers supplier = entities.CreateQuery<Suppliers>("/Suppliers(1)").AsEnumerable().SingleOrDefault();

                //Update supplier
                supplier.ContactTitle = "Charlotte Smith";

                //Persist the changes
                DataServiceResponse dataServiceResponse = entities.SaveChanges();

                //Check for errors
                if (dataServiceResponse.BatchStatusCode == 0)
                {
                    HandleDataServiceResponse(dataServiceResponse, sbResult);
                }
                else
                {
                    //Query for customer
                    //Bug/Feature, another way of getting the first record
                    //customer = entities.CreateQuery<Customers>("/Customers('APRES')").First();
                    supplier = (from s in entities.Suppliers
                                where s.SupplierID.Equals(1)
                                select s).SingleOrDefault();

                    sbResult.Append("RESULTS\r\n");
                    sbResult.Append("====================================================\r\n");

                    if (supplier != null)
                    {
                        sbResult.Append(String.Format("Supplier ID = {0}, Supplier Name = {1}\r\n", supplier.SupplierID, supplier.CompanyName));
                    }
                }

                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Error : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }
        }

        private void valueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serviceOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inteceptorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Other Concepts

        private void lazyLoadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";

            try
            {
                NorthwindEntities entities = new NorthwindEntities(serviceUri);
                entities.MergeOption = MergeOption.AppendOnly;


                var query = from c in entities.Customers
                            where c.CustomerID == "ALFKI"
                            select c;

                //TryGetUri Example takes the absolute URI for a resource
                //Uri custUri = new Uri(entities.BaseUri + "/Customers('ALFKI')",
                //UriKind.RelativeOrAbsolute);

                //if (entities.TryGetEntity<Customers>(custUri, out customer))
                //{
                //    Console.WriteLine("Customer exists");
                //}
                //else
                //{
                //    Console.WriteLine("Customer doesn't exists");
                //}

                sbResult.Append("LINQ to REST query: [Load all ALFKI Customer and lazy load related orders] \r\n");
                sbResult.Append("\r\n");
                sbResult.Append("                     from c in entities.Customers\r\n");
                sbResult.Append("                   where c.CustomerID == \"ALFKI\" \r\n");
                sbResult.Append("\r\n");
                sbResult.Append("URI String: ");
                sbResult.Append("\r\n");
                sbResult.Append("                   " + query.ToString());
                sbResult.Append("\r\n");
                sbResult.Append("RESULTS\r\n");
                sbResult.Append("====================================================\r\n");

                //Force materialization of customer alfki entity
                Customers alfki = query.AsEnumerable<Customers>().FirstOrDefault();

                //Load related orders
                entities.LoadProperty(alfki, "Orders");

                //Print customer
                sbResult.Append(String.Format("Customer ID = {0}, Customer Name = {1}, Country = {2}, City = {3}, Region = {4} \r\n", alfki.CustomerID, alfki.CompanyName, alfki.Country, alfki.City, alfki.Region));
                sbResult.Append("Orders \r\n");

                //For each order
                foreach (Orders o in alfki.Orders)
                {
                    sbResult.Append(String.Format("Order ID = {0}, Order Date = {1} \r\n", o.OrderID, o.OrderDate));

                    //Load Order Details for each order
                    entities.LoadProperty(o, "Order_Details");
                    foreach (Order_Details od in o.Order_Details)
                    {
                        sbResult.Append(String.Format("Product ID = {0}, Quantity = {1}, UnitPrice = {2} \r\n", od.ProductID, od.Quantity, od.UnitPrice));
                    }
                }

                txtResponse.Text = sbResult.ToString();
            }
            catch (Exception ex)
            {
                sbResult.Append("Error : " + ex.ToString());
                sbResult.Append("\r\n");
                txtResponse.Text = sbResult.ToString();
            }

        }

        private void asyncLoadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbResult.Length = 0;
            txtResponse.Text = "";
            NorthwindEntities entities = new NorthwindEntities(serviceUri);
            entities.MergeOption = MergeOption.AppendOnly;

            var qry = from c in entities.Customers
                  orderby c.CompanyName
                  select c;


            // Cast the query to a DataServiceQuery
            DataServiceQuery<Customers> customerQuery = 
                                              (DataServiceQuery<Customers>)qry;


            sbResult.Append("LINQ to REST query: [Load all customers async] \r\n");
            sbResult.Append("                    from c in entities.Customers\r\n");
            sbResult.Append("                    orderby c.CompanyName\r\n");
            sbResult.Append("\r\n");
            sbResult.Append("URI String: ");
            sbResult.Append("\r\n");
            sbResult.Append("                   " + customerQuery.ToString());
            sbResult.Append("\r\n");

            txtResponse.Text = sbResult.ToString();

            // Start the execution
            customerQuery.BeginExecute(new AsyncCallback(OnLoadComplete), 
                                      customerQuery);

           

        }

        private void OnLoadComplete(IAsyncResult result)
        {
            sbResult.Length = 0;
            DataServiceQuery<Customers> customerQuery =
              (DataServiceQuery<Customers>)result.AsyncState;

            // Get ther esults and add them to the collection
            List<Customers> customers = customerQuery.EndExecute(result).ToList();

            sbResult.Append("RESULTS\r\n");
            sbResult.Append("====================================================\r\n");

            foreach (Customers c in customers)
            {
                sbResult.Append(String.Format("Customer ID = {0}, Customer Name = {1}, Country = {2}, City = {3}, Region = {4} \r\n", c.CustomerID, c.CompanyName, c.Country, c.City, c.Region));
            }

            //Update UI Thread
            this.Invoke((MethodInvoker)delegate
            {
                txtResponse.Text += sbResult.ToString();
            });
        }



        #endregion

        #region Helpers

        /// <summary>
        /// Handle the Data Service Response
        /// </summary>
        /// <param name="dataServiceResponse"></param>
        /// <param name="sbResult"></param>
        private void HandleDataServiceResponse(DataServiceResponse dataServiceResponse, StringBuilder sbResult)
        {
            sbResult.Append("Exceptions have occurred \r\n");
            sbResult.Append("====================================================\r\n");

            foreach (ChangeOperationResponse cr in dataServiceResponse)
            {
                WebException exception =cr.Error as WebException;

                if (exception != null)
                {
                    while (exception != null)
                    {
                        HttpWebResponse httpResponse = (HttpWebResponse)exception.Response;
                        string errorDescription = "";

                        using (StreamReader reader = new StreamReader(exception.Response.GetResponseStream()))
                        {
                            errorDescription = reader.ReadToEnd();
                        }

                        sbResult.Append(String.Format("Status Code {0}, Error Description {1}", exception.Status.ToString(), errorDescription));

                        exception = exception.InnerException as WebException;
                    }
                }
                else
                {
                    sbResult.Append(String.Format("Status Code {0}, Error Description {1}", cr.StatusCode, exception.ToString()));
                }


                


            }
        }
        #endregion

        private void otherConceptsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
