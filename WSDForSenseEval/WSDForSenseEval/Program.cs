﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSDForSenseEval
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLParser xmlp = new XMLParser();
            xmlp.CreateTrainFile();
            xmlp.GenerateKeyXml();
            
        }
    }
}
