using System;
using Services;

namespace Hello {
  public static class Program {
    public static void Main() {
      var id = 101;
      Console.WriteLine( $"Using {id} to get customer" );
      var customer = CustomerService.Get(101);

      Console.WriteLine( $"ID: {customer.ID}" );
      Console.WriteLine( $"Name: {customer.FirstName} {customer.LastName}" );
    }
  }
}
