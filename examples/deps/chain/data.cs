using Models;

namespace DataAccess
{
    public class CustomerDb
    {
        public Customer Get(int id) => new Customer() { ID = id, FirstName = "John", LastName = "Doe" };
    }
}