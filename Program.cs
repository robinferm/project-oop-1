using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>();
            while (true)
            {
                Menu(members);
            }
            
        }
        static void Register(string fn, string ln, string pw, string pn, List<Member> members)
        {
            int userID = members.Count+1;
            Member newMember = new Member(userID, fn, ln, pw, pn);
            members.Add(newMember);
            foreach (Member item in members)
            {
                Console.WriteLine(newMember.UserID);
                Console.WriteLine(newMember.FirstName);
                Console.WriteLine(newMember.LastName);
                Console.WriteLine(newMember.PassWord);
                Console.WriteLine(newMember.PhoneNumber);
            }
        }

        static void Menu(List<Member> members)
        {
            Console.Clear();
            Console.WriteLine("Gym booking system");
            Console.WriteLine("1. Register account");
            Console.WriteLine("2. Sign in");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("First name: ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Last name: ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Password: ");
                    string password = Console.ReadLine();
                    Console.WriteLine("Phonenumber: ");
                    string phoneNumber = Console.ReadLine();

                    Register(firstName, lastName, password, phoneNumber, members);
                    break;

                case 2:
                    for (int i = 0; i < members.Count; i++)
                    {
                        Console.WriteLine($"{i+1} {members[i].FirstName} {members[i].LastName}");
                    }
                    Console.WriteLine("UserID: ");
                    int userID = int.Parse(Console.ReadLine());
                    Member userExist = members.Find(x => x.UserID == userID);
                    if (userExist != null)
                    {
                        Console.WriteLine("Password: ");
                        string pw = Console.ReadLine();
                        if(userExist.PassWord == pw)
                        {
                            SignedIn(userExist.FirstName);
                        }
                    }
                    break;
            }
        }

        static void SignedIn(string firstName)
        {
            Console.Clear();
            Console.WriteLine($"Welcome {firstName}");
            Console.WriteLine("1. Reserve booking");
            Console.WriteLine("2. Edit booking");
            Console.WriteLine("3. Cancel booking");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    break;
            }
        }
    }
}
