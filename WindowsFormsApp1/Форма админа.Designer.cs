
namespace WindowsFormsApp1
{
    partial class FormAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivaldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentid1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentid2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentid3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admin = new WindowsFormsApp1.admin();
            this.furnitureTableAdapter = new WindowsFormsApp1.adminTableAdapters.furnitureTableAdapter();
            this.BtnForward = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAZ = new System.Windows.Forms.Button();
            this.BtnZA = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.arrivaldateDataGridViewTextBoxColumn,
            this.manufacturedateDataGridViewTextBoxColumn,
            this.componentid1DataGridViewTextBoxColumn,
            this.componentid2DataGridViewTextBoxColumn,
            this.componentid3DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.furnitureBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // arrivaldateDataGridViewTextBoxColumn
            // 
            this.arrivaldateDataGridViewTextBoxColumn.DataPropertyName = "arrival_date";
            this.arrivaldateDataGridViewTextBoxColumn.HeaderText = "arrival_date";
            this.arrivaldateDataGridViewTextBoxColumn.Name = "arrivaldateDataGridViewTextBoxColumn";
            // 
            // manufacturedateDataGridViewTextBoxColumn
            // 
            this.manufacturedateDataGridViewTextBoxColumn.DataPropertyName = "manufacture_date";
            this.manufacturedateDataGridViewTextBoxColumn.HeaderText = "manufacture_date";
            this.manufacturedateDataGridViewTextBoxColumn.Name = "manufacturedateDataGridViewTextBoxColumn";
            // 
            // componentid1DataGridViewTextBoxColumn
            // 
            this.componentid1DataGridViewTextBoxColumn.DataPropertyName = "component_id1";
            this.componentid1DataGridViewTextBoxColumn.HeaderText = "component_id1";
            this.componentid1DataGridViewTextBoxColumn.Name = "componentid1DataGridViewTextBoxColumn";
            // 
            // componentid2DataGridViewTextBoxColumn
            // 
            this.componentid2DataGridViewTextBoxColumn.DataPropertyName = "component_id2";
            this.componentid2DataGridViewTextBoxColumn.HeaderText = "component_id2";
            this.componentid2DataGridViewTextBoxColumn.Name = "componentid2DataGridViewTextBoxColumn";
            // 
            // componentid3DataGridViewTextBoxColumn
            // 
            this.componentid3DataGridViewTextBoxColumn.DataPropertyName = "component_id3";
            this.componentid3DataGridViewTextBoxColumn.HeaderText = "component_id3";
            this.componentid3DataGridViewTextBoxColumn.Name = "componentid3DataGridViewTextBoxColumn";
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataMember = "furniture";
            this.furnitureBindingSource.DataSource = this.admin;
            // 
            // admin
            // 
            this.admin.DataSetName = "admin";
            this.admin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furnitureTableAdapter
            // 
            this.furnitureTableAdapter.ClearBeforeFill = true;
            // 
            // BtnForward
            // 
            this.BtnForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnForward.Location = new System.Drawing.Point(12, 12);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(108, 23);
            this.BtnForward.TabIndex = 1;
            this.BtnForward.Text = "Назад";
            this.BtnForward.UseVisualStyleBackColor = true;
            this.BtnForward.Click += new System.EventHandler(this.BtnForward_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(12, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(126, 361);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(108, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Location = new System.Drawing.Point(240, 361);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(108, 23);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Обновить";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAZ
            // 
            this.BtnAZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAZ.Location = new System.Drawing.Point(12, 390);
            this.BtnAZ.Name = "BtnAZ";
            this.BtnAZ.Size = new System.Drawing.Size(164, 23);
            this.BtnAZ.TabIndex = 5;
            this.BtnAZ.Text = "Сортировка А-Я";
            this.BtnAZ.UseVisualStyleBackColor = true;
            this.BtnAZ.Click += new System.EventHandler(this.BtnAZ_Click);
            // 
            // BtnZA
            // 
            this.BtnZA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnZA.Location = new System.Drawing.Point(184, 390);
            this.BtnZA.Name = "BtnZA";
            this.BtnZA.Size = new System.Drawing.Size(164, 23);
            this.BtnZA.TabIndex = 6;
            this.BtnZA.Text = "Сортировка Я-А";
            this.BtnZA.UseVisualStyleBackColor = true;
            this.BtnZA.Click += new System.EventHandler(this.BtnZA_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Location = new System.Drawing.Point(937, 361);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(117, 23);
            this.BtnSearch.TabIndex = 7;
            this.BtnSearch.Text = "Поиск";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFilter.Location = new System.Drawing.Point(937, 390);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(117, 23);
            this.BtnFilter.TabIndex = 8;
            this.BtnFilter.Text = "Фильтр";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(675, 363);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(256, 20);
            this.textBoxSearch.TabIndex = 9;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(675, 391);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 20);
            this.textBox2.TabIndex = 10;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 423);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnZA);
            this.Controls.Add(this.BtnAZ);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnForward);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAdmin";
            this.Text = "Форма админа";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private admin admin;
        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private adminTableAdapters.furnitureTableAdapter furnitureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentid1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentid2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentid3DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnForward;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAZ;
        private System.Windows.Forms.Button BtnZA;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBox2;
    }
}