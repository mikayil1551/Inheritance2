namespace Inheritance2
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
            this.btnEt = new System.Windows.Forms.Button();
            this.btnSy = new System.Windows.Forms.Button();
            this.btnAs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEt
            // 
            this.btnEt.Location = new System.Drawing.Point(173, 79);
            this.btnEt.Name = "btnEt";
            this.btnEt.Size = new System.Drawing.Size(75, 23);
            this.btnEt.TabIndex = 0;
            this.btnEt.Text = "EtYemekleri";
            this.btnEt.UseVisualStyleBackColor = true;
            this.btnEt.Click += new System.EventHandler(this.txtEt_Click);
            // 
            // btnSy
            // 
            this.btnSy.Location = new System.Drawing.Point(350, 79);
            this.btnSy.Name = "btnSy";
            this.btnSy.Size = new System.Drawing.Size(75, 23);
            this.btnSy.TabIndex = 1;
            this.btnSy.Text = "SebzeYemekleri";
            this.btnSy.UseVisualStyleBackColor = true;
            this.btnSy.Click += new System.EventHandler(this.txtSy_Click);
            // 
            // btnAs
            // 
            this.btnAs.Location = new System.Drawing.Point(548, 79);
            this.btnAs.Name = "btnAs";
            this.btnAs.Size = new System.Drawing.Size(75, 23);
            this.btnAs.TabIndex = 2;
            this.btnAs.Text = "AraSicaklar";
            this.btnAs.UseVisualStyleBackColor = true;
            this.btnAs.Click += new System.EventHandler(this.btnAs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAs);
            this.Controls.Add(this.btnSy);
            this.Controls.Add(this.btnEt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEt;
        private System.Windows.Forms.Button btnSy;
        private System.Windows.Forms.Button btnAs;
    }
}

