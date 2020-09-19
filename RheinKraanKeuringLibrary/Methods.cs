using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
