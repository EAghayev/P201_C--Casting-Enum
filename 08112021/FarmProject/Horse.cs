using System;
using System.Collections.Generic;
using System.Text;

namespace FarmProject
{
    enum HorseSort:byte
    {
        Qarabagh,
        Ingilis,
        Ereb
    }
    class Horse:Animal
    {
        public HorseSort Sort;

        public static Horse operator+ (Horse horse1, Horse horse2)
        {
            Horse horse3 = new Horse
            {
                Age = (byte)(horse1.Age + horse2.Age),
                Gender = horse1.Gender,
                Name = horse1.Name + " " + horse2.Name,
                Sort = horse2.Sort
            };

            return horse3;
        } 

        public static bool operator>(Horse horse1, Horse horse2)
        {
            return horse1.Age > horse2.Age;
        }
        public static bool operator <(Horse horse1, Horse horse2)
        {
            return horse1.Age < horse2.Age;
        }
    }


}
