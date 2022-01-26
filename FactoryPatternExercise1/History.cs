using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    public class History : ISubject
    {
        public History()
        {

        }
        public void RoomNum()
        {
            Console.WriteLine("History class is at Room 2.");
        }
    }
}
