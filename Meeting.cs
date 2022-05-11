using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMIS
{
    public enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};

    public class Meeting
    {
        public int meeting_id { get; set; }

        public int group_id { get; set; }

        public Day day { get; set; }

        public DateTime start { get; set; }

        public DateTime end { get; set; }

        public char room { get; set; }


        public override string ToString()
        {
            return meeting_id + "\t" + group_id + "\t" + day + "\t" + start + "\t" + end + "\t" + room;
        }
    }

    
    
}
