using System;

class Program
{
    static void Main()
    {
        xyz ob = new xyz();
        String res = ob.evenodd(10);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
class xyz
{
    public string evenodd(int a)
    {
        //return a % 2 == 0 ? "Even" : "odd";


        //if (a % 2 == 0)
        //    return "even";
        //else
        //    return "odd";



        String res = "";
        if (a % 2 == 0)
            res = "even";
        else
            res = "odd";
                return res;


    }
}
