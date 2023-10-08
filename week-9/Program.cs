using System;

namespace Program
{

    class CoffeeLuxer
    {

    }
    class CoffeePremuim
    {
        public int val;
        public static void Main(string[] args)
        {
            int val;
            CoffeePremuim CP = new CoffeePremuim();
            CP.selected_band();
            val = Int32.Parse(Console.ReadLine());
            CP.Line();
            CP.routes(val);
        }
        public void selected_band()
        {



            Console.WriteLine("Please selected Band Coffee");
            Console.WriteLine("1:  Amezon");
            Console.WriteLine("2:  Inthanin");
            Console.WriteLine("3:  Punthai");
            Console.WriteLine("4:  D-Oro");

            Console.Write("selected :");

        }


        public void routes(int val)
        {
            CoffeePremuim CP = new CoffeePremuim();


            switch (val)
            {
                case 1:
                    {
                        CP.Amezon();
                        break;
                    }
                case 2:
                    {
                        CP.Inthanin();
                        break;
                    }
                case 3:
                    {
                        CP.Punthai();
                        break;
                    }
                case 4:
                    {
                        CP.Dora();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }





        public void Line()
        {
            Console.WriteLine("-----------------");
        }
        public void Amezon()
        {
            Console.WriteLine("Amezon cafe");
            Console.WriteLine("Manu");
            Console.WriteLine("Black Cofee");
            Console.WriteLine("Capu chino");
            Console.WriteLine("Late");
        }
        public void Inthanin()
        {
            Console.WriteLine("Inthanin cafe");
            Console.WriteLine("Manu");
            Console.WriteLine("Black Mix Orange");
            Console.WriteLine("Late");
            Console.WriteLine("Capu chino");
        }
        public void Punthai()
        {
            Console.WriteLine("Panthai cafe");
            Console.WriteLine("Manu");
            Console.WriteLine("Chocolate");
            Console.WriteLine("Americano");
        }

        public void Dora()
        {
            Console.WriteLine("Dora cafe");
            Console.WriteLine("Manu");
            Console.WriteLine("Milk Chocolate");
            Console.WriteLine("Capu chino");
            Console.WriteLine("Capu chino");
        }

    }



}






