namespace BFRESAnimOffset
{
    partial class MainForm
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
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_Bones = new System.Windows.Forms.ListBox();
            this.groupBox_Offsets = new System.Windows.Forms.GroupBox();
            this.tlp_Offsets = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_ScaleZ = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ScaleZ = new System.Windows.Forms.Label();
            this.num_ScaleZ = new System.Windows.Forms.NumericUpDown();
            this.tlp_RotateZ = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_RotateZ = new System.Windows.Forms.Label();
            this.num_RotateZ = new System.Windows.Forms.NumericUpDown();
            this.tlp_TranslateZ = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_TranslateZ = new System.Windows.Forms.Label();
            this.num_TranslateZ = new System.Windows.Forms.NumericUpDown();
            this.tlp_ScaleY = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ScaleY = new System.Windows.Forms.Label();
            this.num_ScaleY = new System.Windows.Forms.NumericUpDown();
            this.tlp_RotateY = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_RotateY = new System.Windows.Forms.Label();
            this.num_RotateY = new System.Windows.Forms.NumericUpDown();
            this.tlp_TranslateY = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_TranslateY = new System.Windows.Forms.Label();
            this.num_TranslateY = new System.Windows.Forms.NumericUpDown();
            this.tlp_ScaleX = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ScaleX = new System.Windows.Forms.Label();
            this.num_ScaleX = new System.Windows.Forms.NumericUpDown();
            this.tlp_RotateX = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_RotateX = new System.Windows.Forms.Label();
            this.num_RotateX = new System.Windows.Forms.NumericUpDown();
            this.tlp_TranslateX = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_TranslateX = new System.Windows.Forms.Label();
            this.num_TranslateX = new System.Windows.Forms.NumericUpDown();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.chk_KeepSign = new System.Windows.Forms.CheckBox();
            this.rtb_KeyframeData = new System.Windows.Forms.RichTextBox();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp_Main.SuspendLayout();
            this.groupBox_Offsets.SuspendLayout();
            this.tlp_Offsets.SuspendLayout();
            this.tlp_ScaleZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ScaleZ)).BeginInit();
            this.tlp_RotateZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RotateZ)).BeginInit();
            this.tlp_TranslateZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TranslateZ)).BeginInit();
            this.tlp_ScaleY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ScaleY)).BeginInit();
            this.tlp_RotateY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RotateY)).BeginInit();
            this.tlp_TranslateY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TranslateY)).BeginInit();
            this.tlp_ScaleX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ScaleX)).BeginInit();
            this.tlp_RotateX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RotateX)).BeginInit();
            this.tlp_TranslateX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TranslateX)).BeginInit();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 2;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.Controls.Add(this.listBox_Bones, 0, 0);
            this.tlp_Main.Controls.Add(this.groupBox_Offsets, 1, 0);
            this.tlp_Main.Controls.Add(this.rtb_KeyframeData, 1, 1);
            this.tlp_Main.Location = new System.Drawing.Point(12, 27);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 2;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_Main.Size = new System.Drawing.Size(728, 431);
            this.tlp_Main.TabIndex = 0;
            // 
            // listBox_Bones
            // 
            this.listBox_Bones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Bones.FormattingEnabled = true;
            this.listBox_Bones.ItemHeight = 16;
            this.listBox_Bones.Location = new System.Drawing.Point(3, 3);
            this.listBox_Bones.Name = "listBox_Bones";
            this.tlp_Main.SetRowSpan(this.listBox_Bones, 2);
            this.listBox_Bones.Size = new System.Drawing.Size(358, 425);
            this.listBox_Bones.TabIndex = 0;
            this.listBox_Bones.SelectedIndexChanged += new System.EventHandler(this.SelectedBone_Changed);
            // 
            // groupBox_Offsets
            // 
            this.groupBox_Offsets.Controls.Add(this.tlp_Offsets);
            this.groupBox_Offsets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Offsets.Location = new System.Drawing.Point(367, 3);
            this.groupBox_Offsets.Name = "groupBox_Offsets";
            this.groupBox_Offsets.Size = new System.Drawing.Size(358, 295);
            this.groupBox_Offsets.TabIndex = 1;
            this.groupBox_Offsets.TabStop = false;
            this.groupBox_Offsets.Text = "Keyframe Offsets";
            // 
            // tlp_Offsets
            // 
            this.tlp_Offsets.ColumnCount = 3;
            this.tlp_Offsets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Offsets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Offsets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Offsets.Controls.Add(this.tlp_ScaleZ, 2, 2);
            this.tlp_Offsets.Controls.Add(this.tlp_RotateZ, 1, 2);
            this.tlp_Offsets.Controls.Add(this.tlp_TranslateZ, 0, 2);
            this.tlp_Offsets.Controls.Add(this.tlp_ScaleY, 2, 1);
            this.tlp_Offsets.Controls.Add(this.tlp_RotateY, 1, 1);
            this.tlp_Offsets.Controls.Add(this.tlp_TranslateY, 0, 1);
            this.tlp_Offsets.Controls.Add(this.tlp_ScaleX, 2, 0);
            this.tlp_Offsets.Controls.Add(this.tlp_RotateX, 1, 0);
            this.tlp_Offsets.Controls.Add(this.tlp_TranslateX, 0, 0);
            this.tlp_Offsets.Controls.Add(this.btn_Apply, 2, 3);
            this.tlp_Offsets.Controls.Add(this.chk_KeepSign, 1, 3);
            this.tlp_Offsets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Offsets.Location = new System.Drawing.Point(3, 18);
            this.tlp_Offsets.Name = "tlp_Offsets";
            this.tlp_Offsets.RowCount = 4;
            this.tlp_Offsets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Offsets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Offsets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Offsets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Offsets.Size = new System.Drawing.Size(352, 274);
            this.tlp_Offsets.TabIndex = 0;
            // 
            // tlp_ScaleZ
            // 
            this.tlp_ScaleZ.ColumnCount = 1;
            this.tlp_ScaleZ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScaleZ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScaleZ.Controls.Add(this.lbl_ScaleZ, 0, 0);
            this.tlp_ScaleZ.Controls.Add(this.num_ScaleZ, 0, 1);
            this.tlp_ScaleZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ScaleZ.Location = new System.Drawing.Point(237, 139);
            this.tlp_ScaleZ.Name = "tlp_ScaleZ";
            this.tlp_ScaleZ.RowCount = 2;
            this.tlp_ScaleZ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScaleZ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScaleZ.Size = new System.Drawing.Size(112, 62);
            this.tlp_ScaleZ.TabIndex = 8;
            // 
            // lbl_ScaleZ
            // 
            this.lbl_ScaleZ.AutoSize = true;
            this.lbl_ScaleZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ScaleZ.Location = new System.Drawing.Point(3, 0);
            this.lbl_ScaleZ.Name = "lbl_ScaleZ";
            this.lbl_ScaleZ.Size = new System.Drawing.Size(106, 31);
            this.lbl_ScaleZ.TabIndex = 0;
            this.lbl_ScaleZ.Text = "Z scale:";
            this.lbl_ScaleZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_ScaleZ
            // 
            this.num_ScaleZ.DecimalPlaces = 6;
            this.num_ScaleZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_ScaleZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_ScaleZ.Location = new System.Drawing.Point(3, 34);
            this.num_ScaleZ.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_ScaleZ.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.num_ScaleZ.Name = "num_ScaleZ";
            this.num_ScaleZ.Size = new System.Drawing.Size(106, 22);
            this.num_ScaleZ.TabIndex = 1;
            this.num_ScaleZ.Click += new System.EventHandler(this.ZScale_Click);
            // 
            // tlp_RotateZ
            // 
            this.tlp_RotateZ.ColumnCount = 1;
            this.tlp_RotateZ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RotateZ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RotateZ.Controls.Add(this.lbl_RotateZ, 0, 0);
            this.tlp_RotateZ.Controls.Add(this.num_RotateZ, 0, 1);
            this.tlp_RotateZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RotateZ.Location = new System.Drawing.Point(120, 139);
            this.tlp_RotateZ.Name = "tlp_RotateZ";
            this.tlp_RotateZ.RowCount = 2;
            this.tlp_RotateZ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RotateZ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RotateZ.Size = new System.Drawing.Size(111, 62);
            this.tlp_RotateZ.TabIndex = 7;
            // 
            // lbl_RotateZ
            // 
            this.lbl_RotateZ.AutoSize = true;
            this.lbl_RotateZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_RotateZ.Location = new System.Drawing.Point(3, 0);
            this.lbl_RotateZ.Name = "lbl_RotateZ";
            this.lbl_RotateZ.Size = new System.Drawing.Size(105, 31);
            this.lbl_RotateZ.TabIndex = 0;
            this.lbl_RotateZ.Text = "Z rotation:";
            this.lbl_RotateZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_RotateZ
            // 
            this.num_RotateZ.DecimalPlaces = 6;
            this.num_RotateZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_RotateZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_RotateZ.Location = new System.Drawing.Point(3, 34);
            this.num_RotateZ.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_RotateZ.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.num_RotateZ.Name = "num_RotateZ";
            this.num_RotateZ.Size = new System.Drawing.Size(105, 22);
            this.num_RotateZ.TabIndex = 1;
            this.num_RotateZ.Click += new System.EventHandler(this.ZRotation_Click);
            // 
            // tlp_TranslateZ
            // 
            this.tlp_TranslateZ.ColumnCount = 1;
            this.tlp_TranslateZ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TranslateZ.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TranslateZ.Controls.Add(this.lbl_TranslateZ, 0, 0);
            this.tlp_TranslateZ.Controls.Add(this.num_TranslateZ, 0, 1);
            this.tlp_TranslateZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TranslateZ.Location = new System.Drawing.Point(3, 139);
            this.tlp_TranslateZ.Name = "tlp_TranslateZ";
            this.tlp_TranslateZ.RowCount = 2;
            this.tlp_TranslateZ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TranslateZ.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TranslateZ.Size = new System.Drawing.Size(111, 62);
            this.tlp_TranslateZ.TabIndex = 6;
            // 
            // lbl_TranslateZ
            // 
            this.lbl_TranslateZ.AutoSize = true;
            this.lbl_TranslateZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_TranslateZ.Location = new System.Drawing.Point(3, 0);
            this.lbl_TranslateZ.Name = "lbl_TranslateZ";
            this.lbl_TranslateZ.Size = new System.Drawing.Size(105, 31);
            this.lbl_TranslateZ.TabIndex = 0;
            this.lbl_TranslateZ.Text = "Z translation:";
            this.lbl_TranslateZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_TranslateZ
            // 
            this.num_TranslateZ.DecimalPlaces = 6;
            this.num_TranslateZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_TranslateZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_TranslateZ.Location = new System.Drawing.Point(3, 34);
            this.num_TranslateZ.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_TranslateZ.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.num_TranslateZ.Name = "num_TranslateZ";
            this.num_TranslateZ.Size = new System.Drawing.Size(105, 22);
            this.num_TranslateZ.TabIndex = 1;
            this.num_TranslateZ.Click += new System.EventHandler(this.ZTranslation_Click);
            // 
            // tlp_ScaleY
            // 
            this.tlp_ScaleY.ColumnCount = 1;
            this.tlp_ScaleY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScaleY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScaleY.Controls.Add(this.lbl_ScaleY, 0, 0);
            this.tlp_ScaleY.Controls.Add(this.num_ScaleY, 0, 1);
            this.tlp_ScaleY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ScaleY.Location = new System.Drawing.Point(237, 71);
            this.tlp_ScaleY.Name = "tlp_ScaleY";
            this.tlp_ScaleY.RowCount = 2;
            this.tlp_ScaleY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScaleY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScaleY.Size = new System.Drawing.Size(112, 62);
            this.tlp_ScaleY.TabIndex = 5;
            // 
            // lbl_ScaleY
            // 
            this.lbl_ScaleY.AutoSize = true;
            this.lbl_ScaleY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ScaleY.Location = new System.Drawing.Point(3, 0);
            this.lbl_ScaleY.Name = "lbl_ScaleY";
            this.lbl_ScaleY.Size = new System.Drawing.Size(106, 31);
            this.lbl_ScaleY.TabIndex = 0;
            this.lbl_ScaleY.Text = "Y scale:";
            this.lbl_ScaleY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_ScaleY
            // 
            this.num_ScaleY.DecimalPlaces = 6;
            this.num_ScaleY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_ScaleY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_ScaleY.Location = new System.Drawing.Point(3, 34);
            this.num_ScaleY.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_ScaleY.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.num_ScaleY.Name = "num_ScaleY";
            this.num_ScaleY.Size = new System.Drawing.Size(106, 22);
            this.num_ScaleY.TabIndex = 1;
            this.num_ScaleY.Click += new System.EventHandler(this.YScale_Click);
            // 
            // tlp_RotateY
            // 
            this.tlp_RotateY.ColumnCount = 1;
            this.tlp_RotateY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RotateY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RotateY.Controls.Add(this.lbl_RotateY, 0, 0);
            this.tlp_RotateY.Controls.Add(this.num_RotateY, 0, 1);
            this.tlp_RotateY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RotateY.Location = new System.Drawing.Point(120, 71);
            this.tlp_RotateY.Name = "tlp_RotateY";
            this.tlp_RotateY.RowCount = 2;
            this.tlp_RotateY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RotateY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RotateY.Size = new System.Drawing.Size(111, 62);
            this.tlp_RotateY.TabIndex = 4;
            // 
            // lbl_RotateY
            // 
            this.lbl_RotateY.AutoSize = true;
            this.lbl_RotateY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_RotateY.Location = new System.Drawing.Point(3, 0);
            this.lbl_RotateY.Name = "lbl_RotateY";
            this.lbl_RotateY.Size = new System.Drawing.Size(105, 31);
            this.lbl_RotateY.TabIndex = 0;
            this.lbl_RotateY.Text = "Y rotation:";
            this.lbl_RotateY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_RotateY
            // 
            this.num_RotateY.DecimalPlaces = 6;
            this.num_RotateY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_RotateY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_RotateY.Location = new System.Drawing.Point(3, 34);
            this.num_RotateY.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_RotateY.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.num_RotateY.Name = "num_RotateY";
            this.num_RotateY.Size = new System.Drawing.Size(105, 22);
            this.num_RotateY.TabIndex = 1;
            this.num_RotateY.Click += new System.EventHandler(this.YRotation_Click);
            // 
            // tlp_TranslateY
            // 
            this.tlp_TranslateY.ColumnCount = 1;
            this.tlp_TranslateY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TranslateY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TranslateY.Controls.Add(this.lbl_TranslateY, 0, 0);
            this.tlp_TranslateY.Controls.Add(this.num_TranslateY, 0, 1);
            this.tlp_TranslateY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TranslateY.Location = new System.Drawing.Point(3, 71);
            this.tlp_TranslateY.Name = "tlp_TranslateY";
            this.tlp_TranslateY.RowCount = 2;
            this.tlp_TranslateY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TranslateY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TranslateY.Size = new System.Drawing.Size(111, 62);
            this.tlp_TranslateY.TabIndex = 3;
            // 
            // lbl_TranslateY
            // 
            this.lbl_TranslateY.AutoSize = true;
            this.lbl_TranslateY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_TranslateY.Location = new System.Drawing.Point(3, 0);
            this.lbl_TranslateY.Name = "lbl_TranslateY";
            this.lbl_TranslateY.Size = new System.Drawing.Size(105, 31);
            this.lbl_TranslateY.TabIndex = 0;
            this.lbl_TranslateY.Text = "Y translation:";
            this.lbl_TranslateY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_TranslateY
            // 
            this.num_TranslateY.DecimalPlaces = 6;
            this.num_TranslateY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_TranslateY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_TranslateY.Location = new System.Drawing.Point(3, 34);
            this.num_TranslateY.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_TranslateY.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.num_TranslateY.Name = "num_TranslateY";
            this.num_TranslateY.Size = new System.Drawing.Size(105, 22);
            this.num_TranslateY.TabIndex = 1;
            this.num_TranslateY.Click += new System.EventHandler(this.YTranslation_Click);
            // 
            // tlp_ScaleX
            // 
            this.tlp_ScaleX.ColumnCount = 1;
            this.tlp_ScaleX.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScaleX.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScaleX.Controls.Add(this.lbl_ScaleX, 0, 0);
            this.tlp_ScaleX.Controls.Add(this.num_ScaleX, 0, 1);
            this.tlp_ScaleX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ScaleX.Location = new System.Drawing.Point(237, 3);
            this.tlp_ScaleX.Name = "tlp_ScaleX";
            this.tlp_ScaleX.RowCount = 2;
            this.tlp_ScaleX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScaleX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ScaleX.Size = new System.Drawing.Size(112, 62);
            this.tlp_ScaleX.TabIndex = 2;
            // 
            // lbl_ScaleX
            // 
            this.lbl_ScaleX.AutoSize = true;
            this.lbl_ScaleX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ScaleX.Location = new System.Drawing.Point(3, 0);
            this.lbl_ScaleX.Name = "lbl_ScaleX";
            this.lbl_ScaleX.Size = new System.Drawing.Size(106, 31);
            this.lbl_ScaleX.TabIndex = 0;
            this.lbl_ScaleX.Text = "X scale:";
            this.lbl_ScaleX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_ScaleX
            // 
            this.num_ScaleX.DecimalPlaces = 6;
            this.num_ScaleX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_ScaleX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_ScaleX.Location = new System.Drawing.Point(3, 34);
            this.num_ScaleX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_ScaleX.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.num_ScaleX.Name = "num_ScaleX";
            this.num_ScaleX.Size = new System.Drawing.Size(106, 22);
            this.num_ScaleX.TabIndex = 1;
            this.num_ScaleX.Click += new System.EventHandler(this.XScale_Click);
            // 
            // tlp_RotateX
            // 
            this.tlp_RotateX.ColumnCount = 1;
            this.tlp_RotateX.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RotateX.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RotateX.Controls.Add(this.lbl_RotateX, 0, 0);
            this.tlp_RotateX.Controls.Add(this.num_RotateX, 0, 1);
            this.tlp_RotateX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_RotateX.Location = new System.Drawing.Point(120, 3);
            this.tlp_RotateX.Name = "tlp_RotateX";
            this.tlp_RotateX.RowCount = 2;
            this.tlp_RotateX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RotateX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_RotateX.Size = new System.Drawing.Size(111, 62);
            this.tlp_RotateX.TabIndex = 1;
            // 
            // lbl_RotateX
            // 
            this.lbl_RotateX.AutoSize = true;
            this.lbl_RotateX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_RotateX.Location = new System.Drawing.Point(3, 0);
            this.lbl_RotateX.Name = "lbl_RotateX";
            this.lbl_RotateX.Size = new System.Drawing.Size(105, 31);
            this.lbl_RotateX.TabIndex = 0;
            this.lbl_RotateX.Text = "X rotation:";
            this.lbl_RotateX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_RotateX
            // 
            this.num_RotateX.DecimalPlaces = 6;
            this.num_RotateX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_RotateX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_RotateX.Location = new System.Drawing.Point(3, 34);
            this.num_RotateX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_RotateX.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.num_RotateX.Name = "num_RotateX";
            this.num_RotateX.Size = new System.Drawing.Size(105, 22);
            this.num_RotateX.TabIndex = 1;
            this.num_RotateX.Click += new System.EventHandler(this.XRotation_Click);
            // 
            // tlp_TranslateX
            // 
            this.tlp_TranslateX.ColumnCount = 1;
            this.tlp_TranslateX.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TranslateX.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TranslateX.Controls.Add(this.lbl_TranslateX, 0, 0);
            this.tlp_TranslateX.Controls.Add(this.num_TranslateX, 0, 1);
            this.tlp_TranslateX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TranslateX.Location = new System.Drawing.Point(3, 3);
            this.tlp_TranslateX.Name = "tlp_TranslateX";
            this.tlp_TranslateX.RowCount = 2;
            this.tlp_TranslateX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TranslateX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TranslateX.Size = new System.Drawing.Size(111, 62);
            this.tlp_TranslateX.TabIndex = 0;
            // 
            // lbl_TranslateX
            // 
            this.lbl_TranslateX.AutoSize = true;
            this.lbl_TranslateX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_TranslateX.Location = new System.Drawing.Point(3, 0);
            this.lbl_TranslateX.Name = "lbl_TranslateX";
            this.lbl_TranslateX.Size = new System.Drawing.Size(105, 31);
            this.lbl_TranslateX.TabIndex = 0;
            this.lbl_TranslateX.Text = "X translation:";
            this.lbl_TranslateX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_TranslateX
            // 
            this.num_TranslateX.DecimalPlaces = 6;
            this.num_TranslateX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_TranslateX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_TranslateX.Location = new System.Drawing.Point(3, 34);
            this.num_TranslateX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_TranslateX.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.num_TranslateX.Name = "num_TranslateX";
            this.num_TranslateX.Size = new System.Drawing.Size(105, 22);
            this.num_TranslateX.TabIndex = 1;
            this.num_TranslateX.Click += new System.EventHandler(this.XTranslation_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Apply.Location = new System.Drawing.Point(237, 207);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(112, 64);
            this.btn_Apply.TabIndex = 9;
            this.btn_Apply.Text = "Apply Changes";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // chk_KeepSign
            // 
            this.chk_KeepSign.AutoSize = true;
            this.chk_KeepSign.Checked = true;
            this.chk_KeepSign.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_KeepSign.Dock = System.Windows.Forms.DockStyle.Right;
            this.chk_KeepSign.Location = new System.Drawing.Point(140, 207);
            this.chk_KeepSign.Name = "chk_KeepSign";
            this.chk_KeepSign.Size = new System.Drawing.Size(91, 64);
            this.chk_KeepSign.TabIndex = 10;
            this.chk_KeepSign.Text = "Keep Sign";
            this.chk_KeepSign.UseVisualStyleBackColor = true;
            // 
            // rtb_KeyframeData
            // 
            this.rtb_KeyframeData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_KeyframeData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_KeyframeData.Location = new System.Drawing.Point(367, 304);
            this.rtb_KeyframeData.Name = "rtb_KeyframeData";
            this.rtb_KeyframeData.ReadOnly = true;
            this.rtb_KeyframeData.Size = new System.Drawing.Size(358, 124);
            this.rtb_KeyframeData.TabIndex = 2;
            this.rtb_KeyframeData.Text = "";
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(752, 28);
            this.menuStrip_Main.TabIndex = 1;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 470);
            this.Controls.Add(this.tlp_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "MainForm";
            this.Text = "BFRES Anim Offsetter";
            this.tlp_Main.ResumeLayout(false);
            this.groupBox_Offsets.ResumeLayout(false);
            this.tlp_Offsets.ResumeLayout(false);
            this.tlp_Offsets.PerformLayout();
            this.tlp_ScaleZ.ResumeLayout(false);
            this.tlp_ScaleZ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ScaleZ)).EndInit();
            this.tlp_RotateZ.ResumeLayout(false);
            this.tlp_RotateZ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RotateZ)).EndInit();
            this.tlp_TranslateZ.ResumeLayout(false);
            this.tlp_TranslateZ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TranslateZ)).EndInit();
            this.tlp_ScaleY.ResumeLayout(false);
            this.tlp_ScaleY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ScaleY)).EndInit();
            this.tlp_RotateY.ResumeLayout(false);
            this.tlp_RotateY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RotateY)).EndInit();
            this.tlp_TranslateY.ResumeLayout(false);
            this.tlp_TranslateY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TranslateY)).EndInit();
            this.tlp_ScaleX.ResumeLayout(false);
            this.tlp_ScaleX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ScaleX)).EndInit();
            this.tlp_RotateX.ResumeLayout(false);
            this.tlp_RotateX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RotateX)).EndInit();
            this.tlp_TranslateX.ResumeLayout(false);
            this.tlp_TranslateX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TranslateX)).EndInit();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.ListBox listBox_Bones;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_Offsets;
        private System.Windows.Forms.TableLayoutPanel tlp_Offsets;
        private System.Windows.Forms.TableLayoutPanel tlp_TranslateX;
        private System.Windows.Forms.Label lbl_TranslateX;
        private System.Windows.Forms.NumericUpDown num_TranslateX;
        private System.Windows.Forms.TableLayoutPanel tlp_ScaleZ;
        private System.Windows.Forms.Label lbl_ScaleZ;
        private System.Windows.Forms.NumericUpDown num_ScaleZ;
        private System.Windows.Forms.TableLayoutPanel tlp_RotateZ;
        private System.Windows.Forms.Label lbl_RotateZ;
        private System.Windows.Forms.NumericUpDown num_RotateZ;
        private System.Windows.Forms.TableLayoutPanel tlp_TranslateZ;
        private System.Windows.Forms.Label lbl_TranslateZ;
        private System.Windows.Forms.NumericUpDown num_TranslateZ;
        private System.Windows.Forms.TableLayoutPanel tlp_ScaleY;
        private System.Windows.Forms.Label lbl_ScaleY;
        private System.Windows.Forms.NumericUpDown num_ScaleY;
        private System.Windows.Forms.TableLayoutPanel tlp_RotateY;
        private System.Windows.Forms.Label lbl_RotateY;
        private System.Windows.Forms.NumericUpDown num_RotateY;
        private System.Windows.Forms.TableLayoutPanel tlp_TranslateY;
        private System.Windows.Forms.Label lbl_TranslateY;
        private System.Windows.Forms.NumericUpDown num_TranslateY;
        private System.Windows.Forms.TableLayoutPanel tlp_ScaleX;
        private System.Windows.Forms.Label lbl_ScaleX;
        private System.Windows.Forms.NumericUpDown num_ScaleX;
        private System.Windows.Forms.TableLayoutPanel tlp_RotateX;
        private System.Windows.Forms.Label lbl_RotateX;
        private System.Windows.Forms.NumericUpDown num_RotateX;
        private System.Windows.Forms.RichTextBox rtb_KeyframeData;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.CheckBox chk_KeepSign;
    }
}

