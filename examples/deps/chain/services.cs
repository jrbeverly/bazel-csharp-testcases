using DataAccess;
using Models;

namespace Services
{
    public static class CustomerService
    {
        private static readonly CustomerDb _db = new CustomerDb();
        public static Customer Get(int id)
        {
            return _db.Get(id);
        }
    }
}