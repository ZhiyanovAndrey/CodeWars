// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Linq;


string[] art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
string[] cd = new String[] { "A", "B" };

Console.WriteLine($"Hello, World! {StockList.stockSummary(art, cd)}");




Console.ReadKey();

public class StockList
{
    /*{"ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60"}
     *  where A, B, C, W are the categories, 20 is the sum of the unique book of category A, 
     *  114 the sum corresponding to "BKWRK" and "BTSQZ", 50 corresponding to "CDXEF" and 0 to category 'W' since there are no code beginning with W.
        If L or M are empty return string is "" (Clojure/Racket/Prolog should return an empty array/list instead).
     * где A, B, C, W — категории, 20 — сумма уникальной книги категории A, 114 — сумма, соответствующая «BKWRK» и «BTSQZ», 50 — «CDXEF» и 0 — категории «W». поскольку нет кода, начинающегося с W.
    
    В результирующих кодах и их значениях тот же порядок, что и в lstOf1stLetter.
     */


    public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
    {
        string result = String.Empty;
        int number;
        Dictionary<string, int> dic = new Dictionary<string, int>();




        foreach (var pair in lstOfArt)
        {
            string[] str = pair.Split(" ");

            if (str.Length == 2)
            {
                string key = str[0];
                int value = int.Parse(str[1]);
                dic[key] = value; // запись в словарь
            }
                    }
        foreach (var item in lstOf1stLetter)
        {
            var a = dic.Keys.Where(x => x.StartsWith(item));
        }
        



        foreach (var item in dic)
        {
   


            Console.WriteLine($"Key:[{item.Key}] Value:[{item.Value}]");
        }
        return result;
    }





    public static string stockSummary1(String[] lstOfArt, String[] lstOf1stLetter)
    {
        string rezult = String.Empty;
        var listInt = new List<int>();
        var listStr = new List<string>();
        foreach (var item in lstOfArt)
        {
            //Console.WriteLine(item);

            int number;
            string[] str = item.Split(" ");



            foreach (var num in str)
            {
                if (int.TryParse(num, out number)) listInt.Add(number);
                else listStr.Add(num);

            }

        }
        foreach (var item in listInt) Console.WriteLine(item);




        //listStr.Select(x => $"{i++}. {x}");
        //.Select(int.Parse).Count(c => c is >= 0 and <= 255) == 4;
        //Select(x => $"{i++}. {x}")
        int[] arr = new int[listInt.Count];
        for (int i = 0; i < listInt.Count; i++)
        {

            // добавить в массив далее просумировать элементы массива
            if (listStr[i].StartsWith(lstOf1stLetter[i]))
            {
                arr[i] = listInt[i];
            }


            rezult = $"{listInt[i]}";
        }
        return rezult;
    }
    //var a = from n in str
    //     where  n    




    //[Test]
    //public void Test1()
    //{
    //    string[] art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
    //    String[] cd = new String[] { "A", "B" };
    //    Assert.AreEqual("(A : 200) - (B : 1140)", StockList.stockSummary(art, cd));
    //}
}