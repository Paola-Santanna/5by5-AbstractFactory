using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Menu
    {
        public Menu() { }

        public int MenuOptions()
        {
            Console.WriteLine("Qual animal você quer gerar?");
            Console.WriteLine("1 -> Vaca");
            Console.WriteLine("2 -> Cavalo");
            Console.WriteLine("0 -> Sair e Mostrar os animais");
            Console.Write("Opção Escolhida: ");
            return int.Parse(Console.ReadLine());
        }

        public void OptionChoosed(int resposta)
        {
            int qtdAnimais;
            Cow cow;
            List<Cow> cows = new List<Cow>();
            Horse horse;
            List<Horse> horses = new List<Horse>();

            do
            {
                switch (resposta)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    case 1:
                        Console.WriteLine("Gerando Vaca");
                        Console.WriteLine($"\nInsira a quantidade de vacas: ");
                        qtdAnimais = int.Parse(Console.ReadLine());
                        for (int i = 0; i < qtdAnimais; i++)
                        {
                            cow = new Cow();
                            cows.Add(cow);
                            Console.WriteLine();
                        }

                        Console.WriteLine("\nPressione ENTER para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        resposta = MenuOptions();

                        break;

                    case 2:
                        Console.WriteLine("Gerando Cavalo");
                        Console.WriteLine($"\nInsira a quantidade de cavalos: ");
                        qtdAnimais = int.Parse(Console.ReadLine());
                        for (int i = 0; i < qtdAnimais; i++)
                        {
                            horse = new Horse();
                            horses.Add(horse);
                            Console.WriteLine();
                        }

                        Console.WriteLine("\nPressione ENTER para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        resposta = MenuOptions();
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

            } while (resposta != 0 && resposta != 2);

            Console.Clear();
            Console.WriteLine("Vacas:\n".ToUpper());
            foreach (var animal in cows)
            {
                Console.WriteLine(animal.ToString() + "\n");
            }

            Console.WriteLine("\n\nCavalos:\n".ToUpper());
            foreach (var animal in horses)
            {
                Console.WriteLine(animal.ToString() + "\n");
            }
        }
    }
}