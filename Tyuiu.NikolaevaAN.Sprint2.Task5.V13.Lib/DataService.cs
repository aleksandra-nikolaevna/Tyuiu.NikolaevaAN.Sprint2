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
            string res;
            int n1 = n, m1 = m, g1 = g;
            switch (m)
            {
                case 1:
                    if (n != 31)
                    {
                        n1++;
                    }
                    else
                    {
                        n1 = 1; m1++;
                    }
                    break;
                case 2:
                    if (n != 29)
                    {
                        n1++;
                    }
                    else
                    {
                        n1 = 1; m1++;
                    }
                    break;
                case 3:
                    if (n != 31)
                    {
                        n1++;
                    }
                    else
                    {
                        n1 = 1; m1++;
                    }
                    break;
                case 4:
                    if (n != 30)
                    {
                        n1++;
                    }
                    else
                    {
                        n1 = 1; m1++;
                    }
                    break;
                case 5:
                    if (n != 31)
                    {
                        n1++;
                    }
                    else
                    {
                        n1 = 1; m1++;
                    }
                    break;
                case 6:
                    if (n != 30)
                    {
                        n1++;
                    }
                    else
                    {
                        n1 = 1; m1++;
                    }
                    break;
                case 7:
                    if (n != 31)
                    {
                        n1++;
                    }
                    else
                    {
                        n1 = 1; m1++;
                    }
                    break;
                case 8:
                    if (n != 31)
                    {
                        n1++;
                    }
                    else
                    {
                        n1 = 1; m1++;
                    }
                    break;
                case 9:
                    if (n != 30)
                    {
                        n1++;
                    }
                    else
                    {
                        n1 = 1; m1++;
                    }
                    break;
                case 10:
                    if (n != 31)
                    {
                        n1++;
                    }
                    else
                    {
                        n1 = 1; m1++;
                    }
                    break;
                case 11:
                    if (n != 30)
                    {
                        n1++;
                    }
                    else
                    {
                        n1 = 1; m1++;
                    }
                    break;
                case 12:
                    if (n != 31)
                    {
                        n1++;
                    }
                    else
                    {
                        n1 = 1; m1 = 1; g1++;
                    }
                    break;
                default:
                    res = "Неправильный формат даты";
                    break;
            }
            res = Convert.ToString(n1) + "." + Convert.ToString(m1) + "." + Convert.ToString(g1);
            return res;
        }
    }
}
