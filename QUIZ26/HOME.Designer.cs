
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
            this.components = new System.ComponentModel.Container();
            this.btn = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.btnfecha = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.rdio2 = new System.Windows.Forms.RadioButton();
            this.rdio1 = new System.Windows.Forms.RadioButton();
            this.lst = new System.Windows.Forms.ListBox();
            this.rdio3 = new System.Windows.Forms.RadioButton();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.save = new System.Windows.Forms.Button();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn.Location = new System.Drawing.Point(328, 27);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(138, 30);
            this.btn.TabIndex = 0;
            this.btn.Text = "PEDIR CITA";
            this.btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(328, 56);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(141, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "llene la informacion";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(211, 430);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(97, 20);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "cita apartada";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(3, 79);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(68, 20);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Nombre ";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(6, 174);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(62, 20);
            this.lbl5.TabIndex = 6;
            this.lbl5.Text = "Doctor :";
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(80, 76);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(216, 27);
            this.txtb1.TabIndex = 7;
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(178, 148);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(216, 27);
            this.txtb2.TabIndex = 8;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(523, 351);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(47, 20);
            this.lblfecha.TabIndex = 10;
            this.lblfecha.Text = "Fecha";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(508, 105);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 11;
            // 
            // btnfecha
            // 
            this.btnfecha.Location = new System.Drawing.Point(523, 319);
            this.btnfecha.Name = "btnfecha";
            this.btnfecha.Size = new System.Drawing.Size(94, 29);
            this.btnfecha.TabIndex = 12;
            this.btnfecha.Text = "Seleccionar";
            this.btnfecha.UseVisualStyleBackColor = true;
            this.btnfecha.Click += new System.EventHandler(this.btnfecha_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(372, 693);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(94, 29);
            this.btnsiguiente.TabIndex = 13;
            this.btnsiguiente.Text = "guardar";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(306, 398);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(200, 29);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // rdio2
            // 
            this.rdio2.AutoSize = true;
            this.rdio2.Location = new System.Drawing.Point(34, 42);
            this.rdio2.Name = "rdio2";
            this.rdio2.Size = new System.Drawing.Size(117, 24);
            this.rdio2.TabIndex = 15;
            this.rdio2.TabStop = true;
            this.rdio2.Text = "Fabian Duran";
            this.rdio2.UseVisualStyleBackColor = true;
            this.rdio2.CheckedChanged += new System.EventHandler(this.rdio2_CheckedChanged);
            // 
            // rdio1
            // 
            this.rdio1.AutoSize = true;
            this.rdio1.Location = new System.Drawing.Point(34, 12);
            this.rdio1.Name = "rdio1";
            this.rdio1.Size = new System.Drawing.Size(108, 24);
            this.rdio1.TabIndex = 16;
            this.rdio1.TabStop = true;
            this.rdio1.Text = "Luis Payares";
            this.rdio1.UseVisualStyleBackColor = true;
            this.rdio1.CheckedChanged += new System.EventHandler(this.rdio1_CheckedChanged);
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 20;
            this.lst.Items.AddRange(new object[] {
            "Virtual",
            "Efectivo"});
            this.lst.Location = new System.Drawing.Point(6, 342);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(150, 24);
            this.lst.TabIndex = 18;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // rdio3
            // 
            this.rdio3.AutoSize = true;
            this.rdio3.Location = new System.Drawing.Point(34, 74);
            this.rdio3.Name = "rdio3";
            this.rdio3.Size = new System.Drawing.Size(126, 24);
            this.rdio3.TabIndex = 19;
            this.rdio3.TabStop = true;
            this.rdio3.Text = "Pedro Guzman";
            this.rdio3.UseVisualStyleBackColor = true;
            this.rdio3.CheckedChanged += new System.EventHandler(this.rdio3_CheckedChanged);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(137, 314);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(0, 20);
            this.lbl6.TabIndex = 20;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(6, 314);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(125, 20);
            this.lbl7.TabIndex = 21;
            this.lbl7.Text = "Metodo de pago:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cedula",
            "T.I"});
            this.comboBox1.Location = new System.Drawing.Point(0, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 28);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Text = "Documento";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(113, 151);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(0, 20);
            this.lbl9.TabIndex = 24;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleName = "rtxresults";
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(1, 492);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(797, 147);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(354, 457);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(94, 29);
            this.save.TabIndex = 28;
            this.save.Text = "button1";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // grpbox
            // 
            this.grpbox.Controls.Add(this.rdio1);
            this.grpbox.Controls.Add(this.rdio2);
            this.grpbox.Controls.Add(this.rdio3);
            this.grpbox.Location = new System.Drawing.Point(61, 197);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(266, 114);
            this.grpbox.TabIndex = 29;
            this.grpbox.TabStop = false;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(61, 174);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(0, 20);
            this.lbl10.TabIndex = 30;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(508, 76);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(203, 20);
            this.lbl11.TabIndex = 31;
            this.lbl11.Text = "Seleccione la fecha de su cita";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(6, 105);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(50, 20);
            this.lblemail.TabIndex = 32;
            this.lblemail.Text = "Email ";
            // 
            // txtb3
            // 
            this.txtb3.Location = new System.Drawing.Point(80, 109);
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(216, 27);
            this.txtb3.TabIndex = 33;
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 734);
            this.Controls.Add(this.txtb3);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.save);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnfecha);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn);
            this.Name = "HOME";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.HOME_Load);
            this.grpbox.ResumeLayout(false);
            this.grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button btnfecha;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.RadioButton rdio2;
        private System.Windows.Forms.RadioButton rdio1;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.RadioButton rdio3;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtb3;
    }
}