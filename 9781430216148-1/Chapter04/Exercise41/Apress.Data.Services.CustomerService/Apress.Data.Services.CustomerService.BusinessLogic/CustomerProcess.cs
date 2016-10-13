using System;
using System.Collections.Generic;
using Apress.Data.Services.CustomerService.BusinessEntities;
using Apress.Data.Services.CustomerService.Data;

namespace Apress.Data.Services.CustomerService.BusinessLogic
{
    /// <summary>
    /// The customer business process layer.
    /// </summary>
    public class CustomerProcess
    {
        private CustomerData customerData;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerProcess"/> class.
        /// </summary>
        public CustomerProcess()
        {
            customerData = new CustomerData();
        }

        /// <summary>
        /// Gets the specified customer by id.
        /// </summary>
        /// <param name="customerId">The customer id.</param>
        /// <returns></returns>
        public CustomerModel Get(int customerId)
        {
            if (customerId < 1)
            {
                throw new ArgumentException("Customer Id must be greater than zero");
            }

            return customerData.Get(customerId);
        }

        /// <summary>
        /// Persists the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public void Persist(CustomerModel customer)
        {
            if (!IsPersistValid(customer))
            {
                throw new CustomerValidationException("Cannot persist customer because the customer is not valid");
            }


            if (customer.Id == 0)
            {
                customerData.Add(customer);
            }
            else
            {
                customerData.Update(customer);
            }
        }

        /// <summary>
        /// Determines whether [is persist valid] [the specified customer].
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns>
        /// 	<c>true</c> if [is persist valid] [the specified customer]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsPersistValid(CustomerModel customer)
        {
            if (customer.Id < 0)
            {
                return false;
            }

            if (customer.Gender == null)
            {
                return false;
            }

            if (customer.Salutation == null)
            {
                return false;
            }

            if (string.IsNullOrEmpty(customer.FirstName))
            {
                return false;
            }

            if (string.IsNullOrEmpty(customer.LastName))
            {
                return false;
            }

            if (string.IsNullOrEmpty(customer.Gender.Id) || (customer.Gender.Id != "M" && customer.Gender.Id != "F"))
            {
                return false;
            }

            if (customer.Salutation.Id < 1 || customer.Salutation.Id > 10)
            {
                return false;
            }

            if (customer.DateOfBirth == DateTime.MinValue)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets a list of customers by part of the lastname.
        /// </summary>
        /// <param name="lastname">The lastname.</param>
        /// <returns></returns>
        public List<CustomerModel> GetByLastName(string lastname)
        {
            if (string.IsNullOrEmpty(lastname))
            {
                throw new ArgumentNullException("Lastname cannot be null or empty");
            }

            return customerData.GetByLastname(lastname);
        }
    }
}
