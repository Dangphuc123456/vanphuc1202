namespace DangVanPhuc_10121268_DA1_QLNH
{
    partial class GUI_Thongkehoadonban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Thongkehoadonban));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hDBanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNH_DA1_10121268_DVPDataSet = new DangVanPhuc_10121268_DA1_QLNH.QLNH_DA1_10121268_DVPDataSet();
            this.hDBanTableAdapter = new DangVanPhuc_10121268_DA1_QLNH.QLNH_DA1_10121268_DVPDataSetTableAdapters.HDBanTableAdapter();
            this.tableAdapterManager = new DangVanPhuc_10121268_DA1_QLNH.QLNH_DA1_10121268_DVPDataSetTableAdapters.TableAdapterManager();
            this.hDBanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXuatfileExcel = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.hDBanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hDBanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNH_DA1_10121268_DVPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBanBindingNavigator)).BeginInit();
            this.hDBanBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Hóa Đơn Bán";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hDBanDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1269, 298);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thống kê hóa đơn bán";
            // 
            // hDBanDataGridView
            // 
            this.hDBanDataGridView.AutoGenerateColumns = false;
            this.hDBanDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hDBanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hDBanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.hDBanDataGridView.DataSource = this.hDBanBindingSource;
            this.hDBanDataGridView.Location = new System.Drawing.Point(6, 21);
            this.hDBanDataGridView.Name = "hDBanDataGridView";
            this.hDBanDataGridView.RowHeadersWidth = 51;
            this.hDBanDataGridView.RowTemplate.Height = 24;
            this.hDBanDataGridView.Size = new System.Drawing.Size(1257, 254);
            this.hDBanDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHDBan";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaHDBan";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayBan";
            this.dataGridViewTextBoxColumn3.HeaderText = "NgayBan";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaKhach";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaKhach";
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
            // hDBanBindingSource
            // 
            this.hDBanBindingSource.DataMember = "HDBan";
            this.hDBanBindingSource.DataSource = this.qLNH_DA1_10121268_DVPDataSet;
            // 
            // qLNH_DA1_10121268_DVPDataSet
            // 
            this.qLNH_DA1_10121268_DVPDataSet.DataSetName = "QLNH_DA1_10121268_DVPDataSet";
            this.qLNH_DA1_10121268_DVPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hDBanTableAdapter
            // 
            this.hDBanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietHDBanTableAdapter = null;
            this.tableAdapterManager.ChiTietHDNhapTableAdapter = null;
            this.tableAdapterManager.HDBanTableAdapter = this.hDBanTableAdapter;
            this.tableAdapterManager.HDNhapTableAdapter = null;
            this.tableAdapterManager.KhachTableAdapter = null;
            this.tableAdapterManager.MonanTableAdapter = null;
            this.tableAdapterManager.NguyenlieuTableAdapter = null;
            this.tableAdapterManager.NhaCCTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DangVanPhuc_10121268_DA1_QLNH.QLNH_DA1_10121268_DVPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hDBanBindingNavigator
            // 
            this.hDBanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hDBanBindingNavigator.BindingSource = this.hDBanBindingSource;
            this.hDBanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hDBanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hDBanBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.hDBanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hDBanBindingNavigatorSaveItem});
            this.hDBanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hDBanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hDBanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hDBanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hDBanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hDBanBindingNavigator.Name = "hDBanBindingNavigator";
            this.hDBanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hDBanBindingNavigator.Size = new System.Drawing.Size(1295, 27);
            this.hDBanBindingNavigator.TabIndex = 5;
            this.hDBanBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnXuatfileExcel
            // 
            this.btnXuatfileExcel.BackColor = System.Drawing.Color.Lime;
            this.btnXuatfileExcel.Location = new System.Drawing.Point(39, 117);
            this.btnXuatfileExcel.Name = "btnXuatfileExcel";
            this.btnXuatfileExcel.Size = new System.Drawing.Size(123, 59);
            this.btnXuatfileExcel.TabIndex = 6;
            this.btnXuatfileExcel.Text = "Xuất File Excel";
            this.btnXuatfileExcel.UseVisualStyleBackColor = false;
            this.btnXuatfileExcel.Click += new System.EventHandler(this.btnXuatfileExcel_Click);
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
            // hDBanBindingNavigatorSaveItem
            // 
            this.hDBanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hDBanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hDBanBindingNavigatorSaveItem.Image")));
            this.hDBanBindingNavigatorSaveItem.Name = "hDBanBindingNavigatorSaveItem";
            this.hDBanBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.hDBanBindingNavigatorSaveItem.Text = "Save Data";
            this.hDBanBindingNavigatorSaveItem.Click += new System.EventHandler(this.hDBanBindingNavigatorSaveItem_Click);
            // 
            // GUI_Thongkehoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1295, 574);
            this.Controls.Add(this.btnXuatfileExcel);
            this.Controls.Add(this.hDBanBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "GUI_Thongkehoadonban";
            this.Text = "GUI_Thongke";
            this.Load += new System.EventHandler(this.GUI_Thongke_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hDBanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNH_DA1_10121268_DVPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBanBindingNavigator)).EndInit();
            this.hDBanBindingNavigator.ResumeLayout(false);
            this.hDBanBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private QLNH_DA1_10121268_DVPDataSet qLNH_DA1_10121268_DVPDataSet;
        private System.Windows.Forms.BindingSource hDBanBindingSource;
        private QLNH_DA1_10121268_DVPDataSetTableAdapters.HDBanTableAdapter hDBanTableAdapter;
        private QLNH_DA1_10121268_DVPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hDBanBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hDBanBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hDBanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnXuatfileExcel;
    }
}