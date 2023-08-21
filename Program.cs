using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
             List<int> dso = new List<int>();
            int luachon;
            
            for (; ;)
            {
                Console.Write("\nmoi nhap lua chon: ");
                luachon = int.Parse(Console.ReadLine());
                if (luachon == 0) break;
                switch (luachon)
                {
                    case 1: List(dso);
                        break;
                    case 2: 
                        kiemTra(dso);
                        break;
                }
            }
        }
        public static void List( List<int> dso)
        {
           
            Random a = new Random();
            for (int i = 0; i < 20; i++)
            {
                int k = a.Next(1000);
                dso.Add(k);
            }
            foreach (int t in dso)
                Console.Write(t + " ");
            Console.ReadLine();
            dso.Reverse();
            Console.WriteLine("day dao nguoc:");
            foreach (int t in dso)
                Console.Write(t + " ");
            Console.ReadLine();
           
        }
       public static void kiemTra(List<int> dso)
        {
            int n;
            Console.Write("moi nhap so can tim:");
            n= int.Parse(Console.ReadLine());
            bool t = dso.Contains(n);
            if(t==false)
            {
                Console.Write("khong ton tai gia tri {0}", n);
            }
            else
                Console.Write("co ton tai gia tri {0}", n);
            
        }

    }
}
