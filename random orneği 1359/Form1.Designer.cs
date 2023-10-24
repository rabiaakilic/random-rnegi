namespace random_orneği_1359
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
            this.btnÜret = new System.Windows.Forms.Button();
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnÜret
            // 
            this.btnÜret.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnÜret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜret.Location = new System.Drawing.Point(26, 132);
            this.btnÜret.Name = "btnÜret";
            this.btnÜret.Size = new System.Drawing.Size(123, 78);
            this.btnÜret.TabIndex = 0;
            this.btnÜret.Text = "Üret";
            this.btnÜret.UseVisualStyleBackColor = false;
            this.btnÜret.Click += new System.EventHandler(this.btnÜret_Click);
            // 
            // lbNotlar
            // 
            this.lbNotlar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.ItemHeight = 24;
            this.lbNotlar.Location = new System.Drawing.Point(171, 43);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(120, 268);
            this.lbNotlar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 421);
            this.Controls.Add(this.lbNotlar);
            this.Controls.Add(this.btnÜret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnÜret;
        private System.Windows.Forms.ListBox lbNotlar;
    }
}

