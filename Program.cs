using System;

namespace OOP_projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Member testObj = new Member(01, "Erik", "Appelgren", "1234", "072");
            Admin test = new Admin(02, "odksaf", "apa", "4345", "1234566");
            
            Console.WriteLine(testObj.FirstName);
            Console.WriteLine(test.UserID);
        }
    }
}
