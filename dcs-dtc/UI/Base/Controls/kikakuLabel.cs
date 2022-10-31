using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTC.UI.Base.Controls
{
	class kikakuLabel : Label
	{
		public static kikakuLabel MakeVerticalCentered(string label, int x, int y, int width, int height)
		{
			var lbl = Make(label, x, y, width, height);
			lbl.TextAlign = ContentAlignment.MiddleCenter;
			return lbl;
		}

		public static kikakuLabel Make(string label, int x, int y, int width, int height)
		{
			var lbl = Make(label);
			lbl.Location = new Point(x, y);
			lbl.AutoSize = false;
			lbl.Size = new Size(width, height);
			return lbl;
		}

		public static kikakuLabel Make(string label, int x, int y, System.Drawing.Color bkgd)
		{
			var lbl = Make(label);
            lbl.BackColor = bkgd;
            lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

			lbl.Location = new Point(x, y);
			return lbl;
		}

		public static kikakuLabel Make(string label)
		{
			var lbl = new kikakuLabel();
			lbl.TextAlign = ContentAlignment.TopLeft;
			lbl.Text = label;
			return lbl;
		}

		public kikakuLabel()
		{
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.AutoSize = true;
		}
	}
}
/*this.dtcLabel2.AutoSize = true;   kikakuLabel.Make("VRP",7,7
            this.dtcLabel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtcLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtcLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.dtcLabel2.Location = new System.Drawing.Point(7, 7);
            this.dtcLabel2.Name = "dtcLabel2";
            this.dtcLabel2.Size = new System.Drawing.Size(52, 24);
            this.dtcLabel2.TabIndex = 16;
            this.dtcLabel2.Text = "VRP";
*/