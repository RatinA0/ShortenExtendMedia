namespace ShortenExtendMedia
{
	partial class wndForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wndForm));
			this.btnRun = new System.Windows.Forms.Button();
			this.gbxShorten = new System.Windows.Forms.GroupBox();
			this.cbShortenTimecode = new System.Windows.Forms.ComboBox();
			this.lblShortenLength = new System.Windows.Forms.Label();
			this.nudShorten = new System.Windows.Forms.NumericUpDown();
			this.btnHelp = new System.Windows.Forms.Button();
			this.gbxExtend = new System.Windows.Forms.GroupBox();
			this.cbExtendTimecode = new System.Windows.Forms.ComboBox();
			this.lblExtendLength = new System.Windows.Forms.Label();
			this.nudExtend = new System.Windows.Forms.NumericUpDown();
			this.gbxShorten.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudShorten)).BeginInit();
			this.gbxExtend.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudExtend)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(11, 134);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(198, 30);
			this.btnRun.TabIndex = 3;
			this.btnRun.Text = "Run";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// gbxShorten
			// 
			this.gbxShorten.Controls.Add(this.cbShortenTimecode);
			this.gbxShorten.Controls.Add(this.lblShortenLength);
			this.gbxShorten.Controls.Add(this.nudShorten);
			this.gbxShorten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxShorten.Location = new System.Drawing.Point(12, 12);
			this.gbxShorten.Name = "gbxShorten";
			this.gbxShorten.Size = new System.Drawing.Size(277, 55);
			this.gbxShorten.TabIndex = 0;
			this.gbxShorten.TabStop = false;
			this.gbxShorten.Text = "Shorten settings";
			// 
			// cbShortenTimecode
			// 
			this.cbShortenTimecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.cbShortenTimecode.FormattingEnabled = true;
			this.cbShortenTimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
			this.cbShortenTimecode.Location = new System.Drawing.Point(166, 17);
			this.cbShortenTimecode.Margin = new System.Windows.Forms.Padding(4);
			this.cbShortenTimecode.Name = "cbShortenTimecode";
			this.cbShortenTimecode.Size = new System.Drawing.Size(98, 24);
			this.cbShortenTimecode.TabIndex = 1;
			this.cbShortenTimecode.Text = "Frames";
			// 
			// lblShortenLength
			// 
			this.lblShortenLength.AutoSize = true;
			this.lblShortenLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblShortenLength.Location = new System.Drawing.Point(11, 20);
			this.lblShortenLength.Name = "lblShortenLength";
			this.lblShortenLength.Size = new System.Drawing.Size(56, 17);
			this.lblShortenLength.TabIndex = 0;
			this.lblShortenLength.Text = "Length:";
			// 
			// nudShorten
			// 
			this.nudShorten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudShorten.Location = new System.Drawing.Point(73, 18);
			this.nudShorten.Name = "nudShorten";
			this.nudShorten.Size = new System.Drawing.Size(86, 23);
			this.nudShorten.TabIndex = 0;
			// 
			// btnHelp
			// 
			this.btnHelp.Location = new System.Drawing.Point(215, 134);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(75, 30);
			this.btnHelp.TabIndex = 4;
			this.btnHelp.Text = "help";
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// gbxExtend
			// 
			this.gbxExtend.Controls.Add(this.cbExtendTimecode);
			this.gbxExtend.Controls.Add(this.lblExtendLength);
			this.gbxExtend.Controls.Add(this.nudExtend);
			this.gbxExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxExtend.Location = new System.Drawing.Point(12, 73);
			this.gbxExtend.Name = "gbxExtend";
			this.gbxExtend.Size = new System.Drawing.Size(277, 55);
			this.gbxExtend.TabIndex = 2;
			this.gbxExtend.TabStop = false;
			this.gbxExtend.Text = "Extend settings";
			// 
			// cbExtendTimecode
			// 
			this.cbExtendTimecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.cbExtendTimecode.FormattingEnabled = true;
			this.cbExtendTimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
			this.cbExtendTimecode.Location = new System.Drawing.Point(166, 17);
			this.cbExtendTimecode.Margin = new System.Windows.Forms.Padding(4);
			this.cbExtendTimecode.Name = "cbExtendTimecode";
			this.cbExtendTimecode.Size = new System.Drawing.Size(98, 24);
			this.cbExtendTimecode.TabIndex = 1;
			this.cbExtendTimecode.Text = "Frames";
			// 
			// lblExtendLength
			// 
			this.lblExtendLength.AutoSize = true;
			this.lblExtendLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExtendLength.Location = new System.Drawing.Point(11, 20);
			this.lblExtendLength.Name = "lblExtendLength";
			this.lblExtendLength.Size = new System.Drawing.Size(56, 17);
			this.lblExtendLength.TabIndex = 0;
			this.lblExtendLength.Text = "Length:";
			// 
			// nudExtend
			// 
			this.nudExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudExtend.Location = new System.Drawing.Point(73, 18);
			this.nudExtend.Name = "nudExtend";
			this.nudExtend.Size = new System.Drawing.Size(86, 23);
			this.nudExtend.TabIndex = 0;
			// 
			// wndForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(302, 176);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.gbxExtend);
			this.Controls.Add(this.gbxShorten);
			this.Controls.Add(this.btnRun);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "wndForm";
			this.Text = "Shorten/Extend media";
			this.gbxShorten.ResumeLayout(false);
			this.gbxShorten.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudShorten)).EndInit();
			this.gbxExtend.ResumeLayout(false);
			this.gbxExtend.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudExtend)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.GroupBox gbxShorten;
		private System.Windows.Forms.Label lblShortenLength;
		private System.Windows.Forms.NumericUpDown nudShorten;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.ComboBox cbShortenTimecode;
		private System.Windows.Forms.GroupBox gbxExtend;
		private System.Windows.Forms.ComboBox cbExtendTimecode;
		private System.Windows.Forms.Label lblExtendLength;
		private System.Windows.Forms.NumericUpDown nudExtend;
	}
}

