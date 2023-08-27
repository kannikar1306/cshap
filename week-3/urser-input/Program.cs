/*
string fname = "";
double height = 0;
double weight = 0.0d;
double BMI = 0.0d;

Console.Write("input first name : ");    //display ชื่อ
fname = Console.ReadLine();              //input keyboard

Console.Write("input height : ");         //display ความสูง
height = double.Parse(Console.ReadLine());  //input keyboard and convert

Console.Write("input weight : ");         //display นน
weight = double.Parse(Console.ReadLine());  //input keyboard and convert

BMI = height/weight;

BMI = Math.Pow(BMI, 2);

Console.WriteLine("BMI is : "+BMI);
*/


string prefix ="";
string fname = "";
string lname = "";
int ID      =0;
double height = 0;
double weight = 0.0d;
double BMI = 0.0d;

Console.WriteLine("Sawadee Welcome to program to calculate body mass index");

Console.Write("input perfix : ");    //display คำนำหน้า
prefix = Console.ReadLine();        //input keyboard

Console.Write("input first name : ");    //display ชื่อ
fname = Console.ReadLine();              //input keyboard

Console.Write("input last name  : ");    //display สกุล
lname = Console.ReadLine();              //input keyboard

Console.Write("input student ID  : ");    //display รหัสนักศึกษา
ID = Int32.Parse(Console.ReadLine());   //input keyboard


Console.Write("input height : ");         //display ความสูง
height = double.Parse(Console.ReadLine());  //input keyboard and convert

Console.Write("input weight : ");         //display นน
weight = double.Parse(Console.ReadLine());  //input keyboard and convert

BMI = height/weight;

BMI = Math.Pow(BMI, 2);

Console.WriteLine("********************");
Console.WriteLine("student ID : "+ID);
Console.WriteLine("Fullname  : " + prefix + " " + fname + " " + lname);
Console.WriteLine("height  : "+height);
Console.WriteLine("weight  : "+weight);
Console.WriteLine("BMI is : "+BMI);
Console.WriteLine("********************");