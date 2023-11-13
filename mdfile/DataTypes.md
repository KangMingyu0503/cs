# DataTypes for Cs
```c#
using System;
using System.Linq.Expressions;
namespace IntegralTypes{
    class MainApp{
        static void Main(string[] args){
            sbyte a = -10; // 부호 없는 정수
            byte b = 40; // singed byte 정수
            Console.WriteLine($"a={a},b={b}");

            short c = -30000; // 정수
            ushort d = 60000; // unsigned short 부호없는 정수
            Console.WriteLine($"c={c},d={d}");

            int e = -1000_0000; // 정수
            uint f = 3_0000_0000; // unsigned uint 부호없는 정수
            Console.WriteLine($"e={e},f={f}");

            long g = -5000_0000_0000; // 정수 64bit
            ulong h = 200_0000_0000_0000_0000; // unsigned ulong 부호없는 정수 64bit
            Console.WriteLine($"g={g},h={h}");
        }
    }
}
```