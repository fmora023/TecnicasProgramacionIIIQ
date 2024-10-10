using Model;

namespace Controller
{
    /// <summary>
    /// Class in charge of managing the Person entity.
    /// </summary>
    public static class PersonController
    {
        /// <summary>
        /// Gets the people.
        /// </summary>
        /// <returns>a list for the people existing in the DB.</returns>
        public static List<Person> GetPeople()
        {
            return new List<Person>()
            {
                new Person("Christopher Calvo", DateTime.Today)
            };
        }
    }
}
