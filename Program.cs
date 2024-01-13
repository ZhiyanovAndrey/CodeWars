// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;


string[] art = new string[] { "ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60" };
string[] cd = new String[] { "A", "B", "C", "W" };

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

    System.ArgumentOutOfRangeException : Index and count must refer to a location within the string. (Parameter 'count')
   
    at System.String.Remove(Int32 startIndex, Int32 count)
   at StockList.stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
   at StockListTests.Test5()

     */


    public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
    {
        if (lstOfArt.Length != 0)
        {
        string result = String.Empty;
        Dictionary<string, int> dic = new Dictionary<string, int>();

        // создаем и записываем словарь
        foreach (var pair in lstOfArt)
        {
            string[] str = pair.Split(" ");

            if (str.Length == 2)
            {
                string key = str[0];
                int value = int.Parse(str[1]);
                dic[key] = value; 
            }
        }


        StringBuilder sb = new StringBuilder();
        List<int> list = new List<int>();
        
             int sum = 0;
            foreach (var category in lstOf1stLetter)
            {
                List<string> listKeys = dic.Keys.Where(x => x.StartsWith(category)).ToList(); // выбор ключей из словаря
                List<int> listValues = dic.Where(key => listKeys.Contains(key.Key)).Select(x=>x.Value).ToList(); // выбор значений из списка

                sum = listValues.Sum(x => x);

                sb.Append($" - ({category} : {sum})");
            }

        result = sb.ToString().Remove(0,3); 
        return result;
        }
        return string.Empty;
    }

        //List<int> listValues = dic.Values.Select(v => dic[v]).Where(x => x.StartsWith(category)).ToList();
        //List<int> listValus = listKeys.AddRange(dic.Values); // преобразовать список ключей в список значений
        //List<int> listValues = listKeys.Where(x => x.StartsWith(category)).ToList(); // выбор ключей из словаря
        //}
        //int sum = 0;

        //foreach (var item in dic)
        //{

        //    foreach (var item1 in lstOf1stLetter)
        //    {
        //        if (item.Key.StartsWith(item1)) // суммируем все совпадения и записываем в строку 
        //        {
        //            list.Add(item.Value);
        //            sum = list.Sum(x => x);

        //            sb.Append($" - ({item1} : {sum})");

        //        }



        //    }


        //    Console.WriteLine($"Key:[{item.Key}] Value:[{item.Value}]");
        //}








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