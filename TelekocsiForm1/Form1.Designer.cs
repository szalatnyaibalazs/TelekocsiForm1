namespace TelekocsiForm1
{
    partial class frmFo
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
            this.btnBeolvasas = new System.Windows.Forms.Button();
            this.btnSecond = new System.Windows.Forms.Button();
            this.lbKimenet = new System.Windows.Forms.ListBox();
            this.btnThird = new System.Windows.Forms.Button();
            this.btnFourth = new System.Windows.Forms.Button();
            this.btnFifth = new System.Windows.Forms.Button();
            this.btnSixth = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBeolvasas
            // 
            this.btnBeolvasas.Location = new System.Drawing.Point(12, 12);
            this.btnBeolvasas.Name = "btnBeolvasas";
            this.btnBeolvasas.Size = new System.Drawing.Size(75, 23);
            this.btnBeolvasas.TabIndex = 0;
            this.btnBeolvasas.Text = "Beolvasás";
            this.btnBeolvasas.UseVisualStyleBackColor = true;
            this.btnBeolvasas.Click += new System.EventHandler(this.btnBeolvasas_Click);
            // 
            // btnSecond
            // 
            this.btnSecond.Enabled = false;
            this.btnSecond.Location = new System.Drawing.Point(12, 41);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(75, 23);
            this.btnSecond.TabIndex = 1;
            this.btnSecond.Text = "2.feladat";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // lbKimenet
            // 
            this.lbKimenet.FormattingEnabled = true;
            this.lbKimenet.Location = new System.Drawing.Point(131, 51);
            this.lbKimenet.Name = "lbKimenet";
            this.lbKimenet.Size = new System.Drawing.Size(330, 277);
            this.lbKimenet.TabIndex = 2;
            this.lbKimenet.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnThird
            // 
            this.btnThird.Enabled = false;
            this.btnThird.Location = new System.Drawing.Point(12, 70);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(75, 23);
            this.btnThird.TabIndex = 3;
            this.btnThird.Text = "3.feladat";
            this.btnThird.UseVisualStyleBackColor = true;
            this.btnThird.Click += new System.EventHandler(this.btnThird_Click);
            // 
            // btnFourth
            // 
            this.btnFourth.Enabled = false;
            this.btnFourth.Location = new System.Drawing.Point(12, 99);
            this.btnFourth.Name = "btnFourth";
            this.btnFourth.Size = new System.Drawing.Size(75, 23);
            this.btnFourth.TabIndex = 4;
            this.btnFourth.Text = "4.feladat";
            this.btnFourth.UseVisualStyleBackColor = true;
            this.btnFourth.Click += new System.EventHandler(this.btnFourth_Click);
            // 
            // btnFifth
            // 
            this.btnFifth.Enabled = false;
            this.btnFifth.Location = new System.Drawing.Point(12, 128);
            this.btnFifth.Name = "btnFifth";
            this.btnFifth.Size = new System.Drawing.Size(75, 23);
            this.btnFifth.TabIndex = 5;
            this.btnFifth.Text = "5.feladat";
            this.btnFifth.UseVisualStyleBackColor = true;
            this.btnFifth.Click += new System.EventHandler(this.btnFifth_Click);
            // 
            // btnSixth
            // 
            this.btnSixth.Enabled = false;
            this.btnSixth.Location = new System.Drawing.Point(12, 157);
            this.btnSixth.Name = "btnSixth";
            this.btnSixth.Size = new System.Drawing.Size(75, 23);
            this.btnSixth.TabIndex = 6;
            this.btnSixth.Text = "6.feladat";
            this.btnSixth.UseVisualStyleBackColor = true;
            this.btnSixth.Click += new System.EventHandler(this.btnSixth_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(497, 334);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(75, 23);
            this.btnKilepes.TabIndex = 7;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "A feladatok kimenetele";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnSixth);
            this.Controls.Add(this.btnFifth);
            this.Controls.Add(this.btnFourth);
            this.Controls.Add(this.btnThird);
            this.Controls.Add(this.lbKimenet);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnBeolvasas);
            this.Name = "frmFo";
            this.Text = "Telekocsi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeolvasas;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.ListBox lbKimenet;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.Button btnFourth;
        private System.Windows.Forms.Button btnFifth;
        private System.Windows.Forms.Button btnSixth;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Label label1;
    }
}

