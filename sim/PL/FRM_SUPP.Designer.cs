namespace sim
{
    partial class FRM_SUPP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SUPP));
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.pn_cat = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.edit_search = new System.Windows.Forms.TextBox();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tBSuppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SMPDataSet = new sim.DB_SMPDataSet();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tB_SuppTableAdapter = new sim.DB_SMPDataSetTableAdapters.TB_SuppTableAdapter();
            this.dBSMPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_SMPDataSet1 = new sim.DB_SMPDataSet();
            this.tB_SuppTableAdapter1 = new sim.DB_SMPDataSetTableAdapters.TB_SuppTableAdapter();
            this.dB_SMPDataSet2 = new sim.DB_SMPDataSet();
            this.tB_SuppTableAdapter2 = new sim.DB_SMPDataSetTableAdapters.TB_SuppTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSupp_Name = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSupp_Phone = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSupp_Email = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSupp_image = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.pn_cat.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSuppBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSMPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_cat
            // 
            this.pn_cat.Controls.Add(this.panel1);
            this.pn_cat.Controls.Add(this.gridControl1);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(1280, 532);
            this.pn_cat.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.edit_search);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_delet);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 100);
            this.panel1.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_search.Location = new System.Drawing.Point(771, 25);
            this.btn_search.Name = "btn_search";
            this.btn_search.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_search.Size = new System.Drawing.Size(61, 54);
            this.btn_search.TabIndex = 6;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // edit_search
            // 
            this.edit_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.edit_search.Location = new System.Drawing.Point(529, 45);
            this.edit_search.Name = "edit_search";
            this.edit_search.Size = new System.Drawing.Size(227, 20);
            this.edit_search.TabIndex = 5;
            this.edit_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_edit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.Location = new System.Drawing.Point(383, 31);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(114, 42);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "edit";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delet
            // 
            this.btn_delet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delet.Appearance.Options.UseFont = true;
            this.btn_delet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delet.ImageOptions.Image")));
            this.btn_delet.Location = new System.Drawing.Point(266, 31);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(100, 42);
            this.btn_delet.TabIndex = 3;
            this.btn_delet.Text = "Delet";
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(145, 31);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(102, 42);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Update";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.Location = new System.Drawing.Point(25, 31);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 42);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add ";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "TB_Supp";
            this.gridControl1.DataSource = this.dB_SMPDataSet2;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1280, 532);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tBSuppBindingSource
            // 
            this.tBSuppBindingSource.DataMember = "TB_Supp";
            this.tBSuppBindingSource.DataSource = this.dB_SMPDataSet;
            // 
            // dB_SMPDataSet
            // 
            this.dB_SMPDataSet.DataSetName = "DB_SMPDataSet";
            this.dB_SMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSupp_Name,
            this.colSupp_Phone,
            this.colSupp_Email,
            this.colSupp_image});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(404, 354);
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            tableRowDefinition1.Length.Value = 64D;
            tableRowDefinition2.Length.Value = 57D;
            tableRowDefinition3.Length.Value = 68D;
            tableRowDefinition4.Length.Value = 99D;
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            this.tileView1.TileRows.Add(tableRowDefinition3);
            this.tileView1.TileRows.Add(tableRowDefinition4);
            tileViewItemElement1.Appearance.Disabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Disabled.Options.UseFont = true;
            tileViewItemElement1.Column = this.colSupp_Name;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "colSupp_Name";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.colSupp_Phone;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "colSupp_Phone";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.colSupp_Email;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 2;
            tileViewItemElement3.Text = "colSupp_Email";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Column = this.colSupp_image;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.RowIndex = 3;
            tileViewItemElement4.Text = "colSupp_image";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            this.tileView1.TileTemplate.Add(tileViewItemElement3);
            this.tileView1.TileTemplate.Add(tileViewItemElement4);
            // 
            // tB_SuppTableAdapter
            // 
            this.tB_SuppTableAdapter.ClearBeforeFill = true;
            // 
            // dBSMPDataSetBindingSource
            // 
            this.dBSMPDataSetBindingSource.DataSource = this.dB_SMPDataSet;
            this.dBSMPDataSetBindingSource.Position = 0;
            // 
            // dB_SMPDataSet1
            // 
            this.dB_SMPDataSet1.DataSetName = "DB_SMPDataSet";
            this.dB_SMPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_SuppTableAdapter1
            // 
            this.tB_SuppTableAdapter1.ClearBeforeFill = true;
            // 
            // dB_SMPDataSet2
            // 
            this.dB_SMPDataSet2.DataSetName = "DB_SMPDataSet";
            this.dB_SMPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_SuppTableAdapter2
            // 
            this.tB_SuppTableAdapter2.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colSupp_Name
            // 
            this.colSupp_Name.FieldName = "Supp_Name";
            this.colSupp_Name.Name = "colSupp_Name";
            this.colSupp_Name.Visible = true;
            this.colSupp_Name.VisibleIndex = 1;
            // 
            // colSupp_Phone
            // 
            this.colSupp_Phone.FieldName = "Supp_Phone";
            this.colSupp_Phone.Name = "colSupp_Phone";
            this.colSupp_Phone.Visible = true;
            this.colSupp_Phone.VisibleIndex = 2;
            // 
            // colSupp_Email
            // 
            this.colSupp_Email.FieldName = "Supp_Email";
            this.colSupp_Email.Name = "colSupp_Email";
            this.colSupp_Email.Visible = true;
            this.colSupp_Email.VisibleIndex = 3;
            // 
            // colSupp_image
            // 
            this.colSupp_image.FieldName = "Supp_image";
            this.colSupp_image.Name = "colSupp_image";
            this.colSupp_image.Visible = true;
            this.colSupp_image.VisibleIndex = 4;
            // 
            // FRM_SUPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 532);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SUPP";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.FRM_SUPP_Load);
            this.pn_cat.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSuppBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSMPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SMPDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_cat;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.TextBox edit_search;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_delet;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DB_SMPDataSet dB_SMPDataSet;
        private System.Windows.Forms.BindingSource tBSuppBindingSource;
        private DB_SMPDataSetTableAdapters.TB_SuppTableAdapter tB_SuppTableAdapter;
        private DB_SMPDataSet dB_SMPDataSet1;
        private System.Windows.Forms.BindingSource dBSMPDataSetBindingSource;
        private DB_SMPDataSetTableAdapters.TB_SuppTableAdapter tB_SuppTableAdapter1;
        private DB_SMPDataSet dB_SMPDataSet2;
        private DB_SMPDataSetTableAdapters.TB_SuppTableAdapter tB_SuppTableAdapter2;
        private DevExpress.XtraGrid.Columns.TileViewColumn colID;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSupp_Name;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSupp_Phone;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSupp_Email;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSupp_image;
    }
}