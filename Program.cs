using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
	    if(args.Length > 0) {	
            	Console.WriteLine(String.Format("Hello args: [{0}]", String.Join(",", args)));
	    }
	    else {
                Console.WriteLine("Hello with no args!");
	    }
	    //Block to stay running
	    Console.ReadLine();
        }
    }
}
