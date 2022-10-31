using System; 
using static System.Console; 
using System.Threading; 

namespace Clock
{
    class ClockOptions
    {
        public virtual void MainOptions()
        {
            int option = int.Parse(Console.ReadLine());
        
            switch(option)
            {
                case 1:
                
                break; 
                
                case 2:
                
                break; 
                
                case 3:
                
                break; 
                default:
                    WriteLine("Not Valid option");
                    break; 
            }
        }
        
    }
    
}