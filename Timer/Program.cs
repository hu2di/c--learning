using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        /*
         
         */
        static void Main(string[] args)
        {
            Timer12H a = new Timer12H();
            a.setTimer(12, 59, 59);
            Console.Write("Show: ");
            a.showTimer();
            Console.Write("AddOneHour");
            a.AddOneHour();
            a.showTimer();
            Console.Write("AddOneMinute");
            a.AddOneMinute();
            a.showTimer();
            Console.Write("AddOneSecond");
            a.AddOneSecond();
            a.showTimer();
            Console.ReadLine();
        }
        class TimerH
        {
            public byte hour, minute, second;
            public String PMorAM;
            public TimerH()
            {
                hour = 0;
                minute = 0;
                second = 0;
                PMorAM = "AM";
            }
            public void setTimer(byte hour, byte minute, byte second)
            {
                this.hour = hour;
                this.minute = minute;
                this.second = second;
            }
            public void showTimer()
            {
                Console.Write("{0}:{1}:{2}", hour, minute, second);
            }
            public virtual void AddOneHour()
            {

            }
            public virtual void AddOneMinute()
            {

            }
            public virtual void AddOneSecond()
            {

            }
        }
        class Timer24H : TimerH
        {
            public override void AddOneHour()
            {
                if (hour == 23)
                {
                    hour = 0;
                }
                else
                { 
                    hour++; 
                }
            }
            public override void AddOneMinute()
            {
                if (minute ==59)
                {
                    minute = 0;
                    AddOneHour();
                }
                else
                {
                    minute++;
                }
            }
            public override void AddOneSecond()
            {
                if (second==59)
                {
                    second = 0;
                    AddOneMinute();
                }
                else
                {
                    second++;
                }
            }
        }
        class Timer12H : TimerH
        {
            public void setTimer(byte hour, byte minute, byte second,String PMorAM)
            {
                base.setTimer(hour, minute, second);
                this.PMorAM = PMorAM;
            }
            public void showTimer()
            {
                base.showTimer();
                Console.WriteLine(PMorAM);
            }
            public override void AddOneHour()
            {
                if (hour == 12)
                {
                    hour = 1;
                    if (PMorAM == "PM")
                    {
                        PMorAM = "AM";
                    }
                    else
                    {
                        PMorAM = "PM";
                    }
                }
                else
                {
                    hour++;
                }
            }
            public override void AddOneMinute()
            {
                if (minute == 59)
                {
                    minute = 0;
                    AddOneHour();
                }
                else
                {
                    minute++;
                }
            }
            public override void AddOneSecond()
            {
                if (second == 59)
                {
                    second = 0;
                    AddOneMinute();
                }
                else
                {
                    second++;
                }
            }
        }
    }
}
