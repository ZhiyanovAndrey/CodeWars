

using System;







Console.WriteLine(RomanConvert.Solution(152)); // CLII

Console.ReadKey();

public class RomanConvert
{
    public static string Solution(int n)
    {
        if (n >= 1 && n <= 3999)
        {

            string rezult = string.Empty;

            // разбить цифру на порядки 100 50 10 5
            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                stack.Push(n % 10);
                n = n / 10;
            }

            Console.WriteLine($"Извлек {stack.Pop()}");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            //  необходимо сначала записать число тысяч, затем сотен, затем десятков и, наконец, единиц. 
            if (stack.Count == 3) // извлекаем верхний разряд
            {
                switch (stack.Pop())
                {
                    case 1: rezult = "C"; break;
                    case 2: rezult = "CC"; break;
                    case 3: rezult = "CCC"; break;
                    case 4: rezult = "CD"; break;
                    case 5: rezult = "D"; break;
                    case 6: rezult = "DC"; break;
                    case 7: rezult = "DCC"; break;
                    case 8: rezult = "DCCC"; break;
                    case 9: rezult = "CM"; break;
                }
            return rezult;
            }

            if (stack.Count == 2) 
            {
                switch (stack.Pop())
                {
                    //case 1: rezult = "X"; break;
                    case 2: rezult = "XX"; break;
                    case 3: rezult = "XXX"; break;
                    case 4: rezult = "XL"; break;
                    case 5: rezult = "L"; break;
                    case 6: rezult = "LX"; break;
                    case 7: rezult = "LXX"; break;
                    case 8: rezult = "LXXX"; break;
                    case 9: rezult = "XC"; break;
                }
                return rezult;
            }

            if (stack.Count == 1 )
            {
                switch (stack.Pop())
                {
                    case 1: rezult = "I"; break;
                    case 2: rezult = "II"; break;
                    case 3: rezult = "III"; break;
                    case 4: rezult = "IV"; break;
                    case 5: rezult = "V"; break;
                    case 6: rezult = "VI"; break;
                    case 7: rezult = "VII"; break;
                    case 8: rezult = "VIII"; break;
                    case 9: rezult = "IX"; break;
                    //case 10: rezult = "X"; break;
                    //case 11: rezult = "XI"; break;
                    //case 12: rezult = "XII"; break;
                    //case 13: rezult = "XII"; break;
                    //case 14: rezult = "XIV"; break;
                    //case 15: rezult = "XV"; break;
                    //case 16: rezult = "IX"; break;
                }
            }
            return rezult;



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
