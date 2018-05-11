using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroService4Net;

namespace ReallySimpleMicroservice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var microService = new MicroService(1235);
                microService.Run(args);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            
        }
    }
}
