namespace FindTheSame.WithResourcesFolder
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
            this.components = new System.ComponentModel.Container();
            this.onizlemeTimer = new System.Windows.Forms.Timer(this.components);
            this.btnBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOyunSuresi = new System.Windows.Forms.Label();
            this.oyunSuresiTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // onizlemeTimer
            // 
            this.onizlemeTimer.Interval = 250;
            this.onizlemeTimer.Tick += new System.EventHandler(this.onizlemeTimer_Tick);
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(700, 50);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(80, 23);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Oyunu Başlat";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(697, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oyun Süresi:";
            // 
            // lblOyunSuresi
            // 
            this.lblOyunSuresi.AutoSize = true;
            this.lblOyunSuresi.Location = new System.Drawing.Point(770, 96);
            this.lblOyunSuresi.Name = "lblOyunSuresi";
            this.lblOyunSuresi.Size = new System.Drawing.Size(13, 13);
            this.lblOyunSuresi.TabIndex = 2;
            this.lblOyunSuresi.Text = "0";
            // 
            // oyunSuresiTimer
            // 
            this.oyunSuresiTimer.Interval = 1000;
            this.oyunSuresiTimer.Tick += new System.EventHandler(this.oyunSuresiTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 661);
            this.Controls.Add(this.lblOyunSuresi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBasla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer onizlemeTimer;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOyunSuresi;
        private System.Windows.Forms.Timer oyunSuresiTimer;
    }
}

