using System;
class My
{
    public int Sum(params int [] arr)
    {
        int ad=0;
        for (int i=0; i<arr.Length; i++)
        {
            ad= ad + arr[i];

        }
        return ad;

    }
    public string Summ(params string[] ar)
    {
        string ad = " ";
        for (int i = 0; i < ar.Length; i++)
        {
            ad = ad +" "+ ar[i];

        }
        return ad;

    }
}

class program
{
    static void Main()
    {
        My ob = new My();
        int x = ob.Sum(10, 20, 30, 40, 50, 60, 70);
        int y = ob.Sum(10, 20, 30);
        int z = ob.Sum(10, 20, 30, 40, 50, 60, 70,1,2,3,4,5,6,7,8,9,1);
        Console.WriteLine("Sum is :{0}",x);
        Console.WriteLine("Sum is :{0}", y);
        Console.WriteLine("Sum is :{0}", z);
        Console.ReadKey();
        string t = ob.Summ("Ashok", "ak", "sdda");
        Console.WriteLine("Summ is :{0}", t);
        Console.ReadKey();
    }
}