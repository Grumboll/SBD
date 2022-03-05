namespace SBD
{
    partial class AddTicketForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet3 = new SBD.DataSet3();
            this.rEZERVACIIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEZERVACIITableAdapter = new SBD.DataSet3TableAdapters.REZERVACIITableAdapter();
            this.iDREZERVACIQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSLUJITELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLINIQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEZERVACIIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDREZERVACIQDataGridViewTextBoxColumn,
            this.dATASDataGridViewTextBoxColumn,
            this.cENADataGridViewTextBoxColumn,
            this.iDSLUJITELDataGridViewTextBoxColumn,
            this.iDKLIENTDataGridViewTextBoxColumn,
            this.iDLINIQDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEZERVACIIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 164);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reservations:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add Ticket:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ticket type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bus seat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reservation id:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ticket types:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "One way Ticket, id: 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Two way Ticket, id: 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEZERVACIIBindingSource
            // 
            this.rEZERVACIIBindingSource.DataMember = "REZERVACII";
            this.rEZERVACIIBindingSource.DataSource = this.dataSet3;
            // 
            // rEZERVACIITableAdapter
            // 
            this.rEZERVACIITableAdapter.ClearBeforeFill = true;
            // 
            // iDREZERVACIQDataGridViewTextBoxColumn
            // 
            this.iDREZERVACIQDataGridViewTextBoxColumn.DataPropertyName = "ID_REZERVACIQ";
            this.iDREZERVACIQDataGridViewTextBoxColumn.HeaderText = "ID_REZERVACIQ";
            this.iDREZERVACIQDataGridViewTextBoxColumn.Name = "iDREZERVACIQDataGridViewTextBoxColumn";
            // 
            // dATASDataGridViewTextBoxColumn
            // 
            this.dATASDataGridViewTextBoxColumn.DataPropertyName = "DATAS";
            this.dATASDataGridViewTextBoxColumn.HeaderText = "DATAS";
            this.dATASDataGridViewTextBoxColumn.Name = "dATASDataGridViewTextBoxColumn";
            // 
            // cENADataGridViewTextBoxColumn
            // 
            this.cENADataGridViewTextBoxColumn.DataPropertyName = "CENA";
            this.cENADataGridViewTextBoxColumn.HeaderText = "CENA";
            this.cENADataGridViewTextBoxColumn.Name = "cENADataGridViewTextBoxColumn";
            // 
            // iDSLUJITELDataGridViewTextBoxColumn
            // 
            this.iDSLUJITELDataGridViewTextBoxColumn.DataPropertyName = "ID_SLUJITEL";
            this.iDSLUJITELDataGridViewTextBoxColumn.HeaderText = "ID_SLUJITEL";
            this.iDSLUJITELDataGridViewTextBoxColumn.Name = "iDSLUJITELDataGridViewTextBoxColumn";
            // 
            // iDKLIENTDataGridViewTextBoxColumn
            // 
            this.iDKLIENTDataGridViewTextBoxColumn.DataPropertyName = "ID_KLIENT";
            this.iDKLIENTDataGridViewTextBoxColumn.HeaderText = "ID_KLIENT";
            this.iDKLIENTDataGridViewTextBoxColumn.Name = "iDKLIENTDataGridViewTextBoxColumn";
            // 
            // iDLINIQDataGridViewTextBoxColumn
            // 
            this.iDLINIQDataGridViewTextBoxColumn.DataPropertyName = "ID_LINIQ";
            this.iDLINIQDataGridViewTextBoxColumn.HeaderText = "ID_LINIQ";
            this.iDLINIQDataGridViewTextBoxColumn.Name = "iDLINIQDataGridViewTextBoxColumn";
            // 
            // AddTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AddTicketForm";
            this.Text = "AddTicketForm";
            this.Load += new System.EventHandler(this.AddTicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEZERVACIIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource rEZERVACIIBindingSource;
        private DataSet3TableAdapters.REZERVACIITableAdapter rEZERVACIITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDREZERVACIQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSLUJITELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLINIQDataGridViewTextBoxColumn;
    }
}