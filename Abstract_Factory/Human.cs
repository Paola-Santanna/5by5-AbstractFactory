using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class Human : IAnimal
    {
        public string name { get; set; }
        public string animalType { get; set; }
        public string animalSound { get; set; }
        public string run { get; set; }
        public string sleep { get; set; }
        public string eat { get; set; }

        public Human()
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
            string type = "Ser Humano";
            return type;
        }

        public string Name()
        {
            Console.Write($"Insira o nome do {AnimalType()}: ");
            return Console.ReadLine();
        }

        public string AnimalSound()
        {
            Console.Write("Som: ");
            string sound = Console.ReadLine();
            return sound;
        }
        string Run(bool isRunning) => isRunning ? "Sim" : "Não";
        string Sleep(bool isSleeping) => isSleeping ? "Sim" : "Não";
        string Eat(bool isEating) => isEating ? "Sim" : "Não";

        private bool StatusAnimalRunning()
        {
            int resposta;
            bool status;
            Console.WriteLine("O animal está correndo?");
            Console.WriteLine("1 -> Sim \n2 -> Não");
            do
            {
                Console.Write("Resposta: ");
                resposta = int.Parse(Console.ReadLine());

                if (resposta == 2)
                    status = false;
                else
                    status = true;

            } while (resposta != 1 && resposta != 2);

            return status;
        }

        private bool StatusAnimalSleeping()
        {
            int resposta;
            bool status;
            Console.WriteLine("O animal está dormindo?");
            Console.WriteLine("1 -> Sim \n2 -> Não");
            do
            {
                Console.Write("Resposta: ");
                resposta = int.Parse(Console.ReadLine());

                if (resposta == 2)
                    status = false;
                else
                    status = true;

            } while (resposta != 1 && resposta != 2);

            return status;
        }

        private bool StatusAnimalEating()
        {
            int resposta;
            bool status = false;
            Console.WriteLine("O animal está se alimentando?");
            Console.WriteLine("1 -> Sim \n2 -> Não");
            do
            {
                Console.Write("Resposta: ");
                resposta = int.Parse(Console.ReadLine());

                if (resposta == 2)
                    status = false;
                else if (resposta == 1)
                    status = true;

            } while (resposta != 1 && resposta != 2);

            return status;
        }

        public override string? ToString()
        {
            return $"Nome: {this.name} \nTipo de Animal: {this.animalType} \nSom: {this.animalSound} \nEstá correndo: {this.run} \nEstá se alimentando: {this.eat} \nEstá dormindo: {this.sleep}";
        }
    }
}
