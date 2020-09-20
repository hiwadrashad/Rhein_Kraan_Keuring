using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RheinKraanKeuringLibrary
{
    public static class Methods
    {
        public static void StoreValues(Dictionary<int, List<string>> storagelist,int storagenumber, string value1, string value2, string value3, string value4, string value5 )
        {
            storagelist[storagenumber] = new List<string> { value1, value2, value3, value4, value5 };
        }

        public static void StoreValues(Dictionary<int, List<string>> storagelist, int storagenumber, string value)
        {
            storagelist[storagenumber] = new List<string> { value };
        }
        public static void StoreValues(Dictionary<int, string> storagelist, int storagenumber, string value)
        {
            storagelist[storagenumber] = value;
        }
        public static void AssignListInsideList(int opdrachtnummer)
        {
            ExtractedModel.lengte = StaticModel.lengte6dlist[opdrachtnummer];
            ExtractedModel.lengte30 = StaticModel.lengte30dlist[opdrachtnummer];
            ExtractedModel.Id = StaticModel.IDlist[opdrachtnummer];
            ExtractedModel.afslijping = StaticModel.afslijpinglist[opdrachtnummer];
            ExtractedModel.roest = StaticModel.roestlist[opdrachtnummer];
            ExtractedModel.diameter = StaticModel.diameterlist[opdrachtnummer];
            ExtractedModel.positie = StaticModel.positielist[opdrachtnummer];
            ExtractedModel.beoordeling = StaticModel.beoordelinglist[opdrachtnummer];
            ExtractedModel.type = StaticModel.typelist[opdrachtnummer];
            ExtractedModel.typeroest = StaticModel.typeroestlist[opdrachtnummer];
            ExtractedModel.leverancier = StaticModel.kabelleverancierlist[opdrachtnummer];
            ExtractedModel.waarnemingen = StaticModel.waarnemingenlist[opdrachtnummer];
            ExtractedModel.uren = StaticModel.bedrijfsurenelist[opdrachtnummer];
            ExtractedModel.reden = StaticModel.redenenlist[opdrachtnummer];
            ExtractedModel.datum = StaticModel.datelist[opdrachtnummer];
            ExtractedModel.imageobj = StaticModel.imagepath[opdrachtnummer];
        }

        public static void InitializeModel()
        {
            StaticModel.opdrachtnummer = 0;

            StaticModel.maximumgecreerde = 0;

            StaticModel.lengte6dlist = new Dictionary<int, List<string>>();

            StaticModel.lengte30dlist = new Dictionary<int, List<string>>();

            StaticModel.IDlist = new Dictionary<int, List<string>>();

            StaticModel.afslijpinglist = new Dictionary<int, List<string>>();

            StaticModel.roestlist = new Dictionary<int, List<string>>();

            StaticModel.diameterlist = new Dictionary<int, List<string>>();

            StaticModel.positielist = new Dictionary<int, List<string>>();

            StaticModel.beoordelinglist = new Dictionary<int, List<string>>();

            StaticModel.typelist = new Dictionary<int, List<string>>();

            StaticModel.typeroestlist = new Dictionary<int, List<string>>();

            StaticModel.kabelleverancierlist = new Dictionary<int, List<string>>();

            StaticModel.waarnemingenlist = new Dictionary<int, List<string>>();

            StaticModel.bedrijfsurenelist = new Dictionary<int, List<string>>();

            StaticModel.redenenlist = new Dictionary<int, List<string>>();

            StaticModel.datelist = new Dictionary<int, List<string>>();

            StaticModel.imagepath = new Dictionary<int, string>();
        }


    }
}
