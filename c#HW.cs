using System;


namespace GuessTheGame
{
    public class DisplayResult
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("--------Shree Ambika Secondary----------\n" +
                "-----------Pokhara 25,Hemja---------");
            Console.WriteLine("Enter your name");
            string? name = Console.ReadLine();
            Console.WriteLine("MARKSHEET OF" + " " + name);
            string[] arr = { "Maths", "English", "Physics", "Social", "Chemistry", "Virtual Programming", "Contemporary Technology", "Computer Network", "Software Engineering Project" };
            double obtainedMarks = 0;

            int[] marks = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter your marks in" + " " + arr[i]);
                marks[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arr[i] + " :" + marks[i]);
                obtainedMarks = obtainedMarks + marks[i];

            }
            Console.WriteLine("Obtained marks is" + ": " + obtainedMarks);
            double total = 900;
            double percentage = (obtainedMarks / total) * 100;
            Console.WriteLine("Total Marks" + ": " + total);

            Console.WriteLine("Your total Percentage is:" + percentage + "%");
            Console.WriteLine("-------------------------------------------------Shree Ambika Secondary School-------------------------------------");
            Console.WriteLine("--------------------------------------------------Marksheet Of" + " " + name + "-------------------------------------------");
            Console.WriteLine("--------Marksheet------");
            Console.WriteLine("Name:" + " " + name);
            for(int i=0; i<arr.Length;i++){
                Console.WriteLine(arr[i]+" :"+marks[i]);
            }
            Console.Write("");
            Console.WriteLine("Total Percentage:"+" "+percentage+"%");
            if(percentage<60 && percentage>50){
                Console.WriteLine("---------------------------Average.Need To improve a lot.-------------------------\n");
            }else if(percentage<=70 && percentage>60){
                Console.WriteLine("-----------------------------Good.Do more Hardwork.--------------------------------\n");
            }else if(percentage<=90 && percentage>80){
                Console.WriteLine("-----------------------------Very Good.Keep it up.---------------------------------\n");
            }else if(percentage<=80 && percentage>70){
                Console.WriteLine("-----------------------------Satisfactory.Improve More.-----------------------------\n");
            }else if(percentage>=90){
                Console.WriteLine("-------------------------------Excellent.Keep it up.------------------------------- \n");
            }else{
                Console.WriteLine("-------------------------------Fail.Focus on your study rather than anything else.--------------------\n");
            }







        }
    }
}