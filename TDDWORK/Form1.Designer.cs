namespace TDDWORK
{
    partial class lblName
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
            this.TaxCal = new System.Windows.Forms.Button();
            this.Add10Employee = new System.Windows.Forms.Button();
            this.ListEmployee = new System.Windows.Forms.Button();
            this.SortBySalary = new System.Windows.Forms.Button();
            this.AddEmploye = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_family = new System.Windows.Forms.TextBox();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_addEmplyee = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaxCal
            // 
            this.TaxCal.BackColor = System.Drawing.Color.Pink;
            this.TaxCal.FlatAppearance.BorderSize = 0;
            this.TaxCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaxCal.Font = new System.Drawing.Font("Bauhaus 93", 17F, System.Drawing.FontStyle.Bold);
            this.TaxCal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TaxCal.Image = global::TDDWORK.Properties.Resources.tax_51x51;
            this.TaxCal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TaxCal.Location = new System.Drawing.Point(-2, 3);
            this.TaxCal.Name = "TaxCal";
            this.TaxCal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TaxCal.Size = new System.Drawing.Size(182, 79);
            this.TaxCal.TabIndex = 1;
            this.TaxCal.Text = "חישוב מס";
            this.TaxCal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaxCal.UseVisualStyleBackColor = false;
            this.TaxCal.Click += new System.EventHandler(this.TaxCal_Click);
            // 
            // Add10Employee
            // 
            this.Add10Employee.FlatAppearance.BorderSize = 0;
            this.Add10Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add10Employee.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add10Employee.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Add10Employee.Image = global::TDDWORK.Properties.Resources.group_61x61;
            this.Add10Employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add10Employee.Location = new System.Drawing.Point(480, 4);
            this.Add10Employee.Name = "Add10Employee";
            this.Add10Employee.Size = new System.Drawing.Size(143, 79);
            this.Add10Employee.TabIndex = 1;
            this.Add10Employee.Text = "הוספת\r\n 10,000\r\n עובדים";
            this.Add10Employee.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Add10Employee.UseVisualStyleBackColor = true;
            this.Add10Employee.Click += new System.EventHandler(this.Add10Employee_Click);
            // 
            // ListEmployee
            // 
            this.ListEmployee.FlatAppearance.BorderSize = 0;
            this.ListEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListEmployee.Font = new System.Drawing.Font("Bauhaus 93", 17F, System.Drawing.FontStyle.Bold);
            this.ListEmployee.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ListEmployee.Image = global::TDDWORK.Properties.Resources.clipboard_51x51;
            this.ListEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListEmployee.Location = new System.Drawing.Point(177, 4);
            this.ListEmployee.Name = "ListEmployee";
            this.ListEmployee.Size = new System.Drawing.Size(164, 80);
            this.ListEmployee.TabIndex = 1;
            this.ListEmployee.Text = "הצג רשימת\r\nעובדים\r\n";
            this.ListEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ListEmployee.UseVisualStyleBackColor = true;
            this.ListEmployee.Click += new System.EventHandler(this.ListEmployee_Click);
            // 
            // SortBySalary
            // 
            this.SortBySalary.FlatAppearance.BorderSize = 0;
            this.SortBySalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortBySalary.Font = new System.Drawing.Font("Bauhaus 93", 17F, System.Drawing.FontStyle.Bold);
            this.SortBySalary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SortBySalary.Image = global::TDDWORK.Properties.Resources.dollar_51x51;
            this.SortBySalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SortBySalary.Location = new System.Drawing.Point(347, 4);
            this.SortBySalary.Name = "SortBySalary";
            this.SortBySalary.Size = new System.Drawing.Size(127, 79);
            this.SortBySalary.TabIndex = 1;
            this.SortBySalary.Text = "מיון לפי\r\n משכורת";
            this.SortBySalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SortBySalary.UseVisualStyleBackColor = true;
            this.SortBySalary.Click += new System.EventHandler(this.SortBySalary_Click);
            // 
            // AddEmploye
            // 
            this.AddEmploye.BackColor = System.Drawing.Color.SlateGray;
            this.AddEmploye.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddEmploye.FlatAppearance.BorderSize = 4;
            this.AddEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmploye.Font = new System.Drawing.Font("Bauhaus 93", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmploye.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddEmploye.Image = global::TDDWORK.Properties.Resources.person_icon_1682_62x80__1_;
            this.AddEmploye.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddEmploye.Location = new System.Drawing.Point(3, 379);
            this.AddEmploye.Name = "AddEmploye";
            this.AddEmploye.Size = new System.Drawing.Size(200, 80);
            this.AddEmploye.TabIndex = 1;
            this.AddEmploye.Text = "הוספת עובד";
            this.AddEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddEmploye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddEmploye.UseVisualStyleBackColor = false;
            this.AddEmploye.Click += new System.EventHandler(this.AddEmploye_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.HideSelection = false;
            this.textBox_name.Location = new System.Drawing.Point(6, 78);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(96, 20);
            this.textBox_name.TabIndex = 4;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(6, 166);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(96, 20);
            this.textBox_id.TabIndex = 5;
            // 
            // textBox_family
            // 
            this.textBox_family.Location = new System.Drawing.Point(6, 117);
            this.textBox_family.Name = "textBox_family";
            this.textBox_family.Size = new System.Drawing.Size(96, 20);
            this.textBox_family.TabIndex = 6;
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(6, 287);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(96, 20);
            this.textBox_salary.TabIndex = 7;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(6, 246);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(96, 20);
            this.textBox_phone.TabIndex = 8;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(6, 328);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(96, 20);
            this.textBox_email.TabIndex = 9;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(6, 202);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(96, 20);
            this.textBox_address.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "פרטי עובד";
            // 
            // lbl_addEmplyee
            // 
            this.lbl_addEmplyee.AutoSize = true;
            this.lbl_addEmplyee.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addEmplyee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_addEmplyee.Location = new System.Drawing.Point(111, 75);
            this.lbl_addEmplyee.Name = "lbl_addEmplyee";
            this.lbl_addEmplyee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_addEmplyee.Size = new System.Drawing.Size(89, 273);
            this.lbl_addEmplyee.TabIndex = 13;
            this.lbl_addEmplyee.Text = "שם \r\n\r\nשם משפחה\r\n\r\nת\"ז\r\n\r\nכתובת\r\n\r\nפלאפון\r\n\r\nמשכורת\r\n\r\nאימייל\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.AddEmploye);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_addEmplyee);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.textBox_family);
            this.panel1.Controls.Add(this.textBox_address);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.textBox_phone);
            this.panel1.Controls.Add(this.textBox_email);
            this.panel1.Controls.Add(this.textBox_salary);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(623, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 459);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.ListEmployee);
            this.panel2.Controls.Add(this.SortBySalary);
            this.panel2.Controls.Add(this.TaxCal);
            this.panel2.Controls.Add(this.Add10Employee);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 85);
            this.panel2.TabIndex = 15;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Azure;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.ID,
            this.salary});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(180, 85);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(445, 371);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // name
            // 
            this.name.Text = "שם";
            this.name.Width = 150;
            // 
            // ID
            // 
            this.ID.Text = "ת\"ז";
            this.ID.Width = 150;
            // 
            // salary
            // 
            this.salary.Text = "משכורת";
            this.salary.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = ":מס הכנסה חודשי\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(31, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 54);
            this.button1.TabIndex = 20;
            this.button1.Text = "יציאה";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(57, 237);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(0, 0);
            this.listView2.TabIndex = 21;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // lblName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 461);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(75, 65);
            this.Name = "lblName";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.lblName_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddEmploye;
        private System.Windows.Forms.Button Add10Employee;
        private System.Windows.Forms.Button SortBySalary;
        private System.Windows.Forms.Button ListEmployee;
        private System.Windows.Forms.Button TaxCal;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_family;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_addEmplyee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader salary;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView2;
    }
}

