using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class WorkItem : object
    {
        // Static field currentID stores the job ID of the last WorkItem that had been created
        private static int currentID;

        //Properties
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan JobLength { get; set; }

        
    }
}
