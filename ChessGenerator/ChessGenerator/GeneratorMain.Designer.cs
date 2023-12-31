﻿namespace ChessGenerator
{
    partial class foMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foMain));
            this.panelBoard = new System.Windows.Forms.Panel();
            this.pictureBoard = new System.Windows.Forms.PictureBox();
            this.Setting = new System.Windows.Forms.Panel();
            this.checkVert = new System.Windows.Forms.CheckBox();
            this.laSquare = new System.Windows.Forms.Label();
            this.trackVert = new System.Windows.Forms.TrackBar();
            this.numericPosition = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackHorz = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureMenu = new System.Windows.Forms.PictureBox();
            this.panelBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoard)).BeginInit();
            this.Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHorz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBoard
            // 
            this.panelBoard.Controls.Add(this.pictureBoard);
            this.panelBoard.Location = new System.Drawing.Point(37, 34);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(439, 420);
            this.panelBoard.TabIndex = 0;
            // 
            // pictureBoard
            // 
            this.pictureBoard.Location = new System.Drawing.Point(43, 49);
            this.pictureBoard.Name = "pictureBoard";
            this.pictureBoard.Size = new System.Drawing.Size(331, 318);
            this.pictureBoard.TabIndex = 0;
            this.pictureBoard.TabStop = false;
            this.pictureBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoard_MouseDown);
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.Color.SeaGreen;
            this.Setting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Setting.Controls.Add(this.checkVert);
            this.Setting.Controls.Add(this.laSquare);
            this.Setting.Controls.Add(this.trackVert);
            this.Setting.Controls.Add(this.numericPosition);
            this.Setting.Controls.Add(this.pictureBox2);
            this.Setting.Controls.Add(this.trackHorz);
            this.Setting.Controls.Add(this.pictureBox1);
            this.Setting.Location = new System.Drawing.Point(492, 34);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(153, 236);
            this.Setting.TabIndex = 1;
            // 
            // checkVert
            // 
            this.checkVert.AutoSize = true;
            this.checkVert.ForeColor = System.Drawing.Color.White;
            this.checkVert.Location = new System.Drawing.Point(3, 156);
            this.checkVert.Name = "checkVert";
            this.checkVert.Size = new System.Drawing.Size(80, 17);
            this.checkVert.TabIndex = 6;
            this.checkVert.Text = "Вертикаль";
            this.checkVert.UseVisualStyleBackColor = true;
            // 
            // laSquare
            // 
            this.laSquare.AutoSize = true;
            this.laSquare.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laSquare.ForeColor = System.Drawing.Color.White;
            this.laSquare.Location = new System.Drawing.Point(64, 11);
            this.laSquare.Name = "laSquare";
            this.laSquare.Size = new System.Drawing.Size(38, 37);
            this.laSquare.TabIndex = 5;
            this.laSquare.Text = "...";
            // 
            // trackVert
            // 
            this.trackVert.LargeChange = 1;
            this.trackVert.Location = new System.Drawing.Point(3, 60);
            this.trackVert.Maximum = 7;
            this.trackVert.Name = "trackVert";
            this.trackVert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackVert.Size = new System.Drawing.Size(137, 45);
            this.trackVert.TabIndex = 4;
            this.trackVert.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackVert.Scroll += new System.EventHandler(this.trackVert_Scroll);
            // 
            // numericPosition
            // 
            this.numericPosition.BackColor = System.Drawing.Color.SeaGreen;
            this.numericPosition.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericPosition.Location = new System.Drawing.Point(54, 186);
            this.numericPosition.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericPosition.Name = "numericPosition";
            this.numericPosition.Size = new System.Drawing.Size(86, 45);
            this.numericPosition.TabIndex = 3;
            this.numericPosition.ValueChanged += new System.EventHandler(this.numericPosition_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // trackHorz
            // 
            this.trackHorz.LargeChange = 1;
            this.trackHorz.Location = new System.Drawing.Point(3, 108);
            this.trackHorz.Margin = new System.Windows.Forms.Padding(0);
            this.trackHorz.Maximum = 7;
            this.trackHorz.Name = "trackHorz";
            this.trackHorz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackHorz.Size = new System.Drawing.Size(137, 45);
            this.trackHorz.TabIndex = 1;
            this.trackHorz.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackHorz.Scroll += new System.EventHandler(this.trackHorz_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureMenu
            // 
            this.pictureMenu.Location = new System.Drawing.Point(761, 34);
            this.pictureMenu.Name = "pictureMenu";
            this.pictureMenu.Size = new System.Drawing.Size(120, 360);
            this.pictureMenu.TabIndex = 2;
            this.pictureMenu.TabStop = false;
            this.pictureMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureMenu_MouseDown);
            // 
            // foMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(950, 630);
            this.Controls.Add(this.pictureMenu);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.panelBoard);
            this.Name = "foMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoard)).EndInit();
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHorz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.PictureBox pictureBoard;
        private System.Windows.Forms.Panel Setting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackHorz;
        private System.Windows.Forms.NumericUpDown numericPosition;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackVert;
        private System.Windows.Forms.Label laSquare;
        private System.Windows.Forms.CheckBox checkVert;
        private System.Windows.Forms.PictureBox pictureMenu;
    }
}

