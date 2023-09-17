using System;
namespace Program
{
class Grade{

public string grade_is;    

public Grade(int score){

    int point;
 // check grade
 point=score;
    //ตัดเกรด
 if(point >= 80){
 //A
 grade_is = "A";
 }else if(point >=75){
 grade_is = "B+";
 }else if(point >=70){
 grade_is= "B";
 }else if(point >=65){
 grade_is = "C+";    
 }else if(point >=60){
 grade_is = "C";   
 }else if(point >=55){
 grade_is = "D+";    
 }else if(point >=50){
 grade_is= "D";    
 }else if(point ==0){
 grade_is = "I";     
 }else{
 grade_is = "E"; 
}
}

//function หลัก object / function
static void Main(string[]args){
    int loop = 0; // วน รับข้อมูล 3 รอบ

 Console.Write("How many reccord input :"); //Display
 loop = Int32.Parse(Console.ReadLine());    //input data int loop


 string student_id,perfix,fname,lname,score;

 string[][] data = new string[loop][];
 string grade;
 int point;



 // วน loop เพื่อเก็บข้อมูล
 for(int i=0; i < loop; i++){
 Console.Write(" input student id :");
 student_id = Console.ReadLine();

 Console.Write(" input perfix :");
 perfix = Console.ReadLine();

 Console.Write(" input frist_name id :");
 fname = Console.ReadLine();

 Console.Write(" last_name id :");
 lname = Console.ReadLine();

 Console.Write(" input score :");
 score = Console.ReadLine();



 Console.WriteLine("-----------------");
 // save to data
 data[i] = new string[] {student_id, perfix, fname, lname, score};


}


for(int i=0; i < loop; i++)
{
 Grade Score = new Grade(Int32.Parse(data[i][4]));
 Console.WriteLine(Score.grade_is);  
}






}

}


}