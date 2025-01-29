namespace A_Waddell_CPT_206_A80S_Lab_2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.citiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.citiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.citiesDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSortAscName = new System.Windows.Forms.Button();
            this.btnPopAscSort = new System.Windows.Forms.Button();
            this.btnPopDescSort = new System.Windows.Forms.Button();
            this.btnGetTotal = new System.Windows.Forms.Button();
            this.btnGetAvg = new System.Windows.Forms.Button();
            this.btnGetHighest = new System.Windows.Forms.Button();
            this.btnGetLowest = new System.Windows.Forms.Button();
            this.lblGet = new System.Windows.Forms.Label();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityDBDataSet = new A_Waddell_CPT_206_A80S_Lab_2.CityDBDataSet();
            this.citiesTableAdapter = new A_Waddell_CPT_206_A80S_Lab_2.CityDBDataSetTableAdapters.CitiesTableAdapter();
            this.tableAdapterManager = new A_Waddell_CPT_206_A80S_Lab_2.CityDBDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Population = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingNavigator)).BeginInit();
            this.citiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // citiesBindingNavigator
            // 
            this.citiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.citiesBindingNavigator.BindingSource = this.citiesBindingSource;
            this.citiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.citiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.citiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.citiesBindingNavigatorSaveItem});
            this.citiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.citiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.citiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.citiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.citiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.citiesBindingNavigator.Name = "citiesBindingNavigator";
            this.citiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.citiesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.citiesBindingNavigator.TabIndex = 0;
            this.citiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // citiesBindingNavigatorSaveItem
            // 
            this.citiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.citiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("citiesBindingNavigatorSaveItem.Image")));
            this.citiesBindingNavigatorSaveItem.Name = "citiesBindingNavigatorSaveItem";
            this.citiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.citiesBindingNavigatorSaveItem.Text = "Save Data";
            this.citiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.citiesBindingNavigatorSaveItem_Click);
            // 
            // citiesDataGridView
            // 
            this.citiesDataGridView.AutoGenerateColumns = false;
            this.citiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Population,
            this.dataGridViewTextBoxColumn2});
            this.citiesDataGridView.DataSource = this.citiesBindingSource;
            this.citiesDataGridView.Location = new System.Drawing.Point(348, 52);
            this.citiesDataGridView.Name = "citiesDataGridView";
            this.citiesDataGridView.Size = new System.Drawing.Size(391, 248);
            this.citiesDataGridView.TabIndex = 1;
            // 
            // btnSortAscName
            // 
            this.btnSortAscName.AutoSize = true;
            this.btnSortAscName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSortAscName.Location = new System.Drawing.Point(122, 133);
            this.btnSortAscName.Name = "btnSortAscName";
            this.btnSortAscName.Size = new System.Drawing.Size(145, 30);
            this.btnSortAscName.TabIndex = 2;
            this.btnSortAscName.Text = "Name Sort";
            this.btnSortAscName.UseVisualStyleBackColor = true;
            this.btnSortAscName.Click += new System.EventHandler(this.btnSortAscName_Click);
            // 
            // btnPopAscSort
            // 
            this.btnPopAscSort.AutoSize = true;
            this.btnPopAscSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnPopAscSort.Location = new System.Drawing.Point(106, 184);
            this.btnPopAscSort.Name = "btnPopAscSort";
            this.btnPopAscSort.Size = new System.Drawing.Size(179, 30);
            this.btnPopAscSort.TabIndex = 3;
            this.btnPopAscSort.Text = "Population Sort (Asc)";
            this.btnPopAscSort.UseVisualStyleBackColor = true;
            this.btnPopAscSort.Click += new System.EventHandler(this.btnPopAscSort_Click);
            // 
            // btnPopDescSort
            // 
            this.btnPopDescSort.AutoSize = true;
            this.btnPopDescSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnPopDescSort.Location = new System.Drawing.Point(102, 235);
            this.btnPopDescSort.Name = "btnPopDescSort";
            this.btnPopDescSort.Size = new System.Drawing.Size(190, 30);
            this.btnPopDescSort.TabIndex = 4;
            this.btnPopDescSort.Text = "Population Sort (Desc)";
            this.btnPopDescSort.UseVisualStyleBackColor = true;
            this.btnPopDescSort.Click += new System.EventHandler(this.btnPopDescSort_Click);
            // 
            // btnGetTotal
            // 
            this.btnGetTotal.AutoSize = true;
            this.btnGetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnGetTotal.Location = new System.Drawing.Point(89, 398);
            this.btnGetTotal.Name = "btnGetTotal";
            this.btnGetTotal.Size = new System.Drawing.Size(100, 30);
            this.btnGetTotal.TabIndex = 5;
            this.btnGetTotal.Text = "Get Total";
            this.btnGetTotal.UseVisualStyleBackColor = true;
            this.btnGetTotal.Click += new System.EventHandler(this.btnGetTotal_Click);
            // 
            // btnGetAvg
            // 
            this.btnGetAvg.AutoSize = true;
            this.btnGetAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnGetAvg.Location = new System.Drawing.Point(237, 398);
            this.btnGetAvg.Name = "btnGetAvg";
            this.btnGetAvg.Size = new System.Drawing.Size(112, 30);
            this.btnGetAvg.TabIndex = 6;
            this.btnGetAvg.Text = "Get Average";
            this.btnGetAvg.UseVisualStyleBackColor = true;
            this.btnGetAvg.Click += new System.EventHandler(this.btnGetAvg_Click);
            // 
            // btnGetHighest
            // 
            this.btnGetHighest.AutoSize = true;
            this.btnGetHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnGetHighest.Location = new System.Drawing.Point(419, 398);
            this.btnGetHighest.Name = "btnGetHighest";
            this.btnGetHighest.Size = new System.Drawing.Size(109, 30);
            this.btnGetHighest.TabIndex = 7;
            this.btnGetHighest.Text = "Get Highest";
            this.btnGetHighest.UseVisualStyleBackColor = true;
            this.btnGetHighest.Click += new System.EventHandler(this.btnGetHighest_Click);
            // 
            // btnGetLowest
            // 
            this.btnGetLowest.AutoSize = true;
            this.btnGetLowest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnGetLowest.Location = new System.Drawing.Point(582, 398);
            this.btnGetLowest.Name = "btnGetLowest";
            this.btnGetLowest.Size = new System.Drawing.Size(105, 30);
            this.btnGetLowest.TabIndex = 8;
            this.btnGetLowest.Text = "Get Lowest";
            this.btnGetLowest.UseVisualStyleBackColor = true;
            this.btnGetLowest.Click += new System.EventHandler(this.btnGetLowest_Click);
            // 
            // lblGet
            // 
            this.lblGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblGet.Location = new System.Drawing.Point(184, 323);
            this.lblGet.Name = "lblGet";
            this.lblGet.Size = new System.Drawing.Size(438, 53);
            this.lblGet.TabIndex = 9;
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.cityDBDataSet;
            // 
            // cityDBDataSet
            // 
            this.cityDBDataSet.DataSetName = "CityDBDataSet";
            this.cityDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitiesTableAdapter = this.citiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = A_Waddell_CPT_206_A80S_Lab_2.CityDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "State ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "State ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Population
            // 
            this.Population.DataPropertyName = "Population";
            this.Population.HeaderText = "Population";
            this.Population.Name = "Population";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "City Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "City Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGet);
            this.Controls.Add(this.btnGetLowest);
            this.Controls.Add(this.btnGetHighest);
            this.Controls.Add(this.btnGetAvg);
            this.Controls.Add(this.btnGetTotal);
            this.Controls.Add(this.btnPopDescSort);
            this.Controls.Add(this.btnPopAscSort);
            this.Controls.Add(this.btnSortAscName);
            this.Controls.Add(this.citiesDataGridView);
            this.Controls.Add(this.citiesBindingNavigator);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingNavigator)).EndInit();
            this.citiesBindingNavigator.ResumeLayout(false);
            this.citiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityDBDataSet cityDBDataSet;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private CityDBDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private CityDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator citiesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton citiesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView citiesDataGridView;
        private System.Windows.Forms.Button btnSortAscName;
        private System.Windows.Forms.Button btnPopAscSort;
        private System.Windows.Forms.Button btnPopDescSort;
        private System.Windows.Forms.Button btnGetTotal;
        private System.Windows.Forms.Button btnGetAvg;
        private System.Windows.Forms.Button btnGetHighest;
        private System.Windows.Forms.Button btnGetLowest;
        private System.Windows.Forms.Label lblGet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Population;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}