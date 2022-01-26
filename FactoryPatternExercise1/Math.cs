using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    public class Math : ISubject
    {
        public Math()
        {

        }

        public void RoomNum()
        {
            Console.WriteLine("Math class is at Room 3.");
        }
    }
}
