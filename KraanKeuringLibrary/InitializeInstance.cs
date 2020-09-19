using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraanKeuringLibrary
{
    public static class InitializeInstance
    {
        static int opdrachtnummer = 0;
        static int maximumgecreerde = 0;
        static Dictionary<int, List<string>> lengte6dlist { get; set; }
        static Dictionary<int, List<string>> lengte30dlist { get; set; }
        static Dictionary<int, List<string>> IDlist { get; set; }
        static Dictionary<int, List<string>> afslijpinglist { get; set; }
        static Dictionary<int, List<string>> roestlist { get; set; }
        static Dictionary<int, List<string>> diameterlist { get; set; }
        static Dictionary<int, List<string>> positielist { get; set; }
        static Dictionary<int, List<string>> beoordelinglist { get; set; }
        static Dictionary<int, List<string>> typelist { get; set; }
        static Dictionary<int, List<string>> typeroestlist { get; set; }
        static Dictionary<int, List<string>> kabelleverancierlist { get; set; }
        static Dictionary<int, List<string>> waarnemingenlist { get; set; }
        static Dictionary<int, List<string>> bedrijfsurenelist { get; set; }
        static Dictionary<int, List<string>> redenenlist { get; set; }
        static Dictionary<int, List<string>> datelist { get; set; }
        static Dictionary<int, string> imagepath { get; set; }
    }
}
