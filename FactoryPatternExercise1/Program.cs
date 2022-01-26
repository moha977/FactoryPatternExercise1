using System;

namespace FactoryPatternExercise1
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a school subject for a room number.");
           string userSubject =  Console.ReadLine();
            ISubject subject = RoomFactory.GetSubject(userSubject);
            subject.RoomNum();
        }
    }
}
