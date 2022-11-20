using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        SingletonClass singleton1 = SingletonClass.Instance();


        
        SingletonClass singleton2 = SingletonClass.Instance();


        Console.WriteLine(singleton1.GetHashCode());
        Console.WriteLine(singleton2.GetHashCode());

    }
}