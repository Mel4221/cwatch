using System; 
using System.Threading; 

namespace Clock
{
    class RealTime
    {
        private DateTime TimeNow  = DateTime.Now;
        public string Date = ""; 
        public int Day = 0; 
        public int Month = 0; 
        public int Year = 0; 
        public int Hour = 0; 
        public int Minute = 0; 
        public int Second = 0; 
        public const int Interval = 1000;
        
        public void PrintStatus()
        {
            Console.WriteLine($"{Day} {Month} {Year} {Hour} {Minute} {Second} "); 
        }
        
        

     
     public RealTime()
     {
         Date = this.TimeNow.ToString("MM/dd/yyyy"); 
         Day = int.Parse(this.TimeNow.ToString("dd"));
         Month = int.Parse(this.TimeNow.ToString("MM"));
         Year = int.Parse(this.TimeNow.ToString("yyyy"));
         Hour = int.Parse(this.TimeNow.ToString("HH")); 
         Minute = int.Parse(this.TimeNow.ToString("mm")); 
         Second =  int.Parse(this.TimeNow.ToString("ss")); 
     }
     
     
    public RealTime(DateTime dateTime, int day , int month , int year  , int hour , int minute , int second)
     {
         Date = dateTime.ToString(); 
         Day = day ; 
         Month = month ; 
         Year = year; 
         Hour = hour; 
         Minute = minute; 
         Second =  second; 
     }
     
     
     
     
        
    }
    
}