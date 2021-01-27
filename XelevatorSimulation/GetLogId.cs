using System;
using System.Collections.Generic;
using System.Text;
//
// @Robert Bradu
//
namespace XelevatorSimulation
{ 
    //This is a class that get the name of the Log ID and and send to the Admin form and into datebase
    class GetLogId
    {
        static string IdName;
        public static string idName
        {
            get
            {
                return IdName;
            }
            set
            {
                IdName = value;
            }
        }
    }
}
