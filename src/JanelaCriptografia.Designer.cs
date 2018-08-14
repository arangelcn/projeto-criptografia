namespace CriptografiaCifraCesar
{
    partial class JanelaCriptografia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaCriptografia));
            this.txtBoxN = new System.Windows.Forms.TextBox();
            this.txtBoxEncripyt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Encript = new System.Windows.Forms.Button();
            this.btn_Decript = new System.Windows.Forms.Button();
            this.Arquivo = new System.Windows.Forms.OpenFileDialog();
            this.bntEncArq = new System.Windows.Forms.Button();
            this.btnDecArq = new System.Windows.Forms.Button();
            this.textBoxArq = new System.Windows.Forms.TextBox();
            this.btnCarrega = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxN
            // 
            this.txtBoxN.AllowDrop = true;
            this.txtBoxN.BackColor = System.Drawing.Color.White;
            this.txtBoxN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxN.Location = new System.Drawing.Point(33, 53);
            this.txtBoxN.Multiline = true;
            this.txtBoxN.Name = "txtBoxN";
            this.txtBoxN.Size = new System.Drawing.Size(386, 177);
            this.txtBoxN.TabIndex = 0;
            // 
            // txtBoxEncripyt
            // 
            this.txtBoxEncripyt.AllowDrop = true;
            this.txtBoxEncripyt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxEncripyt.Location = new System.Drawing.Point(441, 53);
            this.txtBoxEncripyt.Multiline = true;
            this.txtBoxEncripyt.Name = "txtBoxEncripyt";
            this.txtBoxEncripyt.Size = new System.Drawing.Size(385, 177);
            this.txtBoxEncripyt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto Normal: ";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(439, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Criptografado:";
            // 
            // btn_Encript
            // 
            this.btn_Encript.AllowDrop = true;
            this.btn_Encript.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Encript.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encript.Location = new System.Drawing.Point(329, 253);
            this.btn_Encript.Name = "btn_Encript";
            this.btn_Encript.Size = new System.Drawing.Size(92, 31);
            this.btn_Encript.TabIndex = 6;
            this.btn_Encript.Text = "Encript";
            this.btn_Encript.UseVisualStyleBackColor = true;
            this.btn_Encript.Click += new System.EventHandler(this.btn_Encript_Click);
            // 
            // btn_Decript
            // 
            this.btn_Decript.AllowDrop = true;
            this.btn_Decript.BackColor = System.Drawing.Color.Maroon;
            this.btn_Decript.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Decript.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decript.ForeColor = System.Drawing.Color.Black;
            this.btn_Decript.Location = new System.Drawing.Point(441, 253);
            this.btn_Decript.Name = "btn_Decript";
            this.btn_Decript.Size = new System.Drawing.Size(92, 31);
            this.btn_Decript.TabIndex = 8;
            this.btn_Decript.Text = "Decript";
            this.btn_Decript.UseVisualStyleBackColor = false;
            this.btn_Decript.Click += new System.EventHandler(this.btn_Decript_Click);
            // 
            // Arquivo
            // 
            this.Arquivo.FileName = "openFileDialog";
            // 
            // bntEncArq
            // 
            this.bntEncArq.AllowDrop = true;
            this.bntEncArq.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bntEncArq.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEncArq.ForeColor = System.Drawing.Color.Black;
            this.bntEncArq.Location = new System.Drawing.Point(247, 445);
            this.bntEncArq.Name = "bntEncArq";
            this.bntEncArq.Size = new System.Drawing.Size(174, 31);
            this.bntEncArq.TabIndex = 10;
            this.bntEncArq.Text = "Encriptar Arquivo ";
            this.bntEncArq.UseVisualStyleBackColor = true;
            this.bntEncArq.Click += new System.EventHandler(this.bntEncArq_Click);
            // 
            // btnDecArq
            // 
            this.btnDecArq.AllowDrop = true;
            this.btnDecArq.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDecArq.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecArq.ForeColor = System.Drawing.Color.Black;
            this.btnDecArq.Location = new System.Drawing.Point(441, 445);
            this.btnDecArq.Name = "btnDecArq";
            this.btnDecArq.Size = new System.Drawing.Size(174, 31);
            this.btnDecArq.TabIndex = 11;
            this.btnDecArq.Text = "Decriptar Arquivo ";
            this.btnDecArq.UseVisualStyleBackColor = true;
            this.btnDecArq.Click += new System.EventHandler(this.btnDecArq_Click);
            // 
            // textBoxArq
            // 
            this.textBoxArq.AllowDrop = true;
            this.textBoxArq.Location = new System.Drawing.Point(33, 408);
            this.textBoxArq.Name = "textBoxArq";
            this.textBoxArq.Size = new System.Drawing.Size(793, 20);
            this.textBoxArq.TabIndex = 12;
            this.textBoxArq.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCarrega
            // 
            this.btnCarrega.AllowDrop = true;
            this.btnCarrega.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCarrega.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrega.Location = new System.Drawing.Point(366, 359);
            this.btnCarrega.Name = "btnCarrega";
            this.btnCarrega.Size = new System.Drawing.Size(133, 31);
            this.btnCarrega.TabIndex = 13;
            this.btnCarrega.Text = "Carregar Arquivo";
            this.btnCarrega.UseVisualStyleBackColor = true;
            this.btnCarrega.Click += new System.EventHandler(this.btnCarrega_Click);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(309, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Criptografe um Arquivo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // JanelaCriptografia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCarrega);
            this.Controls.Add(this.textBoxArq);
            this.Controls.Add(this.btnDecArq);
            this.Controls.Add(this.bntEncArq);
            this.Controls.Add(this.btn_Decript);
            this.Controls.Add(this.btn_Encript);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxEncripyt);
            this.Controls.Add(this.txtBoxN);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JanelaCriptografia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codificar Cifra de Cesar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxN;
        private System.Windows.Forms.TextBox txtBoxEncripyt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Encript;
        private System.Windows.Forms.Button btn_Decript;
        private System.Windows.Forms.OpenFileDialog Arquivo;
        private System.Windows.Forms.Button bntEncArq;
        private System.Windows.Forms.Button btnDecArq;
        private System.Windows.Forms.TextBox textBoxArq;
        private System.Windows.Forms.Button btnCarrega;
        private System.Windows.Forms.Label label3;
    }
}

