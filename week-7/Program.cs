using System;

namespace Program
{


    class Finance
    {

        public static void Main(string[] args)
        {
            int number_product = 0; // จำนวนชิ้น
            string code;
            string product_name;
            string price;

            // input
            // step 1 จำนวนสินค้า
            Console.Write("number of products ? :");
            number_product = Int32.Parse(Console.ReadLine()); // แปลงจาก string to int
            string[][] data_product = new string[number_product][]; //array

            // step 2 เก็บข้อมูลสินค้า
            for (int i = 0; i < number_product; i++)
            {

                Console.WriteLine("code product : ");
                code = Console.ReadLine();

                Console.WriteLine("product name : ");
                product_name = Console.ReadLine();

                Console.WriteLine("price : ");
                price = Console.ReadLine();

                Console.WriteLine("--------------------");

                data_product[i] = new string[] { code, product_name, price, };

            }
            // display
            for (int i = 0; i < number_product; i++)
            {
                Console.WriteLine(data_product[i][0] + data_product[i][1] + data_product[i][2]);
            }


            //display 2

            //step 1
            //header
            Console.WriteLine("Ms.Kannikar minimart");
            Console.WriteLine("---------------------------");
            Console.WriteLine("# title (code)      price  ");
            Console.WriteLine("---------------------------");
            // Variable
            double produc_price = 0.00;
            double vat = 0.00;
            double val = 107;
            double total = 0.00;

            for (int i = 0; i < number_product; i++)
            {
                Console.WriteLine(
                  (i+1) + "   " +
                   data_product[i][1] + "   " +
                   data_product[i][0] + "             " +
                   data_product[i][2] + "   "
                );
                   total += double.Parse (data_product[i][2] );
                
            }   

               vat = Math.Round((total*7)/val, 2);
               total= total;
               produc_price = total-vat;

                //footer
                Console.WriteLine("--------------------------");
                Console.WriteLine("Product Price         "+ produc_price);
                Console.WriteLine("Vat                    "+ vat);
                Console.WriteLine("Total                  "+total);
                Console.WriteLine();
                Console.WriteLine("*_* Thank You *_*         ");




            
        }
    }
}




          