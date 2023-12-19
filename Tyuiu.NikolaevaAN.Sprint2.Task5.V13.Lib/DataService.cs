using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NikolaevaAN.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string res = "";
            int gg = g + 1;
            int nn = n + 1;


            if (n == 31)
            {
                switch (m)
                {
                    case 1:
                        res= "01.02." + g;
                        break;

                    case 3:
                        res= "01.04." + g;
                        break;

                    case 5:
                        res= "01.06." + g;
                        break;

                    case 7:
                        res= "01.08." + g;
                        break;

                    case 8:
                        res= "01.09." + g;
                        break;

                    case 10:
                        res= "01.11." + g;
                        break;

                    case 12:
                        res= "01.01." + gg;
                        break;

                    default:
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                }
            }
            else if (n == 30)
            {
                switch (m)
                {
                    case 1:
                        res = "31.01." + g;
                        break;

                    case 2:
                        res = "31.02." + g;
                        break;

                    case 3:
                        res = "31.03." + g;
                        break;

                    case 4:
                        res= "01.05." + g;
                        break;

                    case 5:
                        res = "31.05." + g;
                        break;

                    case 6:
                        res= "01.07." + g;
                        break;

                    case 7:
                        res = "31.07." + g;
                        break;

                    case 8:
                        res = "31.08." + g;
                        break;

                    case 9:
                        res= "01.10." + g;
                        break;

                    case 10:
                        res = "31.10." + g;
                        break;

                    case 11:
                        res= "01.12." + g;
                        break;

                    case 12:
                        res = "31.12." + g;
                        break;

                    default:
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                }
            }
            else if (n == 29)
            {
                switch (m)
                {
                    case 1:
                        res = "30.01." + g;
                        break;

                    case 2:
                        res = "01.03." + g;
                        break;

                    case 3:
                        res = "30.03." + g;
                        break;

                    case 4:
                        res = "30.04." + g;
                        break;

                    case 5:
                        res = "30.05." + g;
                        break;

                    case 6:
                        res = "30.06." + g;
                        break;

                    case 7:
                        res = "30.07." + g;
                        break;

                    case 8:
                        res = "30.08." + g;
                        break;

                    case 9:
                        res = "30.09." + g;
                        break;

                    case 10:
                        res = "30.10." + g;
                        break;

                    case 11:
                        res = "30.11." + g;
                        break;

                    case 12:
                        res = "30.12." + g;
                        break;

                    default:
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                }
            }
            else
            {
                if (n < 10 && m < 10)
                {
                    res= "0" + nn + ".0" + m + "." + g;
                }
                else
                {
                    if (n >= 10 && m < 10)
                    {
                        res= nn + ".0" + m + "." + g;
                    }
                    else
                    {
                        if (n >= 10 && m >= 10)
                        {
                            res= nn + "." + m + "." + g;
                        }
                        else
                        {
                            res= $"Месяц должен быть от 1 до 12. Значение {m}";
                        }
                    }
                }
            }
            return res;
        }
    }
}
