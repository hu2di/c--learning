using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArray
{
    class Program
    {
         /*
         * Viet phuong thuc getCount nhan dau vao la mot List<String>,
         * tra ve gia tri kieu int sao cho gia tri do la so luong cac 
         * xau trong danh sach ma moi xau deu co chua mot cap phu am 
         * dung canh nhau (khong tinh cac truong hop phu am duoc phep
         * dung canh nhau theo dung ngu phap tieng Viet).
         */
        public static string[] TachXau(String x, int c)
        {
            List<string> s = new List<String>();
            string temp = "";
            for (int j = 0; j < x.Length; j++)
            {
                temp = temp + x[j];
                if (temp.Length >= c && ((temp[temp.Length-1]=='.')
                                        || (temp[temp.Length - 1] == '?')
                                        || (temp[temp.Length - 1] == '!')
                                        || (temp[temp.Length - 1] == ';')))
                {
                    s.Add(temp);
                    temp="";
                }
            }
                return s.ToArray();
        }
        /*
         * Viet phuong thuc dem cac xau trong mot List<String> 
         * ma xau do co chua cac nguyen am.
         */
        public static int DemXau(List<String> x)
        {
            int kq = 0;
            String[] y = x.ToArray();
            for (int i = 0; i < y.Length; i++ )
            {
                if ( (y[i].LastIndexOf("u") >= 0)
                    || (y[i].LastIndexOf("e") >= 0)
                    || (y[i].LastIndexOf("a") >= 0)
                    || (y[i].LastIndexOf("o") >= 0) 
                    || (y[i].LastIndexOf("i") >= 0)
                    || (y[i].LastIndexOf("U") >= 0)
                    || (y[i].LastIndexOf("E") >= 0)
                    || (y[i].LastIndexOf("O") >= 0)
                    || (y[i].LastIndexOf("A") >= 0)
                    || (y[i].LastIndexOf("I") >= 0)) kq++;
            }
                return kq;
        }
        /*
         * Viet ham : tham so truyen vao la cac xau. Phuong thuc
         * tra ve mot danh sach moi trong do: cac xau cua danh sach cu 
         * se duoc gom lai thanh 1 cau trong danh sach moi neu cac xau do
         * khong chua ki tu ket thuc cau ( cham, cham hoi, hai cham, cham than)
         * Cac phan tu trong danh sach moi la cac xau va moi xau nay chi 
         * chua ky tu ket thuc cau o cuoi cung.
         */
        public static List<String> GhepCau(List<String> list)
        {
            List<String> kq = new List<String>();
            String[] xau = list.ToArray();
            String temp = "";
            for (int i = 0; i < xau.Length; i++ )
            {
                temp = temp + " " + xau[i];
            }
            int vt=0;
            for (int i = 0; i < temp.Length; i++ )
            {
                if (temp[i]=='.' || temp[i]==':' || temp[i]=='?' || temp[i]=='!')
                {
                    int len = i - vt;
                    kq.Add(temp.Substring(vt,len));
                    vt = i;
                }
                if (i == (temp.Length - 1))
                {

                }
            }
                return kq;
        }
        static void Main(string[] args)
        {
            List<String> x = new List<string>();
            x.Add("Hung");
            x.Add("a hg");
            x.Add("Dhnb");
            x.Add("oiii");
            x.Add("ueou");
            int a = DemXau(x);
            Console.WriteLine(a);
 
            String[] xau = x.ToArray();
            String temp = "";
            for (int i = 0; i < xau.Length; i++)
            {
                temp = temp + " " + xau[i];
            }
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
