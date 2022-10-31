using System;
using System.Text.RegularExpressions;

namespace DTC.Models.F16.PUP
{
	public class PUPprofile
	{
		//private static Regex coordRegex = new Regex("^([N|S] \\d\\d\\.\\d\\d\\.\\d\\d\\d) ([E|W] \\d\\d\\d\\.\\d\\d\\.\\d\\d\\d)$");

		public int StrPtTGT { get; set; }
		public string ProfileName { get; set; }
        public DEDConfiguration VRPpg { get; set; }
        public DEDConfiguration PUPpg { get; set; }
        public DEDConfiguration OA1pg { get; set; }
        public DEDConfiguration OA2pg { get; set; }
        

		public PUPprofile(int strpt, string PN, DEDConfiguration V, DEDConfiguration P, DEDConfiguration O1, DEDConfiguration O2)
        {
            ProfileName = PN;
            StrPtTGT = strpt;
            VRPpg = V;
            PUPpg = P;
            OA1pg = O1;
            OA2pg = O2;            
            
        }
            
          

		
	}
}
