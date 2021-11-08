using System;
using System.Collections.Generic;
using System.Text;

namespace FarmProject
{
    interface IFarm
    {
        Animal[] Animals { get; }
        Sheep[] GetSheeps();
        Horse[] GetHorses();
        void AddAnimal(Animal animal);
    }
}
