using System;

namespace _22_Float_Dbl_Dml_PlcHldr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Floats... Doubles... Decimals!");

            float flt_Num = 0.0f;
            double dbl_Num = 0.0d;
            decimal dcml_Num = 0.0m;

            flt_Num = 1 / 3f;
            dbl_Num = 1 / 3d;
            dcml_Num = 1 / 3m;

            //place holder
            Console.WriteLine("Float Number = {0}",flt_Num);
            Console.WriteLine("Double Number = {0}", dbl_Num);
            Console.WriteLine("Decimal Number = {0}", dcml_Num);

        }
    }
}
