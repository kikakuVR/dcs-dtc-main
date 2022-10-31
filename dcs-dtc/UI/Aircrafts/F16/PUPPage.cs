using System;
using System.Drawing;
using System.Windows.Forms;
using DTC.Models.DCS;
using DTC.Models.F16.PUP;
using DTC.UI.Base.Controls;
using DTC.UI.CommonPages;
using System.Linq;
using DTC.Models.Base;
using DTC.Models.F16;
using System.Collections.Generic;

namespace DTC.UI.Aircrafts.F16
{
    public partial class PUPPage : AircraftSettingPage
    {
        public PUPSystem _pup;
        public PUPSystem _pupToLoad = new PUPSystem();

        public delegate void RefreshCallback();
        Point OP = new Point(19, 176);
        private List<Point> txt_loc  = new List<Point>()
        {
            new Point(390,140),
            new Point(78,45),
            new Point(78,80),
            new Point(78,115),
            new Point(328,45),
            new Point(328,80),
            new Point(328,115),
            new Point(78,215),
            new Point(78,250),
            new Point(78,285),
            new Point(328,215),
            new Point(328,250),
            new Point(328,285)
        };
        

        private int _lastTabIndex = 0;

        public PUPPage(AircraftPage parent, PUPSystem pup) : base(parent)
        {


            for (int i = 1; i<13; i++)
            {
                txt_loc[i] = new Point(txt_loc[i].X + OP.X, txt_loc[i].Y + OP.Y);
            }
            _pup = pup;
            InitializeComponent();
            this.SuspendLayout();
            this.Controls.Add(CreateSTextBox(txt_loc[0].X, txt_loc[0].Y, pup.GetSteerPoint(), (txt) =>
            {
                txt.Text = pup.SetSteerPoint(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.Controls.Add(CreateTextBox(txt_loc[1].X, txt_loc[1].Y, pup.VRP_PAGE.GetBRG(), (txt) =>
            {
                txt.Text = pup.VRP_PAGE.SetBRG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.Controls.Add(CreateTextBox(txt_loc[2].X, txt_loc[2].Y, pup.VRP_PAGE.GetRNG(), (txt) =>
            {
                txt.Text = pup.VRP_PAGE.SetRNG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.Controls.Add(CreateTextBox(txt_loc[3].X, txt_loc[3].Y, pup.VRP_PAGE.GetELEV(), (txt) =>
            {
                txt.Text = pup.VRP_PAGE.SetELEV(txt.Text);
                _parent.DataChangedCallback();
            }));

            this.Controls.Add(CreateTextBox(txt_loc[4].X, txt_loc[4].Y, pup.PUP_PAGE.GetBRG(), (txt) =>
            {
                txt.Text = pup.PUP_PAGE.SetBRG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.Controls.Add(CreateTextBox(txt_loc[5].X, txt_loc[5].Y, pup.PUP_PAGE.GetRNG(), (txt) =>
            {
                txt.Text = pup.PUP_PAGE.SetRNG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.Controls.Add(CreateTextBox(txt_loc[6].X, txt_loc[6].Y, pup.PUP_PAGE.GetELEV(), (txt) =>
            {
                txt.Text = pup.PUP_PAGE.SetELEV(txt.Text);
                _parent.DataChangedCallback();
            }));

            this.Controls.Add(CreateTextBox(txt_loc[7].X, txt_loc[7].Y, pup.OA1_PAGE.GetBRG(), (txt) =>
            {
                txt.Text = pup.OA1_PAGE.SetBRG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.Controls.Add(CreateTextBox(txt_loc[8].X, txt_loc[8].Y, pup.OA1_PAGE.GetRNG(), (txt) =>
            {
                txt.Text = pup.OA1_PAGE.SetRNG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.Controls.Add(CreateTextBox(txt_loc[9].X, txt_loc[9].Y, pup.OA1_PAGE.GetELEV(), (txt) =>
            {
                txt.Text = pup.OA1_PAGE.SetELEV(txt.Text);
                _parent.DataChangedCallback();
            }));

            this.Controls.Add(CreateTextBox(txt_loc[10].X, txt_loc[10].Y, pup.OA2_PAGE.GetBRG(), (txt) =>
            {
                txt.Text = pup.OA2_PAGE.SetBRG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.Controls.Add(CreateTextBox(txt_loc[11].X, txt_loc[11].Y, pup.OA2_PAGE.GetRNG(), (txt) =>
            {
                txt.Text = pup.OA2_PAGE.SetRNG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.Controls.Add(CreateTextBox(txt_loc[12].X, txt_loc[12].Y, pup.OA2_PAGE.GetELEV(), (txt) =>
            {
                txt.Text = pup.OA2_PAGE.SetELEV(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.ResumeLayout(false);
            PerformLayout();

            /*
             *  this.PUPEntryGB.Controls.Add(CreateTextBox(txt_loc[1].X, txt_loc[1].Y, pup.VRP_PAGE.GetBRG(), (txt) =>
            {
                txt.Text = pup.VRP_PAGE.SetBRG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.PUPEntryGB.Controls.Add(CreateTextBox(txt_loc[2].X, txt_loc[2].Y, pup.VRP_PAGE.GetRNG(), (txt) =>
            {
                txt.Text = pup.VRP_PAGE.SetRNG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.PUPEntryGB.Controls.Add(CreateTextBox(txt_loc[3].X, txt_loc[3].Y, pup.VRP_PAGE.GetELEV(), (txt) =>
            {
                txt.Text = pup.VRP_PAGE.SetELEV(txt.Text);
                _parent.DataChangedCallback();
            }));

            this.PUPEntryGB.Controls.Add(CreateTextBox(txt_loc[4].X, txt_loc[4].Y, pup.PUP_PAGE.GetBRG(), (txt) =>
            {
                txt.Text = pup.PUP_PAGE.SetBRG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.PUPEntryGB.Controls.Add(CreateTextBox(txt_loc[5].X, txt_loc[5].Y, pup.PUP_PAGE.GetRNG(), (txt) =>
            {
                txt.Text = pup.PUP_PAGE.SetRNG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.PUPEntryGB.Controls.Add(CreateTextBox(txt_loc[6].X, txt_loc[6].Y, pup.PUP_PAGE.GetELEV(), (txt) =>
            {
                txt.Text = pup.PUP_PAGE.SetELEV(txt.Text);
                _parent.DataChangedCallback();
            }));

            this.PUPEntryGB.Controls.Add(CreateTextBox(txt_loc[7].X, txt_loc[7].Y, pup.OA1_PAGE.GetBRG(), (txt) =>
            {
                txt.Text = pup.OA1_PAGE.SetBRG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.PUPEntryGB.Controls.Add(CreateTextBox(txt_loc[8].X, txt_loc[8].Y, pup.OA1_PAGE.GetRNG(), (txt) =>
            {
                txt.Text = pup.OA1_PAGE.SetRNG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.PUPEntryGB.Controls.Add(CreateTextBox(txt_loc[9].X, txt_loc[9].Y, pup.OA1_PAGE.GetELEV(), (txt) =>
            {
                txt.Text = pup.OA1_PAGE.SetELEV(txt.Text);
                _parent.DataChangedCallback();
            }));

            this.PUPEntryGB.Controls.Add(CreateTextBox(txt_loc[10].X, txt_loc[10].Y, pup.OA2_PAGE.GetBRG(), (txt) =>
            {
                txt.Text = pup.OA2_PAGE.SetBRG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.PUPEntryGB.Controls.Add(CreateTextBox(txt_loc[11].X, txt_loc[11].Y, pup.OA2_PAGE.GetRNG(), (txt) =>
            {
                txt.Text = pup.OA2_PAGE.SetRNG(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.PUPEntryGB.Controls.Add(CreateTextBox(txt_loc[12].X, txt_loc[12].Y, pup.OA2_PAGE.GetELEV(), (txt) =>
            {
                txt.Text = pup.OA2_PAGE.SetELEV(txt.Text);
                _parent.DataChangedCallback();
            }));
            this.ResumeLayout(false);
            PerformLayout();*/

        }
         
        public override string GetPageTitle()
        {
            return "PUP";
        }

        

        

        

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (PUPoptClipboard.Checked)
            {
                var txt = Clipboard.GetText();
                _pupToLoad = PUPSystem.FromCompressedString(txt);
                if (ValidatePUPProfile(_pupToLoad))
                {                   
                    this.btnLoadApply.Enabled = true;
                    PUPinvalidLBL.Visible = false;
                }
                else
                {
                    PUPinvalidLBL.Visible = true;
                }
            }
            else if (PUPoptMan.Checked)
            {
                this.btnLoadApply.Enabled = true;
                PUPinvalidLBL.Visible = false;
            }
            else
            {
                if (openFileDlg.ShowDialog() == DialogResult.OK)
                {
                    var file = FileStorage.LoadFile(openFileDlg.FileName);
                    // = 
                     PUPSystem _P = _pupToLoad.FuckJson(file);
                    if (ValidatePUPProfile(_P))
                    {                      
                        this.btnLoadApply.Enabled = true;
                        PUPinvalidLBL.Visible = false;
                    }
                    else
                    {

                        PUPinvalidLBL.Visible = true;
                    }
                    AssembleBoxesFromProfile(_P);
                 //   _pup = AssembleProfileFromBoxes();
                }
            }
        }
        private bool ValidatePUPProfile(PUPSystem _PTL)
        {
            bool val = false;
            if (_PTL != null)
            {
                if ((_PTL.VRP_PAGE != null) && (_PTL.PUP_PAGE != null) && (_PTL.OA1_PAGE != null) && (_PTL.OA2_PAGE != null))
                {
                    val = true;
                }
            }
            return val;
        }

 /*       private void btnLoadApply_Click(object sender, EventArgs e)
        {

            var pupcfg = _pupToLoad.Clone();

            _pup.CopyConfiguration(pupcfg);
            _parent.RefreshPages();
            InitializeComponent();

        }
*/

        private delegate void TextBoxChangedCallback(DTCTextBox txt);

        private void Txt_LostFocus(object sender, EventArgs e)
        {
            var txt = (DTCTextBox)sender;
            var callback = (TextBoxChangedCallback)txt.Tag;
            callback(txt);
        }

        private Control CreateTextBox(int left, int top, string value,  TextBoxChangedCallback callback)
        {
            var txt = new DTCTextBox();
            txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
            txt.Text = value;
            //txt.Mask = mask;
            txt.Tag = callback;
            txt.TabIndex = _lastTabIndex++;
            txt.LostFocus += Txt_LostFocus;
            txt.Location = new Point(left, top);
            txt.Size = new Size(115, 30);
            return txt;
        }
        private Control CreateSTextBox(int left, int top, string value, TextBoxChangedCallback callback)
        {
            var txt = new DTCTextBox();
            txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
            txt.Text = value;
            //txt.Mask = mask;
            txt.Tag = callback;
            txt.TabIndex = _lastTabIndex++;
            txt.LostFocus += Txt_LostFocus;
            txt.Location = new Point(left, top);
            txt.Size = new Size(40, 30);
            return txt;
        }

       private void PUPoptFile_CheckedChanged(object sender, EventArgs e)
        {
            _parent.DataChangedCallback(); 
        }

        private void btnLoadApply_Click_1(object sender, EventArgs e)
        {

            PUPSystem pupcfg = null;
            if (PUPoptMan.Checked)
            {
                pupcfg = AssembleProfileFromBoxes();
            }
            else
            {
               
                pupcfg = AssembleProfileFromBoxes();
            }

           // var pupcfg = _pupToLoad.Clone();

            _pup.CopyConfiguration(pupcfg);
            
            _parent.DataChangedCallback();
                _parent.RefreshPages();
            //InitializeComponent();
        }

        private PUPSystem AssembleProfileFromBoxes()
        {
            PUPSystem P = new PUPSystem();
            List<DTCTextBox> GBlist = new List<DTCTextBox>();
            foreach (DTCTextBox d in this.Controls.OfType<DTCTextBox>())
            {
                GBlist.Add(d);
            }
            P.VRP_PAGE.BRG = decimal.Parse(GBlist[1].Text);
            P.VRP_PAGE.RNG = Int32.Parse(GBlist[2].Text);
            P.VRP_PAGE.ELEV = Int32.Parse(GBlist[3].Text);

            P.PUP_PAGE.BRG = decimal.Parse(GBlist[4].Text);
            P.PUP_PAGE.RNG = Int32.Parse(GBlist[5].Text);
            P.PUP_PAGE.ELEV = Int32.Parse(GBlist[6].Text);

            P.OA1_PAGE.BRG = decimal.Parse(GBlist[7].Text);
            P.OA1_PAGE.RNG = Int32.Parse(GBlist[8].Text);
            P.OA1_PAGE.ELEV = Int32.Parse(GBlist[9].Text);

            P.OA2_PAGE.BRG = decimal.Parse(GBlist[10].Text);
            P.OA2_PAGE.RNG = Int32.Parse(GBlist[11].Text);
            P.OA2_PAGE.ELEV = Int32.Parse(GBlist[12].Text);

           // DTCTextBox SP = this.Controls.OfType<DTCTextBox>().First<DTCTextBox>();
            P.SteerPointRef = Int32.Parse(GBlist[0].Text);
            P.SetSteerPoint(GBlist[0].Text);
            return P;
        }

        private void AssembleBoxesFromProfile(PUPSystem P)
        {
             
            List<DTCTextBox> GBlist = new List<DTCTextBox>();
            foreach (DTCTextBox d in this.Controls.OfType<DTCTextBox>())
            {
                GBlist.Add(d);
            }
            GBlist[1].Text = P.VRP_PAGE.BRG.ToString("000.0");
            GBlist[2].Text = P.VRP_PAGE.RNG.ToString();
            GBlist[3].Text = P.VRP_PAGE.ELEV.ToString();
            GBlist[4].Text = P.PUP_PAGE.BRG.ToString("000.0");
            GBlist[5].Text = P.PUP_PAGE.RNG.ToString();
            GBlist[6].Text = P.PUP_PAGE.ELEV.ToString();
            GBlist[7].Text = P.OA1_PAGE.BRG.ToString("000.0");
            GBlist[8].Text = P.OA1_PAGE.RNG.ToString();
            GBlist[9].Text = P.OA1_PAGE.ELEV.ToString();
            GBlist[10].Text = P.OA2_PAGE.BRG.ToString("000.0");
            GBlist[11].Text = P.OA2_PAGE.RNG.ToString();
            GBlist[12].Text = P.OA2_PAGE.ELEV.ToString();
            GBlist[0].Text = P.GetSteerPoint();
            GBlist[1].Text = P.VRP_PAGE.BRG.ToString("000.0");


            //   DTCTextBox SP = this.Controls.OfType<DTCTextBox>().First<DTCTextBox>();
            //   SP.Text = P.SteerPointRef.ToString();

        }



        /*
private void chk_OnChange(object sender, EventArgs e)
{
var chk = ((DTCCheckBox)sender);
var program = _cms.Programs[int.Parse(chk.RelatedTo)];
program.ToBeUpdated = chk.Checked;
_parent.DataChangedCallback();
} */
    }
}
