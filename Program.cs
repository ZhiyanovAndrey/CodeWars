

using System;
using System.Text;







Console.WriteLine(RomanConvert.Solution(188)); // CLII

Console.ReadKey();

public class RomanConvert
{
    public static string Solution(int n)
    {
        if (n >= 1 && n <= 3999)
        {

            string result = string.Empty;
            Stack<int> stack = new Stack<int>();
            var sb = new StringBuilder();


            // разбить цифру на порядки 1000 100 10 0
            while (n > 0)
            {
                stack.Push(n % 10);
                n = n / 10;
            }

            //Console.WriteLine($"Извлек {stack.Pop()}");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            //  необходимо сначала записать число тысяч, затем сотен, затем десятков и, наконец, единиц. 
            if (stack.Count == 3) // извлекаем верхний разряд
            {
                switch (stack.Pop())
                {
                    case 1: sb.Append("C"); break;
                    case 2: sb.Append("CC"); break;
                    case 3: sb.Append( "CCC"); break;
                    case 4: sb.Append( "CD"); break;
                    case 5: sb.Append( "D"); break;
                    case 6: sb.Append( "DC"); break;
                    case 7: sb.Append( "DCC"); break;
                    case 8: sb.Append( "DCCC"); break;
                    case 9: sb.Append( "CM"); break;
                }
               }

            if (stack.Count == 2) 
            {
                switch (stack.Pop())
                {
                    //case 1: rezult = "X"; break;
                    case 2: sb.Append( "XX"); break;
                    case 3: sb.Append( "XXX"); break;
                    case 4: sb.Append( "XL"); break;
                    case 5: sb.Append( "L"); break;
                    case 6: sb.Append( "LX"); break;
                    case 7: sb.Append( "LXX"); break;
                    case 8: sb.Append( "LXXX"); break;
                    case 9: sb.Append( "XC"); break;
                }
              
            }

            if (stack.Count == 1 )
            {
                switch (stack.Pop())
                {
                    case 1: sb.Append( "I"); break;
                    case 2: sb.Append( "II"); break;
                    case 3: sb.Append( "III"); break;
                    case 4: sb.Append( "IV"); break;
                    case 5: sb.Append( "V"); break;
                    case 6: sb.Append( "VI"); break;
                    case 7: sb.Append( "VII"); break;
                    case 8: sb.Append( "VIII"); break;
                    case 9: sb.Append( "IX"); break;
                    //case 10: rezult = "X"; break;
                    //case 11: rezult = "XI"; break;
                    //case 12: rezult = "XII"; break;
                    //case 13: rezult = "XII"; break;
                    //case 14: rezult = "XIV"; break;
                    //case 15: rezult = "XV"; break;
                    //case 16: rezult = "IX"; break;
                }
            }
            return sb.ToString();



        }

        return "Please, enter integer between 1 and 3999";
    }
}

//I          1
//V          5
//X          10
//L          50
//C          100
//D          500
//M          1,000


//using System;
//using NUnit.Framework;

//[TestFixture]
//public class RomanConvertTests
//{
//    [TestCase(1, "I")]
//    [TestCase(2, "II")]
//    [TestCase(4, "IV")]
//    [TestCase(500, "D")]
//    [TestCase(1000, "M")]
//    [TestCase(1954, "MCMLIV")]
//    [TestCase(1990, "MCMXC")]
//    [TestCase(2008, "MMVIII")]
//    [TestCase(2014, "MMXIV")]
//    public void Test(int value, string expected)
//    {
//        Assert.AreEqual(expected, RomanConvert.Solution(value));
//    }
//}
