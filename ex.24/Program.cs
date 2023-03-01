using System;

class Program { 
    

    static void Main(string[] args)
    {

        string a = Console.ReadLine();
        string b = Console.ReadLine();
        if (a == b) 
        {
            Console.WriteLine("Равны");
        }
        else if (a.Length > b.Length)
        {
            Console.WriteLine(a + " больше " + b);
        }
        else
        {
            Console.WriteLine("Слова не равны. Идёт проверка:");
            for(int i = 0; i<a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    Console.WriteLine("+");
                }
                
                else
                {
                    Console.WriteLine("Ошибка! " + a[i] + " не равен " + b[i] + ". Позиция № "+ i);
                }
            }
        }
    }
}