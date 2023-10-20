
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colrds_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colitem_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colretention_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladd_info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltime_value = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1086, 553);
            this.gridControl1.TabIndex = 1;
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
            this.colrds_id,
            this.colitem_name,
            this.colcategory_id,
            this.colretention_total,
            this.colremarks,
            this.coladd_info,
            this.coltime_value});
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
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // colrds_id
            // 
            this.colrds_id.AppearanceCell.Options.UseTextOptions = true;
            this.colrds_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colrds_id.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colrds_id.Caption = "RDS / GRDS ID";
            this.colrds_id.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colrds_id.FieldName = "rds_id";
            this.colrds_id.Name = "colrds_id";
            this.colrds_id.OptionsColumn.AllowEdit = false;
            this.colrds_id.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colrds_id.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colrds_id.OptionsColumn.AllowMove = false;
            this.colrds_id.OptionsColumn.AllowShowHide = false;
            this.colrds_id.OptionsColumn.AllowSize = false;
            this.colrds_id.OptionsColumn.ReadOnly = true;
            this.colrds_id.Visible = true;
            this.colrds_id.VisibleIndex = 0;
            this.colrds_id.Width = 100;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colitem_name
            // 
            this.colitem_name.AppearanceCell.Options.UseTextOptions = true;
            this.colitem_name.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colitem_name.Caption = "RECORDS SERIES";
            this.colitem_name.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colitem_name.FieldName = "item_name";
            this.colitem_name.Name = "colitem_name";
            this.colitem_name.OptionsColumn.AllowEdit = false;
            this.colitem_name.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colitem_name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colitem_name.OptionsColumn.AllowMove = false;
            this.colitem_name.OptionsColumn.AllowShowHide = false;
            this.colitem_name.OptionsColumn.AllowSize = false;
            this.colitem_name.OptionsColumn.ReadOnly = true;
            this.colitem_name.Visible = true;
            this.colitem_name.VisibleIndex = 1;
            this.colitem_name.Width = 220;
            // 
            // colcategory_id
            // 
            this.colcategory_id.AppearanceCell.Options.UseTextOptions = true;
            this.colcategory_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcategory_id.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colcategory_id.Caption = "CATEGORY";
            this.colcategory_id.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colcategory_id.FieldName = "category";
            this.colcategory_id.Name = "colcategory_id";
            this.colcategory_id.OptionsColumn.AllowEdit = false;
            this.colcategory_id.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colcategory_id.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colcategory_id.OptionsColumn.AllowMove = false;
            this.colcategory_id.OptionsColumn.AllowShowHide = false;
            this.colcategory_id.OptionsColumn.AllowSize = false;
            this.colcategory_id.OptionsColumn.ReadOnly = true;
            this.colcategory_id.Visible = true;
            this.colcategory_id.VisibleIndex = 2;
            this.colcategory_id.Width = 162;
            // 
            // colretention_total
            // 
            this.colretention_total.AppearanceCell.Options.UseTextOptions = true;
            this.colretention_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colretention_total.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colretention_total.Caption = "RETENTION - TOTAL";
            this.colretention_total.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colretention_total.FieldName = "retention_total";
            this.colretention_total.Name = "colretention_total";
            this.colretention_total.OptionsColumn.AllowEdit = false;
            this.colretention_total.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colretention_total.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colretention_total.OptionsColumn.AllowMove = false;
            this.colretention_total.OptionsColumn.AllowShowHide = false;
            this.colretention_total.OptionsColumn.AllowSize = false;
            this.colretention_total.OptionsColumn.ReadOnly = true;
            this.colretention_total.Visible = true;
            this.colretention_total.VisibleIndex = 3;
            this.colretention_total.Width = 92;
            // 
            // colremarks
            // 
            this.colremarks.AppearanceCell.Options.UseTextOptions = true;
            this.colremarks.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colremarks.Caption = "REMARKS";
            this.colremarks.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colremarks.FieldName = "remarks";
            this.colremarks.Name = "colremarks";
            this.colremarks.OptionsColumn.AllowEdit = false;
            this.colremarks.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colremarks.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colremarks.OptionsColumn.AllowMove = false;
            this.colremarks.OptionsColumn.AllowShowHide = false;
            this.colremarks.OptionsColumn.AllowSize = false;
            this.colremarks.OptionsColumn.ReadOnly = true;
            this.colremarks.Visible = true;
            this.colremarks.VisibleIndex = 4;
            this.colremarks.Width = 212;
            // 
            // coladd_info
            // 
            this.coladd_info.AppearanceCell.Options.UseTextOptions = true;
            this.coladd_info.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.coladd_info.Caption = "ADDITIONAL INFO";
            this.coladd_info.ColumnEdit = this.repositoryItemMemoEdit1;
            this.coladd_info.FieldName = "add_info";
            this.coladd_info.Name = "coladd_info";
            this.coladd_info.OptionsColumn.AllowEdit = false;
            this.coladd_info.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.coladd_info.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.coladd_info.OptionsColumn.AllowMove = false;
            this.coladd_info.OptionsColumn.AllowShowHide = false;
            this.coladd_info.OptionsColumn.AllowSize = false;
            this.coladd_info.OptionsColumn.ReadOnly = true;
            this.coladd_info.Visible = true;
            this.coladd_info.VisibleIndex = 5;
            this.coladd_info.Width = 208;
            // 
            // coltime_value
            // 
            this.coltime_value.AppearanceCell.Options.UseTextOptions = true;
            this.coltime_value.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltime_value.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.coltime_value.Caption = "TIME VALUE";
            this.coltime_value.ColumnEdit = this.repositoryItemMemoEdit1;
            this.coltime_value.FieldName = "time_value";
            this.coltime_value.Name = "coltime_value";
            this.coltime_value.OptionsColumn.AllowEdit = false;
            this.coltime_value.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.coltime_value.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.coltime_value.OptionsColumn.AllowMove = false;
            this.coltime_value.OptionsColumn.AllowShowHide = false;
            this.coltime_value.OptionsColumn.AllowSize = false;
            this.coltime_value.OptionsColumn.ReadOnly = true;
            this.coltime_value.Visible = true;
            this.coltime_value.VisibleIndex = 6;
            this.coltime_value.Width = 60;
            // 
            // ctrl_rds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrl_rds";
            this.Size = new System.Drawing.Size(1092, 569);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colrds_id;
        private DevExpress.XtraGrid.Columns.GridColumn colitem_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory_id;
        private DevExpress.XtraGrid.Columns.GridColumn colretention_total;
        private DevExpress.XtraGrid.Columns.GridColumn colremarks;
        private DevExpress.XtraGrid.Columns.GridColumn coladd_info;
        private DevExpress.XtraGrid.Columns.GridColumn coltime_value;
    }
}
