using DTC.Models.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DTC.Models.F16.PUP
{
	public class PUPSystem : IConfiguration
	{
		public DEDConfiguration VRP_PAGE { get; set; }
        public DEDConfiguration PUP_PAGE { get; set; }
        public DEDConfiguration OA1_PAGE { get; set; }
        public DEDConfiguration OA2_PAGE { get; set; }
        public int SteerPointRef { get; set; }
		public bool EnableUpload { get; set; }

		public PUPSystem()
		{
            VRP_PAGE = new DEDConfiguration(DEDpg.VRP,000.1m,12345,100);
            PUP_PAGE = new DEDConfiguration(DEDpg.PUP, 101.0m, 12345, 200);
            OA1_PAGE = new DEDConfiguration(DEDpg.OA1, 202.2m, 12345, 300);
            OA2_PAGE = new DEDConfiguration(DEDpg.OA2, 303.3m, 12345, 400);
            SteerPointRef = 1;			
			EnableUpload = true;
		}

        public PUPSystem(int SP, DEDConfiguration V, DEDConfiguration P, DEDConfiguration O, DEDConfiguration A)
        {
            VRP_PAGE = V;
            PUP_PAGE = P;
            OA1_PAGE = O;
            OA2_PAGE = A;
            SteerPointRef = SP;
            EnableUpload = true;
        }

        public string SetSteerPoint(string txt)
        {
            SteerPointRef = int.Parse(txt);
            return SteerPointRef.ToString();
        }
        public string GetSteerPoint()
        {
            return SteerPointRef.ToString();
        }

        public static PUPSystem FromCompressedString(string s)
        {
            try
            {
                var json = StringCompressor.DecompressString(s);
                var cfg = FromJson(json);
                return cfg;
            }
            catch
            {
                return null;
            }
        }

        public string ToJson()
        {
            var json = JsonConvert.SerializeObject(this);
            return json;
            
        }

        public string ToCompressedString()
        {
            var json = ToJson();
            return StringCompressor.CompressString(json);
        }

        public static PUPSystem FromJson(string s)
        {
            try
            {
                var cfg = JsonConvert.DeserializeObject<PUPSystem>(s);
                cfg.AfterLoadFromJson();
                return cfg;
            }
            catch
            {
                return null;
            }
        }
        public PUPSystem FuckJson(string s)
        {

            var ass = s.Split(':');
            List<string> hole = ass.ToList<string>();
            decimal VB = decimal.Parse(hole[4].Split(',')[0]);
            int VR = Int32.Parse(hole[5].Split(',')[0]);
            int VE = Int32.Parse(hole[6].Split(',')[0]);
            decimal PB = decimal.Parse(hole[10].Split(',')[0]);
            int PR = Int32.Parse(hole[11].Split(',')[0]);
            int PE = Int32.Parse(hole[12].Split(',')[0]);
            decimal OB = decimal.Parse(hole[16].Split(',')[0]);
            int OR = Int32.Parse(hole[17].Split(',')[0]);
            int OE = Int32.Parse(hole[18].Split(',')[0]);
            decimal AB = decimal.Parse(hole[22].Split(',')[0]);
            int AR = Int32.Parse(hole[23].Split(',')[0]);
            int AE = Int32.Parse(hole[24].Split(',')[0]);
            int STP = Int32.Parse(hole[26].Split(',')[0]);
            DEDConfiguration V_PAGE = new DEDConfiguration(DEDpg.VRP, VB, VR, VE);
            DEDConfiguration P_PAGE = new DEDConfiguration(DEDpg.PUP, PB, PR, PE);
            DEDConfiguration O_PAGE = new DEDConfiguration(DEDpg.OA1, OB, OR, OE);
            DEDConfiguration A_PAGE = new DEDConfiguration(DEDpg.OA2, AB, AR, AE);

            return new PUPSystem(STP, V_PAGE, P_PAGE, O_PAGE, A_PAGE);
        }


        public void AfterLoadFromJson()
        {
           
        }

        public PUPSystem Clone()
        {
            var json = ToJson();
            var cfg = FromJson(json);
            return cfg;
        }

        public void CopyConfiguration(PUPSystem cfg)
        {
            if (cfg.VRP_PAGE != null)
            {
                VRP_PAGE = cfg.VRP_PAGE;
            }
            if (cfg.PUP_PAGE != null)
            {
                PUP_PAGE = cfg.PUP_PAGE;
            }
            if (cfg.OA1_PAGE != null)
            {
                OA1_PAGE = cfg.OA1_PAGE;
            }
            if (cfg.OA2_PAGE != null)
            {
                OA2_PAGE = cfg.OA2_PAGE;
            }
        }
        IConfiguration IConfiguration.Clone()
        {
            return Clone();
        }
       
    }
}
