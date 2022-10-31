//
// ${Melquiceded Balbi Villanueva}
//
// Author:
//       ${Melquiceded} <${melquiceded.balbi@gmail.com}>
//
// Copyright (c) ${2089} MIT
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using QuickTools; 
using System.Threading; 
namespace cwatch
{
      public class Timer
      {
            private int Seconds = 60;
            private int Minutes = 60;
            private int Hours = 24;
            private int TimerGoal = 0;
            private const int SendondsInterval = 1000; 
          
            private static void Display()
            {
                  var app = new Timer();

                  while(true)
                  {
                        Get.Clear(); 
                        Get.Box("Timer");
                        app.TimerGoal++; 
                        Color.Green(app.TimerGoal);
                        Get.WaitTime(SendondsInterval);   
                  }
            }
            public void Start()
            {
                 
                        var app = new Thread(Display);
                        if (app.IsAlive == false)
                        {
                              app.Start();
                        }

                        if (Get.KeyInput().ToString() == "Enter")
                        {
                              app.Abort();
                        }
            

                  Set(); 


            }
            public void Set()
            {
                  // 30 seconds 
                  Color.Yellow("Format: Hours Minutes Seconds ");
                  Color.Yellow("Example: 1m  50s ");
                  C.W("This would take 1 minute 50 seconds");


                  Get.Input();


                  Start(); 


            }
            public void Stop()
            {

            }




      }
}
