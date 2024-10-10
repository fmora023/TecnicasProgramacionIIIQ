namespace Model
{
    /// <summary>
    /// Model for Person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="birth">The birth.</param>
        public Person(string name, DateTime birth)
        {
            this.Name = name;
            this.Birthday = birth;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the birthday.
        /// </summary>
        /// <value>
        /// The birthday.
        /// </value>
        public DateTime Birthday { get; set; }
    }
}
