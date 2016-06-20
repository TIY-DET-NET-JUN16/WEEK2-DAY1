using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Utils.Addition(2, 5);

            try
            {
                NullReferenceException test = new NullReferenceException("This is the message in my exception");
                throw test;
            }
            catch(Exception ex)
            {
                string temp = ex.Message;
            }
        }
    }
}
