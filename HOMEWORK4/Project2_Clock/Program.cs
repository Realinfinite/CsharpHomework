using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{

    public delegate void Clock();

    public class Tick_Alarm
    {
        public event Clock OnTick, OnAlarm;
        public int time = 0;
        public void DoTick(int i)
        {
                if (i % 10 == 0 && OnTick != null)
                    OnTick();
            
        }
        public void DoAlarm(int i)
        {
            
                if(i%30 ==0&&OnAlarm !=null)
                OnAlarm();
            
        }
    }

    public class Form
    {
        public Tick_Alarm tick_alarm = new Tick_Alarm();

        public Form()
        {
            tick_alarm.OnTick += Clock_Tick;
            tick_alarm.OnAlarm += Clock_Alarm;

        }
        void Clock_Tick()
        {
            Console.WriteLine("Clock is ticking!");
        }

        void Clock_Alarm()
        {
            Console.WriteLine("Clock is alarming!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            for(int i = 0; i < 100; i++)
            {
                form1.tick_alarm.DoAlarm(i);
                form1.tick_alarm.DoTick(i);
            }
         
        }
    }
}
