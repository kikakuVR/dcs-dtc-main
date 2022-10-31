using System;
namespace DTC.Models.F16.PUP
{
    public class DEDConfiguration
    {
        public DEDpg PAGE { get; set; }
        public decimal BRG { get; set; }
        public int RNG { get; set; }
        public int ELEV { get; set; }
        public bool ToBeUpdated { get; set; }
        
                
        public DEDConfiguration(DEDpg dpg, decimal B, int R, int E)
        {
            PAGE = dpg;
            BRG = B;
            RNG = R;
            ELEV = E;
            ToBeUpdated = true;
        }

        private bool ValidateBRG(string txt)
        {
            if (!decimal.TryParse(txt, out decimal D))
            {
                return false;
            }

            if ((D < new decimal(0.0)) || (D > new decimal(360.0)))
            {
                return false;
            }

            return true;
        }

        private bool ValidateRNG(string txt)
        {
            if (!int.TryParse(txt, out int i))
            {
                return false;
            }

            if (i < 0 || i > 105600) //20 miles in ft
            {
                return false;
            }

            return true;
        }

        private bool ValidateELEV(string txt)
        {
            if (!int.TryParse(txt, out int i))
            {
                return false;
            }

            if (i > 30000) //30,000 ft??
            {
                return false;
            }

            return true;
        }

        public string GetBRG()
        {
            return BRG.ToString("000.0");
        }

        public string GetRNG()
        {
            return RNG.ToString();
        }

        public string GetELEV()
        {
            return ELEV.ToString();
        }

        public string SetBRG(string txt)
        {
            if (ValidateBRG(txt))
            {
                BRG = Math.Round(decimal.Parse(txt), 1);
            }

            return GetBRG();
        }

        public string SetRNG(string txt)
        {
            if (ValidateRNG(txt))
            {
                RNG = int.Parse(txt);
            }

            return GetRNG();
        }

        public string SetELEV(string txt)
        {
            if (ValidateELEV(txt))
            {
                ELEV = int.Parse(txt);
            }

            return GetELEV();
        }
    }
}
