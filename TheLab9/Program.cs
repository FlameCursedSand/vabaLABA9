using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLab9
{
    internal class Program
    {
        class Resume
        {
            public string name;
            public string dolzhnost;
            public int zp;
            public int year;
            public Resume(string n, string d, int z, int y)
            {
                name = n;
                dolzhnost = d;
                zp = z;
                year = y;
            }
            static void firstQ(Resume[] a) //типмассива[] имямассива
            {
                Console.WriteLine("Введите зарплату, для вывода сотрудников, у которых она больше заданной:");
                int Zep = Convert.ToInt32(Console.ReadLine());
                foreach (Resume i in a)
                {
                    if (Zep < i.zp)
                    {
                        Console.WriteLine(i.name);
                    }
                }
            }
            static void secondQ(Resume[] a)
            {
                Console.WriteLine("Введите должность, для вывода списка работников:");
                string Dol = Console.ReadLine();

                foreach (Resume i in a)
                {
                    if (Dol == i.dolzhnost)
                    {
                        Console.WriteLine(i.name);
                    }
                }
            }
            static void Main(string[] args)
            {
                Resume[] objt = new Resume[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Введите фамилию и инциалы сотрудника(Иванов И.И.):");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Введите год поступления сотрудника");
                    int Year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите должность сотрудника");
                    string Dolzh = Console.ReadLine();
                    Console.WriteLine("Введите зарплату сотрудника");
                    int ZP = Convert.ToInt32(Console.ReadLine());
                    objt[i] = new Resume(Name,Dolzh,ZP,Year);
                }
                firstQ(objt);
                secondQ(objt);
                

                
                
            }
        }
    }
}
