using System;
class My
{
    int age = 20;
    string name = "Ashok";
    float per = 85.4f;

    public void ott(out string n,out int a,out float p)
    {
        n = name;
        a = age;
        p = per;
    }
   /* public void ott1( string n1,  int a1,  float p1)
    {
        n1 = name;
        a1 = age;
        p1 = per;
    }*/
}
class Program
{
    static void Main()
    {
        My obj = new My();
        string x;
        int y;
        float z;
       // obj.ott1( x,  y,  z);
        obj.ott(out x,out y,out z);
        //String nam = s+" "+a;
        //Console.WriteLine(nam);
        Console.WriteLine("{0} {1} {2}",x,y,z);
        Console.ReadKey();
    }
}