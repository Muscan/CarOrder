
namespace CarOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl1Car = new System.Windows.Forms.Label();
            this.lbl2Color = new System.Windows.Forms.Label();
            this.lbl3Engine = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBoxCar = new System.Windows.Forms.GroupBox();
            this.rdoBtnAudi = new System.Windows.Forms.RadioButton();
            this.rdoBtnVW = new System.Windows.Forms.RadioButton();
            this.grpBoxColor = new System.Windows.Forms.GroupBox();
            this.rdoBtnWhite = new System.Windows.Forms.RadioButton();
            this.rdoBtnRed = new System.Windows.Forms.RadioButton();
            this.grpBoxEngine = new System.Windows.Forms.GroupBox();
            this.rdoBtnBenzin = new System.Windows.Forms.RadioButton();
            this.rdoBtnDiesel = new System.Windows.Forms.RadioButton();
            this.lblResults = new System.Windows.Forms.Label();
            this.cmbBoxCity = new System.Windows.Forms.ComboBox();
            this.grpBoxCar.SuspendLayout();
            this.grpBoxColor.SuspendLayout();
            this.grpBoxEngine.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1Car
            // 
            this.lbl1Car.AutoSize = true;
            this.lbl1Car.Location = new System.Drawing.Point(12, 27);
            this.lbl1Car.Name = "lbl1Car";
            this.lbl1Car.Size = new System.Drawing.Size(31, 20);
            this.lbl1Car.TabIndex = 0;
            this.lbl1Car.Text = "Car";
            // 
            // lbl2Color
            // 
            this.lbl2Color.AutoSize = true;
            this.lbl2Color.Location = new System.Drawing.Point(365, 27);
            this.lbl2Color.Name = "lbl2Color";
            this.lbl2Color.Size = new System.Drawing.Size(45, 20);
            this.lbl2Color.TabIndex = 1;
            this.lbl2Color.Text = "Color";
            // 
            // lbl3Engine
            // 
            this.lbl3Engine.AutoSize = true;
            this.lbl3Engine.Location = new System.Drawing.Point(719, 27);
            this.lbl3Engine.Name = "lbl3Engine";
            this.lbl3Engine.Size = new System.Drawing.Size(54, 20);
            this.lbl3Engine.TabIndex = 2;
            this.lbl3Engine.Text = "Engine";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(719, 246);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 29);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(875, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpBoxCar
            // 
            this.grpBoxCar.Controls.Add(this.rdoBtnAudi);
            this.grpBoxCar.Controls.Add(this.rdoBtnVW);
            this.grpBoxCar.Location = new System.Drawing.Point(12, 80);
            this.grpBoxCar.Name = "grpBoxCar";
            this.grpBoxCar.Size = new System.Drawing.Size(250, 125);
            this.grpBoxCar.TabIndex = 6;
            this.grpBoxCar.TabStop = false;
            this.grpBoxCar.Text = "Car selection";
            // 
            // rdoBtnAudi
            // 
            this.rdoBtnAudi.AutoSize = true;
            this.rdoBtnAudi.Location = new System.Drawing.Point(6, 56);
            this.rdoBtnAudi.Name = "rdoBtnAudi";
            this.rdoBtnAudi.Size = new System.Drawing.Size(61, 24);
            this.rdoBtnAudi.TabIndex = 1;
            this.rdoBtnAudi.TabStop = true;
            this.rdoBtnAudi.Text = "Audi";
            this.rdoBtnAudi.UseVisualStyleBackColor = true;
            // 
            // rdoBtnVW
            // 
            this.rdoBtnVW.AutoSize = true;
            this.rdoBtnVW.Location = new System.Drawing.Point(6, 26);
            this.rdoBtnVW.Name = "rdoBtnVW";
            this.rdoBtnVW.Size = new System.Drawing.Size(53, 24);
            this.rdoBtnVW.TabIndex = 0;
            this.rdoBtnVW.TabStop = true;
            this.rdoBtnVW.Text = "VW";
            this.rdoBtnVW.UseVisualStyleBackColor = true;
            this.rdoBtnVW.CheckedChanged += new System.EventHandler(this.rdoBtnVW_CheckedChanged);
            // 
            // grpBoxColor
            // 
            this.grpBoxColor.Controls.Add(this.rdoBtnWhite);
            this.grpBoxColor.Controls.Add(this.rdoBtnRed);
            this.grpBoxColor.Location = new System.Drawing.Point(365, 80);
            this.grpBoxColor.Name = "grpBoxColor";
            this.grpBoxColor.Size = new System.Drawing.Size(250, 125);
            this.grpBoxColor.TabIndex = 7;
            this.grpBoxColor.TabStop = false;
            this.grpBoxColor.Text = "Color selection";
            // 
            // rdoBtnWhite
            // 
            this.rdoBtnWhite.AutoSize = true;
            this.rdoBtnWhite.Location = new System.Drawing.Point(13, 56);
            this.rdoBtnWhite.Name = "rdoBtnWhite";
            this.rdoBtnWhite.Size = new System.Drawing.Size(69, 24);
            this.rdoBtnWhite.TabIndex = 3;
            this.rdoBtnWhite.TabStop = true;
            this.rdoBtnWhite.Text = "White";
            this.rdoBtnWhite.UseVisualStyleBackColor = true;
            // 
            // rdoBtnRed
            // 
            this.rdoBtnRed.AutoSize = true;
            this.rdoBtnRed.Location = new System.Drawing.Point(13, 26);
            this.rdoBtnRed.Name = "rdoBtnRed";
            this.rdoBtnRed.Size = new System.Drawing.Size(56, 24);
            this.rdoBtnRed.TabIndex = 2;
            this.rdoBtnRed.TabStop = true;
            this.rdoBtnRed.Text = "Red";
            this.rdoBtnRed.UseVisualStyleBackColor = true;
            // 
            // grpBoxEngine
            // 
            this.grpBoxEngine.Controls.Add(this.rdoBtnBenzin);
            this.grpBoxEngine.Controls.Add(this.rdoBtnDiesel);
            this.grpBoxEngine.Location = new System.Drawing.Point(719, 80);
            this.grpBoxEngine.Name = "grpBoxEngine";
            this.grpBoxEngine.Size = new System.Drawing.Size(250, 125);
            this.grpBoxEngine.TabIndex = 7;
            this.grpBoxEngine.TabStop = false;
            this.grpBoxEngine.Text = "Engine selection";
            this.grpBoxEngine.Enter += new System.EventHandler(this.grpBoxEngine_Enter);
            // 
            // rdoBtnBenzin
            // 
            this.rdoBtnBenzin.AutoSize = true;
            this.rdoBtnBenzin.Location = new System.Drawing.Point(34, 56);
            this.rdoBtnBenzin.Name = "rdoBtnBenzin";
            this.rdoBtnBenzin.Size = new System.Drawing.Size(74, 24);
            this.rdoBtnBenzin.TabIndex = 2;
            this.rdoBtnBenzin.TabStop = true;
            this.rdoBtnBenzin.Text = "Benzin";
            this.rdoBtnBenzin.UseVisualStyleBackColor = true;
            // 
            // rdoBtnDiesel
            // 
            this.rdoBtnDiesel.AutoSize = true;
            this.rdoBtnDiesel.Location = new System.Drawing.Point(34, 26);
            this.rdoBtnDiesel.Name = "rdoBtnDiesel";
            this.rdoBtnDiesel.Size = new System.Drawing.Size(71, 24);
            this.rdoBtnDiesel.TabIndex = 1;
            this.rdoBtnDiesel.TabStop = true;
            this.rdoBtnDiesel.Text = "Diesel";
            this.rdoBtnDiesel.UseVisualStyleBackColor = true;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(342, 374);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(55, 20);
            this.lblResults.TabIndex = 8;
            this.lblResults.Text = "Results";
            this.lblResults.Visible = false;
            // 
            // cmbBoxCity
            // 
            this.cmbBoxCity.AllowDrop = true;
            this.cmbBoxCity.FormattingEnabled = true;
            this.cmbBoxCity.Items.AddRange(new object[] {
            "Cluj",
            "Iasi",
            "Brasov",
            "Arad"});
            this.cmbBoxCity.Location = new System.Drawing.Point(12, 257);
            this.cmbBoxCity.Name = "cmbBoxCity";
            this.cmbBoxCity.Size = new System.Drawing.Size(151, 28);
            this.cmbBoxCity.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(981, 568);
            this.Controls.Add(this.cmbBoxCity);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.grpBoxColor);
            this.Controls.Add(this.grpBoxEngine);
            this.Controls.Add(this.grpBoxCar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbl3Engine);
            this.Controls.Add(this.lbl2Color);
            this.Controls.Add(this.lbl1Car);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car configurator";
            this.grpBoxCar.ResumeLayout(false);
            this.grpBoxCar.PerformLayout();
            this.grpBoxColor.ResumeLayout(false);
            this.grpBoxColor.PerformLayout();
            this.grpBoxEngine.ResumeLayout(false);
            this.grpBoxEngine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1Car;
        private System.Windows.Forms.Label lbl2Color;
        private System.Windows.Forms.Label lbl3Engine;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpBoxCar;
        private System.Windows.Forms.GroupBox grpBoxColor;
        private System.Windows.Forms.GroupBox grpBoxEngine;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ComboBox cmbBoxCity;
        private System.Windows.Forms.RadioButton rdoBtnAudi;
        private System.Windows.Forms.RadioButton rdoBtnVW;
        private System.Windows.Forms.RadioButton rdoBtnWhite;
        private System.Windows.Forms.RadioButton rdoBtnRed;
        private System.Windows.Forms.RadioButton rdoBtnBenzin;
        private System.Windows.Forms.RadioButton rdoBtnDiesel;
    }
}

