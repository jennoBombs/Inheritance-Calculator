namespace InheritanceCalculatorJH
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.instructionLblJH = new System.Windows.Forms.Label();
            this.amountLabelJH = new System.Windows.Forms.Label();
            this.inheritInputBoxJH = new System.Windows.Forms.TextBox();
            this.threeRadioBtnJH = new System.Windows.Forms.RadioButton();
            this.fourRadioBtnJH = new System.Windows.Forms.RadioButton();
            this.accInheritanceListBxJH = new System.Windows.Forms.ListBox();
            this.calculateBtnJH = new System.Windows.Forms.Button();
            this.clearBtnJH = new System.Windows.Forms.Button();
            this.exitBtnJH = new System.Windows.Forms.Button();
            this.welcomePictureJH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureJH)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLblJH
            // 
            this.instructionLblJH.AutoSize = true;
            this.instructionLblJH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionLblJH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLblJH.Location = new System.Drawing.Point(28, 31);
            this.instructionLblJH.Name = "instructionLblJH";
            this.instructionLblJH.Size = new System.Drawing.Size(437, 20);
            this.instructionLblJH.TabIndex = 0;
            this.instructionLblJH.Text = "Enter the amount of your inheritance and choose an inflation rate.";
            // 
            // amountLabelJH
            // 
            this.amountLabelJH.AutoSize = true;
            this.amountLabelJH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabelJH.Location = new System.Drawing.Point(36, 88);
            this.amountLabelJH.Name = "amountLabelJH";
            this.amountLabelJH.Size = new System.Drawing.Size(138, 18);
            this.amountLabelJH.TabIndex = 1;
            this.amountLabelJH.Text = "Inheritance Amount:";
            // 
            // inheritInputBoxJH
            // 
            this.inheritInputBoxJH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inheritInputBoxJH.Location = new System.Drawing.Point(201, 82);
            this.inheritInputBoxJH.Name = "inheritInputBoxJH";
            this.inheritInputBoxJH.Size = new System.Drawing.Size(100, 24);
            this.inheritInputBoxJH.TabIndex = 2;
            // 
            // threeRadioBtnJH
            // 
            this.threeRadioBtnJH.AutoSize = true;
            this.threeRadioBtnJH.Checked = true;
            this.threeRadioBtnJH.Location = new System.Drawing.Point(329, 65);
            this.threeRadioBtnJH.Name = "threeRadioBtnJH";
            this.threeRadioBtnJH.Size = new System.Drawing.Size(136, 21);
            this.threeRadioBtnJH.TabIndex = 3;
            this.threeRadioBtnJH.TabStop = true;
            this.threeRadioBtnJH.Text = "3% Inflation Rate";
            this.threeRadioBtnJH.UseVisualStyleBackColor = true;
            // 
            // fourRadioBtnJH
            // 
            this.fourRadioBtnJH.AutoSize = true;
            this.fourRadioBtnJH.Location = new System.Drawing.Point(329, 92);
            this.fourRadioBtnJH.Name = "fourRadioBtnJH";
            this.fourRadioBtnJH.Size = new System.Drawing.Size(136, 21);
            this.fourRadioBtnJH.TabIndex = 4;
            this.fourRadioBtnJH.Text = "4% Inflation Rate";
            this.fourRadioBtnJH.UseVisualStyleBackColor = true;
            // 
            // accInheritanceListBxJH
            // 
            this.accInheritanceListBxJH.FormattingEnabled = true;
            this.accInheritanceListBxJH.ItemHeight = 16;
            this.accInheritanceListBxJH.Location = new System.Drawing.Point(28, 137);
            this.accInheritanceListBxJH.Name = "accInheritanceListBxJH";
            this.accInheritanceListBxJH.Size = new System.Drawing.Size(451, 356);
            this.accInheritanceListBxJH.TabIndex = 5;
            // 
            // calculateBtnJH
            // 
            this.calculateBtnJH.Location = new System.Drawing.Point(28, 521);
            this.calculateBtnJH.Name = "calculateBtnJH";
            this.calculateBtnJH.Size = new System.Drawing.Size(114, 40);
            this.calculateBtnJH.TabIndex = 6;
            this.calculateBtnJH.Text = "Calculate";
            this.calculateBtnJH.UseVisualStyleBackColor = true;
            this.calculateBtnJH.Click += new System.EventHandler(this.calculateBtnJH_Click);
            // 
            // clearBtnJH
            // 
            this.clearBtnJH.Location = new System.Drawing.Point(201, 521);
            this.clearBtnJH.Name = "clearBtnJH";
            this.clearBtnJH.Size = new System.Drawing.Size(114, 40);
            this.clearBtnJH.TabIndex = 7;
            this.clearBtnJH.Text = "Clear";
            this.clearBtnJH.UseVisualStyleBackColor = true;
            this.clearBtnJH.Click += new System.EventHandler(this.clearBtnJH_Click);
            // 
            // exitBtnJH
            // 
            this.exitBtnJH.Location = new System.Drawing.Point(365, 521);
            this.exitBtnJH.Name = "exitBtnJH";
            this.exitBtnJH.Size = new System.Drawing.Size(114, 40);
            this.exitBtnJH.TabIndex = 8;
            this.exitBtnJH.Text = "Exit";
            this.exitBtnJH.UseVisualStyleBackColor = true;
            // 
            // welcomePictureJH
            // 
            this.welcomePictureJH.Image = ((System.Drawing.Image)(resources.GetObject("welcomePictureJH.Image")));
            this.welcomePictureJH.Location = new System.Drawing.Point(0, 0);
            this.welcomePictureJH.Name = "welcomePictureJH";
            this.welcomePictureJH.Size = new System.Drawing.Size(372, 275);
            this.welcomePictureJH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.welcomePictureJH.TabIndex = 9;
            this.welcomePictureJH.TabStop = false;
            this.welcomePictureJH.Click += new System.EventHandler(this.welcomePictureJH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 573);
            this.Controls.Add(this.welcomePictureJH);
            this.Controls.Add(this.exitBtnJH);
            this.Controls.Add(this.clearBtnJH);
            this.Controls.Add(this.calculateBtnJH);
            this.Controls.Add(this.accInheritanceListBxJH);
            this.Controls.Add(this.fourRadioBtnJH);
            this.Controls.Add(this.threeRadioBtnJH);
            this.Controls.Add(this.inheritInputBoxJH);
            this.Controls.Add(this.amountLabelJH);
            this.Controls.Add(this.instructionLblJH);
            this.Name = "Form1";
            this.Text = "Inheritance Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureJH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLblJH;
        private System.Windows.Forms.Label amountLabelJH;
        private System.Windows.Forms.TextBox inheritInputBoxJH;
        private System.Windows.Forms.RadioButton threeRadioBtnJH;
        private System.Windows.Forms.RadioButton fourRadioBtnJH;
        private System.Windows.Forms.ListBox accInheritanceListBxJH;
        private System.Windows.Forms.Button calculateBtnJH;
        private System.Windows.Forms.Button clearBtnJH;
        private System.Windows.Forms.Button exitBtnJH;
        private System.Windows.Forms.PictureBox welcomePictureJH;
    }
}

