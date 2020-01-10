using System;
using System.Linq;
using Library;

namespace Hello {
  public static class Program {
    public static void Main() {
      var result = Computer.Sum(5, 6);
      if (result != 11) {
        Console.WriteLine( $"Sum is not as expected: {result}" );
        System.Environment.Exit(1);
      }
      Console.WriteLine( $"Sum: {result}" );
    }
  }
}
