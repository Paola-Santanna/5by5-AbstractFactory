using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public interface IAnimal
    {
        string AnimalType();

        string Name();

        string AnimalSound();
        string Run(bool isRunning) => isRunning ? "Sim" : "Não";
        string Sleep(bool isSleeping) => isSleeping ? "Sim" : "Não";
        string Eat(bool isEating) => isEating ? "Sim" : "Não";
    }
}
