using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    public class English : ISubject
    {
        public English()
        {

        }
        public void RoomNum()
        {
            Console.WriteLine("English class is at Room 1.");
        }
    }
}
