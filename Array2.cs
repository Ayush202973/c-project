using System;


namespace GuessTheGame
{
    public class Array2
    {
       public void ArrayProgram()
        {
            String[] names = { "Ayush", "Aashish", "Puskar", "Bishnu", "Apshan" };
            Console.WriteLine("Fifth Element is:"+names[4]);
            for (int i = 0; i < names.Length; i++)
            { Console.WriteLine(names[i]); }
        }
    }
}
