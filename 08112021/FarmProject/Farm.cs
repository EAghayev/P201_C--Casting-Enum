using System;
using System.Collections.Generic;
using System.Text;

namespace FarmProject
{
    class Farm : IFarm
    {
        public Farm()
        {
            _animals = new Animal[0];
        }
        private Animal[] _animals;
        public Animal[] Animals { get =>_animals;}

        public void AddAnimal(Animal animal)
        {
            Array.Resize(ref _animals, _animals.Length + 1);
            _animals[_animals.Length - 1] = animal;
        }

        public Horse[] GetHorses()
        {
            Horse[] horses = new Horse[0];

            foreach (var item in _animals)
            {
                if(item is Horse)
                {
                    Array.Resize(ref horses, horses.Length + 1);
                    horses[horses.Length - 1] = item as Horse;
                }
            }

            return horses;
        }
        public Horse[] GetHorses(HorseSort sort)
        {
            Horse[] horses = new Horse[0];

            foreach (var item in _animals)
            {
                if (item is Horse)
                {
                    Horse horse = item as Horse;
                    if(horse.Sort == sort)
                    {
                        Array.Resize(ref horses, horses.Length + 1);
                        horses[horses.Length - 1] = horse;
                    }
                }
            }

            return horses;
        }

        public Sheep[] GetSheeps()
        {
            Sheep[] sheeps = new Sheep[0];
            foreach (var item in _animals)
            {
                if(item is Sheep)
                {
                    Array.Resize(ref sheeps, sheeps.Length + 1);
                    sheeps[sheeps.Length - 1] = item as Sheep;
                }
            }

            return sheeps;
        }
    }
}
