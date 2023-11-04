namespace ChessGenerator
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
            this.numericPosition = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackHorz = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoard)).BeginInit();
            this.Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHorz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.Color.SeaGreen;
            this.Setting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Setting.Controls.Add(this.numericPosition);
            this.Setting.Controls.Add(this.pictureBox2);
            this.Setting.Controls.Add(this.trackHorz);
            this.Setting.Controls.Add(this.pictureBox1);
            this.Setting.Location = new System.Drawing.Point(492, 34);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(153, 123);
            this.Setting.TabIndex = 1;
            // 
            // numericPosition
            // 
            this.numericPosition.BackColor = System.Drawing.Color.SeaGreen;
            this.numericPosition.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericPosition.Location = new System.Drawing.Point(54, 65);
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
            this.pictureBox2.Location = new System.Drawing.Point(3, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // trackHorz
            // 
            this.trackHorz.LargeChange = 1;
            this.trackHorz.Location = new System.Drawing.Point(51, 3);
            this.trackHorz.Margin = new System.Windows.Forms.Padding(0);
            this.trackHorz.Maximum = 7;
            this.trackHorz.Name = "trackHorz";
            this.trackHorz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackHorz.Size = new System.Drawing.Size(89, 45);
            this.trackHorz.TabIndex = 1;
            this.trackHorz.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
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
            // foMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(780, 630);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHorz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

