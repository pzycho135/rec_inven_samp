namespace rec_inven_samp
{
    partial class frm_add_nap1
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
            this.button1 = new System.Windows.Forms.Button();
            this.grp_encoder = new System.Windows.Forms.GroupBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_office_categ = new System.Windows.Forms.ComboBox();
            this.cmb_office = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_dt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grp_encoder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "add entry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grp_encoder
            // 
            this.grp_encoder.Controls.Add(this.txt_name);
            this.grp_encoder.Controls.Add(this.label5);
            this.grp_encoder.Controls.Add(this.cmb_office_categ);
            this.grp_encoder.Controls.Add(this.cmb_office);
            this.grp_encoder.Controls.Add(this.label4);
            this.grp_encoder.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_encoder.Location = new System.Drawing.Point(12, 12);
            this.grp_encoder.Name = "grp_encoder";
            this.grp_encoder.Size = new System.Drawing.Size(731, 112);
            this.grp_encoder.TabIndex = 2;
            this.grp_encoder.TabStop = false;
            this.grp_encoder.Text = "Encoder Details";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.txt_name.Location = new System.Drawing.Point(85, 25);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(404, 26);
            this.txt_name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name:";
            // 
            // cmb_office_categ
            // 
            this.cmb_office_categ.BackColor = System.Drawing.Color.White;
            this.cmb_office_categ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_office_categ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.cmb_office_categ.FormattingEnabled = true;
            this.cmb_office_categ.Items.AddRange(new object[] {
            "DIVISION",
            "DISTRICT",
            "SCHOOL"});
            this.cmb_office_categ.Location = new System.Drawing.Point(85, 71);
            this.cmb_office_categ.Name = "cmb_office_categ";
            this.cmb_office_categ.Size = new System.Drawing.Size(106, 29);
            this.cmb_office_categ.TabIndex = 2;
            this.cmb_office_categ.SelectionChangeCommitted += new System.EventHandler(this.cmb_office_categ_SelectionChangeCommitted);
            // 
            // cmb_office
            // 
            this.cmb_office.BackColor = System.Drawing.Color.White;
            this.cmb_office.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_office.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.cmb_office.FormattingEnabled = true;
            this.cmb_office.Location = new System.Drawing.Point(198, 71);
            this.cmb_office.Name = "cmb_office";
            this.cmb_office.Size = new System.Drawing.Size(515, 29);
            this.cmb_office.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Office:";
            // 
            // lbl_dt
            // 
            this.lbl_dt.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dt.Location = new System.Drawing.Point(818, 37);
            this.lbl_dt.Name = "lbl_dt";
            this.lbl_dt.Size = new System.Drawing.Size(201, 61);
            this.lbl_dt.TabIndex = 13;
            this.lbl_dt.Text = "2023, September 29 12:00:00 tt";
            this.lbl_dt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(763, 60);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Date:";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(894, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 396);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Records Series Details";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(853, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 33);
            this.button3.TabIndex = 0;
            this.button3.Text = "delete entry";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "rds id";
            this.gridColumn1.FieldName = "rds_id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.AllowShowHide = false;
            this.gridColumn1.OptionsColumn.AllowSize = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Width = 88;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "records series";
            this.gridColumn3.FieldName = "rec_series";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowMove = false;
            this.gridColumn3.OptionsColumn.AllowShowHide = false;
            this.gridColumn3.OptionsColumn.AllowSize = false;
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Width = 117;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "location";
            this.gridColumn4.FieldName = "location";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowMove = false;
            this.gridColumn4.OptionsColumn.AllowShowHide = false;
            this.gridColumn4.OptionsColumn.AllowSize = false;
            this.gridColumn4.OptionsColumn.FixedWidth = true;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Width = 143;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "volume";
            this.gridColumn5.FieldName = "volume";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowMove = false;
            this.gridColumn5.OptionsColumn.AllowShowHide = false;
            this.gridColumn5.OptionsColumn.AllowSize = false;
            this.gridColumn5.OptionsColumn.FixedWidth = true;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Width = 96;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "time value";
            this.gridColumn6.FieldName = "time_val";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowMove = false;
            this.gridColumn6.OptionsColumn.AllowShowHide = false;
            this.gridColumn6.OptionsColumn.AllowSize = false;
            this.gridColumn6.OptionsColumn.FixedWidth = true;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "utility value";
            this.gridColumn7.FieldName = "util_val";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowMove = false;
            this.gridColumn7.OptionsColumn.AllowShowHide = false;
            this.gridColumn7.OptionsColumn.AllowSize = false;
            this.gridColumn7.OptionsColumn.FixedWidth = true;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "use frequency";
            this.gridColumn8.FieldName = "use_freq";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowMove = false;
            this.gridColumn8.OptionsColumn.AllowShowHide = false;
            this.gridColumn8.OptionsColumn.AllowSize = false;
            this.gridColumn8.OptionsColumn.FixedWidth = true;
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Width = 103;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "duplication";
            this.gridColumn9.FieldName = "duplication";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.AllowMove = false;
            this.gridColumn9.OptionsColumn.AllowShowHide = false;
            this.gridColumn9.OptionsColumn.AllowSize = false;
            this.gridColumn9.OptionsColumn.FixedWidth = true;
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "period start";
            this.gridColumn10.FieldName = "period_start";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.AllowMove = false;
            this.gridColumn10.OptionsColumn.AllowShowHide = false;
            this.gridColumn10.OptionsColumn.AllowSize = false;
            this.gridColumn10.OptionsColumn.FixedWidth = true;
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Width = 91;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "period end";
            this.gridColumn11.FieldName = "period_end";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.AllowMove = false;
            this.gridColumn11.OptionsColumn.AllowShowHide = false;
            this.gridColumn11.OptionsColumn.AllowSize = false;
            this.gridColumn11.OptionsColumn.FixedWidth = true;
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.Width = 98;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1007, 326);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F);
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1109, 371, 252, 306);
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "RDS / GRDS ID";
            this.gridColumn2.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn2.FieldName = "rds_id";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowSize = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 98;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "ITEM NAME";
            this.gridColumn12.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn12.FieldName = "rec_series";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.AllowSize = false;
            this.gridColumn12.OptionsColumn.FixedWidth = true;
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 187;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "LOCATION";
            this.gridColumn13.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn13.FieldName = "location";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.OptionsColumn.AllowSize = false;
            this.gridColumn13.OptionsColumn.FixedWidth = true;
            this.gridColumn13.OptionsColumn.ReadOnly = true;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            this.gridColumn13.Width = 198;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "VOLUME";
            this.gridColumn14.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn14.FieldName = "volume";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.OptionsColumn.AllowSize = false;
            this.gridColumn14.OptionsColumn.FixedWidth = true;
            this.gridColumn14.OptionsColumn.ReadOnly = true;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 3;
            this.gridColumn14.Width = 91;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "TIME VALUE";
            this.gridColumn15.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn15.FieldName = "time_val";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.OptionsColumn.AllowSize = false;
            this.gridColumn15.OptionsColumn.FixedWidth = true;
            this.gridColumn15.OptionsColumn.ReadOnly = true;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            this.gridColumn15.Width = 103;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "UTILITY VALUE";
            this.gridColumn16.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn16.FieldName = "util_val";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.OptionsColumn.AllowSize = false;
            this.gridColumn16.OptionsColumn.FixedWidth = true;
            this.gridColumn16.OptionsColumn.ReadOnly = true;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 5;
            this.gridColumn16.Width = 136;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "USE FREQUENCY";
            this.gridColumn17.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn17.FieldName = "use_freq";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.OptionsColumn.AllowSize = false;
            this.gridColumn17.OptionsColumn.FixedWidth = true;
            this.gridColumn17.OptionsColumn.ReadOnly = true;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 6;
            this.gridColumn17.Width = 125;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "DUPLICATION";
            this.gridColumn18.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn18.FieldName = "duplication";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.OptionsColumn.AllowSize = false;
            this.gridColumn18.OptionsColumn.FixedWidth = true;
            this.gridColumn18.OptionsColumn.ReadOnly = true;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 7;
            this.gridColumn18.Width = 115;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "PERIOD COVERED - FROM";
            this.gridColumn19.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn19.FieldName = "period_start";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.OptionsColumn.AllowSize = false;
            this.gridColumn19.OptionsColumn.FixedWidth = true;
            this.gridColumn19.OptionsColumn.ReadOnly = true;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 8;
            this.gridColumn19.Width = 126;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "PERIOD COVERED - TO";
            this.gridColumn20.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn20.FieldName = "period_end";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            this.gridColumn20.OptionsColumn.AllowSize = false;
            this.gridColumn20.OptionsColumn.FixedWidth = true;
            this.gridColumn20.OptionsColumn.ReadOnly = true;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 9;
            this.gridColumn20.Width = 125;
            // 
            // frm_add_nap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_dt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grp_encoder);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.Name = "frm_add_nap1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add NAP 1";
            this.grp_encoder.ResumeLayout(false);
            this.grp_encoder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grp_encoder;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_office_categ;
        private System.Windows.Forms.ComboBox cmb_office;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_dt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
    }
}