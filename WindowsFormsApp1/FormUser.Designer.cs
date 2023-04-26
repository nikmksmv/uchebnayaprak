
namespace WindowsFormsApp1
{
    partial class FormUser
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
            this.BtnForward = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user = new WindowsFormsApp1.user();
            this.componentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componentsTableAdapter = new WindowsFormsApp1.userTableAdapters.componentsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivaldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnZA = new System.Windows.Forms.Button();
            this.BtnAZ = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnForward
            // 
            this.BtnForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnForward.Location = new System.Drawing.Point(12, 12);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(75, 23);
            this.BtnForward.TabIndex = 0;
            this.BtnForward.Text = "Назад";
            this.BtnForward.UseVisualStyleBackColor = true;
            this.BtnForward.Click += new System.EventHandler(this.BtnForward_Click);
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
            this.quantityDataGridViewTextBoxColumn,
            this.arrivaldateDataGridViewTextBoxColumn,
            this.usedateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.componentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 309);
            this.dataGridView1.TabIndex = 1;
            // 
            // user
            // 
            this.user.DataSetName = "user";
            this.user.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // componentsBindingSource
            // 
            this.componentsBindingSource.DataMember = "components";
            this.componentsBindingSource.DataSource = this.user;
            // 
            // componentsTableAdapter
            // 
            this.componentsTableAdapter.ClearBeforeFill = true;
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
            // usedateDataGridViewTextBoxColumn
            // 
            this.usedateDataGridViewTextBoxColumn.DataPropertyName = "use_date";
            this.usedateDataGridViewTextBoxColumn.HeaderText = "use_date";
            this.usedateDataGridViewTextBoxColumn.Name = "usedateDataGridViewTextBoxColumn";
            // 
            // BtnZA
            // 
            this.BtnZA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnZA.Location = new System.Drawing.Point(185, 388);
            this.BtnZA.Name = "BtnZA";
            this.BtnZA.Size = new System.Drawing.Size(164, 23);
            this.BtnZA.TabIndex = 11;
            this.BtnZA.Text = "Сортировка Я-А";
            this.BtnZA.UseVisualStyleBackColor = true;
            this.BtnZA.Click += new System.EventHandler(this.BtnZA_Click);
            // 
            // BtnAZ
            // 
            this.BtnAZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAZ.Location = new System.Drawing.Point(13, 388);
            this.BtnAZ.Name = "BtnAZ";
            this.BtnAZ.Size = new System.Drawing.Size(164, 23);
            this.BtnAZ.TabIndex = 10;
            this.BtnAZ.Text = "Сортировка А-Я";
            this.BtnAZ.UseVisualStyleBackColor = true;
            this.BtnAZ.Click += new System.EventHandler(this.BtnAZ_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Location = new System.Drawing.Point(241, 359);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(108, 23);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Обновить";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(127, 359);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(108, 23);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(13, 359);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(108, 23);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(372, 389);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(372, 361);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(161, 20);
            this.textBoxSearch.TabIndex = 14;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // BtnFilter
            // 
            this.BtnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFilter.Location = new System.Drawing.Point(539, 388);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(117, 23);
            this.BtnFilter.TabIndex = 13;
            this.BtnFilter.Text = "Фильтр";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Location = new System.Drawing.Point(539, 359);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(117, 23);
            this.BtnSearch.TabIndex = 12;
            this.BtnSearch.Text = "Поиск";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 423);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnZA);
            this.Controls.Add(this.BtnAZ);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnForward);
            this.Name = "FormUser";
            this.Text = "Форма пользователя";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnForward;
        private System.Windows.Forms.DataGridView dataGridView1;
        private user user;
        private System.Windows.Forms.BindingSource componentsBindingSource;
        private userTableAdapters.componentsTableAdapter componentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnZA;
        private System.Windows.Forms.Button BtnAZ;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnSearch;
    }
}