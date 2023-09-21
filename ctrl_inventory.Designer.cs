
namespace rec_inven_samp
{
    partial class ctrl_inventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrl_inventory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_edit_save = new System.Windows.Forms.Button();
            this.button_edit_exit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coloffice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colrds_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrecord_loc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvol_cubic_meter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colutility_value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluse_frequency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colduplication = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperiod_start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperiod_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubmit_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubmit_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_edit_save);
            this.panel1.Controls.Add(this.button_edit_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 531);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(429, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "You are in EDIT mode!";
            // 
            // button_edit_save
            // 
            this.button_edit_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.button_edit_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_edit_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.button_edit_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_edit_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit_save.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(148)))), ((int)(((byte)(96)))));
            this.button_edit_save.Location = new System.Drawing.Point(968, 0);
            this.button_edit_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_edit_save.Name = "button_edit_save";
            this.button_edit_save.Size = new System.Drawing.Size(62, 38);
            this.button_edit_save.TabIndex = 2;
            this.button_edit_save.Text = "Save";
            this.button_edit_save.UseVisualStyleBackColor = false;
            this.button_edit_save.Click += new System.EventHandler(this.button_edit_save_Click);
            // 
            // button_edit_exit
            // 
            this.button_edit_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button_edit_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_edit_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button_edit_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_edit_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit_exit.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(93)))), ((int)(((byte)(125)))));
            this.button_edit_exit.Location = new System.Drawing.Point(1030, 0);
            this.button_edit_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_edit_exit.Name = "button_edit_exit";
            this.button_edit_exit.Size = new System.Drawing.Size(62, 38);
            this.button_edit_exit.TabIndex = 1;
            this.button_edit_exit.Text = "Exit";
            this.button_edit_exit.UseVisualStyleBackColor = false;
            this.button_edit_exit.Click += new System.EventHandler(this.button_edit_exit_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Transparent;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(155)))), ((int)(((byte)(177)))));
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(155)))), ((int)(((byte)(177)))));
            this.button_add.Location = new System.Drawing.Point(583, 4);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(79, 32);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(93)))), ((int)(((byte)(125)))));
            this.button_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(93)))), ((int)(((byte)(125)))));
            this.button_delete.Location = new System.Drawing.Point(670, 4);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(79, 32);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Transparent;
            this.button_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(115)))));
            this.button_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(228)))), ((int)(((byte)(223)))));
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(139)))), ((int)(((byte)(115)))));
            this.button_edit.Location = new System.Drawing.Point(757, 4);
            this.button_edit.Margin = new System.Windows.Forms.Padding(4);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(79, 32);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Office / District"});
            this.comboBox1.Location = new System.Drawing.Point(68, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Office / School"});
            this.comboBox2.Location = new System.Drawing.Point(266, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 28);
            this.comboBox2.TabIndex = 12;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource2;
            this.gridControl1.Location = new System.Drawing.Point(3, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1086, 477);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "localhost_records_inventory_Connection 1";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
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
            this.coloffice,
            this.colrds_id,
            this.colrecord_loc,
            this.colvol_cubic_meter,
            this.colutility_value,
            this.coluse_frequency,
            this.colduplication,
            this.colperiod_start,
            this.colperiod_end,
            this.colsubmit_name,
            this.colsubmit_date});
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
            // coloffice
            // 
            this.coloffice.ColumnEdit = this.repositoryItemMemoEdit1;
            this.coloffice.FieldName = "office";
            this.coloffice.Name = "coloffice";
            this.coloffice.OptionsColumn.AllowEdit = false;
            this.coloffice.OptionsColumn.AllowMove = false;
            this.coloffice.OptionsColumn.AllowShowHide = false;
            this.coloffice.OptionsColumn.AllowSize = false;
            this.coloffice.OptionsColumn.ReadOnly = true;
            this.coloffice.Visible = true;
            this.coloffice.VisibleIndex = 0;
            this.coloffice.Width = 208;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colrds_id
            // 
            this.colrds_id.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colrds_id.FieldName = "rds_id";
            this.colrds_id.Name = "colrds_id";
            this.colrds_id.OptionsColumn.AllowEdit = false;
            this.colrds_id.OptionsColumn.AllowMove = false;
            this.colrds_id.OptionsColumn.AllowShowHide = false;
            this.colrds_id.OptionsColumn.AllowSize = false;
            this.colrds_id.OptionsColumn.ReadOnly = true;
            this.colrds_id.Visible = true;
            this.colrds_id.VisibleIndex = 1;
            this.colrds_id.Width = 94;
            // 
            // colrecord_loc
            // 
            this.colrecord_loc.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colrecord_loc.FieldName = "record_loc";
            this.colrecord_loc.Name = "colrecord_loc";
            this.colrecord_loc.OptionsColumn.AllowEdit = false;
            this.colrecord_loc.OptionsColumn.AllowMove = false;
            this.colrecord_loc.OptionsColumn.AllowShowHide = false;
            this.colrecord_loc.OptionsColumn.AllowSize = false;
            this.colrecord_loc.OptionsColumn.ReadOnly = true;
            this.colrecord_loc.Visible = true;
            this.colrecord_loc.VisibleIndex = 2;
            this.colrecord_loc.Width = 136;
            // 
            // colvol_cubic_meter
            // 
            this.colvol_cubic_meter.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colvol_cubic_meter.FieldName = "vol_cubic_meter";
            this.colvol_cubic_meter.Name = "colvol_cubic_meter";
            this.colvol_cubic_meter.OptionsColumn.AllowEdit = false;
            this.colvol_cubic_meter.OptionsColumn.AllowMove = false;
            this.colvol_cubic_meter.OptionsColumn.AllowShowHide = false;
            this.colvol_cubic_meter.OptionsColumn.AllowSize = false;
            this.colvol_cubic_meter.OptionsColumn.ReadOnly = true;
            this.colvol_cubic_meter.Visible = true;
            this.colvol_cubic_meter.VisibleIndex = 3;
            this.colvol_cubic_meter.Width = 119;
            // 
            // colutility_value
            // 
            this.colutility_value.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colutility_value.FieldName = "utility_value";
            this.colutility_value.Name = "colutility_value";
            this.colutility_value.OptionsColumn.AllowEdit = false;
            this.colutility_value.OptionsColumn.AllowMove = false;
            this.colutility_value.OptionsColumn.AllowShowHide = false;
            this.colutility_value.OptionsColumn.AllowSize = false;
            this.colutility_value.OptionsColumn.ReadOnly = true;
            this.colutility_value.Visible = true;
            this.colutility_value.VisibleIndex = 4;
            this.colutility_value.Width = 126;
            // 
            // coluse_frequency
            // 
            this.coluse_frequency.ColumnEdit = this.repositoryItemMemoEdit1;
            this.coluse_frequency.FieldName = "use_frequency";
            this.coluse_frequency.Name = "coluse_frequency";
            this.coluse_frequency.OptionsColumn.AllowEdit = false;
            this.coluse_frequency.OptionsColumn.AllowMove = false;
            this.coluse_frequency.OptionsColumn.AllowShowHide = false;
            this.coluse_frequency.OptionsColumn.AllowSize = false;
            this.coluse_frequency.OptionsColumn.ReadOnly = true;
            this.coluse_frequency.Visible = true;
            this.coluse_frequency.VisibleIndex = 5;
            this.coluse_frequency.Width = 112;
            // 
            // colduplication
            // 
            this.colduplication.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colduplication.FieldName = "duplication";
            this.colduplication.Name = "colduplication";
            this.colduplication.OptionsColumn.AllowEdit = false;
            this.colduplication.OptionsColumn.AllowMove = false;
            this.colduplication.OptionsColumn.AllowShowHide = false;
            this.colduplication.OptionsColumn.AllowSize = false;
            this.colduplication.OptionsColumn.ReadOnly = true;
            this.colduplication.Visible = true;
            this.colduplication.VisibleIndex = 6;
            this.colduplication.Width = 113;
            // 
            // colperiod_start
            // 
            this.colperiod_start.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colperiod_start.FieldName = "period_start";
            this.colperiod_start.Name = "colperiod_start";
            this.colperiod_start.OptionsColumn.AllowEdit = false;
            this.colperiod_start.OptionsColumn.AllowMove = false;
            this.colperiod_start.OptionsColumn.AllowShowHide = false;
            this.colperiod_start.OptionsColumn.AllowSize = false;
            this.colperiod_start.OptionsColumn.ReadOnly = true;
            this.colperiod_start.Visible = true;
            this.colperiod_start.VisibleIndex = 7;
            this.colperiod_start.Width = 119;
            // 
            // colperiod_end
            // 
            this.colperiod_end.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colperiod_end.FieldName = "period_end";
            this.colperiod_end.Name = "colperiod_end";
            this.colperiod_end.OptionsColumn.AllowEdit = false;
            this.colperiod_end.OptionsColumn.AllowMove = false;
            this.colperiod_end.OptionsColumn.AllowShowHide = false;
            this.colperiod_end.OptionsColumn.AllowSize = false;
            this.colperiod_end.OptionsColumn.ReadOnly = true;
            this.colperiod_end.Visible = true;
            this.colperiod_end.VisibleIndex = 8;
            this.colperiod_end.Width = 110;
            // 
            // colsubmit_name
            // 
            this.colsubmit_name.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colsubmit_name.FieldName = "submit_name";
            this.colsubmit_name.Name = "colsubmit_name";
            this.colsubmit_name.OptionsColumn.AllowEdit = false;
            this.colsubmit_name.OptionsColumn.AllowMove = false;
            this.colsubmit_name.OptionsColumn.AllowShowHide = false;
            this.colsubmit_name.OptionsColumn.AllowSize = false;
            this.colsubmit_name.OptionsColumn.ReadOnly = true;
            this.colsubmit_name.Visible = true;
            this.colsubmit_name.VisibleIndex = 9;
            this.colsubmit_name.Width = 124;
            // 
            // colsubmit_date
            // 
            this.colsubmit_date.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colsubmit_date.FieldName = "submit_date";
            this.colsubmit_date.Name = "colsubmit_date";
            this.colsubmit_date.OptionsColumn.AllowEdit = false;
            this.colsubmit_date.OptionsColumn.AllowMove = false;
            this.colsubmit_date.OptionsColumn.AllowShowHide = false;
            this.colsubmit_date.OptionsColumn.AllowSize = false;
            this.colsubmit_date.OptionsColumn.ReadOnly = true;
            this.colsubmit_date.Visible = true;
            this.colsubmit_date.VisibleIndex = 10;
            this.colsubmit_date.Width = 117;
            // 
            // ctrl_inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctrl_inventory";
            this.Size = new System.Drawing.Size(1092, 569);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_edit_exit;
        private System.Windows.Forms.Button button_edit_save;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.Columns.GridColumn coloffice;
        private DevExpress.XtraGrid.Columns.GridColumn colrds_id;
        private DevExpress.XtraGrid.Columns.GridColumn colrecord_loc;
        private DevExpress.XtraGrid.Columns.GridColumn colvol_cubic_meter;
        private DevExpress.XtraGrid.Columns.GridColumn colutility_value;
        private DevExpress.XtraGrid.Columns.GridColumn coluse_frequency;
        private DevExpress.XtraGrid.Columns.GridColumn colduplication;
        private DevExpress.XtraGrid.Columns.GridColumn colperiod_start;
        private DevExpress.XtraGrid.Columns.GridColumn colperiod_end;
        private DevExpress.XtraGrid.Columns.GridColumn colsubmit_name;
        private DevExpress.XtraGrid.Columns.GridColumn colsubmit_date;
    }
}
