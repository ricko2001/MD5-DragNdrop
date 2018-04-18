namespace RJO
{
    partial class MainFrm
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
			this.table = new System.Windows.Forms.DataGridView();
			this.MD5Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FileNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PathCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
			this.SuspendLayout();
			// 
			// table
			// 
			this.table.AllowDrop = true;
			this.table.AllowUserToAddRows = false;
			this.table.AllowUserToOrderColumns = true;
			this.table.AllowUserToResizeRows = false;
			this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MD5Col,
            this.SizeCol,
            this.FileNameCol,
            this.PathCol});
			this.table.Dock = System.Windows.Forms.DockStyle.Fill;
			this.table.Location = new System.Drawing.Point(4, 0);
			this.table.Margin = new System.Windows.Forms.Padding(20);
			this.table.Name = "table";
			this.table.ReadOnly = true;
			this.table.ShowCellToolTips = false;
			this.table.ShowEditingIcon = false;
			this.table.ShowRowErrors = false;
			this.table.Size = new System.Drawing.Size(780, 86);
			this.table.TabIndex = 0;
			this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
			this.table.DragDrop += new System.Windows.Forms.DragEventHandler(this.table_DragDrop);
			this.table.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
			// 
			// MD5Col
			// 
			this.MD5Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.MD5Col.DividerWidth = 3;
			this.MD5Col.Frozen = true;
			this.MD5Col.HeaderText = "MD5";
			this.MD5Col.MinimumWidth = 280;
			this.MD5Col.Name = "MD5Col";
			this.MD5Col.ReadOnly = true;
			this.MD5Col.Width = 280;
			// 
			// SizeCol
			// 
			this.SizeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.SizeCol.DividerWidth = 3;
			this.SizeCol.HeaderText = "Size";
			this.SizeCol.MinimumWidth = 150;
			this.SizeCol.Name = "SizeCol";
			this.SizeCol.ReadOnly = true;
			this.SizeCol.Width = 150;
			// 
			// FileNameCol
			// 
			this.FileNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.FileNameCol.DividerWidth = 3;
			this.FileNameCol.HeaderText = "File Name";
			this.FileNameCol.MinimumWidth = 60;
			this.FileNameCol.Name = "FileNameCol";
			this.FileNameCol.ReadOnly = true;
			this.FileNameCol.Width = 108;
			// 
			// PathCol
			// 
			this.PathCol.FillWeight = 147.3684F;
			this.PathCol.HeaderText = "Full Path";
			this.PathCol.Name = "PathCol";
			this.PathCol.ReadOnly = true;
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(792, 94);
			this.Controls.Add(this.table);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(800, 120);
			this.Name = "MainFrm";
			this.Padding = new System.Windows.Forms.Padding(4, 0, 8, 8);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "MD5 Drag & Drop";
			((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.DataGridView table;
		private System.Windows.Forms.DataGridViewTextBoxColumn MD5Col;
		private System.Windows.Forms.DataGridViewTextBoxColumn SizeCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn FileNameCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn PathCol;


    }
}

