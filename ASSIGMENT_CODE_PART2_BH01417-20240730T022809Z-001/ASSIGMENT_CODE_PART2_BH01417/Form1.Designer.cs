namespace ASSIGMENT_CODE_PART2_BH01417
{
    partial class Form1
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
            this.lbNo = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbPeople = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbPeople = new System.Windows.Forms.TextBox();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.lbThisMonth = new System.Windows.Forms.Label();
            this.lbLastMonth = new System.Windows.Forms.Label();
            this.tbThisMonth = new System.Windows.Forms.TextBox();
            this.tbLastMonth = new System.Windows.Forms.TextBox();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.clNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmWaterconsump = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.Location = new System.Drawing.Point(42, 26);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(21, 13);
            this.lbNo.TabIndex = 0;
            this.lbNo.Text = "No";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(42, 69);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(42, 112);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(38, 13);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Phone";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(42, 168);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(42, 13);
            this.lbGender.TabIndex = 3;
            this.lbGender.Text = "Gender";
            this.lbGender.Click += new System.EventHandler(this.lbGender_Click);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(401, 23);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(78, 13);
            this.lbType.TabIndex = 4;
            this.lbType.Text = "Customer Type";
            // 
            // lbPeople
            // 
            this.lbPeople.AutoSize = true;
            this.lbPeople.Location = new System.Drawing.Point(387, 72);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(92, 13);
            this.lbPeople.TabIndex = 5;
            this.lbPeople.Text = "Number of People";
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(127, 26);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(100, 20);
            this.tbNo.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(127, 69);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 7;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(499, 20);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(100, 20);
            this.tbType.TabIndex = 8;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(127, 112);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 9;
            // 
            // tbPeople
            // 
            this.tbPeople.Location = new System.Drawing.Point(499, 66);
            this.tbPeople.Name = "tbPeople";
            this.tbPeople.Size = new System.Drawing.Size(100, 20);
            this.tbPeople.TabIndex = 10;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(115, 168);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(48, 17);
            this.rbM.TabIndex = 11;
            this.rbM.TabStop = true;
            this.rbM.Text = "Male";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(196, 168);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(59, 17);
            this.rbF.TabIndex = 12;
            this.rbF.TabStop = true;
            this.rbF.Text = "Female";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // lbThisMonth
            // 
            this.lbThisMonth.AutoSize = true;
            this.lbThisMonth.Location = new System.Drawing.Point(647, 89);
            this.lbThisMonth.Name = "lbThisMonth";
            this.lbThisMonth.Size = new System.Drawing.Size(60, 13);
            this.lbThisMonth.TabIndex = 13;
            this.lbThisMonth.Text = "This Month";
            // 
            // lbLastMonth
            // 
            this.lbLastMonth.AutoSize = true;
            this.lbLastMonth.Location = new System.Drawing.Point(647, 136);
            this.lbLastMonth.Name = "lbLastMonth";
            this.lbLastMonth.Size = new System.Drawing.Size(60, 13);
            this.lbLastMonth.TabIndex = 14;
            this.lbLastMonth.Text = "Last Month";
            // 
            // tbThisMonth
            // 
            this.tbThisMonth.Location = new System.Drawing.Point(713, 86);
            this.tbThisMonth.Name = "tbThisMonth";
            this.tbThisMonth.Size = new System.Drawing.Size(66, 20);
            this.tbThisMonth.TabIndex = 15;
            // 
            // tbLastMonth
            // 
            this.tbLastMonth.Location = new System.Drawing.Point(713, 133);
            this.tbLastMonth.Name = "tbLastMonth";
            this.tbLastMonth.Size = new System.Drawing.Size(66, 20);
            this.tbLastMonth.TabIndex = 16;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNo,
            this.clName,
            this.clmPhone,
            this.clmGender,
            this.clmWaterconsump,
            this.clmTotal});
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(-2, 286);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(803, 167);
            this.lsvBill.TabIndex = 17;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 32);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(164, 225);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 32);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(290, 225);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 32);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(441, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 32);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(581, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 32);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // clNo
            // 
            this.clNo.Text = "No";
            // 
            // clName
            // 
            this.clName.Text = "Name";
            // 
            // clmPhone
            // 
            this.clmPhone.Text = "Phone";
            // 
            // clmGender
            // 
            this.clmGender.Text = "Gender";
            // 
            // clmWaterconsump
            // 
            this.clmWaterconsump.Text = "Water consump";
            // 
            // clmTotal
            // 
            this.clmTotal.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsvBill);
            this.Controls.Add(this.tbLastMonth);
            this.Controls.Add(this.tbThisMonth);
            this.Controls.Add(this.lbLastMonth);
            this.Controls.Add(this.lbThisMonth);
            this.Controls.Add(this.rbF);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.tbPeople);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.lbPeople);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbPeople;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbPeople;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.Label lbThisMonth;
        private System.Windows.Forms.Label lbLastMonth;
        private System.Windows.Forms.TextBox tbThisMonth;
        private System.Windows.Forms.TextBox tbLastMonth;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader clNo;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clmPhone;
        private System.Windows.Forms.ColumnHeader clmGender;
        private System.Windows.Forms.ColumnHeader clmWaterconsump;
        private System.Windows.Forms.ColumnHeader clmTotal;
    }
}

