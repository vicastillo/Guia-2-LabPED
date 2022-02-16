
namespace Ejemplo4_Guia2_LabPED
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.btnextraer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn4 = new System.Windows.Forms.TextBox();
            this.txtn5 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elementos en cola";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(236, 50);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(49, 49);
            this.txttotal.TabIndex = 1;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(372, 56);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(105, 38);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btnextraer
            // 
            this.btnextraer.Location = new System.Drawing.Point(511, 56);
            this.btnextraer.Name = "btnextraer";
            this.btnextraer.Size = new System.Drawing.Size(101, 38);
            this.btnextraer.TabIndex = 3;
            this.btnextraer.Text = "EXTRAER";
            this.btnextraer.UseVisualStyleBackColor = true;
            this.btnextraer.Click += new System.EventHandler(this.btnextraer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-50, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-50, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 49);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(-50, 150);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 49);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(-50, 150);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 49);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(-50, 150);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 49);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(300, 215);
            this.txtn1.Multiline = true;
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(49, 49);
            this.txtn1.TabIndex = 9;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(250, 215);
            this.txtn2.Multiline = true;
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(49, 49);
            this.txtn2.TabIndex = 10;
            // 
            // txtn4
            // 
            this.txtn4.Location = new System.Drawing.Point(150, 215);
            this.txtn4.Multiline = true;
            this.txtn4.Name = "txtn4";
            this.txtn4.Size = new System.Drawing.Size(49, 49);
            this.txtn4.TabIndex = 11;
            // 
            // txtn5
            // 
            this.txtn5.Location = new System.Drawing.Point(100, 215);
            this.txtn5.Multiline = true;
            this.txtn5.Name = "txtn5";
            this.txtn5.Size = new System.Drawing.Size(49, 49);
            this.txtn5.TabIndex = 12;
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(200, 215);
            this.txtn3.Multiline = true;
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(49, 49);
            this.txtn3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 300);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn5);
            this.Controls.Add(this.txtn4);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnextraer);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejemplo función de colas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btnextraer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        protected System.Windows.Forms.TextBox txtn1;
        protected System.Windows.Forms.TextBox txtn2;
        protected System.Windows.Forms.TextBox txtn4;
        protected System.Windows.Forms.TextBox txtn5;
        protected System.Windows.Forms.TextBox txtn3;
    }
}

