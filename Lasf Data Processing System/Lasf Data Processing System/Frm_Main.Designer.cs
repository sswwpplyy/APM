namespace Lasf_Data_Processing_System
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Mnu_Main = new System.Windows.Forms.MenuStrip();
            this.Mnu_MainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_MainData = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_MainDataBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu_Main
            // 
            this.Mnu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_MainFile,
            this.Mnu_MainData});
            this.Mnu_Main.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Main.Name = "Mnu_Main";
            this.Mnu_Main.Size = new System.Drawing.Size(284, 25);
            this.Mnu_Main.TabIndex = 0;
            this.Mnu_Main.Text = "menuStrip1";
            // 
            // Mnu_MainFile
            // 
            this.Mnu_MainFile.Name = "Mnu_MainFile";
            this.Mnu_MainFile.Size = new System.Drawing.Size(58, 21);
            this.Mnu_MainFile.Text = "文件(&F)";
            // 
            // Mnu_MainData
            // 
            this.Mnu_MainData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_MainDataBrowser});
            this.Mnu_MainData.Name = "Mnu_MainData";
            this.Mnu_MainData.Size = new System.Drawing.Size(61, 21);
            this.Mnu_MainData.Text = "数据(&D)";
            // 
            // Mnu_MainDataBrowser
            // 
            this.Mnu_MainDataBrowser.Name = "Mnu_MainDataBrowser";
            this.Mnu_MainDataBrowser.Size = new System.Drawing.Size(121, 22);
            this.Mnu_MainDataBrowser.Text = "浏览器...";
            this.Mnu_MainDataBrowser.Click += new System.EventHandler(this.Mnu_MainDataBrowser_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Mnu_Main);
            this.MainMenuStrip = this.Mnu_Main;
            this.Name = "Frm_Main";
            this.Text = "无人机数据处理系统";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Mnu_Main.ResumeLayout(false);
            this.Mnu_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Main;
        private System.Windows.Forms.ToolStripMenuItem Mnu_MainFile;
        private System.Windows.Forms.ToolStripMenuItem Mnu_MainData;
        private System.Windows.Forms.ToolStripMenuItem Mnu_MainDataBrowser;
    }
}

