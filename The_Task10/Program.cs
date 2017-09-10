using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Task10
{
    class Program
    {

        static Random rnd = new Random();

        static int GetInfo()
        {
            int info = rnd.Next(-100, 100);
            return info;
        }
        //формирование идеально-сбалансированного дерева
        static Point IdealTree(int size, Point p)
        {

            Point r;
            int nl, nr;
            if (size == 0) { p = null; return p; }
            nl = size / 2;
            nr = size - nl - 1;
            int d = GetInfo();
            r = new Point(d);
            r.left = IdealTree(nl, r.left);
            r.right = IdealTree(nr, r.right);
            p = r;
            return p;
        }
        //печать дерева по уровням
        static void ShowTree(Point p, int l)
        {
            if (p != null)
            {
                ShowTree(p.left, l + 4);//переход к левому поддереву
                for (int i = 0; i < l; i++) Console.Write(" ");
                Console.WriteLine(p.data);
                ShowTree(p.right, l + 4);//переход к правому поддереву
            }
        }

        public static int num;
        static void Tree(Point p, int l)
        {
            if (p != null)
            {
                Tree(p.left, l + 3);//переход к левому поддереву
                for (int i = 0; i < l; i++) //Console.Write(" ");
                //Console.WriteLine(p.data);
                Tree(p.right, l + 3);//переход к правому поддереву
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Рисую рандомное дерево:");
            Random rand = new Random();
            int size = rand.Next(5, 15);
            Point idTree = null;
            idTree = IdealTree(size, idTree);
            ShowTree(idTree, 1);
            Console.WriteLine("Считаем ярусы и веточки: ");
            int irus = 0;
            for (int i = 1; i <= size; i *= 2)
            {
                irus += 1;
            }
            Console.WriteLine("Количество ярусов: " + irus);

            int[] list = new int[irus];
            int n = 0, sizeTemp = size;

            for (int i = 1; i <= size; i *= 2)
            {
                list[n] = i;
                sizeTemp -= i;
                n++;
            }
            n--;
            list[n] += sizeTemp;
            for(int i = 0; i < irus; i++)
            Console.WriteLine("Количество веточек на " + (i+1) + " ярусе: " + list[i]);
            Console.ReadKey();
        }


    }
}
