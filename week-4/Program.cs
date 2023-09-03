// PLus บวก
/*
int plus1 = 2;
int plus2 = 3;
int total;

total = plus1 + plus2;

Console.Write(total);
*/

// Minus ลบ
/*
int minus1 = 4;
int minus2 = 2;
int total = minus1 - minus2;

Console.Write(total);
*/

// Modulus 
/*
int Modul1 = 5;
int Modul2 = 3;
int total = Modul1 % Modul2;

Console.Write(total);
*/

/*
int plus = 0;
int total = 0;


plus++;
total = plus;



Console.Write(total);
*/
/*
int minus_down = 10;
int total = 0;

minus_down--;
total = minus_down;

Console.Write(total);

*/
// Math ฟังชั่นทางคณิตศาสตร์














/*


int min = Math.Min(4,4);
Console.WriteLine(min);


int max = Math.Max(4,10);
Console.Write(max);

*/
/*
string hello = "Hello";
string world = "World";

Console.WriteLine(hello+"   "+world);

*/
/*
bool  val = false;
bool  check = false;

Console.WriteLine(val==check);

*/


//if else
/*
int input ;

Console.Write("input value :");
input = Int32.Parse(Console.ReadLine());

if(input == 2){
    Console.WriteLine("true success");
}
else if (input ==3){
    Console.WriteLine("Yes this is 3 value success");
}
else if (input ==4){
     Console.WriteLine("Yes this is 4 value success");
}
else if (input ==5){
   Console.WriteLine("Yes this is 5 value success"); 
}
else if (input == 6 || input == 12){
    Console.WriteLine("Yes this is 6 or 12 value success"); 
}
else{
  Console.WriteLine("False Value Check");
}
*/



/*

int day = 8;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
    
    default:
    Console.WriteLine("Not Fonnd");
    break;
}

*/
// Outputs "Thursday" (day 4)











/*
string[] cars = {"Volvo", "BMW", "Ford", "Mazda","Honda","Toyota","Misubishi","Nissan"};

string[] color = {"Red", "Green", "Blue", "Black","White","Cyan","Yellow","Dark"};


int i = 0;
int seq = 0;
while (i < 8) 
{
 
  seq++;
  Console.WriteLine(seq+"."+cars[i]+"color is "+ color[i]);
  i++;
}

*/


string[] perfiux = {"Ms.", "Ms.", "Mr.", "Mr.","Mr.","Mr.","Mr.","Mr."};
string[] fname = {"Kannikar", "Thanaporn", "Tanakorn", "Watcharapong","Kittiphong","Intat","Pongsakon","Kitisak"};
string[] lname = {"Patposri", "Hongngam", "Suphaphut", "Maneengam","Chaimon","Kanalaksombat","Kongnoi","Srisuk"};
string[] ID = {"663245006", "664245025", "663245002", "663245004","663245001","663245005","663245003","663245009"};


int i = 0;
int seq = 1;
while (i < 8) 
{
 
  //seq++;
  Console.WriteLine((seq++) +". "+perfiux[i]+fname[i]+" "+ lname[i] +" "+"ID. "+ID[i]);
  i++;
}
