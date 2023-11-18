namespace Задачник
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Пример 1");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Пример 2");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Пример 3");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Силовые ходы", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            this.Board = new System.Windows.Forms.Panel();
            this.Area = new System.Windows.Forms.PictureBox();
            this.Comment = new System.Windows.Forms.TextBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.Board.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Area)).BeginInit();
            this.SuspendLayout();
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Board.Controls.Add(this.Area);
            this.Board.Location = new System.Drawing.Point(31, 32);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(530, 530);
            this.Board.TabIndex = 0;
            // 
            // Area
            // 
            this.Area.BackColor = System.Drawing.Color.Transparent;
            this.Area.Location = new System.Drawing.Point(25, 25);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(480, 480);
            this.Area.TabIndex = 0;
            this.Area.TabStop = false;
            // 
            // Comment
            // 
            this.Comment.BackColor = System.Drawing.Color.Wheat;
            this.Comment.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comment.Location = new System.Drawing.Point(32, 582);
            this.Comment.Multiline = true;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Size = new System.Drawing.Size(528, 193);
            this.Comment.TabIndex = 1;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.PapayaWhip;
            this.treeView.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView.Location = new System.Drawing.Point(567, 32);
            this.treeView.Name = "treeView";
            treeNode9.Name = "Nd1";
            treeNode9.Text = "Пример 1";
            treeNode10.Name = "Nd2";
            treeNode10.Text = "Пример 2";
            treeNode11.Name = "Nd3";
            treeNode11.Text = "Пример 3";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Силовые ходы";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView.Size = new System.Drawing.Size(453, 743);
            this.treeView.TabIndex = 2;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1069, 816);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Board);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задачник";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Board.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Area)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Board;
        private System.Windows.Forms.PictureBox Area;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.TreeView treeView;
    }
}

