using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Fasz
{
    public static void Main()
    {
        int p = 0;
        int vzx = 0;
        try
        {
            vzx = 100 / p;
            Console.WriteLine("Эта строка не выполнена");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Возникло исключение");
        }
        Console.WriteLine($"Результатом является {vzx}");
    }
}