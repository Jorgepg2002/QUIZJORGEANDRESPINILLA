
namespace QUIZ26
{
    partial class HOME
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
            this.btn = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(312, 27);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(138, 30);
            this.btn.TabIndex = 0;
            this.btn.Text = "Iniciar Quiz";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(322, 60);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(114, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "lets gets started";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(333, 353);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(94, 29);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Enviar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(343, 385);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(75, 20);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "good luck";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn);
            this.Name = "HOME";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.HOME_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbl2;
    }
}