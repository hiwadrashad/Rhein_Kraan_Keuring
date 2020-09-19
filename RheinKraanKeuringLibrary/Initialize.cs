using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RheinKraanKeuringLibrary
{
    public static class Initialize
    {


        public static void InitializeModel()
        {
            Model.opdrachtnummer = 0;

            Model.maximumgecreerde = 0;

            Model.lengte6dlist = new Dictionary<int, List<string>>();

            Model.lengte30dlist = new Dictionary<int, List<string>>();

            Model.IDlist = new Dictionary<int, List<string>>();

            Model.afslijpinglist = new Dictionary<int, List<string>>();

            Model.roestlist = new Dictionary<int, List<string>>();

            Model.diameterlist = new Dictionary<int, List<string>>();

            Model.positielist = new Dictionary<int, List<string>>();

            Model.beoordelinglist = new Dictionary<int, List<string>>();

            Model.typelist = new Dictionary<int, List<string>>();

            Model.typeroestlist = new Dictionary<int, List<string>>();

            Model.kabelleverancierlist = new Dictionary<int, List<string>>();

            Model.waarnemingenlist = new Dictionary<int, List<string>>();

            Model.bedrijfsurenelist = new Dictionary<int, List<string>>();

            Model.redenenlist = new Dictionary<int, List<string>>();

            Model.datelist = new Dictionary<int, List<string>>();

            Model.imagepath = new Dictionary<int, string>();
        }
      
    }
}
