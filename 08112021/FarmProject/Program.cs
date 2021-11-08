using System;

namespace FarmProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Sheep sheep1 = new Sheep
            {
                Name = "quzu1",
                Age = 1,
                Gender = false,
                Type = "Merinos"
            };
            Sheep sheep2 = new Sheep
            {
                Name = "quzu2",
                Age = 1,
                Gender = false,
                Type = "Dorper"
            };
            Sheep sheep3 = new Sheep
            {
                Name = "quzu3",
                Age = 1,
                Gender = false,
                Type = "Hampshire"
            };

            Horse horse1 = new Horse
            {
                Age = 8,
                Gender = true,
                Name = "Qirat1",
                Sort = HorseSort.Qarabagh
            };
            Horse horse2 = new Horse
            {
                Age = 4,
                Gender = true,
                Name = "Qirat2",
                Sort = HorseSort.Ingilis
            };
            Horse horse3 = new Horse
            {
                Age = 2,
                Gender = true,
                Name = "Qirat3",
                Sort = HorseSort.Ereb
            };
            Horse horse4 = new Horse
            {
                Age = 4,
                Gender = true,
                Name = "Qirat4",
                Sort = HorseSort.Ingilis
            };
            Horse horse5 = new Horse
            {
                Age = 4,
                Gender = true,
                Name = "Qirat5",
                Sort = HorseSort.Ingilis
            };

            Farm farm = new Farm();

            farm.AddAnimal(sheep2);
            farm.AddAnimal(sheep1);
            farm.AddAnimal(sheep3);
            farm.AddAnimal(horse3);
            farm.AddAnimal(horse2);
            farm.AddAnimal(horse1);
            farm.AddAnimal(horse4);
            farm.AddAnimal(horse5);

            Console.WriteLine("Atin adini daxil edin");
            string horse6Name = Console.ReadLine();

            Console.WriteLine("Atin yasini daxil edin");
            byte horse6Age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Atin genderini daxil edin");
            bool horse6Gender = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Atin sortunu daxil edin:");
            foreach (var item in Enum.GetValues(typeof(HorseSort)))
            {
                Console.WriteLine(item + " - "+(byte)item);
            }

            byte horse6Sort = Convert.ToByte(Console.ReadLine());

            Horse horse6 = new Horse
            {
                Age = horse6Age,
                Name = horse6Name,
                Gender = horse6Gender,
                Sort = (HorseSort)horse6Sort
            };
            farm.AddAnimal(horse6);


            Console.WriteLine("Sheeps:");
            foreach (var sheep in farm.GetSheeps())
            {
                Console.WriteLine($"Name: {sheep.Name}  - Gender: {sheep.Gender} - Age: {sheep.Age} - Type: {sheep.Type}");
            }

            Console.WriteLine("Horses:");
            foreach (var horse in farm.GetHorses())
            {
                //string sort = horse.Sort == HorseSort.Qarabagh ? "Qarabagh" : (horse.Sort == HorseSort.Ingilis ? "Ingilis" : "Ereb");
                Console.WriteLine($"Name: {horse.Name}  - Gender: {horse.Gender} - Age: {horse.Age} - Sort Enum value: {(byte)horse.Sort} -  Sort Enum name: {horse.Sort}");
            }

            var newHorse = horse1 + horse2;

            Console.WriteLine(newHorse.Name);

            Console.WriteLine(horse1>horse2);
            Console.WriteLine(horse1<horse2);

        }
    }
}
