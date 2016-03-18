using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3.ViewModels
{
    [Serializable]
    public class GeoDateWrapper
    {
        public long geoDateWrapperId{get;set;}
        public decimal lat{get;set;}
        public decimal lng {get;set;}
        public String zoneId{get;set;}
        public String displayName{get;set;}
        public bool useDaylightTime{get;set;}
        public bool observesDaylightTime {get;set;}
        public int rawOffset{get;set;}
        public int zoneOffset{get;set;}

        public int dSTSavings{get;set;}
        public int year{get;set;}

        public int month{get;set;}
        public int day{get;set;}
        public int realDate{get;set;}
        public int hour{get;set;}
        public int minute{get;set;}
        public int second{get;set;}
    }
}
