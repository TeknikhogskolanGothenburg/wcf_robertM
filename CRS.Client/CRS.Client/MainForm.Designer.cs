using System.Windows.Forms;
//using static System.Windows.Forms;

namespace CRS.Client
{
	partial class MainForm
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
			this.GetCarById = new System.Windows.Forms.Button();
			this.lblBrand = new System.Windows.Forms.Label();
			this.lblModel = new System.Windows.Forms.Label();
			this.lblYear = new System.Windows.Forms.Label();
			this.lblRegnumber = new System.Windows.Forms.Label();
			this.txtBoxId = new System.Windows.Forms.TextBox();
			this.errorMsg = new System.Windows.Forms.Label();
			this.GetCarByRegnumber = new System.Windows.Forms.Panel();
			this.panelTitle = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelTitle2 = new System.Windows.Forms.Label();
			this.GetCarByReg = new System.Windows.Forms.Button();
			this.errorMsg2 = new System.Windows.Forms.Label();
			this.txtBoxReg = new System.Windows.Forms.TextBox();
			this.lblRegnumber2 = new System.Windows.Forms.Label();
			this.lblBrand2 = new System.Windows.Forms.Label();
			this.lblYear2 = new System.Windows.Forms.Label();
			this.lblModel2 = new System.Windows.Forms.Label();
			this.GetCarByRegnumber.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// GetCarById
			// 
			this.GetCarById.Location = new System.Drawing.Point(145, 33);
			this.GetCarById.Name = "GetCarById";
			this.GetCarById.Size = new System.Drawing.Size(81, 23);
			this.GetCarById.TabIndex = 0;
			this.GetCarById.Text = "Get Car By ID";
			this.GetCarById.UseVisualStyleBackColor = true;
			this.GetCarById.Click += new System.EventHandler(this.GetCarById_Click);
			// 
			// lblBrand
			// 
			this.lblBrand.AutoSize = true;
			this.lblBrand.Location = new System.Drawing.Point(504, 13);
			this.lblBrand.Name = "lblBrand";
			this.lblBrand.Size = new System.Drawing.Size(54, 13);
			this.lblBrand.TabIndex = 1;
			this.lblBrand.Text = "Car Brand";
			// 
			// lblModel
			// 
			this.lblModel.AutoSize = true;
			this.lblModel.Location = new System.Drawing.Point(503, 43);
			this.lblModel.Name = "lblModel";
			this.lblModel.Size = new System.Drawing.Size(55, 13);
			this.lblModel.TabIndex = 1;
			this.lblModel.Text = "Car Model";
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Location = new System.Drawing.Point(504, 69);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(48, 13);
			this.lblYear.TabIndex = 1;
			this.lblYear.Text = "Car Year";
			// 
			// lblRegnumber
			// 
			this.lblRegnumber.AutoSize = true;
			this.lblRegnumber.Location = new System.Drawing.Point(580, 43);
			this.lblRegnumber.Name = "lblRegnumber";
			this.lblRegnumber.Size = new System.Drawing.Size(81, 13);
			this.lblRegnumber.TabIndex = 1;
			this.lblRegnumber.Text = "Car Regnumber";
			// 
			// txtBoxId
			// 
			this.txtBoxId.Location = new System.Drawing.Point(17, 35);
			this.txtBoxId.Name = "txtBoxId";
			this.txtBoxId.Size = new System.Drawing.Size(122, 20);
			this.txtBoxId.TabIndex = 2;
			// 
			// errorMsg
			// 
			this.errorMsg.AutoSize = true;
			this.errorMsg.Location = new System.Drawing.Point(235, 38);
			this.errorMsg.Name = "errorMsg";
			this.errorMsg.Size = new System.Drawing.Size(0, 13);
			this.errorMsg.TabIndex = 3;
			// 
			// GetCarByRegnumber
			// 
			this.GetCarByRegnumber.Controls.Add(this.panelTitle);
			this.GetCarByRegnumber.Controls.Add(this.GetCarById);
			this.GetCarByRegnumber.Controls.Add(this.errorMsg);
			this.GetCarByRegnumber.Controls.Add(this.txtBoxId);
			this.GetCarByRegnumber.Controls.Add(this.lblRegnumber);
			this.GetCarByRegnumber.Controls.Add(this.lblBrand);
			this.GetCarByRegnumber.Controls.Add(this.lblYear);
			this.GetCarByRegnumber.Controls.Add(this.lblModel);
			this.GetCarByRegnumber.Location = new System.Drawing.Point(12, 12);
			this.GetCarByRegnumber.Name = "GetCarByRegnumber";
			this.GetCarByRegnumber.Size = new System.Drawing.Size(674, 100);
			this.GetCarByRegnumber.TabIndex = 4;
			// 
			// panelTitle
			// 
			this.panelTitle.AutoSize = true;
			this.panelTitle.Location = new System.Drawing.Point(17, 12);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(72, 13);
			this.panelTitle.TabIndex = 4;
			this.panelTitle.Text = "Get Car By ID";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panelTitle2);
			this.panel1.Controls.Add(this.GetCarByReg);
			this.panel1.Controls.Add(this.errorMsg2);
			this.panel1.Controls.Add(this.txtBoxReg);
			this.panel1.Controls.Add(this.lblRegnumber2);
			this.panel1.Controls.Add(this.lblBrand2);
			this.panel1.Controls.Add(this.lblYear2);
			this.panel1.Controls.Add(this.lblModel2);
			this.panel1.Location = new System.Drawing.Point(12, 138);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(674, 100);
			this.panel1.TabIndex = 4;
			// 
			// panelTitle2
			// 
			this.panelTitle2.AutoSize = true;
			this.panelTitle2.Location = new System.Drawing.Point(17, 12);
			this.panelTitle2.Name = "panelTitle2";
			this.panelTitle2.Size = new System.Drawing.Size(116, 13);
			this.panelTitle2.TabIndex = 4;
			this.panelTitle2.Text = "Get Car By Regnumber";
			// 
			// GetCarByReg
			// 
			this.GetCarByReg.Location = new System.Drawing.Point(145, 33);
			this.GetCarByReg.Name = "GetCarByReg";
			this.GetCarByReg.Size = new System.Drawing.Size(127, 23);
			this.GetCarByReg.TabIndex = 0;
			this.GetCarByReg.Text = "Get Car By Regnumber";
			this.GetCarByReg.UseVisualStyleBackColor = true;
			this.GetCarByReg.Click += new System.EventHandler(this.GetCarByReg_Click);
			// 
			// errorMsg2
			// 
			this.errorMsg2.AutoSize = true;
			this.errorMsg2.Location = new System.Drawing.Point(278, 38);
			this.errorMsg2.Name = "errorMsg2";
			this.errorMsg2.Size = new System.Drawing.Size(0, 13);
			this.errorMsg2.TabIndex = 3;
			// 
			// txtBoxReg
			// 
			this.txtBoxReg.Location = new System.Drawing.Point(17, 35);
			this.txtBoxReg.Name = "txtBoxReg";
			this.txtBoxReg.Size = new System.Drawing.Size(122, 20);
			this.txtBoxReg.TabIndex = 2;
			// 
			// lblRegnumber2
			// 
			this.lblRegnumber2.AutoSize = true;
			this.lblRegnumber2.Location = new System.Drawing.Point(580, 43);
			this.lblRegnumber2.Name = "lblRegnumber2";
			this.lblRegnumber2.Size = new System.Drawing.Size(81, 13);
			this.lblRegnumber2.TabIndex = 1;
			this.lblRegnumber2.Text = "Car Regnumber";
			// 
			// lblBrand2
			// 
			this.lblBrand2.AutoSize = true;
			this.lblBrand2.Location = new System.Drawing.Point(504, 13);
			this.lblBrand2.Name = "lblBrand2";
			this.lblBrand2.Size = new System.Drawing.Size(54, 13);
			this.lblBrand2.TabIndex = 1;
			this.lblBrand2.Text = "Car Brand";
			// 
			// lblYear2
			// 
			this.lblYear2.AutoSize = true;
			this.lblYear2.Location = new System.Drawing.Point(504, 69);
			this.lblYear2.Name = "lblYear2";
			this.lblYear2.Size = new System.Drawing.Size(48, 13);
			this.lblYear2.TabIndex = 1;
			this.lblYear2.Text = "Car Year";
			// 
			// lblModel2
			// 
			this.lblModel2.AutoSize = true;
			this.lblModel2.Location = new System.Drawing.Point(503, 43);
			this.lblModel2.Name = "lblModel2";
			this.lblModel2.Size = new System.Drawing.Size(55, 13);
			this.lblModel2.TabIndex = 1;
			this.lblModel2.Text = "Car Model";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.GetCarByRegnumber);
			this.Name = "MainForm";
			this.Text = "Car Rental Service";
			this.GetCarByRegnumber.ResumeLayout(false);
			this.GetCarByRegnumber.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Button GetCarById;
		private Label lblBrand;
		private Label lblModel;
		private Label lblYear;
		private Label lblRegnumber;
		private TextBox txtBoxId;
		private Label errorMsg;
		private Panel GetCarByRegnumber;
		private Label panelTitle;
		private Panel panel1;
		private Label panelTitle2;
		private Button GetCarByReg;
		private Label errorMsg2;
		private TextBox txtBoxReg;
		private Label lblRegnumber2;
		private Label lblBrand2;
		private Label lblYear2;
		private Label lblModel2;
	}
}

