
namespace DTC.UI.Aircrafts.F16
{
	partial class PUPPage
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.PUPoptClipboard = new System.Windows.Forms.RadioButton();
            this.PUPoptFile = new System.Windows.Forms.RadioButton();
            this.btnLoad = new DTC.UI.Base.Controls.DTCButton();
            this.PUPpg_title_lbl = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcGroupBox1 = new DTC.UI.Controls.DTCGroupBox();
            this.PUPoptMan = new System.Windows.Forms.RadioButton();
            this.openFileDialogPUP = new System.Windows.Forms.OpenFileDialog();
            this.PUPinvalidLBL = new DTC.UI.Base.Controls.DTCLabel();
            this.DEDEntryLBL = new DTC.UI.Base.Controls.DTCLabel();
            this.btnLoadApply = new DTC.UI.Base.Controls.DTCButton();
            this.dtcLabel16 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel32 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel31 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel30 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel29 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel28 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel27 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel26 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel25 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel24 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel23 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel22 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel21 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel20 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel19 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel18 = new DTC.UI.Base.Controls.DTCLabel();
            this.dtcLabel17 = new DTC.UI.Base.Controls.DTCLabel();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.dtcGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PUPoptClipboard
            // 
            this.PUPoptClipboard.AutoSize = true;
            this.PUPoptClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PUPoptClipboard.Location = new System.Drawing.Point(207, 19);
            this.PUPoptClipboard.Name = "PUPoptClipboard";
            this.PUPoptClipboard.Size = new System.Drawing.Size(86, 21);
            this.PUPoptClipboard.TabIndex = 10;
            this.PUPoptClipboard.TabStop = true;
            this.PUPoptClipboard.Text = "Clipboard";
            this.PUPoptClipboard.UseVisualStyleBackColor = true;
            // 
            // PUPoptFile
            // 
            this.PUPoptFile.AutoSize = true;
            this.PUPoptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PUPoptFile.Location = new System.Drawing.Point(153, 19);
            this.PUPoptFile.Name = "PUPoptFile";
            this.PUPoptFile.Size = new System.Drawing.Size(48, 21);
            this.PUPoptFile.TabIndex = 11;
            this.PUPoptFile.TabStop = true;
            this.PUPoptFile.Text = "File";
            this.PUPoptFile.UseVisualStyleBackColor = true;
            this.PUPoptFile.CheckedChanged += new System.EventHandler(this.PUPoptFile_CheckedChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLoad.Location = new System.Drawing.Point(13, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 25);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // PUPpg_title_lbl
            // 
            this.PUPpg_title_lbl.AutoSize = true;
            this.PUPpg_title_lbl.BackColor = System.Drawing.Color.PaleGreen;
            this.PUPpg_title_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PUPpg_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.PUPpg_title_lbl.Location = new System.Drawing.Point(153, 22);
            this.PUPpg_title_lbl.Name = "PUPpg_title_lbl";
            this.PUPpg_title_lbl.Size = new System.Drawing.Size(210, 27);
            this.PUPpg_title_lbl.TabIndex = 12;
            this.PUPpg_title_lbl.Text = "Pop-Up Profile Page";
            // 
            // dtcGroupBox1
            // 
            this.dtcGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.dtcGroupBox1.BorderRadius = 5;
            this.dtcGroupBox1.BorderWidth = 2;
            this.dtcGroupBox1.Controls.Add(this.PUPoptMan);
            this.dtcGroupBox1.Controls.Add(this.btnLoad);
            this.dtcGroupBox1.Controls.Add(this.PUPoptFile);
            this.dtcGroupBox1.Controls.Add(this.PUPoptClipboard);
            this.dtcGroupBox1.LabelIndent = 10;
            this.dtcGroupBox1.Location = new System.Drawing.Point(55, 63);
            this.dtcGroupBox1.Name = "dtcGroupBox1";
            this.dtcGroupBox1.Size = new System.Drawing.Size(390, 54);
            this.dtcGroupBox1.TabIndex = 13;
            this.dtcGroupBox1.TabStop = false;
            this.dtcGroupBox1.Text = "Loading Options";
            // 
            // PUPoptMan
            // 
            this.PUPoptMan.AutoSize = true;
            this.PUPoptMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PUPoptMan.Location = new System.Drawing.Point(299, 19);
            this.PUPoptMan.Name = "PUPoptMan";
            this.PUPoptMan.Size = new System.Drawing.Size(82, 21);
            this.PUPoptMan.TabIndex = 14;
            this.PUPoptMan.TabStop = true;
            this.PUPoptMan.Text = "Manually";
            this.PUPoptMan.UseVisualStyleBackColor = true;
            // 
            // openFileDialogPUP
            // 
            this.openFileDialogPUP.FileName = "some_PUP_file.pup";
            // 
            // PUPinvalidLBL
            // 
            this.PUPinvalidLBL.AutoSize = true;
            this.PUPinvalidLBL.BackColor = System.Drawing.Color.Crimson;
            this.PUPinvalidLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PUPinvalidLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.PUPinvalidLBL.ForeColor = System.Drawing.Color.Black;
            this.PUPinvalidLBL.Location = new System.Drawing.Point(19, 120);
            this.PUPinvalidLBL.Name = "PUPinvalidLBL";
            this.PUPinvalidLBL.Size = new System.Drawing.Size(151, 27);
            this.PUPinvalidLBL.TabIndex = 14;
            this.PUPinvalidLBL.Text = "Invalid Profile!";
            this.PUPinvalidLBL.Visible = false;
            // 
            // DEDEntryLBL
            // 
            this.DEDEntryLBL.AutoSize = true;
            this.DEDEntryLBL.BackColor = System.Drawing.Color.PaleGreen;
            this.DEDEntryLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DEDEntryLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.DEDEntryLBL.Location = new System.Drawing.Point(116, 141);
            this.DEDEntryLBL.Name = "DEDEntryLBL";
            this.DEDEntryLBL.Size = new System.Drawing.Size(114, 27);
            this.DEDEntryLBL.TabIndex = 15;
            this.DEDEntryLBL.Text = "DED Entry";
            // 
            // btnLoadApply
            // 
            this.btnLoadApply.BackColor = System.Drawing.Color.Gold;
            this.btnLoadApply.BackgroundImage = global::DTC.Properties.Resources.apply;
            this.btnLoadApply.Enabled = false;
            this.btnLoadApply.FlatAppearance.BorderSize = 0;
            this.btnLoadApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLoadApply.Location = new System.Drawing.Point(465, 75);
            this.btnLoadApply.Name = "btnLoadApply";
            this.btnLoadApply.Size = new System.Drawing.Size(54, 86);
            this.btnLoadApply.TabIndex = 17;
            this.btnLoadApply.Text = "Apply!";
            this.btnLoadApply.UseVisualStyleBackColor = false;
            this.btnLoadApply.Click += new System.EventHandler(this.btnLoadApply_Click_1);
            // 
            // dtcLabel16
            // 
            this.dtcLabel16.AutoSize = true;
            this.dtcLabel16.BackColor = System.Drawing.Color.Black;
            this.dtcLabel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtcLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.dtcLabel16.ForeColor = System.Drawing.Color.Lime;
            this.dtcLabel16.Location = new System.Drawing.Point(270, 144);
            this.dtcLabel16.Name = "dtcLabel16";
            this.dtcLabel16.Size = new System.Drawing.Size(116, 24);
            this.dtcLabel16.TabIndex = 18;
            this.dtcLabel16.Text = "TGT StrPt: ";
            // 
            // dtcLabel32
            // 
            this.dtcLabel32.AutoSize = true;
            this.dtcLabel32.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtcLabel32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtcLabel32.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.dtcLabel32.Location = new System.Drawing.Point(37, 183);
            this.dtcLabel32.Name = "dtcLabel32";
            this.dtcLabel32.Size = new System.Drawing.Size(52, 24);
            this.dtcLabel32.TabIndex = 41;
            this.dtcLabel32.Text = "VRP";
            // 
            // dtcLabel31
            // 
            this.dtcLabel31.AutoSize = true;
            this.dtcLabel31.BackColor = System.Drawing.Color.IndianRed;
            this.dtcLabel31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtcLabel31.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.dtcLabel31.Location = new System.Drawing.Point(37, 353);
            this.dtcLabel31.Name = "dtcLabel31";
            this.dtcLabel31.Size = new System.Drawing.Size(51, 24);
            this.dtcLabel31.TabIndex = 42;
            this.dtcLabel31.Text = "OA1";
            // 
            // dtcLabel30
            // 
            this.dtcLabel30.AutoSize = true;
            this.dtcLabel30.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dtcLabel30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtcLabel30.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.dtcLabel30.Location = new System.Drawing.Point(280, 183);
            this.dtcLabel30.Name = "dtcLabel30";
            this.dtcLabel30.Size = new System.Drawing.Size(52, 24);
            this.dtcLabel30.TabIndex = 43;
            this.dtcLabel30.Text = "PUP";
            // 
            // dtcLabel29
            // 
            this.dtcLabel29.AutoSize = true;
            this.dtcLabel29.BackColor = System.Drawing.Color.MediumPurple;
            this.dtcLabel29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtcLabel29.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.dtcLabel29.Location = new System.Drawing.Point(280, 353);
            this.dtcLabel29.Name = "dtcLabel29";
            this.dtcLabel29.Size = new System.Drawing.Size(51, 24);
            this.dtcLabel29.TabIndex = 44;
            this.dtcLabel29.Text = "OA2";
            // 
            // dtcLabel28
            // 
            this.dtcLabel28.AutoSize = true;
            this.dtcLabel28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcLabel28.Location = new System.Drawing.Point(45, 226);
            this.dtcLabel28.Name = "dtcLabel28";
            this.dtcLabel28.Size = new System.Drawing.Size(49, 18);
            this.dtcLabel28.TabIndex = 45;
            this.dtcLabel28.Text = "BRG:";
            this.dtcLabel28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtcLabel27
            // 
            this.dtcLabel27.AutoSize = true;
            this.dtcLabel27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcLabel27.Location = new System.Drawing.Point(44, 261);
            this.dtcLabel27.Name = "dtcLabel27";
            this.dtcLabel27.Size = new System.Drawing.Size(50, 18);
            this.dtcLabel27.TabIndex = 46;
            this.dtcLabel27.Text = "RNG:";
            this.dtcLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtcLabel26
            // 
            this.dtcLabel26.AutoSize = true;
            this.dtcLabel26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcLabel26.Location = new System.Drawing.Point(40, 296);
            this.dtcLabel26.Name = "dtcLabel26";
            this.dtcLabel26.Size = new System.Drawing.Size(54, 18);
            this.dtcLabel26.TabIndex = 47;
            this.dtcLabel26.Text = "ELEV:";
            this.dtcLabel26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtcLabel25
            // 
            this.dtcLabel25.AutoSize = true;
            this.dtcLabel25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcLabel25.Location = new System.Drawing.Point(295, 226);
            this.dtcLabel25.Name = "dtcLabel25";
            this.dtcLabel25.Size = new System.Drawing.Size(49, 18);
            this.dtcLabel25.TabIndex = 48;
            this.dtcLabel25.Text = "BRG:";
            this.dtcLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtcLabel24
            // 
            this.dtcLabel24.AutoSize = true;
            this.dtcLabel24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcLabel24.Location = new System.Drawing.Point(294, 261);
            this.dtcLabel24.Name = "dtcLabel24";
            this.dtcLabel24.Size = new System.Drawing.Size(50, 18);
            this.dtcLabel24.TabIndex = 49;
            this.dtcLabel24.Text = "RNG:";
            this.dtcLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtcLabel23
            // 
            this.dtcLabel23.AutoSize = true;
            this.dtcLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcLabel23.Location = new System.Drawing.Point(290, 296);
            this.dtcLabel23.Name = "dtcLabel23";
            this.dtcLabel23.Size = new System.Drawing.Size(54, 18);
            this.dtcLabel23.TabIndex = 50;
            this.dtcLabel23.Text = "ELEV:";
            this.dtcLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtcLabel22
            // 
            this.dtcLabel22.AutoSize = true;
            this.dtcLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcLabel22.Location = new System.Drawing.Point(45, 396);
            this.dtcLabel22.Name = "dtcLabel22";
            this.dtcLabel22.Size = new System.Drawing.Size(49, 18);
            this.dtcLabel22.TabIndex = 51;
            this.dtcLabel22.Text = "BRG:";
            this.dtcLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtcLabel21
            // 
            this.dtcLabel21.AutoSize = true;
            this.dtcLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcLabel21.Location = new System.Drawing.Point(44, 431);
            this.dtcLabel21.Name = "dtcLabel21";
            this.dtcLabel21.Size = new System.Drawing.Size(50, 18);
            this.dtcLabel21.TabIndex = 52;
            this.dtcLabel21.Text = "RNG:";
            this.dtcLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtcLabel20
            // 
            this.dtcLabel20.AutoSize = true;
            this.dtcLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcLabel20.Location = new System.Drawing.Point(40, 466);
            this.dtcLabel20.Name = "dtcLabel20";
            this.dtcLabel20.Size = new System.Drawing.Size(54, 18);
            this.dtcLabel20.TabIndex = 53;
            this.dtcLabel20.Text = "ELEV:";
            this.dtcLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtcLabel19
            // 
            this.dtcLabel19.AutoSize = true;
            this.dtcLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcLabel19.Location = new System.Drawing.Point(295, 396);
            this.dtcLabel19.Name = "dtcLabel19";
            this.dtcLabel19.Size = new System.Drawing.Size(49, 18);
            this.dtcLabel19.TabIndex = 54;
            this.dtcLabel19.Text = "BRG:";
            this.dtcLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtcLabel18
            // 
            this.dtcLabel18.AutoSize = true;
            this.dtcLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcLabel18.Location = new System.Drawing.Point(294, 431);
            this.dtcLabel18.Name = "dtcLabel18";
            this.dtcLabel18.Size = new System.Drawing.Size(50, 18);
            this.dtcLabel18.TabIndex = 55;
            this.dtcLabel18.Text = "RNG:";
            this.dtcLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtcLabel17
            // 
            this.dtcLabel17.AutoSize = true;
            this.dtcLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcLabel17.Location = new System.Drawing.Point(290, 466);
            this.dtcLabel17.Name = "dtcLabel17";
            this.dtcLabel17.Size = new System.Drawing.Size(54, 18);
            this.dtcLabel17.TabIndex = 56;
            this.dtcLabel17.Text = "ELEV:";
            this.dtcLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "dtc.json";
            // 
            // PUPPage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dtcLabel17);
            this.Controls.Add(this.dtcLabel18);
            this.Controls.Add(this.dtcLabel19);
            this.Controls.Add(this.dtcLabel20);
            this.Controls.Add(this.dtcLabel21);
            this.Controls.Add(this.dtcLabel22);
            this.Controls.Add(this.dtcLabel23);
            this.Controls.Add(this.dtcLabel24);
            this.Controls.Add(this.dtcLabel25);
            this.Controls.Add(this.dtcLabel26);
            this.Controls.Add(this.dtcLabel27);
            this.Controls.Add(this.dtcLabel28);
            this.Controls.Add(this.dtcLabel29);
            this.Controls.Add(this.dtcLabel30);
            this.Controls.Add(this.dtcLabel31);
            this.Controls.Add(this.dtcLabel32);
            this.Controls.Add(this.dtcLabel16);
            this.Controls.Add(this.btnLoadApply);
            this.Controls.Add(this.DEDEntryLBL);
            this.Controls.Add(this.PUPinvalidLBL);
            this.Controls.Add(this.dtcGroupBox1);
            this.Controls.Add(this.PUPpg_title_lbl);
            this.Name = "PUPPage";
            this.Size = new System.Drawing.Size(698, 548);
            this.dtcGroupBox1.ResumeLayout(false);
            this.dtcGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        
        private System.Windows.Forms.RadioButton PUPoptClipboard;
        private System.Windows.Forms.RadioButton PUPoptFile;
        private Base.Controls.DTCButton btnLoad;
        private Base.Controls.DTCLabel PUPpg_title_lbl;
        private Controls.DTCGroupBox dtcGroupBox1;
        private System.Windows.Forms.RadioButton PUPoptMan;
        private Base.Controls.DTCLabel PUPinvalidLBL;
        private Base.Controls.DTCLabel DEDEntryLBL;
        private Base.Controls.DTCButton btnLoadApply;
        private Base.Controls.DTCLabel dtcLabel16;
        private Base.Controls.DTCLabel dtcLabel32;
        private Base.Controls.DTCLabel dtcLabel31;
        private Base.Controls.DTCLabel dtcLabel30;
        private Base.Controls.DTCLabel dtcLabel29;
        private Base.Controls.DTCLabel dtcLabel28;
        private Base.Controls.DTCLabel dtcLabel27;
        private Base.Controls.DTCLabel dtcLabel26;
        private Base.Controls.DTCLabel dtcLabel25;
        private Base.Controls.DTCLabel dtcLabel24;
        private Base.Controls.DTCLabel dtcLabel23;
        private Base.Controls.DTCLabel dtcLabel22;
        private Base.Controls.DTCLabel dtcLabel21;
        private Base.Controls.DTCLabel dtcLabel20;
        private Base.Controls.DTCLabel dtcLabel19;
        private Base.Controls.DTCLabel dtcLabel18;
        private Base.Controls.DTCLabel dtcLabel17;
        private System.Windows.Forms.OpenFileDialog openFileDialogPUP;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
    }
}
