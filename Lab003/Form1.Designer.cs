namespace Lab003
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
            this.labelName = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.Birth = new System.Windows.Forms.TextBox();
            this.labelBirth = new System.Windows.Forms.Label();
            this.High = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.Garde = new System.Windows.Forms.TextBox();
            this.labelGarde = new System.Windows.Forms.Label();
            this.SS = new System.Windows.Forms.TextBox();
            this.labelField = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAllStd = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGarde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(11, 61);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "ชื่อ";
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name.Location = new System.Drawing.Point(119, 61);
            this.Name.Margin = new System.Windows.Forms.Padding(2);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(161, 33);
            this.Name.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(119, 101);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(161, 33);
            this.ID.TabIndex = 3;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(11, 101);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(33, 25);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            // 
            // Birth
            // 
            this.Birth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Birth.Location = new System.Drawing.Point(119, 146);
            this.Birth.Margin = new System.Windows.Forms.Padding(2);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(161, 33);
            this.Birth.TabIndex = 5;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBirth.Location = new System.Drawing.Point(11, 146);
            this.labelBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(54, 25);
            this.labelBirth.TabIndex = 4;
            this.labelBirth.Text = "ปีเกิด";
            // 
            // High
            // 
            this.High.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.High.Location = new System.Drawing.Point(119, 190);
            this.High.Margin = new System.Windows.Forms.Padding(2);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(161, 33);
            this.High.TabIndex = 7;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeight.Location = new System.Drawing.Point(11, 193);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(68, 25);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Text = "ส่วนสูง";
            // 
            // Garde
            // 
            this.Garde.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Garde.Location = new System.Drawing.Point(119, 235);
            this.Garde.Margin = new System.Windows.Forms.Padding(2);
            this.Garde.Name = "Garde";
            this.Garde.Size = new System.Drawing.Size(161, 33);
            this.Garde.TabIndex = 9;
            // 
            // labelGarde
            // 
            this.labelGarde.AutoSize = true;
            this.labelGarde.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGarde.Location = new System.Drawing.Point(11, 235);
            this.labelGarde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGarde.Name = "labelGarde";
            this.labelGarde.Size = new System.Drawing.Size(52, 25);
            this.labelGarde.TabIndex = 8;
            this.labelGarde.Text = "เกรด";
            // 
            // SS
            // 
            this.SS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SS.Location = new System.Drawing.Point(119, 276);
            this.SS.Margin = new System.Windows.Forms.Padding(2);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(161, 33);
            this.SS.TabIndex = 11;
            // 
            // labelField
            // 
            this.labelField.AutoSize = true;
            this.labelField.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelField.Location = new System.Drawing.Point(10, 276);
            this.labelField.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelField.Name = "labelField";
            this.labelField.Size = new System.Drawing.Size(111, 25);
            this.labelField.TabIndex = 10;
            this.labelField.Text = "สาขาที่เรียน";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(11, 364);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 35);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "เพิ่มข้อมูล";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnID,
            this.ColumnBirth,
            this.ColumnHeight,
            this.ColumnGarde,
            this.ColumnField});
            this.dataGridView1.Location = new System.Drawing.Point(299, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(968, 310);
            this.dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(148, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "แสดงผล";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAllStd
            // 
            this.textBoxAllStd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxAllStd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAllStd.Location = new System.Drawing.Point(559, 381);
            this.textBoxAllStd.Name = "textBoxAllStd";
            this.textBoxAllStd.Size = new System.Drawing.Size(100, 33);
            this.textBoxAllStd.TabIndex = 15;
            // 
            // textBoxMax
            // 
            this.textBoxMax.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxMax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMax.Location = new System.Drawing.Point(559, 420);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 33);
            this.textBoxMax.TabIndex = 16;
            // 
            // textBoxMin
            // 
            this.textBoxMin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxMin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMin.Location = new System.Drawing.Point(559, 459);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 33);
            this.textBoxMin.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(410, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "จำนวนนักเรียน";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(410, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "คนที่มีเกรดสูงสุด";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(410, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "คนที่มีเกรดน้อยสุด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(517, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "ตารางข้อมูล";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(69, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "โปรดใส่ข้อมูล";
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "NAME";
            this.ColumnName.HeaderText = "ชื่อ";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 150;
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ID";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 8;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 150;
            // 
            // ColumnBirth
            // 
            this.ColumnBirth.DataPropertyName = "Birth";
            this.ColumnBirth.HeaderText = "ปีเกิด";
            this.ColumnBirth.MinimumWidth = 8;
            this.ColumnBirth.Name = "ColumnBirth";
            this.ColumnBirth.ReadOnly = true;
            this.ColumnBirth.Width = 150;
            // 
            // ColumnHeight
            // 
            this.ColumnHeight.DataPropertyName = "Height";
            this.ColumnHeight.HeaderText = "ส่วนสูง";
            this.ColumnHeight.MinimumWidth = 8;
            this.ColumnHeight.Name = "ColumnHeight";
            this.ColumnHeight.ReadOnly = true;
            this.ColumnHeight.Width = 150;
            // 
            // ColumnGarde
            // 
            this.ColumnGarde.DataPropertyName = "Garde";
            this.ColumnGarde.HeaderText = "เกรด";
            this.ColumnGarde.MinimumWidth = 8;
            this.ColumnGarde.Name = "ColumnGarde";
            this.ColumnGarde.ReadOnly = true;
            this.ColumnGarde.Width = 150;
            // 
            // ColumnField
            // 
            this.ColumnField.DataPropertyName = "Field";
            this.ColumnField.HeaderText = "สาขา";
            this.ColumnField.MinimumWidth = 8;
            this.ColumnField.Name = "ColumnField";
            this.ColumnField.ReadOnly = true;
            this.ColumnField.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 569);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxAllStd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.labelField);
            this.Controls.Add(this.Garde);
            this.Controls.Add(this.labelGarde);
            this.Controls.Add(this.High);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelName;
        private TextBox Name;
        private TextBox ID;
        private Label labelID;
        private TextBox Birth;
        private Label labelBirth;
        private TextBox High;
        private Label labelHeight;
        private TextBox Garde;
        private Label labelGarde;
        private TextBox SS;
        private Label labelField;
        private Button buttonAdd;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBoxAllStd;
        private TextBox textBoxMax;
        private TextBox textBoxMin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnBirth;
        private DataGridViewTextBoxColumn ColumnHeight;
        private DataGridViewTextBoxColumn ColumnGarde;
        private DataGridViewTextBoxColumn ColumnField;
    }
}