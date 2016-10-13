using System;

namespace Apress.Data.Services.CustomerService.BusinessEntities
{
    /// <summary>
    /// The customer entity
    /// </summary>
    public class CustomerModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        /// <value>The date of birth.</value>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Gets or sets the salutation.
        /// </summary>
        /// <value>The salutation.</value>
        public SalutationModel Salutation { get; set; }
        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>The gender.</value>
        public GenderModel Gender { get; set; }
    }
}
