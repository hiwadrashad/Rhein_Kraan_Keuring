using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheinKraanKeuringLibrary
{
    public static class StaticModel
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

    public static class ExtractedModel
    {

        public static List<string> lengte { get; set; }

        public static List<string> lengte30 { get; set; }

        public static List<string> Id { get; set; }

        public static List<string> afslijping { get; set; }

        public static List<string> roest { get; set; }

        public static List<string> diameter { get; set; }

        public static List<string> positie { get; set; }

        public static List<string> beoordeling { get; set; }

        public static List<string> type { get; set; }

        public static List<string> typeroest { get; set; }

        public static List<string> leverancier { get; set; }

        public static List<string> waarnemingen { get; set; }

        public static List<string> uren { get; set; }

        public static List<string> reden { get; set; }

        public static List<string> datum { get; set; }

        public static string imageobj { get; set; }
    }

    public static class SaveDate
    { 
    public static string savedate { get; set; }
    }
}
