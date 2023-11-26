using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Dictionary<string, double> products = new Dictionary<string, double>
        {
            {"1", 25.0},
            {"2", 55.0},
            {"3", 250.0},
            {"4", 300.0},
            {"5", 80.0},
            {"6", 50.0},
            {"7", 950.0},
            {"8",190.0},
            {"9", 250.0},
            {"10", 600.0},
            {"11", 2.0},
            {"12", 300.0},
            {"13", 50.0},
            {"14", 60.0},
            {"15", 400.0}
        };
        Dictionary<int, int> moneyDenominations = new Dictionary<int, int>
        {
            {1000, 1000},
            {500, 500},
            {100, 100},
            {50,50  },
            {20, 20},
        };

        List<string> selectedProducts = new List<string>();
        double totalPrice = 0.0;

        Console.WriteLine("CONSTRUCTION EQUIPMENT STORE");

        while (true)
        {
            Console.WriteLine(" KANNIKAR HOMEWORK");
            Console.WriteLine("\nรายการสินค้า:");
           
                Console.WriteLine("1.brick-25bath");
                Console.WriteLine("2.bucket-55bath");
                Console.WriteLine("3.cement-250bath");
                Console.WriteLine("4.concrete-300bath");
                Console.WriteLine("5.face shield-80bath");
                Console.WriteLine("6.glove-50bath");
                Console.WriteLine("7.gimelt-950bath");
                Console.WriteLine("8.helmet-190bath");
                Console.WriteLine("9.level-250bath");
                Console.WriteLine("10.ledder-600bath");
                Console.WriteLine("11.nail-2bath");
                Console.WriteLine("12.pile-300bath");
                Console.WriteLine("13.magnet-50bath");
                Console.WriteLine("14.hook-60bath");
                Console.WriteLine("15.concrete post-400bath");


            

            Console.Write("\nเลือกสินค้า (หากต้องการคิดเงิน พิมพ์ 'done'): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
            {
                break;
            }

            if (products.ContainsKey(input))
            {
                selectedProducts.Add(input);
                totalPrice += products[input];
                Console.WriteLine($"{input} ถูกเพิ่มในตะกร้าสินค้า");
            }
            else
            {
                Console.WriteLine("ไม่พบสินค้านี้ กรุณาเลือกใหม่");
            }
        }

        Console.WriteLine($"\nราคารวมทั้งสิ้น: {totalPrice} บาท");

        double payment = 0.0;
        while (payment < totalPrice)
        {
            Console.Write("กรุณาใส่จำนวนเงิน (1000, 500, 100, 50, 20): ");
            int.TryParse(Console.ReadLine(), out int paymentDenomination);

            if (moneyDenominations.ContainsKey(paymentDenomination))
            {
                moneyDenominations[paymentDenomination]++;
                payment += paymentDenomination;
            }
            else
            {
                Console.WriteLine("ไม่รองรับเงินตรานี้ กรุณาใส่เงินใหม่");
            }
        }


        double change = payment - totalPrice;
        Console.WriteLine($"เงินทอน: {change} บาท");
        Console.WriteLine("\nขอบคุณที่ใช้บริการ!");
    }
}