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
            SISROperator();
            AssigningOperator();
            RelationOperator();
            LogicOperator();
            BitwiseOperator();
            ShiftOperator();
            ScoreQuery();
            FunctionSolve();
            Console.ReadLine();
        } // 主方法

        static void UnaryOperator()
        {
            ChangeLine();
            int a = -1;
            int b = 2;
            a=-a;
            b = +b;
            Console.WriteLine("原来的值: a=-1 , b=2");
            Console.WriteLine("修改后的值: a={0}, b={1}", a, b);
        }// 练习使用单目运算符(+,-即正负号)
        
        static void BinaryOperator()
        {
            ChangeLine();
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
            Console.WriteLine("太简单了，不显示了");
        } // 练习双目运算符操作(+,-,*,/,%;分别是加减乘除和取余数)

        static void TernaryOperator()
        {
            ChangeLine();
            Console.WriteLine("请输入0或1: ");
            string a = Console.ReadLine();

            // 下面是使用三目运算符的操作
            string b = a == "0" ? "对了!" : "不对!";
            Console.WriteLine(b);

            // 下面是使用if...else语句的操作
            /*if (a=="0")
            {
                Console.WriteLine("对了!!");
            }
            else
            {
                Console.WriteLine("不对!!!");
            }*/
        } // 练习使用三目运算符"?:",l可以简化if...else操作

        static void SISROperator()
        {
            ChangeLine();
            int a, b, c, d, e;
            a = b = 1; // 可以连等但是不建议这样操作
            c = 2;
            d = 3;
            e = 5;
            Console.WriteLine("Initial Value: \na:{0}  b:{1}  c:{2}  d:{3}", a, b, c, d);
            a=a++; // 自增且先自增再进行其他运算
            b=b--; // 自减且先自减再进行其他运算
            c=--c; // 自增但先进行其他运算再自增
            d=++d; // 自减且先进行其他运算再自减
            Console.WriteLine( "Value after operation: \na++:{0}  b--:{1}  --c:{2}  ++d:{3}\n", a, b, c, d);
            a = 1;
            e = ++a; //a先加1再赋值给e a=a+1 e=a
            Console.WriteLine("++expr: {0}", e);
            a = 1;
            e = a++; // a先赋值给e再加1 e=a a=a+1
            Console.WriteLine("expr++: {0}", e);
        } // 练习使用自增自减运算符

        static void AssigningOperator()
        {
            ChangeLine();
            int a, b, c, d;
            a = b = 1; // 基本的赋值运算符, 将等号右面的值赋值给等号左面的值
            c = d = 3;
            Console.WriteLine("初始值: a={0} , b={1} , c={2} , d={3}", a, b, c, d);
            b = a + 1;
            c += b; // 符合复制运算符加赋值, 运算规则为c=c+b
            d *= c; // 复合赋值运算符乘赋值, 运算规则为d=d*c
            Console.WriteLine("操作后值: a={0} , \n赋值: b={1} , \n加赋值: c={2} , \n乘赋值: d={3}", a, b, c, d);
        } // 练习使用赋值运算符和复合赋值运算符

        static void RelationOperator()
        {
            ChangeLine();
            int a, b, c, d;
            a = 1;
            b = 2;
            c = 3;
            d = 1;
            Console.WriteLine("初始值: a=1, b=2, c=3, d=4");
            bool def1, def2, def3, def4, def5, def6;
            def1 = a == b;
            def2 = a < c;
            def3 = a > b;
            def4 = b != c;
            def5 = c <= d;
            def6 = a >= d;
            Console.WriteLine("a = b (==)?  {0}", def1);
            Console.WriteLine("a < c (<)?  {0}", def2);
            Console.WriteLine("a > b (>)?  {0}", def3);
            Console.WriteLine("b ≠ c (!=)?  {0}", def4);
            Console.WriteLine("c ≤ d (<=)?  {0}", def5);
            Console.WriteLine("a ≥ d (>=)?  {0}", def6);
        } // 练习使用关系运算符比如等于= 小于< 大于> 不等于!= 小于等于<= 大于等于>= 并返回布尔值

        static void LogicOperator()
        {
            ChangeLine();
            Console.WriteLine(" T&T: {0}" +
                "\n T&F: {1}" +
                "\n F&F: {2}" +
                "\n T|T: {3}" +
                "\n T|F: {4}" +
                "\n F|F: {5}" +
                "\n !T: {6}" +
                "\n !F: {7}", 
                true & true, 
                true & false, 
                false & false, 
                true | true, 
                true | false, 
                false | false, 
                !true, 
                !false);
        } // 练习使用逻辑运算符 与(&, &&) 或(|, ||) 非(!),通过比较两个布尔值返回布尔值 其中&&和||被称为短路运算符，即如果a&&b或a||b中a为F时直接判断为F

        static void BitwiseOperator()
        {
            ChangeLine();
            int a, b;
            a = 10;
            b = 5;
            Console.WriteLine("初始值: a=10, b=5");
            Console.WriteLine("a & b(a位与b) 的结果为: " + (a & b));
            Console.WriteLine("a | b(a位或b) 的结果为: " + (a | b));
            Console.WriteLine("a ^ b(a位异或b) 的结果为: " + (a ^ b));
            Console.WriteLine("~ b(b取反) 的结果为: " + (~b));
        } // 进行"位与" "位或" "位异或" "取反"运算

        static void ShiftOperator()
        {
            ChangeLine();
            int a = 33,
                b = 16;
            Console.WriteLine("a的初始值: " + a + "二进制: " + Convert.ToString(a, 2));
            Console.WriteLine("b的初始值: " + b + "二进制: " + Convert.ToString(b, 2));
            a = a << 2;
            b = b >> 2;
            Console.WriteLine("\na左移2位之后的值: " + a + "  二进制: " + Convert.ToString(a, 2));
            Console.WriteLine("b右移2位之后的值: " + b + "  二进制: " + Convert.ToString(b, 2));

        } // 练习使用左移位运算符<<和右移位运算符>>

        static void ScoreQuery()
        {
            ChangeLine();
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
        } // 练习1, 主要练习赋值运算符和加减乘除

        static void FunctionSolve()
        {
            ChangeLine();
            Console.WriteLine("解方程练习！\n\n解下列方程: \n  21.8x+2y=28\n  7x+8y=62");
            double a = 21.8,
                   b = 2,
                   c = 7,
                   d = 8,
                   e = 28,
                   f = 62,
                   m, x, y;

            m = (a * d - b * c);
            x = (e * d - b * f) / m;
            y = (a * f - e * c) / m;

            Console.WriteLine("\n方程的解是: \nx=  {0}\ny=  {1}",x,y);
        } // 练习2 解方程

        static void ChangeLine()
        {
            Console.Write("\n----------按回车进行下一项操作!-----------\n");
            Console.ReadLine();
        } // 自定义方法 在不同方法之间加上横线
    }
}
