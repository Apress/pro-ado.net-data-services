using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Apress.Data.Services.CustomerService.Client.Proxy;

namespace Apress.Data.Services.CustomerService.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
            string lastname = "Smith";

            CustomerManagementClient client = new CustomerManagementClient();

            client.Open();
            Console.WriteLine("Call to get customer by id");
            Customer customer = client.GetCustomerById(id);
            Console.WriteLine(string.Format("Details for customer id: {0}", id));
            Console.WriteLine(string.Format("Name: {0} {1} {2}, Date of Birth: {3}, Gender: {4}", customer.Salutation.Description, customer.FirstName, customer.LastName, customer.DateOfBirth, customer.Gender.Name));
            Console.WriteLine();

            Console.WriteLine("Call to get customers by lastname");
            Customer[] customers = client.GetCustomersByLastname(lastname);

            foreach (Customer c in customers)
            {
                Console.WriteLine(string.Format("Details for customer id: {0}", c.Id));
                Console.WriteLine(string.Format("Name: {0} {1} {2}, Date of Birth: {3}, Gender: {4}", c.Salutation.Description, c.FirstName, c.LastName, c.DateOfBirth, c.Gender.Name));
            }

            Console.WriteLine();
            Console.WriteLine("Creating new customer");

            Customer newCustomer = new Customer
            {
                FirstName = "Jimmy",
                LastName = "Brown",
                DateOfBirth = new DateTime(1955, 10, 30),
                Gender = new Gender
                {
                    Id = "M"
                },
                Salutation = new Salutation
                {
                    Id = 1
                }
            };

            int customerId = client.PersistCustomer(newCustomer);

            Console.WriteLine(string.Format("New customer with id {0} created", customerId));
            client.Close();
        }
    }
}
