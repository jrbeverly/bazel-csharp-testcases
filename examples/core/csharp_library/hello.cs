using System;
using System.Linq;
using Library;

namespace Hello {
  public static class Program {
    public static void Main() {
      Console.WriteLine( "Hello, world!" );
      Console.WriteLine( Messages.Apples( 3 ) );
    }
  }
}
