using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomodoro_Final
{
    class ShowJson
    {
        protected ShowJson() { }

        public static List<string> AllTag { get; set; }

        public static List<string> GetTag()
        {
            return AllTag;
        }   
    }
}
