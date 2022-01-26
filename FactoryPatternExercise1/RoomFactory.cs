using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    static class RoomFactory
    {
        public static ISubject GetSubject(string roomNum)
        {
            switch (roomNum.ToLower())
            {
                case "history":
                    return new History();
                case "math":
                    return new Math();
                default:
                    return new English();
               
            }

           

        }
       
    }
}
