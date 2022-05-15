using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01_02
{
    class Mathc
    {
        static int cnum = 1;
        public Mathc()
        {
            printline("객체 생성 횟수: ", cnum);
            cnum++;
        }
        ~Mathc()
        {
            printline("객체 종료");
        }

        public void Ifeven(int val)
        {
            if (val % 2 != 0) Console.WriteLine( "홀수값: " + val);
        }
        public void printline(int val)
        {
            Console.WriteLine(val);
        }
        public void printline(string val)
        {
            Console.WriteLine(val);
        }

        public void printline(string str, int val)
        {
            Console.WriteLine(str + val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //java의 클래스와 비슷하다

            Console.WriteLine("객체 생성전");
            Mathc cal01 = new Mathc();
            cal01.printline("객체 생성 완료");

            System.Int32 a = 10, b = 21;
            cal01.Ifeven(a);
            cal01.Ifeven(b);

            //abs와 max
            //abs(int)는 int값을 절댓값으로 반환하는 함수이다.
            //max(int, int)는 둘중 큰수를 리턴한다.
            int val01 = -19;
            cal01.printline("원래값: ", val01);
            val01 = abs(val01);
            cal01.printline("변환값: ", val01);
            int sum = max(val01, 10);
            cal01.printline(sum);

            cal01 = null; //객체의 포인터 제거
        }

        private static int max(int val01, int v)
        {
            return val01 > v ? val01 : v;
        }

        private static int abs(int val01)
        {
            return -val01;
        }
    }
}
