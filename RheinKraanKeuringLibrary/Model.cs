using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheinKraanKeuringLibrary
{
    public static class Model
    {
        public static int opdrachtnummer { get; set; }

        public static int maximumgecreerde { get; set; }
        public static Dictionary<int, List<string>> lengte6dlist { get; set; }
        public static Dictionary<int, List<string>> lengte30dlist { get; set; }
        public static Dictionary<int, List<string>> IDlist { get; set; }
        public static Dictionary<int, List<string>> afslijpinglist { get; set; }
        public static Dictionary<int, List<string>> roestlist { get; set; }
        public static Dictionary<int, List<string>> diameterlist { get; set; }
        public static Dictionary<int, List<string>> positielist { get; set; }
        public static Dictionary<int, List<string>> beoordelinglist { get; set; }
        public static Dictionary<int, List<string>> typelist { get; set; }
        public static Dictionary<int, List<string>> typeroestlist { get; set; }
        public static Dictionary<int, List<string>> kabelleverancierlist { get; set; }
        public static Dictionary<int, List<string>> waarnemingenlist { get; set; }
        public static Dictionary<int, List<string>> bedrijfsurenelist { get; set; }
        public static Dictionary<int, List<string>> redenenlist { get; set; }
        public static Dictionary<int, List<string>> datelist { get; set; }
        public static Dictionary<int, string> imagepath { get; set; }
    }
}
