using System;

class Program
{
    static void Main()
    {
        abc obj = new abc();
        string r = obj.calc();
        Console.WriteLine(r);
        Console.ReadKey();
        ;
    }
}
class abc
{

    public string calc(int n1,int n2)
    {
        string sum = " ";
        Convert.ToString(sum);
        Convert.ToInt32(n1 + n2);
        sum = n1 + n2;
        return sum; 
        
        

    }
}
