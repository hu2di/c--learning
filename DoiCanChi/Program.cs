using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoiCanChi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH DOI NAM DUONG LICH SANG NAM AM LICH");
        point:
            Console.Write("\nNam:");
            int iYear = int.Parse(Console.ReadLine());
            int iCan = iYear % 10;
            int iChi = iYear % 12;
            String strCan = "";
            string strChi = "";
            switch (iCan)
            {
                case 0:
                    strCan = "Canh";
                    break;
                case 1:
                    strCan = "Tan";
                    break;
                case 2:
                    strCan = "Nham";
                    break;
                case 3:
                    strCan = "Quy";
                    break;
                case 4:
                    strCan = "Giap";
                    break;
                case 5:
                    strCan = "At";
                    break;
                case 6:
                    strCan = "Binh";
                    break;
                case 7:
                    strCan = "Dinh";
                    break;
                case 8:
                    strCan = "Mau";
                    break;
                case 9:
                    strCan = "Ky";
                    break;
            }
            switch (iChi)
            {
                case 0:
                    strChi = "Than";
                    break;
                case 1:
                    strChi = "Dau";
                    break;
                case 2:
                    strChi = "Tuat";
                    break;
                case 3:
                    strChi = "Hoi";
                    break;
                case 4:
                    strChi = "Ti";
                    break;
                case 5:
                    strChi = "Suu";
                    break;
                case 6:
                    strChi = "Dan";
                    break;
                case 7:
                    strChi = "Mao";
                    break;
                case 8:
                    strChi = "Thin";
                    break;
                case 9:
                    strChi = "Ty";
                    break;
                case 10:
                    strChi = "Ngo";
                    break;
                case 11:
                    strChi = "Mui";
                    break;
            }
            Console.WriteLine("Nam {0} la nam {1} {2}", iYear, strCan, strChi);
            goto point;
        }
    }
}
