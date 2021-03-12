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
        static string Register(string fn, string ln, string pw, string pn, List<Member> members)
        {
            string username = fn.Substring(0,3) + ln.Substring(0,3);
            Member newMember = new Member(username, fn, ln, pw, pn);
            members.Add(newMember);
            return username;
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
                // Register account
                case 1:
                    Console.WriteLine("First name: ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Last name: ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Password: ");
                    string password = Console.ReadLine();
                    Console.WriteLine("Phonenumber: ");
                    string phoneNumber = Console.ReadLine();

                    string registered = Register(firstName, lastName, password, phoneNumber, members);
                    if (registered != null)
                    {
                        Console.WriteLine($"You are registered with username {registered}");
                        Console.WriteLine("Press enter to go back to main menu");
                        Console.ReadKey();
                    }
                    
                    break;

                // Sign in
                case 2:
                    Console.WriteLine("Username: ");
                    string username = Console.ReadLine();
                    Member userExist = members.Find(x => x.Username == username);
                    if (userExist != null)
                    {

                        int PWTries = 0;
                        int maxPWTries = 3;
                        while(PWTries < maxPWTries) {
                            Console.WriteLine("Password: ");
                            string pw = Console.ReadLine();
                            PWTries++;
                            if (userExist.PassWord == pw)
                            {
                                SignedIn(userExist.FirstName);
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Password is incorrect, you have {maxPWTries - PWTries} tries left");
                            }
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
