using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_projekt1
{
    class Program
    {
        public List<Member> Members = new List<Member>();
        static void Main(string[] args)
        {
            Register("odksaf", "apa", "4345", "1234566");
        }
        static void Register(string fn, string ln, string pw, string pn)
        {
            List<Member> Members = new List<Member>();
            int userID = Members.Count+1;
            Member newMember = new Member(userID, fn, ln, pw, pn);
            Members.Add(newMember);
            foreach (Member item in Members)
            {
                Console.WriteLine(newMember.UserID);
                Console.WriteLine(newMember.FirstName);
                Console.WriteLine(newMember.LastName);
                Console.WriteLine(newMember.PassWord);
                Console.WriteLine(newMember.PhoneNumber);
            }
        }
    }
}
