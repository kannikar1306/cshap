using System;

namespace Program
{


    class Movie
    {
        public string movie_name;
        public string round_name;


        public void check_state(string choice)
        {
            Movie mv = new Movie();


            if (choice == "q")
            {
                Console.WriteLine("Exit Program");

            }
            else if (choice == "1" || choice == "2" || choice == "3")
            {

                mv.RoundTimes();

            }

            else
            {

                Console.WriteLine("Please Try Agian Here....");
                mv.Menu();
            }
        }

        public void Menu()
        {
            string choice;

            Console.WriteLine("Welcome to Chanwit Cineplex");
            Console.WriteLine("Please Seleted Movie");
            Console.WriteLine("1.sapakur");
            Console.WriteLine("2.The Marvel");
            Console.WriteLine("3.TeeYod");
            Console.WriteLine("Press q = exit");
            Console.WriteLine("--------------------");

            choice = Console.ReadLine();

            Movie mv = new Movie();
            movie_name = choice;
            mv.check_state(choice);
        }

        public static void Main(string[] args)
        {
            Movie mv = new Movie();


            mv.Menu();
        }


        public void CheckRoundTimes(string round)
        {
            Movie mv = new Movie();


            if (round == "q")
            {
                Console.WriteLine("Exit Program");
            }
            else if (round == "1" || round == "2" || round == "3")
            {
                mv.Finish();
            }
            else if (round == "h")
            {
                Console.WriteLine("go to main");
                mv.Menu();
            }
            else
            {
                Console.WriteLine("Please Try Agian Here....");
                mv.RoundTimes();
            }



        }
        public void Finish()
        {
            Movie mv = new Movie();
            Console.WriteLine("Finish" + movie_name);
        }
        public void RoundTimes()
        {
            Movie mv = new Movie();
            Console.WriteLine("Please Seleted Times");
            Console.WriteLine("1  10.00-12.00");
            Console.WriteLine("2  12.00-14.00");
            Console.WriteLine("3   14.00-16.00");
            Console.WriteLine("Press q=exit h=main");
            Console.WriteLine("------------------------");

            string round;
            round = Console.ReadLine();
            mv.CheckRoundTimes(round);

        }
        public void movie_name(string name)
        {

        }

        public void movie_round(string round)
        {

        }
    }
}










