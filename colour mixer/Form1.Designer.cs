
namespace colour_mixer
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
            this.grpBoxColour1 = new System.Windows.Forms.GroupBox();
            this.rdoRed1 = new System.Windows.Forms.RadioButton();
            this.rdoGreen1 = new System.Windows.Forms.RadioButton();
            this.rdoBlue1 = new System.Windows.Forms.RadioButton();
            this.rdoRed2 = new System.Windows.Forms.RadioButton();
            this.rdoGreen2 = new System.Windows.Forms.RadioButton();
            this.rdoBlue2 = new System.Windows.Forms.RadioButton();
            this.lblColour = new System.Windows.Forms.Label();
            this.grpBoxColour2 = new System.Windows.Forms.GroupBox();
            this.btnMix = new System.Windows.Forms.Button();
            this.btnMixFore = new System.Windows.Forms.Button();
            this.grpBoxColour1.SuspendLayout();
            this.grpBoxColour2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxColour1
            // 
            this.grpBoxColour1.Controls.Add(this.rdoBlue1);
            this.grpBoxColour1.Controls.Add(this.rdoGreen1);
            this.grpBoxColour1.Controls.Add(this.rdoRed1);
            this.grpBoxColour1.Location = new System.Drawing.Point(12, 37);
            this.grpBoxColour1.Name = "grpBoxColour1";
            this.grpBoxColour1.Size = new System.Drawing.Size(200, 100);
            this.grpBoxColour1.TabIndex = 0;
            this.grpBoxColour1.TabStop = false;
            this.grpBoxColour1.Text = "Choose First Colour";
            // 
            // rdoRed1
            // 
            this.rdoRed1.AutoSize = true;
            this.rdoRed1.Location = new System.Drawing.Point(6, 32);
            this.rdoRed1.Name = "rdoRed1";
            this.rdoRed1.Size = new System.Drawing.Size(45, 17);
            this.rdoRed1.TabIndex = 0;
            this.rdoRed1.TabStop = true;
            this.rdoRed1.Text = "Red";
            this.rdoRed1.UseVisualStyleBackColor = true;
            // 
            // rdoGreen1
            // 
            this.rdoGreen1.AutoSize = true;
            this.rdoGreen1.Location = new System.Drawing.Point(6, 54);
            this.rdoGreen1.Name = "rdoGreen1";
            this.rdoGreen1.Size = new System.Drawing.Size(54, 17);
            this.rdoGreen1.TabIndex = 1;
            this.rdoGreen1.TabStop = true;
            this.rdoGreen1.Text = "Green";
            this.rdoGreen1.UseVisualStyleBackColor = true;
            // 
            // rdoBlue1
            // 
            this.rdoBlue1.AutoSize = true;
            this.rdoBlue1.Location = new System.Drawing.Point(6, 77);
            this.rdoBlue1.Name = "rdoBlue1";
            this.rdoBlue1.Size = new System.Drawing.Size(46, 17);
            this.rdoBlue1.TabIndex = 2;
            this.rdoBlue1.TabStop = true;
            this.rdoBlue1.Text = "Blue";
            this.rdoBlue1.UseVisualStyleBackColor = true;
            // 
            // rdoRed2
            // 
            this.rdoRed2.AutoSize = true;
            this.rdoRed2.Location = new System.Drawing.Point(6, 32);
            this.rdoRed2.Name = "rdoRed2";
            this.rdoRed2.Size = new System.Drawing.Size(45, 17);
            this.rdoRed2.TabIndex = 3;
            this.rdoRed2.TabStop = true;
            this.rdoRed2.Text = "Red";
            this.rdoRed2.UseVisualStyleBackColor = true;
            // 
            // rdoGreen2
            // 
            this.rdoGreen2.AutoSize = true;
            this.rdoGreen2.Location = new System.Drawing.Point(6, 54);
            this.rdoGreen2.Name = "rdoGreen2";
            this.rdoGreen2.Size = new System.Drawing.Size(54, 17);
            this.rdoGreen2.TabIndex = 4;
            this.rdoGreen2.TabStop = true;
            this.rdoGreen2.Text = "Green";
            this.rdoGreen2.UseVisualStyleBackColor = true;
            // 
            // rdoBlue2
            // 
            this.rdoBlue2.AutoSize = true;
            this.rdoBlue2.Location = new System.Drawing.Point(6, 77);
            this.rdoBlue2.Name = "rdoBlue2";
            this.rdoBlue2.Size = new System.Drawing.Size(46, 17);
            this.rdoBlue2.TabIndex = 5;
            this.rdoBlue2.TabStop = true;
            this.rdoBlue2.Text = "Blue";
            this.rdoBlue2.UseVisualStyleBackColor = true;
            // 
            // lblColour
            // 
            this.lblColour.Location = new System.Drawing.Point(332, 37);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(264, 243);
            this.lblColour.TabIndex = 6;
            this.lblColour.Text = "Colour";
            this.lblColour.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpBoxColour2
            // 
            this.grpBoxColour2.Controls.Add(this.rdoRed2);
            this.grpBoxColour2.Controls.Add(this.rdoGreen2);
            this.grpBoxColour2.Controls.Add(this.rdoBlue2);
            this.grpBoxColour2.Location = new System.Drawing.Point(12, 180);
            this.grpBoxColour2.Name = "grpBoxColour2";
            this.grpBoxColour2.Size = new System.Drawing.Size(200, 100);
            this.grpBoxColour2.TabIndex = 7;
            this.grpBoxColour2.TabStop = false;
            this.grpBoxColour2.Text = "Choose Second Colour";
            // 
            // btnMix
            // 
            this.btnMix.Location = new System.Drawing.Point(18, 339);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(177, 45);
            this.btnMix.TabIndex = 8;
            this.btnMix.Text = "Background Colour";
            this.btnMix.UseVisualStyleBackColor = true;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // btnMixFore
            // 
            this.btnMixFore.Location = new System.Drawing.Point(351, 339);
            this.btnMixFore.Name = "btnMixFore";
            this.btnMixFore.Size = new System.Drawing.Size(161, 45);
            this.btnMixFore.TabIndex = 3;
            this.btnMixFore.Text = "Foreground Colour";
            this.btnMixFore.UseVisualStyleBackColor = true;
            this.btnMixFore.Click += new System.EventHandler(this.btnMixFore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMixFore);
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.grpBoxColour2);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.grpBoxColour1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxColour1.ResumeLayout(false);
            this.grpBoxColour1.PerformLayout();
            this.grpBoxColour2.ResumeLayout(false);
            this.grpBoxColour2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxColour1;
        private System.Windows.Forms.RadioButton rdoBlue1;
        private System.Windows.Forms.RadioButton rdoGreen1;
        private System.Windows.Forms.RadioButton rdoRed1;
        private System.Windows.Forms.RadioButton rdoRed2;
        private System.Windows.Forms.RadioButton rdoGreen2;
        private System.Windows.Forms.RadioButton rdoBlue2;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.GroupBox grpBoxColour2;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnMixFore;
    }
}

