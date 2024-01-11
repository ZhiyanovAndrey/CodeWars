using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Temp
{
    public class StringTraining
    {

        #region Методы для проверки IP
        //Assert.AreEqual(true, Kata.IsValidIp("0.0.0.0"));
        //    Assert.AreEqual(true, Kata.IsValidIp("12.255.56.1"));
        //    Assert.AreEqual(true, Kata.IsValidIp("137.255.156.100"));

        //    Assert.AreEqual(false, Kata.IsValidIp(""));
        //    Assert.AreEqual(false, Kata.IsValidIp("abc.def.ghi.jkl"));
        //    //Assert.AreEqual(false, Kata.IsValidIp("123.456.789.0"));
        //    Assert.AreEqual(false, Kata.IsValidIp("12.34.56"));
        //    //Assert.AreEqual(false, Kata.IsValidIp("12.34.56.00"));
        //    //Assert.AreEqual(false, Kata.IsValidIp("12.34.56.7.8"));
        //    //Assert.AreEqual(false, Kata.IsValidIp("12.34.256.78"));
        //    Assert.AreEqual(false, Kata.IsValidIp("1234.34.56"));
        //    Assert.AreEqual(false, Kata.IsValidIp("pr12.34.56.78"));
        //    Assert.AreEqual(false, Kata.IsValidIp("12.34.56.78sf"));
        //    Assert.AreEqual(false, Kata.IsValidIp("12.34.56 .1"));
        //    Assert.AreEqual(false, Kata.IsValidIp("12.34.56.-1"));
        //    //Assert.AreEqual(false, Kata.IsValidIp("123.045.067.089"));
        // IsValidIp own vertion
        public static void IsValidIp(string ipAddres)
        {
            Console.WriteLine(ipAddres);
            int count = 0;
            bool flag = true;
            string[] ip = ipAddres.Split('.');
            foreach (var item in ip)
            {

                if (item == string.Empty) flag = false; // проверка  на пустые ячейки
                if (item.Contains(" ")) flag = false; // проверка  на пустые ячейки
                if (item.StartsWith('0') && item.Length > 1) flag = false; // проверка строки на первый 0
                if (item.Any(c => char.IsLetter(c))) flag = false; // проверка строки на наличие букв
                if (item.Any(c => char.IsSymbol(c))) flag = false; // проверка строки на наличие пробела и символов
                if (item.Any(c => char.IsSymbol(c))) flag = false; // 

                // проверка от 0 до 255
                // ipAddres.Split('.').Select(int.Parse).Count(c => c is >= 0 and <= 255) == 4; // общее количество из 0..255 = 4
                int number;
                bool YES = int.TryParse(item, out number);
                if (YES && (number < 0 || number > 255)) flag = false;

                count++;
            }
            if (count != 4) flag = false;
            if (flag) Console.WriteLine("Верный");
            else Console.WriteLine("Не верный");

        }
        #region МЕТОДЫ ИЗ CODEWARS

        public static bool REGEX1_IsValidIp(string ipAddres) => Regex.IsMatch(ipAddres, @"^(\b(\d|[1-9]\d|1\d{2}|2[0-4]\d|25[0-5])\b(\.|$)){4}$");

        public static bool REGEX_IsValidIp(string ipAddres)
        {
            string octet = @"(([1][0-9][0-9])|([2][5][0-5])|([2][0-4][0-9])|([1-9][0-9])|([0-9]))";
            string pattern = "^" + octet + @"\." + octet + @"\." + octet + @"\." + octet + "$";
            return Regex.IsMatch(ipAddres, pattern);
        }

        public static bool LINQ_IsValidIp(string ipAddress)
        {
            return !ipAddress.Split(".").Select(x => x).AsEnumerable().Any(x => x.StartsWith('0') && x.Length > 1) && Regex.IsMatch(ipAddress, @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        }

        public static bool IsValidIp1(string ipAddress)
        {
            var octets = ipAddress.Split(".");

            if (octets.Count() != 4) return false;

            foreach (var octet in octets)
            {
                if (!int.TryParse(octet, out int numericOctet))
                    return false;

                if (numericOctet < 0 || numericOctet > 255)
                    return false;

                if (!numericOctet.ToString().Equals(octet))
                    return false;
            }

            return true;
        }

        #endregion

        // возврат IP в нормальном виде
        public static string rightIP(string Address)
        {
            string ip = string.Empty;
            string pattern = @"dd?d?.dd?d?.dd?d?.dd?d?";
            System.Text.RegularExpressions.Regex regex =
            new System.Text.RegularExpressions.Regex(pattern);
            System.Text.RegularExpressions.Match match = regex.Match(Address);
            while (match.Success)
            {
                ip = match.Value;
                match = match.NextMatch();
            }
            return ip;
        }
        public static bool IsIPAddress2(string ipAddres)
        {
            //Инициализируем новый экземпляр класса System.Text.RegularExpressions.Regex
            //для указанного регулярного выражения.
            System.Text.RegularExpressions.Regex IpMatch = new System.Text.RegularExpressions.Regex(@"b(?:d{1,3}.){3}d{1,3}b");
            //Выполняем проверку обнаружено ли в указанной входной строке
            //соответствие регулярному выражению, заданному в
            //конструкторе System.Text.RegularExpressions.Regex.
            //если да то возвращаем true, если нет то false
            return IpMatch.IsMatch(ipAddres);
        }

        public static bool IPValidation(string ipAddress)
        {
            bool isIPAddres = false;
            Match match = Regex.Match(ipAddress, @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            if (match.Success)
            {
                isIPAddres = true;
            }
            return isIPAddres;
        }

        // Метод проверки ip-адреса
        internal static bool IsIPAddress(string ipAddress)
        {
            bool isIPAddres = false;

            try
            {
                IPAddress address;
                // Определяем является ли строка ip-адресом
                isIPAddres = IPAddress.TryParse(ipAddress, out address);
            }
            catch (Exception e) { }
            return isIPAddres;
        }
        #endregion


        internal static string BreakCamelCase(string str)
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

            string result = string.Empty;
            int startindex = 0;

            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == str.ToUpper()[i])
                {


                    //result= str.Insert(i, " ");
                    stringBuilder.Append(str, startindex, i - startindex);
                    stringBuilder.Append(' ');
                    startindex = i;

                }


            }

            stringBuilder = stringBuilder.Append(str, startindex, str.Length - startindex);


            return stringBuilder.ToString();
        }
    }


}
