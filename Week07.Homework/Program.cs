using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week07.Homework
{
    public class DelegateExercises
    {
        public delegate int MyDelegate(int intValue);

        public int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }

        public int Method2(int intMethod2)
        {
            return intMethod2 * 10;
        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            int result1 = myDelegate(10);
            System.Console.WriteLine(result1);
            myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            System.Console.WriteLine(result2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1

            ////Define a list of User objects
            //List<User> users = new List<User>();
            ////a) Add generated user to the list
            //users.AddRange(GenerateUsers());
            //Console.WriteLine("All users successfully added");
            //Console.WriteLine("===========");
            ////b) Find users which are older than 20 and print them
            //List<User> olderThan20 = users.Where(x => x.Age > 20).ToList();
            //foreach(var user in olderThan20)
            //{
            //    user.PrintFullInfo();
            //}
            //Console.WriteLine("===========");
            ////c) Find users belonging to Turkey && younger than 10 and remove them
            //users.RemoveAll(YoungerThan10AndFromTurkey);
            ////List<User> youngerThan10AndTurkey = users.FindAll(x => (x.Country == "Turkey") && (x.Age < 10));
            ////foreach(var user in youngerThan10AndTurkey)
            ////{
            ////    users.Remove(user);
            ////}
            //Console.WriteLine("All users successfully removed");
            //Console.WriteLine("Users after removal");
            //Console.WriteLine(" ");
            //foreach(var user in users)
            //{
            //    user.PrintFullInfo();
            //}
            ////Method to generate user objects
            //static List<User> GenerateUsers()
            //{
            //    List<User> generatedUsers = new List<User>(10);
            //    for(int i = 0; i < 10; i++)
            //    {
            //        //Ask for name
            //        Console.Write($"Enter User {i + 1} name: ");
            //        string name = Console.ReadLine();
            //        //Ask for surname
            //        Console.Write($"Enter User {i + 1} surname: ");
            //        string surname = Console.ReadLine();
            //        //Ask for age
            //        Console.Write($"Enter User {i + 1} age: ");
            //        byte age = byte.Parse(Console.ReadLine());
            //        //Ask for country
            //        Console.Write($"Enter User {i + 1} country: ");
            //        string country = Console.ReadLine();
            //        //Instantiate a user
            //        User user = new User(name, surname, age, country);
            //        //Add to the list
            //        generatedUsers.Add(user);
            //    }
            //    return generatedUsers;
            //}
            #endregion
            #region Task-2
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();

            //The output will be 20 and 100. Explanation:
            //We have a class named "DelegateExercises"
            //In that class we have a delegate named "MyDelegate"
            //which (its methods) accepts  an integer and returns an integer as well
            //"DelegateExercises" class also has 3 methods
            //"Method1" accepts an integer, multiplies it by 2 and returns as a new integer
            //"Method2" accepts an iteger, multiplies it by 10 and returns as a new integer
            //"Method3" doesn't accept any parameters and doesn't have a return type either
            //it instantiates a new delegate called "myDelegate"
            //and passes the "Method1" as the argument
            //then invokes, calls "Method1", passes 10 as argument to it,
            //which in turn multiplies it by 2, thus returns 20
            //and stores this value in an integer called "result1".
            //Then it prints this integer to the Console
            //thus the FIRST VALUE we see on the Console is 20.
            //Afterwards, the "Method3" changes the "myDelegate" delegate
            //by passing the "Method2" to it and assigning to it a new "MyDelegate"
            //then it repeats the previous process, invokes the delegate, which in turn
            //calls the "Method2" function, passes to it 10 as the argument
            //Then it stores the result (multplying the argument by 10), 100, in a new
            //integer called "result2", then prints it to the Console.
            //Thus, the SECOND VALUE we see on the console is 100 (10 * 10)
            //To complete all of the above, the "Main" method instantiates
            //the "DelegateExercises" class, names the object as "delegateExercises",
            //then it simply calls the "Method3" which belongs to the "delegateExercises" object
            //by "delegateExercises.Method3();"
            #endregion
        }
        //Define a predictate to remove elements (from Task-1)
        private static bool YoungerThan10AndFromTurkey(User user)
        {
            return ((user.Age < 10 && user.Country == "Turkey"));
        }
    }
}

