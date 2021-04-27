using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capapresentacion
{
    public static class TiempoStatic
    {
        private static DateTime startDate;
        private static Boolean isWorking;

        public static DateTime StartDate { get => startDate; set => startDate = value; }
        public static bool IsWorking { get => isWorking; set => isWorking = value; }
    }
}
