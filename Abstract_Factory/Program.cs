//Abstract Factory

using System.Collections.Generic;

namespace Abstract_Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            int opcao = menu.MenuOptions();
            menu.OptionChoosed(opcao);
        }
    }
}