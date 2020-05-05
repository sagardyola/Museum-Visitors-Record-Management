using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum
{
    class Visitor
    {
        public DateTime day { get; set; }
        public int cardNo { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public String contact { get; set; }
        public String occupation { get; set; }
        public DateTime inTime { get; set; }
        public DateTime outTime { get; set; }
        public int duration { get; set; }

    }
}
