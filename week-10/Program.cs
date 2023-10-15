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
            int manu;


            switch (val)
            {
                case 1:
                    {
                        CP.Amezon();
                        manu = Int32.Parse(Console.ReadLine());
                        CP.amezon_manu(manu);
                        break;
                    }
                case 2:
                    {
                        CP.Inthanin();
                        manu = Int32.Parse(Console.ReadLine());
                        CP.Inthanin_manu(manu);
                        break;
                    }
                case 3:
                    {
                        CP.Punthai();
                        manu = Int32.Parse(Console.ReadLine());
                        CP.Punthai_manu(manu);
                        break;
                    }
                case 4:
                    {
                        CP.Dora();
                        manu = Int32.Parse(Console.ReadLine());
                        CP.Dora_manu(manu);
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
            int manu;
            Console.WriteLine("Please Select Manu ?");
            Console.WriteLine("1.Black Cofee");
            Console.WriteLine("2.Capu chino");
            Console.WriteLine("3.Late");


        }
        public void amezon_manu(int manu)
        {

            switch (manu)
            {
                case 1:
                    {
                        Console.WriteLine("Amazon-Black Coffee 60 Bath");
                        break;

                    }
                case 2:
                    {
                        Console.WriteLine("Amazon-Capu chino 55 Bath");
                        break;

                    }
                case 3:
                    {
                        Console.WriteLine("Amazon-Late 50 Bath");
                        break;

                    }


            }


        }
        public void Inthanin()
        {
            int manu;
            Console.WriteLine("Please Select Manu ?");
            Console.WriteLine("1.Black Mix Orange");
            Console.WriteLine("2.Late");
            Console.WriteLine("3.Capu chino");
        }
        public void Inthanin_manu(int manu)
        {
            switch (manu)
            {
                case 1:
                    {
                        Console.WriteLine("Inthanin-Black Mix Orange 60 Bath");
                        break;

                    }
                case 2:
                    {
                        Console.WriteLine("Inthanin-Late 40 Bath");
                        break;

                    }
                case 3:
                    {
                        Console.WriteLine("Inthanin-Capu chino 55 Bath");
                        break;

                    }
            }
        }    
        public void Punthai()
            {
                int manu;
                Console.WriteLine("Please Select Manu ?");
                Console.WriteLine("1.Chocolate");
                Console.WriteLine("2.Americano");
            }
        public void Punthai_manu(int manu)
            {
                switch (manu)
                {
                    case 1:
                        {
                            Console.WriteLine(" Punthai-Chocolate 50 Bath");
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine(" Americano 40 Bath");
                            break;

                        }
                }
            }

            public void Dora()
            {
                        {
                            int manu;
                            Console.WriteLine("Please Select Manu ?");
                            Console.WriteLine("1.Milk Chocolate");
                            Console.WriteLine("2.Capu chino");

                        }
                }
            
            public void Dora_manu(int manu)
                {
                    switch (manu)
                    {
                        case 1:
                            {
                                Console.WriteLine("Dora-Mix Chocolate 60 Bath");
                                break;

                            }
                        case 2:
                            {
                                Console.WriteLine("Dora-Capu chino 40 Bath");
                                break;

                            }


                    }



                }
            }
        }




