using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using boat.Model.DTO;
using System.Collections.Concurrent;

namespace boat.Global
{
    class GlobalVariables
    {
        public static Dictionary<string, int> mapHanhtrinhtau = new Dictionary<string, int>();

        public static Dictionary<int, LatLng> mapLatLng = new Dictionary<int, LatLng>();

        public static Dictionary<string, int> mapHanhTrinhCu = new Dictionary<string, int>();

        public static string messageStates = "-----------------------\n";

        public static ConcurrentDictionary<string, int> mapHanhtrinhBao = new ConcurrentDictionary<string, int>();

        public static ConcurrentDictionary<string, LatLng> mapHanhtrinhBaoCu = new ConcurrentDictionary<string, LatLng>();
    }
}
