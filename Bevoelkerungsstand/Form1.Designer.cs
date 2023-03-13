namespace Bevoelkerungsstand
{
    partial class Bevoelkerungstand
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FederalStates_cmb = new System.Windows.Forms.ComboBox();
            this.Years_cmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalNumber_lb = new System.Windows.Forms.Label();
            this.maleNumber_lb = new System.Windows.Forms.Label();
            this.femaleNumber_lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bundesland";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bevölkerungsstand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jahr";
            // 
            // FederalStates_cmb
            // 
            this.FederalStates_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FederalStates_cmb.FormattingEnabled = true;
            this.FederalStates_cmb.Location = new System.Drawing.Point(126, 99);
            this.FederalStates_cmb.Name = "FederalStates_cmb";
            this.FederalStates_cmb.Size = new System.Drawing.Size(193, 31);
            this.FederalStates_cmb.TabIndex = 1;
            this.FederalStates_cmb.SelectedIndexChanged += new System.EventHandler(this.FederalStates_cmb_SelectedIndexChanged);
            // 
            // Years_cmb
            // 
            this.Years_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Years_cmb.FormattingEnabled = true;
            this.Years_cmb.Location = new System.Drawing.Point(126, 136);
            this.Years_cmb.Name = "Years_cmb";
            this.Years_cmb.Size = new System.Drawing.Size(193, 31);
            this.Years_cmb.TabIndex = 2;
            this.Years_cmb.SelectedIndexChanged += new System.EventHandler(this.Years_cmb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gesamtbevölkerung:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "davon männlich:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "davon weiblich:";
            // 
            // totalNumber_lb
            // 
            this.totalNumber_lb.AutoSize = true;
            this.totalNumber_lb.Location = new System.Drawing.Point(538, 94);
            this.totalNumber_lb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalNumber_lb.Name = "totalNumber_lb";
            this.totalNumber_lb.Size = new System.Drawing.Size(20, 23);
            this.totalNumber_lb.TabIndex = 6;
            this.totalNumber_lb.Text = "0";
            // 
            // maleNumber_lb
            // 
            this.maleNumber_lb.AutoSize = true;
            this.maleNumber_lb.Location = new System.Drawing.Point(538, 127);
            this.maleNumber_lb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.maleNumber_lb.Name = "maleNumber_lb";
            this.maleNumber_lb.Size = new System.Drawing.Size(20, 23);
            this.maleNumber_lb.TabIndex = 7;
            this.maleNumber_lb.Text = "0";
            // 
            // femaleNumber_lb
            // 
            this.femaleNumber_lb.AutoSize = true;
            this.femaleNumber_lb.Location = new System.Drawing.Point(537, 155);
            this.femaleNumber_lb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.femaleNumber_lb.Name = "femaleNumber_lb";
            this.femaleNumber_lb.Size = new System.Drawing.Size(20, 23);
            this.femaleNumber_lb.TabIndex = 8;
            this.femaleNumber_lb.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(348, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 129);
            this.panel1.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-14, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(668, 10);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 11;
            // 
            // Bevoelkerungstand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 196);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.femaleNumber_lb);
            this.Controls.Add(this.maleNumber_lb);
            this.Controls.Add(this.totalNumber_lb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Years_cmb);
            this.Controls.Add(this.FederalStates_cmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Bevoelkerungstand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bevoelkerungstand";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FederalStates_cmb;
        private System.Windows.Forms.ComboBox Years_cmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalNumber_lb;
        private System.Windows.Forms.Label maleNumber_lb;
        private System.Windows.Forms.Label femaleNumber_lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
    }
}

