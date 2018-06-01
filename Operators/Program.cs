using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            UnaryOperator();
            BinaryOperator();
            TernaryOperator();
            ScoreQuery();
            FunctionSolve();
            Console.ReadLine();
        }
        static void UnaryOperator()
        {
            int a = -1;
            int b = 2;
            a=-a;
            b = +b;
            Console.WriteLine("原来的值: a=-1 , b=2");
            Console.WriteLine("修改后的值: a={0}, b={1}", a, b);
        }// 练习使用单目运算符(+,-即正负号)
        
        static void BinaryOperator()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            int f, g, h, i;
            f = a + b + c;
            g = a * b * c - d;
            h = d * e - a + c;
            i = e % 2;
        } // 练习双目运算符操作(+,-,*,/,%;分别是加减乘除和取余数)

        static void TernaryOperator()
        {

        }

        static void ScoreQuery()
        {
            string a, b, c;
            a = "C: ";
            b = "C#: ";
            c = "SQL: ";
            int d, e, f;
            d = 89;
            e = 90;
            f = 66;
            int average=(d+e+f)/3;
            Console.WriteLine("欢迎使用成绩查询系统！！！\n学生姓名: 张三\n\n成绩: ");
            Console.WriteLine("\n{0}\n{1}\n{2}", a + d, b + e, c + f);
            Console.WriteLine("\n平均分: {0}", average);
        }

        static void FunctionSolve()
        {
            Console.WriteLine("解方程练习！\n\n解下列方程: \n  21.8x+2y=28\n  7x+8y=62");
            double a = 21.8;
            double b = 2;
            double c = 7;
            double d = 8;
            double e = 28;
            double f = 62;
            double m, x, y;

            m = (a * d - b * c);
            x = (e * d - b * f) / m;
            y = (a * f - e * c) / m;

            Console.WriteLine("\n方程的解是: \nx=  {0}\ny=  {1}",x,y);
        }
    }
}
