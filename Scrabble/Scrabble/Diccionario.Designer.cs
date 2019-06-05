namespace Scrabble
{
    partial class Diccionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diccionario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbMinimizeWindows = new System.Windows.Forms.PictureBox();
            this.PbCloseWindows = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimizeWindows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCloseWindows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.PbMinimizeWindows);
            this.panel1.Controls.Add(this.PbCloseWindows);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 31);
            this.panel1.TabIndex = 0;
            // 
            // PbMinimizeWindows
            // 
            this.PbMinimizeWindows.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbMinimizeWindows.BackgroundImage")));
            this.PbMinimizeWindows.Location = new System.Drawing.Point(438, 3);
            this.PbMinimizeWindows.Name = "PbMinimizeWindows";
            this.PbMinimizeWindows.Size = new System.Drawing.Size(25, 25);
            this.PbMinimizeWindows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMinimizeWindows.TabIndex = 6;
            this.PbMinimizeWindows.TabStop = false;
            this.PbMinimizeWindows.Click += new System.EventHandler(this.PbMinimizeWindows_Click);
            // 
            // PbCloseWindows
            // 
            this.PbCloseWindows.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbCloseWindows.BackgroundImage")));
            this.PbCloseWindows.Location = new System.Drawing.Point(469, 2);
            this.PbCloseWindows.Name = "PbCloseWindows";
            this.PbCloseWindows.Size = new System.Drawing.Size(25, 25);
            this.PbCloseWindows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCloseWindows.TabIndex = 5;
            this.PbCloseWindows.TabStop = false;
            this.PbCloseWindows.Click += new System.EventHandler(this.PbCloseWindows_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(84, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Verificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresar palabra";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 113);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Diccionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(497, 295);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diccionario";
            this.Text = "Diccionario";
            this.Load += new System.EventHandler(this.Diccionario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimizeWindows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCloseWindows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbMinimizeWindows;
        private System.Windows.Forms.PictureBox PbCloseWindows;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}