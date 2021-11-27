
namespace CourseWork
{
    partial class DBForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new CourseWork.Database1DataSet();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dealerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentialAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.clientTableAdapter = new CourseWork.Database1DataSetTableAdapters.ClientTableAdapter();
            this.dealerTableAdapter = new CourseWork.Database1DataSetTableAdapters.DealerTableAdapter();
            this.contractTableAdapter = new CourseWork.Database1DataSetTableAdapters.ContractTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Домой";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 186);
            this.dataGridView1.TabIndex = 2;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(743, 190);
            this.dataGridView3.TabIndex = 4;
            // 
            // dealerBindingSource
            // 
            this.dealerBindingSource.DataMember = "Dealer";
            this.dealerBindingSource.DataSource = this.database1DataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 209);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиенты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 215);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дилеры";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1245, 167);
            this.dataGridView2.TabIndex = 3;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.database1DataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(12, 477);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1251, 192);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Договоры";
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // residentialAddressDataGridViewTextBoxColumn
            // 
            this.residentialAddressDataGridViewTextBoxColumn.DataPropertyName = "ResidentialAddress";
            this.residentialAddressDataGridViewTextBoxColumn.HeaderText = "ResidentialAddress";
            this.residentialAddressDataGridViewTextBoxColumn.Name = "residentialAddressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // dealerTableAdapter
            // 
            this.dealerTableAdapter.ClearBeforeFill = true;
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "DBForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBForm";
            this.Load += new System.EventHandler(this.DBForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentialAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.DataGridView dataGridView2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Database1DataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource dealerBindingSource;
        private Database1DataSetTableAdapters.DealerTableAdapter dealerTableAdapter;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private Database1DataSetTableAdapters.ContractTableAdapter contractTableAdapter;
    }
}