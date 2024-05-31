using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class Horse : IAnimal
    {
        string name { get; set; }
        string animalType { get; set; }
        string animalSound { get; set; }
        string run { get; set; }
        string sleep { get; set; }
        string eat { get; set; }
        public Horse() 
        {
            this.name = Name();
            this.animalType = AnimalType();
            this.animalSound = AnimalSound();
            this.run = Run(StatusAnimalRunning());
            this.sleep = Sleep(StatusAnimalSleeping());
            this.eat = Eat(StatusAnimalEating());
        }

        public string AnimalType()
        {
            string type = "Cavalo";
            return type;
        }
        public string Name()
        {
            Console.Write($"Insira o nome do {AnimalType()}: ");
            return Console.ReadLine();
        }
        
        public string AnimalSound()
        {
            string sound = "hajashklajhfjkjhfd";
            return sound;
        }
        string Run(bool isRunning) => isRunning ? "Sim" : "Não";
        string Sleep(bool isSleeping) => isSleeping ? "Sim" : "Não";
        string Eat(bool isEating) => isEating ? "Sim" : "Não";

        private bool StatusAnimalRunning()
        {
            int resposta;

            Console.WriteLine($"A {this.animalType} está correndo? ");
            Console.WriteLine("1 -> Sim \n2 -> Não");
            resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
                return true;
            else if (resposta == 2)
                return false;
            else
            {
                Console.WriteLine("\nOpção Inválida!\n");
                return false;
            }
        }

        private bool StatusAnimalSleeping()
        {
            int resposta;
            bool RunReturn = StatusAnimalRunning();

            if (RunReturn == false)
            {
                Console.WriteLine($"O {this.animalType} está dormindo?");
                Console.WriteLine("1 -> Sim \n2 -> Não");
                resposta = int.Parse(Console.ReadLine());
                if (resposta == 1)
                    return true;
                else if (resposta == 2)
                    return false;
                else
                {
                    Console.WriteLine("\nOpção Inválida!\n");
                    return false;
                }
            }
            else
                return false;
        }

        private bool StatusAnimalEating()
        {
            bool SleepReturn = StatusAnimalSleeping();
            bool RunReturn = StatusAnimalRunning();

            if (SleepReturn == false && RunReturn == false)
                return true;
            else
                return false;
        }
        public override string? ToString()
        {
            return $"Nome: {this.name} \nTipo de Animal: {this.animalType} \nSom: {this.animalSound} \nEstá correndo: {this.run} \nEstá se alimentando: {this.eat} \nEstá dormindo: {this.sleep}";
        }
    }
}
