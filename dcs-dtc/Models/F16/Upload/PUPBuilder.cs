using DTC.Models.DCS;
using DTC.Models.F16.PUP;
using System.Text;

namespace DTC.Models.F16.Upload
{
	public class PUPBuilder : BaseBuilder
	{
		private F16Configuration _cfg;

		public PUPBuilder(F16Configuration cfg, IAircraftDeviceManager aircraft, StringBuilder sb) : base(aircraft, sb)
		{
			_cfg = cfg;
		}

		public override void Build()
		{

            var vrp_page = _cfg.PUP.VRP_PAGE;
            var pup_page = _cfg.PUP.PUP_PAGE;
            var oa1_page = _cfg.PUP.OA1_PAGE;
            var oa2_page = _cfg.PUP.OA2_PAGE;
            var strptref = _cfg.PUP.SteerPointRef;
            var wpts = _cfg.Waypoints.Waypoints;
			var wptStart = _cfg.Waypoints.SteerpointStart;
			var wptEnd = _cfg.Waypoints.SteerpointEnd;

			//if ((strptref > wptEnd) || (strptref < wptStart))
			//{
			//	return;
			//}

			

			var ufc = _aircraft.GetDevice("UFC");

			AppendCommand(ufc.GetCommand("RTN"));
			AppendCommand(ufc.GetCommand("RTN"));
			AppendCommand(ufc.GetCommand("LIST"));
            AppendCommand(ufc.GetCommand("9")); //VRP
            AppendCommand(ufc.GetCommand("0")); //MSEL turns it on
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, (strptref).ToString()));
            AppendCommand(ufc.GetCommand("ENTR"));
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, RemoveSeparators(vrp_page.BRG.ToString())));
            AppendCommand(ufc.GetCommand("ENTR"));
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, RemoveSeparators(vrp_page.RNG.ToString())));
            AppendCommand(ufc.GetCommand("ENTR"));
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, RemoveSeparators(vrp_page.ELEV.ToString())));
            AppendCommand(ufc.GetCommand("ENTR")); //done with VRP
            AppendCommand(ufc.GetCommand("SEQ")); //move to pup
            AppendCommand(ufc.GetCommand("UP"));
            AppendCommand(ufc.GetCommand("UP"));
            AppendCommand(ufc.GetCommand("UP"));
            AppendCommand(ufc.GetCommand("UP")); //top of page

            AppendCommand(ufc.GetCommand("0")); //MSEL turns it on
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, (strptref).ToString()));
            AppendCommand(ufc.GetCommand("ENTR"));
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, RemoveSeparators(pup_page.BRG.ToString())));
            AppendCommand(ufc.GetCommand("ENTR"));
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, RemoveSeparators(pup_page.RNG.ToString())));
            AppendCommand(ufc.GetCommand("ENTR"));
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, RemoveSeparators(pup_page.ELEV.ToString())));
            AppendCommand(ufc.GetCommand("ENTR")); //done with PUP
            AppendCommand(ufc.GetCommand("SEQ")); //move back to VRP
            AppendCommand(ufc.GetCommand("RTN"));
            AppendCommand(ufc.GetCommand("RTN"));//exit


            AppendCommand(ufc.GetCommand("LIST"));
            AppendCommand(ufc.GetCommand("1")); //dest page
            AppendCommand(ufc.GetCommand("SEQ")); //set ref pg
            AppendCommand(BuildDigits(ufc, (strptref).ToString()));
            AppendCommand(ufc.GetCommand("ENTR"));
            AppendCommand(ufc.GetCommand("SEQ")); //move to oa1 page
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, RemoveSeparators(oa1_page.RNG.ToString())));
            AppendCommand(ufc.GetCommand("ENTR"));
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, RemoveSeparators(oa1_page.BRG.ToString())));
            AppendCommand(ufc.GetCommand("ENTR"));
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, RemoveSeparators(oa1_page.ELEV.ToString())));
            AppendCommand(ufc.GetCommand("ENTR"));
            AppendCommand(ufc.GetCommand("SEQ")); //move to oa2 page
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, RemoveSeparators(oa2_page.RNG.ToString())));
            AppendCommand(ufc.GetCommand("ENTR"));
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, RemoveSeparators(oa2_page.BRG.ToString())));
            AppendCommand(ufc.GetCommand("ENTR"));
            AppendCommand(ufc.GetCommand("DOWN"));
            AppendCommand(BuildDigits(ufc, RemoveSeparators(oa2_page.ELEV.ToString())));
            AppendCommand(ufc.GetCommand("ENTR"));
            AppendCommand(ufc.GetCommand("SEQ"));
            AppendCommand(ufc.GetCommand("RTN"));
            AppendCommand(ufc.GetCommand("RTN"));//exit

		}

		private string BuildCoordinate(Device ufc, string coord)
		{
			var sb = new StringBuilder();

			var latStr = RemoveSeparators(coord.Replace(" ", ""));

			foreach (var c in latStr.ToCharArray())
			{
				if (c == 'N')
				{
					sb.Append(ufc.GetCommand("2"));
				}
				else if (c == 'S')
				{
					sb.Append(ufc.GetCommand("8"));
				}
				else if (c == 'E')
				{
					sb.Append(ufc.GetCommand("6"));
				}
				else if (c == 'W')
				{
					sb.Append(ufc.GetCommand("4"));
				}
				else
				{
					sb.Append(ufc.GetCommand(c.ToString()));
				}
			}

			return sb.ToString();
		}
	}
}
