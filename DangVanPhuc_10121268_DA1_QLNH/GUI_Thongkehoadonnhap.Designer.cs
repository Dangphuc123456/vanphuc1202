namespace DangVanPhuc_10121268_DA1_QLNH
{
    partial class GUI_Thongkehoadonnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Thongkehoadonnhap));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qLNH_DA1_10121268_DVPDataSet = new DangVanPhuc_10121268_DA1_QLNH.QLNH_DA1_10121268_DVPDataSet();
            this.hDNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDNhapTableAdapter = new DangVanPhuc_10121268_DA1_QLNH.QLNH_DA1_10121268_DVPDataSetTableAdapters.HDNhapTableAdapter();
            this.tableAdapterManager = new DangVanPhuc_10121268_DA1_QLNH.QLNH_DA1_10121268_DVPDataSetTableAdapters.TableAdapterManager();
            this.hDNhapBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.hDNhapBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hDNhapDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuấtfileExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNH_DA1_10121268_DVPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDNhapBindingNavigator)).BeginInit();
            this.hDNhapBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hDNhapDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê hóa đơn nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hDNhapDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(39, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1178, 328);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thống kê hóa đơn nhập";
            // 
            // qLNH_DA1_10121268_DVPDataSet
            // 
            this.qLNH_DA1_10121268_DVPDataSet.DataSetName = "QLNH_DA1_10121268_DVPDataSet";
            this.qLNH_DA1_10121268_DVPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hDNhapBindingSource
            // 
            this.hDNhapBindingSource.DataMember = "HDNhap";
            this.hDNhapBindingSource.DataSource = this.qLNH_DA1_10121268_DVPDataSet;
            // 
            // hDNhapTableAdapter
            // 
            this.hDNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietHDBanTableAdapter = null;
            this.tableAdapterManager.ChiTietHDNhapTableAdapter = null;
            this.tableAdapterManager.HDBanTableAdapter = null;
            this.tableAdapterManager.HDNhapTableAdapter = this.hDNhapTableAdapter;
            this.tableAdapterManager.KhachTableAdapter = null;
            this.tableAdapterManager.MonanTableAdapter = null;
            this.tableAdapterManager.NguyenlieuTableAdapter = null;
            this.tableAdapterManager.NhaCCTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DangVanPhuc_10121268_DA1_QLNH.QLNH_DA1_10121268_DVPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hDNhapBindingNavigator
            // 
            this.hDNhapBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hDNhapBindingNavigator.BindingSource = this.hDNhapBindingSource;
            this.hDNhapBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hDNhapBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hDNhapBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.hDNhapBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hDNhapBindingNavigatorSaveItem});
            this.hDNhapBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hDNhapBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hDNhapBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hDNhapBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hDNhapBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hDNhapBindingNavigator.Name = "hDNhapBindingNavigator";
            this.hDNhapBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hDNhapBindingNavigator.Size = new System.Drawing.Size(1261, 27);
            this.hDNhapBindingNavigator.TabIndex = 3;
            this.hDNhapBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // hDNhapBindingNavigatorSaveItem
            // 
            this.hDNhapBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hDNhapBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hDNhapBindingNavigatorSaveItem.Image")));
            this.hDNhapBindingNavigatorSaveItem.Name = "hDNhapBindingNavigatorSaveItem";
            this.hDNhapBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.hDNhapBindingNavigatorSaveItem.Text = "Save Data";
            this.hDNhapBindingNavigatorSaveItem.Click += new System.EventHandler(this.hDNhapBindingNavigatorSaveItem_Click);
            // 
            // hDNhapDataGridView
            // 
            this.hDNhapDataGridView.AutoGenerateColumns = false;
            this.hDNhapDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hDNhapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hDNhapDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.hDNhapDataGridView.DataSource = this.hDNhapBindingSource;
            this.hDNhapDataGridView.Location = new System.Drawing.Point(20, 36);
            this.hDNhapDataGridView.Name = "hDNhapDataGridView";
            this.hDNhapDataGridView.RowHeadersWidth = 51;
            this.hDNhapDataGridView.RowTemplate.Height = 24;
            this.hDNhapDataGridView.Size = new System.Drawing.Size(1132, 260);
            this.hDNhapDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHDNhap";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaHDNhap";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaNhanVien";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaNhanVien";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NhaCCID";
            this.dataGridViewTextBoxColumn3.HeaderText = "NhaCCID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NgayNhap";
            this.dataGridViewTextBoxColumn4.HeaderText = "NgayNhap";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TongTien";
            this.dataGridViewTextBoxColumn5.HeaderText = "TongTien";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // XuấtfileExcel
            // 
            this.XuấtfileExcel.BackColor = System.Drawing.Color.Lime;
            this.XuấtfileExcel.Location = new System.Drawing.Point(74, 107);
            this.XuấtfileExcel.Name = "XuấtfileExcel";
            this.XuấtfileExcel.Size = new System.Drawing.Size(120, 59);
            this.XuấtfileExcel.TabIndex = 4;
            this.XuấtfileExcel.Text = "Xuất File Excel";
            this.XuấtfileExcel.UseVisualStyleBackColor = false;
            this.XuấtfileExcel.Click += new System.EventHandler(this.XuấtfileExcel_Click);
            // 
            // GUI_Thongkehoadonnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1261, 577);
            this.Controls.Add(this.XuấtfileExcel);
            this.Controls.Add(this.hDNhapBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "GUI_Thongkehoadonnhap";
            this.Text = "GUI_Thongkehoadonnhap";
            this.Load += new System.EventHandler(this.GUI_Thongkehoadonnhap_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLNH_DA1_10121268_DVPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDNhapBindingNavigator)).EndInit();
            this.hDNhapBindingNavigator.ResumeLayout(false);
            this.hDNhapBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hDNhapDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private QLNH_DA1_10121268_DVPDataSet qLNH_DA1_10121268_DVPDataSet;
        private System.Windows.Forms.BindingSource hDNhapBindingSource;
        private QLNH_DA1_10121268_DVPDataSetTableAdapters.HDNhapTableAdapter hDNhapTableAdapter;
        private QLNH_DA1_10121268_DVPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hDNhapBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hDNhapBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hDNhapDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button XuấtfileExcel;
    }
}