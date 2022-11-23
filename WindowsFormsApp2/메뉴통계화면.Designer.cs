namespace WindowsFormsApp2
{
    partial class 메뉴통계화면
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메인화면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.투표관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.투표통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(416, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(240, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "매출";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인화면ToolStripMenuItem,
            this.메뉴관리ToolStripMenuItem,
            this.투표관리ToolStripMenuItem,
            this.메뉴통계ToolStripMenuItem,
            this.투표통계ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메인화면ToolStripMenuItem
            // 
            this.메인화면ToolStripMenuItem.Name = "메인화면ToolStripMenuItem";
            this.메인화면ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.메인화면ToolStripMenuItem.Text = "메인화면";
            this.메인화면ToolStripMenuItem.Click += new System.EventHandler(this.메인화면ToolStripMenuItem_Click);
            // 
            // 메뉴관리ToolStripMenuItem
            // 
            this.메뉴관리ToolStripMenuItem.Name = "메뉴관리ToolStripMenuItem";
            this.메뉴관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.메뉴관리ToolStripMenuItem.Text = "메뉴관리";
            this.메뉴관리ToolStripMenuItem.Click += new System.EventHandler(this.메뉴관리ToolStripMenuItem_Click);
            // 
            // 투표관리ToolStripMenuItem
            // 
            this.투표관리ToolStripMenuItem.Name = "투표관리ToolStripMenuItem";
            this.투표관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.투표관리ToolStripMenuItem.Text = "투표관리";
            this.투표관리ToolStripMenuItem.Click += new System.EventHandler(this.투표관리ToolStripMenuItem_Click);
            // 
            // 메뉴통계ToolStripMenuItem
            // 
            this.메뉴통계ToolStripMenuItem.Name = "메뉴통계ToolStripMenuItem";
            this.메뉴통계ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.메뉴통계ToolStripMenuItem.Text = "메뉴통계";
            // 
            // 투표통계ToolStripMenuItem
            // 
            this.투표통계ToolStripMenuItem.Name = "투표통계ToolStripMenuItem";
            this.투표통계ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.투표통계ToolStripMenuItem.Text = "투표통계";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.둥글게_깎기;
            this.pictureBox1.Location = new System.Drawing.Point(199, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // 메뉴통계화면
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 421);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "메뉴통계화면";
            this.Text = "메뉴통계화면";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메인화면ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 투표관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 투표통계ToolStripMenuItem;
    }
}