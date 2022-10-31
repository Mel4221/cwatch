using System;
using QuickTools;
using static QuickTools.Color; 
using System.Threading; 

namespace Clock
{
    class Timer:RealTime
    {
            private int Goal = 0;
            private int Current = 0;
            private char[] Types = {'h','m','s' };
            public char Type = 'x'; 



            public void Display()
            {
                  Color.Yellow("Type time on the fallowing format: 1h , 1m , 1s , 10m 10s");
                  if (Get.TextInput().IndexOf("s",StringComparison.Ordinal) > 0 )
                  {
                        Goal = int.Parse(Get.Text.Replace("s",""));
                        Type = 's'; 
                        Start(); 
                  }
            }

            private void Init()
            {
                    while(Goal != Current)
                    {
                        Get.Clear(); 
                        Current++;
                        Green($"Timer Running: {Current}{Type} Until: {Goal} {Type}");
                        Get.WaitTime(Interval);

                       
                    }
                  Get.Green("Time is up!!! "+Goal+Type); 
            }

            Thread TimerHandeler = null;   
            public void Start()
            {
               TimerHandeler = new Thread(()=>{Init();});
                if(TimerHandeler.IsAlive == false)
                {
                    TimerHandeler.Start(); 
                }

                  string question = Get.TextInput("Press any key to exit");
                
                if(question == "")
                {
                    TimerHandeler.Abort(); 
                }
            }


     
        public void Checker()
        {
            bool condition = true; 
            while(condition)
            {
                  string question = Console.ReadLine();
                  if(question == "out")
                  {
                       TimerHandeler.Abort(); 
                       condition = false; 
                  }
            }
        }



      public Timer()
    {
         //throw new NotImplementedException();
    }
    public Timer(int time)
    {
        Goal = time;
        
    }
        
    }
    
}