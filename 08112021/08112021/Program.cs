using System;

namespace _08112021
{
    class Program
    {
        static void Main(string[] args)
        {
            //UpCasting
            Animal horseAnimal = new Horse { Name = "Qirat",Color = "Gray",Sort = "Ingiliz"};
            Animal sheepAnimal = new Sheep { Name = "Sebet", Color = "White", Type = "Kababliq" };
            Animal animal = new Animal();

            //DownCasting
            Horse horse = (Horse)horseAnimal; // horseAnimal as Horse
            Console.WriteLine(horse.Sort);


            int age = 258;

            //expicit convertion
            byte ageByte = (byte)age;

            ageByte = 200;

            //implicit convertion
            int ageInt = ageByte;

            Console.WriteLine(ageByte);

            Animal[] animals = new Animal[]
            {
                 new Horse { Name = "Qirat",Color = "Gray",Sort = "Ingiliz"},
                 new Sheep { Name = "Sebet", Color = "White", Type = "Kababliq" }
            };

            Console.WriteLine("Animals:");
            foreach (var anm in animals)
            {
                if(anm is Horse)
                {
                    var anmHorse = anm as Horse;
                    Console.WriteLine("atin sortu: "+anmHorse.Sort);
                }
                else if(anm is Sheep)
                {
                    var anmSheep = anm as Sheep;
                    Console.WriteLine("qoyunun novu: "+anmSheep.Type);
                }
            }
        }
    }
}
