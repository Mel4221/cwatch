using System; 
using System.Threading; 

namespace Clock
{
    class Timer:RealTime
    {
            private int Goal = 0;
            private int Current = 0; 
            
           
            private void Init()
            {
                    while(true)
                    {
                        Current++; 
                        Console.WriteLine(Current); 
                    }
            }
        
             Thread timer = null; 
            public void Start()
            {
               timer = new Thread(()=>{Init();});
                if(timer.IsAlive == false)
                {
                    timer.Start(); 
                }
                    
                string question = Console.ReadLine();
                
                if(question == "out")
                {
                    timer.Abort(); 
                }else{
                   Checker(); 
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
                       timer.Abort(); 
                       condition = false; 
                  }
            }
        }
    public Timer()
    {
         throw new NotImplementedException();
    }
    public Timer(int time)
    {
        Goal = time;
        
    }
        
    }
    
}