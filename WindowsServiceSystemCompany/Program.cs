﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace WindowsServiceSystemCompany
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
         ServiceBase[] ServicesToRun;
              ServicesToRun = new ServiceBase[] 
            { 
                new ServiceSystemCompany() 
            };
            ServiceBase.Run(ServicesToRun);  
                                
          /*  #if DEBUG
                      var ser = new ServiceSystemCompany();
                      ser.OnDebug();
          #else 

          #endif      */   
            

        }
    }
}
