using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molodoy
{
    class Program
    {
                /*Даны даты рождения 5 человек. Вывести даты рождения самого младшего из них. 
        Напишите функцию для сравнения двух дат для решения этой задачи.

        Начальные данные: 5 строчек по 3 числа на каждой - день, месяц и год рождения (через пробел)
        Вывод результата: 3 числа - дата рождения самого младшего - день, месяц и год.*/
        static void Main(string[] args)
        {
    
        int aD, aM, aY, bD, bM, bY, cD, cM, cY, dD, dM, dY, eD, eM, eY,minY,minM,minD,D,M,Y;
        int minD,minM,minY;
        input ( out aD, out aM, out aY);
        input ( out bD, out bM, out bY);
        input ( out cD, out cM, out cY);
        input ( out dD, out dM, out dY);
        input ( out eD, out eM, out eY);
        
        minY = aY;
        minM = aM;
        minD = aD;
        
        conferment (bD,bM,bY);
        conferment (cD,cM,cY);
        conferment (dD,dM,dY);
        conferment (eD,eM,eY);
        
        Console.WriteLine (minD + " " + minM + " " + minY); 
        
        }
        
        static void input (out int D, out int M, out int Y)
        {
            string [] str = Console.ReadLine().Split();
            
            D = int.Parse (str[0]);
            M = int.Parse (str[1]);
            Y = int.Parse (str[2]);
        }
        
        
        static void conferment (int D1, int M1, int Y1)
        {
            if (comparsion (int minY,int Y1))
             {
                yanger (int D1, int M1, int Y1);
             }
            else
            {
               if(comparsion (int minM,int M1))
                    yanger (int D1, int M1, int Y1);
            }
               else
                 {
                  if(comparsion (int minD,int D1))
                      yanger (int D1, int M1, int Y1);
                 }
        }
        
        static bool comparison (int chel1);
        {
            if (minY<chel1)
                return true
            if (minY == chel1)
                    return false;
                
        }
        
        static void yanger ( int D1, int M1, int Y1)
        {
           minY = Y1;
           minM = M1;
           minD = D1; 
        }
    }
}
