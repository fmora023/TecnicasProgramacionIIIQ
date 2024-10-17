namespace Model
{
    /// <summary>
    /// Model for Person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="lastname">The lastname.</param>
        /// <param name="country">The country.</param>
        public Person(string name, string lastname, string country)
        {
            this.Country = country;
            this.LastName = lastname;
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
    }
}
