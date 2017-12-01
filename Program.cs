using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZKI3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение");
            string str1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(str1);
            Console.WriteLine(str1.Length);

            ///////////////////////////////////////////////////////////////

            string str = String.Empty;
            int cz = 0;
            for (cz = 0; cz < str1.Length; cz++)
            {
                if (!char.IsDigit(str1[cz]))
                {
                    str += str1[cz];
                }
            }

            Console.WriteLine("Это будет зашифровано -> "+str);
            double ln = str.Length;
            Console.WriteLine(ln/2);

            //if (str.Length % 2 != 0)
            //    str += "ъ";
            //Console.WriteLine(str);


            str1 = str;
            string str2 = str;
            Console.WriteLine(str2);
            double ln1 = str1.Length;
            Console.WriteLine(ln1 / 2);

            for (int i = 2; i < str.Length; i += 3)
                    str = str.Insert(i, "|");
                Console.WriteLine(str);

                string[] mas = str.Split('|');

                foreach (string s in mas)
                    Console.Write(s + " ");

                Console.WriteLine("\n");

            for (int i = 1; i < str1.Length; i += 3)
                str1 = str1.Insert(i, "|");
            Console.WriteLine(str1);

            string[] mas1 = str1.Split('|');

            foreach (string s in mas1)
                Console.Write(s + " ");



            int k = 0;

            if (ln % 2 != 0)
            {
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    char[] ch = mas[i].ToCharArray();
                    if (ch[0] == ch[1])
                    {
                        k++;
                    }
                }
            }

            else if (ln % 2 == 0)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    char[] ch = mas[i].ToCharArray();
                    if (ch[0] == ch[1])
                    {
                        k++;
                    }
                }
            }

            if (ln1 % 2 != 0)
            {
                for (int i = 1; i < mas1.Length - 1; i++)
                {
                    char[] ch = mas1[i].ToCharArray();
                    if (ch[0] == ch[1])
                    {
                        k++;
                    }
                }
            }

            else if (ln1 % 2 == 0)
            {
                for (int i = 1; i < mas1.Length-1; i++)
                {
                    char[] ch = mas1[i].ToCharArray();
                    if (ch[0] == ch[1])
                    {
                        k++;
                    }
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine(k);
            Console.WriteLine("\n");
            
            int y = 0;
            //string temp = String.Empty;
            //string temp1 = String.Empty;
            while (y < k)
            {

                str = str2;
                Console.WriteLine(str+" == "+str2);

                for (int i = 2; i < str.Length; i += 3)
                    str = str.Insert(i, "|");
                Console.WriteLine(str);
                mas1 = str.Split('|');

                if (ln % 2 != 0)
                {
                    for (int i = 0; i < mas1.Length - 1; i++)
                    {
                        char[] ch = mas1[i].ToCharArray();
                        if (ch[0] == ch[1])
                        {
                            string s = ch[0].ToString();
                            s += "ъ";
                            s += ch[1].ToString();
                            mas1[i] = s;
                        }
                    }
                }

                else if (ln % 2 == 0)
                {
                    for (int i = 0; i < mas1.Length; i++)
                    {
                        char[] ch = mas1[i].ToCharArray();
                        if (ch[0] == ch[1])
                        {
                            string s = ch[0].ToString();
                            s += "ъ";
                            s += ch[1].ToString();
                            mas1[i] = s;
                        }
                    }
                }

                str2 = string.Concat(mas1);
                Console.WriteLine(str2);

                y++;
            }

            //Console.WriteLine(str1);

            //    foreach (string s in mas)
            //        Console.Write(s + " ");

            //    Console.Write("\n");

            //    str = string.Concat(mas);

            //    Console.Write(str);
            //Console.WriteLine("\n");


            Console.WriteLine("\n");
            Console.WriteLine(str2);

            

            if (str2.Length % 2 != 0)
            {
                str2 += "ъ";
                Console.WriteLine(str2+" Lenght is "+str2.Length);
            }
            Console.WriteLine("\n");

            ///////////////////////////////////////////////////////////////

            char[,] table = new char[8,4];
            string n1 = Convert.ToString(Console.ReadLine());
            string n = String.Empty;
            for (cz = 0; cz < n1.Length; cz++)
            {
                if (!char.IsDigit(n1[cz]))
                {
                    n += n1[cz];
                }
            }
            Console.WriteLine("Ключ -> "+n);

            ///////////////////////////////////////////////////////////////

            int z1=0;
            string p = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
            Console.WriteLine(p);
            n += p;
            char[] chart = n.ToCharArray();
            IEnumerable<char> p1 = chart.Distinct();
            chart = p1.ToArray();
            string e = new string(chart);
            Console.WriteLine(e);
            chart = e.ToCharArray();
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    for (int z = z1; z < chart.Length;)
                    {
                        table[i, j] = chart[z];
                        z1++;
                        break;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(" "+table[i,j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            ///////////////////////////////////////////////////////////////

            string shifr = String.Empty;

            for (int i = 2; i < str2.Length; i += 3)
                str2 = str2.Insert(i, "|");
            //Console.WriteLine(str);
            string[] word = str2.Split('|');
            //foreach (string strin in word)
            //    Console.Write(strin+" ");
            int iR1 = 0, jR1 = 0, iR2 = 0, jR2 = 0;
            for (int w = 0; w < word.Length; w++)
            {
                char[] wR = word[w].ToCharArray();
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        if (table[i, j] == wR[0])
                        {
                            iR1 = i;
                            jR1 = j;
                        }
                        else if (table[i, j] == wR[1])
                        {
                            iR2 = i;
                            jR2 = j;
                        }
                    }
                }

                if ((iR1 != iR2) && (jR1 != jR2))
                {
                    shifr += table[iR1, jR2];
                    shifr += table[iR2, jR1];
                }

                else if (iR1 == iR2)
                {
                    if ((jR1 + 1 <= table.GetLength(1)-1) && (jR2 + 1 <= table.GetLength(1)-1))
                    {
                        shifr += table[iR1, jR2 + 1];
                        shifr += table[iR2, jR1 + 1];
                    }
                    else if ((jR1 + 1 > table.GetLength(1)-1) && (jR2 + 1 <= table.GetLength(1)-1))
                    {
                        shifr += table[iR1, 0];
                        shifr += table[iR2, jR2+1];
                    }
                    else if ((jR1 + 1 <= table.GetLength(1)-1) && (jR2 + 1 > table.GetLength(1)-1))
                    {
                        shifr += table[iR1, jR1+1];
                        shifr += table[iR2, 0];
                    }
                }
                else if (jR1 == jR2)
                {
                    if ((iR1 + 1 <= table.GetLength(0)-1) && (iR2 + 1 <= table.GetLength(0)-1))
                    {
                        shifr += table[iR1+1, jR2];
                        shifr += table[iR2+1, jR1];
                    }
                    else if ((iR1 + 1 > table.GetLength(0) - 1) && (iR2 + 1 <= table.GetLength(0) - 1))
                    {
                        shifr += table[0, jR2];
                        shifr += table[iR2 + 1, jR1];
                    }
                    else if ((iR1 + 1 <= table.GetLength(0) - 1) && (iR2 + 1 > table.GetLength(0) - 1))
                    {
                        shifr += table[iR1 + 1, jR2];
                        shifr += table[0, jR1];
                    }

                }

            }

            Console.WriteLine(shifr);

            Console.ReadKey();
        }
    }
}
