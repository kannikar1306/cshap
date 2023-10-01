using System;

namespace Program
{


    class Finance
    {

        public static void Main(string[] args)
        {


            int number_product = 0; // จำนวนชิ้น
            string product_name;
            string price;


            // input
            // step 1 จำนวนสินค้า
            Console.Write("How many product  ? :");
            number_product = Int32.Parse(Console.ReadLine()); // แปลงจาก string to int
            string[][] data_product = new string[number_product][]; //array


            // step 2 เก็บข้อมูลสินค้า
            for (int i = 0; i < number_product; i++)
            {

                Console.WriteLine();
                Console.WriteLine("input product name :? ");
                product_name = Console.ReadLine();

                Console.WriteLine("input product price :? ");
                price = Console.ReadLine();

                Console.WriteLine("--------------------");

                data_product[i] = new string[] { product_name, price, };
            }


            double get = 0;
            double tax = 0;
            double discount = 0;
            double val = 0;

            Console.WriteLine();
            Console.WriteLine("get the many ?: ");
            get = Int32.Parse(Console.ReadLine());


            Console.WriteLine("tex deducted ?: ");
            tax = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Discount(bath): ");
            discount = Int32.Parse(Console.ReadLine());

            val = (100 + tax);

            //step 1
            //header
            Console.WriteLine("Welcomp to Computer Service");
            Console.WriteLine("#     Product      price  ");
            Console.WriteLine("---------------------------");

            // Variable
            double produc_price = 0.00;
            double vat = 0.00;
            double total = 0.00;
            double total1 =0.00;
            double Change =0.00;


            for (int i = 0; i < number_product; i++)
            {
                Console.WriteLine(
                  (i + 1) + "   " +
                   data_product[i][0] + "   " +
                   data_product[i][1] + "             "

                );
                total += double.Parse(data_product[i][1]);

            }

            vat = Math.Round((total * tax) / val, 2);
            total1 = (total-discount);
            produc_price = total - vat;
            Change = (get-total1);

            //footer
            Console.WriteLine("--------------------------");
            Console.WriteLine("Product Price         " + produc_price);
            Console.WriteLine("Tax                    " + vat);
            Console.WriteLine("Discount                 " +discount);
            Console.WriteLine("Total                  " + total1);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Get the mony              "+get);
            Console.WriteLine("Change                    "+Change);
            Console.WriteLine("*_* Thank You *_*         "); 





        }
    }
}

