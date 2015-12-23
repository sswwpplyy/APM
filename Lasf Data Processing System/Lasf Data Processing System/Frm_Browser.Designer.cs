namespace Lasf_Data_Processing_System
{
    partial class Frm_Browser
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("线路1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("线路2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("线路3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("线路4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("线路", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("地图1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("地图2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("地图3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("地图4");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("地图", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Browser));
            this.Tlp_Browser = new System.Windows.Forms.TableLayoutPanel();
            this.Trv_Browser = new System.Windows.Forms.TreeView();
            this.Cht_Browser = new Steema.TeeChart.TChart();
            this.surface1 = new Steema.TeeChart.Styles.Surface();
            this.Tlp_Info = new System.Windows.Forms.TableLayoutPanel();
            this.Lst_NodeInfo = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLineX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLineY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLineDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMapX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMapY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMapZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Txt_NodeInfo = new System.Windows.Forms.TextBox();
            this.Tlp_ChartDimension = new System.Windows.Forms.TableLayoutPanel();
            this.Rdb_Chart2D = new System.Windows.Forms.RadioButton();
            this.Rdb_Chart3D = new System.Windows.Forms.RadioButton();
            this.Tlp_ChartPoint = new System.Windows.Forms.TableLayoutPanel();
            this.Lab_X = new System.Windows.Forms.Label();
            this.Lab_Y = new System.Windows.Forms.Label();
            this.Lab_Z = new System.Windows.Forms.Label();
            this.Txt_X = new System.Windows.Forms.TextBox();
            this.Txt_Y = new System.Windows.Forms.TextBox();
            this.Txt_Z = new System.Windows.Forms.TextBox();
            this.Tls_Browser = new System.Windows.Forms.ToolStrip();
            this.Tsb_DataImport = new System.Windows.Forms.ToolStripButton();
            this.Tsb_DataExport = new System.Windows.Forms.ToolStripButton();
            this.Tlp_Browser.SuspendLayout();
            this.Tlp_Info.SuspendLayout();
            this.Tlp_ChartDimension.SuspendLayout();
            this.Tlp_ChartPoint.SuspendLayout();
            this.Tls_Browser.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp_Browser
            // 
            this.Tlp_Browser.ColumnCount = 10;
            this.Tlp_Browser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.Controls.Add(this.Trv_Browser, 0, 0);
            this.Tlp_Browser.Controls.Add(this.Cht_Browser, 2, 0);
            this.Tlp_Browser.Controls.Add(this.Tlp_Info, 2, 7);
            this.Tlp_Browser.Controls.Add(this.Tlp_ChartDimension, 9, 0);
            this.Tlp_Browser.Controls.Add(this.Tlp_ChartPoint, 9, 1);
            this.Tlp_Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Browser.Location = new System.Drawing.Point(0, 25);
            this.Tlp_Browser.Name = "Tlp_Browser";
            this.Tlp_Browser.RowCount = 10;
            this.Tlp_Browser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Browser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_Browser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_Browser.Size = new System.Drawing.Size(784, 537);
            this.Tlp_Browser.TabIndex = 0;
            this.Tlp_Browser.Paint += new System.Windows.Forms.PaintEventHandler(this.Tlp_Browser_Paint);
            // 
            // Trv_Browser
            // 
            this.Tlp_Browser.SetColumnSpan(this.Trv_Browser, 2);
            this.Trv_Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Trv_Browser.Location = new System.Drawing.Point(3, 3);
            this.Trv_Browser.Name = "Trv_Browser";
            treeNode1.Name = "line1";
            treeNode1.Text = "线路1";
            treeNode2.Name = "line2";
            treeNode2.Text = "线路2";
            treeNode3.Name = "line3";
            treeNode3.Text = "线路3";
            treeNode4.Name = "line4";
            treeNode4.Text = "线路4";
            treeNode5.Name = "nodLine";
            treeNode5.Text = "线路";
            treeNode6.Name = "map1";
            treeNode6.Text = "地图1";
            treeNode7.Name = "map2";
            treeNode7.Text = "地图2";
            treeNode8.Name = "map3";
            treeNode8.Text = "地图3";
            treeNode9.Name = "map4";
            treeNode9.Text = "地图4";
            treeNode10.Name = "nodMap";
            treeNode10.Text = "地图";
            this.Trv_Browser.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10});
            this.Tlp_Browser.SetRowSpan(this.Trv_Browser, 10);
            this.Trv_Browser.Size = new System.Drawing.Size(150, 531);
            this.Trv_Browser.TabIndex = 0;
            this.Trv_Browser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Trv_Browser_AfterSelect);
            // 
            // Cht_Browser
            // 
            // 
            // 
            // 
            this.Cht_Browser.Aspect.ZOffset = 0D;
            this.Tlp_Browser.SetColumnSpan(this.Cht_Browser, 7);
            this.Cht_Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cht_Browser.Location = new System.Drawing.Point(159, 3);
            this.Cht_Browser.Name = "Cht_Browser";
            this.Tlp_Browser.SetRowSpan(this.Cht_Browser, 7);
            this.Cht_Browser.Series.Add(this.surface1);
            this.Cht_Browser.Size = new System.Drawing.Size(540, 365);
            this.Cht_Browser.TabIndex = 2;
            // 
            // surface1
            // 
            // 
            // 
            // 
            this.surface1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.surface1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.surface1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.surface1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.surface1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.surface1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.surface1.Marks.Callout.Distance = 0;
            this.surface1.Marks.Callout.Draw3D = false;
            this.surface1.Marks.Callout.Length = 10;
            this.surface1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.surface1.PaletteMin = 0D;
            this.surface1.PaletteStep = 0D;
            this.surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
            this.surface1.Title = "surface1";
            // 
            // 
            // 
            this.surface1.XValues.DataMember = "X";
            // 
            // 
            // 
            this.surface1.YValues.DataMember = "Y";
            // 
            // 
            // 
            this.surface1.ZValues.DataMember = "Z";
            // 
            // Tlp_Info
            // 
            this.Tlp_Info.ColumnCount = 1;
            this.Tlp_Browser.SetColumnSpan(this.Tlp_Info, 8);
            this.Tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_Info.Controls.Add(this.Lst_NodeInfo, 0, 1);
            this.Tlp_Info.Controls.Add(this.Txt_NodeInfo, 0, 0);
            this.Tlp_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Info.Location = new System.Drawing.Point(159, 374);
            this.Tlp_Info.Name = "Tlp_Info";
            this.Tlp_Info.RowCount = 2;
            this.Tlp_Browser.SetRowSpan(this.Tlp_Info, 3);
            this.Tlp_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Tlp_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Info.Size = new System.Drawing.Size(622, 160);
            this.Tlp_Info.TabIndex = 3;
            // 
            // Lst_NodeInfo
            // 
            this.Lst_NodeInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colLineX,
            this.colLineY,
            this.colLineDistance,
            this.colMapX,
            this.colMapY,
            this.colMapZ});
            this.Lst_NodeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lst_NodeInfo.Location = new System.Drawing.Point(3, 63);
            this.Lst_NodeInfo.Name = "Lst_NodeInfo";
            this.Lst_NodeInfo.Size = new System.Drawing.Size(616, 94);
            this.Lst_NodeInfo.TabIndex = 1;
            this.Lst_NodeInfo.UseCompatibleStateImageBehavior = false;
            this.Lst_NodeInfo.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "名称";
            this.colName.Width = 120;
            // 
            // colLineX
            // 
            this.colLineX.Text = "X";
            this.colLineX.Width = 120;
            // 
            // colLineY
            // 
            this.colLineY.Text = "Y";
            this.colLineY.Width = 120;
            // 
            // colLineDistance
            // 
            this.colLineDistance.Text = "里程";
            this.colLineDistance.Width = 120;
            // 
            // colMapX
            // 
            this.colMapX.Text = "X";
            this.colMapX.Width = 120;
            // 
            // colMapY
            // 
            this.colMapY.Text = "Y";
            this.colMapY.Width = 120;
            // 
            // colMapZ
            // 
            this.colMapZ.Text = "Z";
            this.colMapZ.Width = 120;
            // 
            // Txt_NodeInfo
            // 
            this.Txt_NodeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_NodeInfo.Location = new System.Drawing.Point(3, 3);
            this.Txt_NodeInfo.Multiline = true;
            this.Txt_NodeInfo.Name = "Txt_NodeInfo";
            this.Txt_NodeInfo.Size = new System.Drawing.Size(616, 54);
            this.Txt_NodeInfo.TabIndex = 2;
            // 
            // Tlp_ChartDimension
            // 
            this.Tlp_ChartDimension.ColumnCount = 1;
            this.Tlp_ChartDimension.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_ChartDimension.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlp_ChartDimension.Controls.Add(this.Rdb_Chart2D, 0, 0);
            this.Tlp_ChartDimension.Controls.Add(this.Rdb_Chart3D, 0, 1);
            this.Tlp_ChartDimension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_ChartDimension.Location = new System.Drawing.Point(705, 3);
            this.Tlp_ChartDimension.Name = "Tlp_ChartDimension";
            this.Tlp_ChartDimension.RowCount = 2;
            this.Tlp_ChartDimension.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_ChartDimension.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_ChartDimension.Size = new System.Drawing.Size(76, 47);
            this.Tlp_ChartDimension.TabIndex = 4;
            // 
            // Rdb_Chart2D
            // 
            this.Rdb_Chart2D.AutoSize = true;
            this.Rdb_Chart2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rdb_Chart2D.Location = new System.Drawing.Point(3, 3);
            this.Rdb_Chart2D.Name = "Rdb_Chart2D";
            this.Rdb_Chart2D.Size = new System.Drawing.Size(70, 17);
            this.Rdb_Chart2D.TabIndex = 0;
            this.Rdb_Chart2D.TabStop = true;
            this.Rdb_Chart2D.Text = "2D";
            this.Rdb_Chart2D.UseVisualStyleBackColor = true;
            // 
            // Rdb_Chart3D
            // 
            this.Rdb_Chart3D.AutoSize = true;
            this.Rdb_Chart3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rdb_Chart3D.Location = new System.Drawing.Point(3, 26);
            this.Rdb_Chart3D.Name = "Rdb_Chart3D";
            this.Rdb_Chart3D.Size = new System.Drawing.Size(70, 18);
            this.Rdb_Chart3D.TabIndex = 1;
            this.Rdb_Chart3D.TabStop = true;
            this.Rdb_Chart3D.Text = "3D";
            this.Rdb_Chart3D.UseVisualStyleBackColor = true;
            // 
            // Tlp_ChartPoint
            // 
            this.Tlp_ChartPoint.ColumnCount = 2;
            this.Tlp_ChartPoint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Tlp_ChartPoint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_ChartPoint.Controls.Add(this.Lab_X, 0, 1);
            this.Tlp_ChartPoint.Controls.Add(this.Lab_Y, 0, 2);
            this.Tlp_ChartPoint.Controls.Add(this.Lab_Z, 0, 3);
            this.Tlp_ChartPoint.Controls.Add(this.Txt_X, 1, 1);
            this.Tlp_ChartPoint.Controls.Add(this.Txt_Y, 1, 2);
            this.Tlp_ChartPoint.Controls.Add(this.Txt_Z, 1, 3);
            this.Tlp_ChartPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_ChartPoint.Location = new System.Drawing.Point(705, 56);
            this.Tlp_ChartPoint.Name = "Tlp_ChartPoint";
            this.Tlp_ChartPoint.RowCount = 4;
            this.Tlp_Browser.SetRowSpan(this.Tlp_ChartPoint, 2);
            this.Tlp_ChartPoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tlp_ChartPoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tlp_ChartPoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tlp_ChartPoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tlp_ChartPoint.Size = new System.Drawing.Size(76, 100);
            this.Tlp_ChartPoint.TabIndex = 5;
            // 
            // Lab_X
            // 
            this.Lab_X.AutoSize = true;
            this.Lab_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lab_X.Location = new System.Drawing.Point(3, 25);
            this.Lab_X.Name = "Lab_X";
            this.Lab_X.Size = new System.Drawing.Size(24, 25);
            this.Lab_X.TabIndex = 0;
            this.Lab_X.Text = "X:";
            this.Lab_X.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lab_Y
            // 
            this.Lab_Y.AutoSize = true;
            this.Lab_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lab_Y.Location = new System.Drawing.Point(3, 50);
            this.Lab_Y.Name = "Lab_Y";
            this.Lab_Y.Size = new System.Drawing.Size(24, 25);
            this.Lab_Y.TabIndex = 1;
            this.Lab_Y.Text = "Y:";
            this.Lab_Y.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lab_Z
            // 
            this.Lab_Z.AutoSize = true;
            this.Lab_Z.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lab_Z.Location = new System.Drawing.Point(3, 75);
            this.Lab_Z.Name = "Lab_Z";
            this.Lab_Z.Size = new System.Drawing.Size(24, 25);
            this.Lab_Z.TabIndex = 2;
            this.Lab_Z.Text = "Z:";
            this.Lab_Z.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_X
            // 
            this.Txt_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_X.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_X.Location = new System.Drawing.Point(33, 28);
            this.Txt_X.Name = "Txt_X";
            this.Txt_X.ReadOnly = true;
            this.Txt_X.Size = new System.Drawing.Size(40, 21);
            this.Txt_X.TabIndex = 3;
            // 
            // Txt_Y
            // 
            this.Txt_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Y.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_Y.Location = new System.Drawing.Point(33, 53);
            this.Txt_Y.Name = "Txt_Y";
            this.Txt_Y.ReadOnly = true;
            this.Txt_Y.Size = new System.Drawing.Size(40, 21);
            this.Txt_Y.TabIndex = 4;
            // 
            // Txt_Z
            // 
            this.Txt_Z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Z.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_Z.Location = new System.Drawing.Point(33, 78);
            this.Txt_Z.Name = "Txt_Z";
            this.Txt_Z.ReadOnly = true;
            this.Txt_Z.Size = new System.Drawing.Size(40, 21);
            this.Txt_Z.TabIndex = 5;
            // 
            // Tls_Browser
            // 
            this.Tls_Browser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsb_DataImport,
            this.Tsb_DataExport});
            this.Tls_Browser.Location = new System.Drawing.Point(0, 0);
            this.Tls_Browser.Name = "Tls_Browser";
            this.Tls_Browser.Size = new System.Drawing.Size(784, 25);
            this.Tls_Browser.TabIndex = 1;
            this.Tls_Browser.Text = "toolStrip1";
            // 
            // Tsb_DataImport
            // 
            this.Tsb_DataImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_DataImport.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_DataImport.Image")));
            this.Tsb_DataImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_DataImport.Name = "Tsb_DataImport";
            this.Tsb_DataImport.Size = new System.Drawing.Size(23, 22);
            this.Tsb_DataImport.Text = "导入";
            this.Tsb_DataImport.Click += new System.EventHandler(this.Tsb_DataImport_Click);
            // 
            // Tsb_DataExport
            // 
            this.Tsb_DataExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_DataExport.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_DataExport.Image")));
            this.Tsb_DataExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_DataExport.Name = "Tsb_DataExport";
            this.Tsb_DataExport.Size = new System.Drawing.Size(23, 22);
            this.Tsb_DataExport.Text = "导出";
            this.Tsb_DataExport.Click += new System.EventHandler(this.Tsb_DataExport_Click);
            // 
            // Frm_Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.Tlp_Browser);
            this.Controls.Add(this.Tls_Browser);
            this.Name = "Frm_Browser";
            this.Text = "数据浏览器";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Tlp_Browser.ResumeLayout(false);
            this.Tlp_Info.ResumeLayout(false);
            this.Tlp_Info.PerformLayout();
            this.Tlp_ChartDimension.ResumeLayout(false);
            this.Tlp_ChartDimension.PerformLayout();
            this.Tlp_ChartPoint.ResumeLayout(false);
            this.Tlp_ChartPoint.PerformLayout();
            this.Tls_Browser.ResumeLayout(false);
            this.Tls_Browser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tlp_Browser;
        private System.Windows.Forms.TreeView Trv_Browser;
        private System.Windows.Forms.ListView Lst_NodeInfo;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colLineX;
        private System.Windows.Forms.ColumnHeader colLineY;
        private System.Windows.Forms.ColumnHeader colLineDistance;
        private System.Windows.Forms.ToolStrip Tls_Browser;
        private System.Windows.Forms.ToolStripButton Tsb_DataImport;
        private System.Windows.Forms.ToolStripButton Tsb_DataExport;
        private System.Windows.Forms.ColumnHeader colMapX;
        private System.Windows.Forms.ColumnHeader colMapY;
        private System.Windows.Forms.ColumnHeader colMapZ;
        private Steema.TeeChart.TChart Cht_Browser;
        private System.Windows.Forms.TableLayoutPanel Tlp_Info;
        private System.Windows.Forms.TextBox Txt_NodeInfo;
        private System.Windows.Forms.TableLayoutPanel Tlp_ChartDimension;
        private System.Windows.Forms.TableLayoutPanel Tlp_ChartPoint;
        private System.Windows.Forms.RadioButton Rdb_Chart2D;
        private System.Windows.Forms.RadioButton Rdb_Chart3D;
        private System.Windows.Forms.Label Lab_X;
        private System.Windows.Forms.Label Lab_Y;
        private System.Windows.Forms.Label Lab_Z;
        private System.Windows.Forms.TextBox Txt_X;
        private System.Windows.Forms.TextBox Txt_Y;
        private System.Windows.Forms.TextBox Txt_Z;
        private Steema.TeeChart.Styles.Surface surface1;
    }
}