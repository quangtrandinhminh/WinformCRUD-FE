namespace StudentCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblName = new Label();
            lblAge = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            dgvListStudents = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListStudents).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(43, 66);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 25);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(43, 109);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(43, 154);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(44, 25);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age";
            // 
            // txtId
            // 
            txtId.Location = new Point(121, 60);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(264, 31);
            txtId.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(121, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 31);
            txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(121, 148);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(264, 31);
            txtAge.TabIndex = 5;
            // 
            // dgvListStudents
            // 
            dgvListStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListStudents.Location = new Point(412, 60);
            dgvListStudents.Name = "dgvListStudents";
            dgvListStudents.RowHeadersWidth = 62;
            dgvListStudents.RowTemplate.Height = 33;
            dgvListStudents.Size = new Size(489, 306);
            dgvListStudents.TabIndex = 6;
            dgvListStudents.CellContentDoubleClick += dgvListStudents_CellContentDoubleClick;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(126, 218);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(78, 34);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(210, 218);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 34);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(303, 218);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 34);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dgvListStudents);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvListStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblAge;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAge;
        private DataGridView dgvListStudents;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
    }
}