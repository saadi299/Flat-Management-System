namespace FlatManagementSystem
{
    partial class Employee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEcon = new System.Windows.Forms.TextBox();
            this.txtEage = new System.Windows.Forms.TextBox();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.txtEN = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvEmployeeInfoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfoes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Contact :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Age :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Employee Name :";
            // 
            // txtEcon
            // 
            this.txtEcon.Location = new System.Drawing.Point(213, 264);
            this.txtEcon.Name = "txtEcon";
            this.txtEcon.Size = new System.Drawing.Size(205, 22);
            this.txtEcon.TabIndex = 16;
            // 
            // txtEage
            // 
            this.txtEage.Location = new System.Drawing.Point(213, 190);
            this.txtEage.Name = "txtEage";
            this.txtEage.Size = new System.Drawing.Size(205, 22);
            this.txtEage.TabIndex = 17;
            // 
            // txtEID
            // 
            this.txtEID.Location = new System.Drawing.Point(213, 124);
            this.txtEID.Name = "txtEID";
            this.txtEID.ReadOnly = true;
            this.txtEID.Size = new System.Drawing.Size(205, 22);
            this.txtEID.TabIndex = 18;
            // 
            // txtEN
            // 
            this.txtEN.Location = new System.Drawing.Point(213, 66);
            this.txtEN.Name = "txtEN";
            this.txtEN.Size = new System.Drawing.Size(205, 22);
            this.txtEN.TabIndex = 19;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1179, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 22);
            this.txtSearch.TabIndex = 20;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(700, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 50);
            this.button6.TabIndex = 21;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1004, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(213, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 50);
            this.button2.TabIndex = 23;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(846, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 50);
            this.button3.TabIndex = 24;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(542, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 50);
            this.button4.TabIndex = 25;
            this.button4.Text = "New";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // dgvEmployeeInfoes
            // 
            this.dgvEmployeeInfoes.AllowUserToAddRows = false;
            this.dgvEmployeeInfoes.AllowUserToDeleteRows = false;
            this.dgvEmployeeInfoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeInfoes.Location = new System.Drawing.Point(542, 190);
            this.dgvEmployeeInfoes.Name = "dgvEmployeeInfoes";
            this.dgvEmployeeInfoes.ReadOnly = true;
            this.dgvEmployeeInfoes.RowHeadersWidth = 51;
            this.dgvEmployeeInfoes.RowTemplate.Height = 24;
            this.dgvEmployeeInfoes.Size = new System.Drawing.Size(842, 237);
            this.dgvEmployeeInfoes.TabIndex = 26;
            this.dgvEmployeeInfoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmployeeInfoes_CellClick);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 717);
            this.Controls.Add(this.dgvEmployeeInfoes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtEN);
            this.Controls.Add(this.txtEID);
            this.Controls.Add(this.txtEage);
            this.Controls.Add(this.txtEcon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEcon;
        private System.Windows.Forms.TextBox txtEage;
        private System.Windows.Forms.TextBox txtEID;
        private System.Windows.Forms.TextBox txtEN;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvEmployeeInfoes;
    }
}