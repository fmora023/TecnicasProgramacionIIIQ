using Model;

namespace Controller.DataHandler
{
    /// <summary>
    /// Contract for elements who handles data.
    /// </summary>
    public interface IDataHandler
    {
        /// <summary>
        /// Gets the persons.
        /// </summary>
        /// <param name="people">The people.</param>
        /// <returns> A list with the people in the system.</returns>
        public List<Person> GetPeople(string people);

        /// <summary>
        /// Reads the data.
        /// </summary>
        public string ReadData();

        /// <summary>
        /// Writes the data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void WriteData(string data);
    }
}
