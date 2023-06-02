
namespace rec_inven_samp
{
    partial class ctrl_rds
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns1 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrl_rds));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colrds_grds_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colitem_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colretention_active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colretention_storage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colretention_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladd_info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltime_value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "rds_grds_list";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(23, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1051, 527);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_records_inventory_Connection 1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"263\" />";
            table1.Name = "rds_grds_list";
            allColumns1.Table = table1;
            selectQuery1.Columns.Add(allColumns1);
            selectQuery1.Name = "rds_grds_list";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
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
            this.colid,
            this.colrds_grds_id,
            this.colitem_name,
            this.colcategory,
            this.colretention_active,
            this.colretention_storage,
            this.colretention_total,
            this.colremarks,
            this.coladd_info,
            this.coltime_value});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1109, 371, 252, 306);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.AppearanceCell.Options.UseTextOptions = true;
            this.colid.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colid.Caption = "#";
            this.colid.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colid.FieldName = "id";
            this.colid.MinWidth = 10;
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colid.OptionsColumn.AllowMove = false;
            this.colid.OptionsColumn.AllowShowHide = false;
            this.colid.OptionsColumn.AllowSize = false;
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 41;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colrds_grds_id
            // 
            this.colrds_grds_id.AppearanceCell.Options.UseTextOptions = true;
            this.colrds_grds_id.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colrds_grds_id.Caption = "RDS/GRDS ID";
            this.colrds_grds_id.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colrds_grds_id.FieldName = "rds_grds_id";
            this.colrds_grds_id.Name = "colrds_grds_id";
            this.colrds_grds_id.OptionsColumn.AllowEdit = false;
            this.colrds_grds_id.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colrds_grds_id.OptionsColumn.AllowMove = false;
            this.colrds_grds_id.OptionsColumn.AllowShowHide = false;
            this.colrds_grds_id.OptionsColumn.AllowSize = false;
            this.colrds_grds_id.OptionsColumn.ReadOnly = true;
            this.colrds_grds_id.Visible = true;
            this.colrds_grds_id.VisibleIndex = 1;
            this.colrds_grds_id.Width = 87;
            // 
            // colitem_name
            // 
            this.colitem_name.AppearanceCell.Options.UseTextOptions = true;
            this.colitem_name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colitem_name.Caption = "Records Series";
            this.colitem_name.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colitem_name.FieldName = "item_name";
            this.colitem_name.Name = "colitem_name";
            this.colitem_name.OptionsColumn.AllowEdit = false;
            this.colitem_name.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colitem_name.OptionsColumn.AllowMove = false;
            this.colitem_name.OptionsColumn.AllowShowHide = false;
            this.colitem_name.OptionsColumn.AllowSize = false;
            this.colitem_name.OptionsColumn.ReadOnly = true;
            this.colitem_name.Visible = true;
            this.colitem_name.VisibleIndex = 2;
            this.colitem_name.Width = 205;
            // 
            // colcategory
            // 
            this.colcategory.AppearanceCell.Options.UseTextOptions = true;
            this.colcategory.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colcategory.Caption = "Category";
            this.colcategory.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colcategory.FieldName = "category";
            this.colcategory.Name = "colcategory";
            this.colcategory.OptionsColumn.AllowEdit = false;
            this.colcategory.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colcategory.OptionsColumn.AllowMove = false;
            this.colcategory.OptionsColumn.AllowShowHide = false;
            this.colcategory.OptionsColumn.AllowSize = false;
            this.colcategory.OptionsColumn.ReadOnly = true;
            this.colcategory.Visible = true;
            this.colcategory.VisibleIndex = 3;
            this.colcategory.Width = 134;
            // 
            // colretention_active
            // 
            this.colretention_active.AppearanceCell.Options.UseTextOptions = true;
            this.colretention_active.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colretention_active.Caption = "Retention Period - Active";
            this.colretention_active.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colretention_active.FieldName = "retention_active";
            this.colretention_active.Name = "colretention_active";
            this.colretention_active.OptionsColumn.AllowEdit = false;
            this.colretention_active.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colretention_active.OptionsColumn.AllowMove = false;
            this.colretention_active.OptionsColumn.AllowShowHide = false;
            this.colretention_active.OptionsColumn.AllowSize = false;
            this.colretention_active.OptionsColumn.ReadOnly = true;
            this.colretention_active.Width = 83;
            // 
            // colretention_storage
            // 
            this.colretention_storage.AppearanceCell.Options.UseTextOptions = true;
            this.colretention_storage.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colretention_storage.Caption = "Retention Period - Storage";
            this.colretention_storage.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colretention_storage.FieldName = "retention_storage";
            this.colretention_storage.Name = "colretention_storage";
            this.colretention_storage.OptionsColumn.AllowEdit = false;
            this.colretention_storage.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colretention_storage.OptionsColumn.AllowMove = false;
            this.colretention_storage.OptionsColumn.AllowShowHide = false;
            this.colretention_storage.OptionsColumn.AllowSize = false;
            this.colretention_storage.OptionsColumn.ReadOnly = true;
            this.colretention_storage.Width = 83;
            // 
            // colretention_total
            // 
            this.colretention_total.AppearanceCell.Options.UseTextOptions = true;
            this.colretention_total.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colretention_total.Caption = "Retention Period-Total";
            this.colretention_total.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colretention_total.FieldName = "retention_total";
            this.colretention_total.Name = "colretention_total";
            this.colretention_total.OptionsColumn.AllowEdit = false;
            this.colretention_total.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colretention_total.OptionsColumn.AllowMove = false;
            this.colretention_total.OptionsColumn.AllowShowHide = false;
            this.colretention_total.OptionsColumn.AllowSize = false;
            this.colretention_total.OptionsColumn.ReadOnly = true;
            this.colretention_total.Visible = true;
            this.colretention_total.VisibleIndex = 6;
            this.colretention_total.Width = 126;
            // 
            // colremarks
            // 
            this.colremarks.AppearanceCell.Options.UseTextOptions = true;
            this.colremarks.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colremarks.Caption = "Remarks";
            this.colremarks.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colremarks.FieldName = "remarks";
            this.colremarks.Name = "colremarks";
            this.colremarks.OptionsColumn.AllowEdit = false;
            this.colremarks.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colremarks.OptionsColumn.AllowMove = false;
            this.colremarks.OptionsColumn.AllowShowHide = false;
            this.colremarks.OptionsColumn.AllowSize = false;
            this.colremarks.OptionsColumn.ReadOnly = true;
            this.colremarks.Visible = true;
            this.colremarks.VisibleIndex = 5;
            this.colremarks.Width = 186;
            // 
            // coladd_info
            // 
            this.coladd_info.AppearanceCell.Options.UseTextOptions = true;
            this.coladd_info.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coladd_info.Caption = "Additional Information";
            this.coladd_info.ColumnEdit = this.repositoryItemMemoEdit1;
            this.coladd_info.FieldName = "add_info";
            this.coladd_info.Name = "coladd_info";
            this.coladd_info.OptionsColumn.AllowEdit = false;
            this.coladd_info.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.coladd_info.OptionsColumn.AllowMove = false;
            this.coladd_info.OptionsColumn.AllowShowHide = false;
            this.coladd_info.OptionsColumn.AllowSize = false;
            this.coladd_info.OptionsColumn.ReadOnly = true;
            this.coladd_info.Visible = true;
            this.coladd_info.VisibleIndex = 4;
            this.coladd_info.Width = 189;
            // 
            // coltime_value
            // 
            this.coltime_value.AppearanceCell.Options.UseTextOptions = true;
            this.coltime_value.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coltime_value.Caption = "Time Value";
            this.coltime_value.ColumnEdit = this.repositoryItemMemoEdit1;
            this.coltime_value.FieldName = "time_value";
            this.coltime_value.Name = "coltime_value";
            this.coltime_value.OptionsColumn.AllowEdit = false;
            this.coltime_value.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.coltime_value.OptionsColumn.AllowMove = false;
            this.coltime_value.OptionsColumn.AllowShowHide = false;
            this.coltime_value.OptionsColumn.AllowSize = false;
            this.coltime_value.OptionsColumn.ReadOnly = true;
            this.coltime_value.Visible = true;
            this.coltime_value.VisibleIndex = 7;
            this.coltime_value.Width = 58;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(148)))), ((int)(((byte)(96)))));
            this.button1.Location = new System.Drawing.Point(918, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add RDS / GRDS";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ctrl_rds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrl_rds";
            this.Size = new System.Drawing.Size(1092, 569);
            this.Load += new System.EventHandler(this.rds_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colrds_grds_id;
        private DevExpress.XtraGrid.Columns.GridColumn colitem_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory;
        private DevExpress.XtraGrid.Columns.GridColumn colretention_active;
        private DevExpress.XtraGrid.Columns.GridColumn colretention_storage;
        private DevExpress.XtraGrid.Columns.GridColumn colretention_total;
        private DevExpress.XtraGrid.Columns.GridColumn colremarks;
        private DevExpress.XtraGrid.Columns.GridColumn coladd_info;
        private DevExpress.XtraGrid.Columns.GridColumn coltime_value;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private System.Windows.Forms.Button button1;
    }
}
