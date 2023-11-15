using System;
namespace SignedUnsigned{
    class MainApp{
        static void Main(string[] args){

            byte a = 255; //byte value is 1111_1111
            sbyte b = (sbyte)a;

            Console.WriteLine(a);
            Console.WriteLine(b);

            /* 
            2의 보수법
            1. 수 부분을 비트에 채운다
            2. 전체 비트를 반전시킨다.
            3. 반전된 비트에 1을 더한다.
             */
        }
    }
}