namespace FlatManagementSystem
{
    partial class Customer
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCustomerInfoes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.txtCcon = new System.Windows.Forms.TextBox();
            this.txtCage = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfoes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Contact :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Age :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID :";
            // 
            // dgvCustomerInfoes
            // 
            this.dgvCustomerInfoes.AllowUserToAddRows = false;
            this.dgvCustomerInfoes.AllowUserToDeleteRows = false;
            this.dgvCustomerInfoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInfoes.Location = new System.Drawing.Point(596, 264);
            this.dgvCustomerInfoes.Name = "dgvCustomerInfoes";
            this.dgvCustomerInfoes.ReadOnly = true;
            this.dgvCustomerInfoes.RowHeadersWidth = 51;
            this.dgvCustomerInfoes.RowTemplate.Height = 24;
            this.dgvCustomerInfoes.Size = new System.Drawing.Size(725, 150);
            this.dgvCustomerInfoes.TabIndex = 5;
            this.dgvCustomerInfoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomerInfoes_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(137, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1125, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(862, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(731, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 50);
            this.button5.TabIndex = 10;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(596, 44);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 50);
            this.button6.TabIndex = 11;
            this.button6.Text = "New";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(249, 75);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(205, 22);
            this.txtCN.TabIndex = 12;
            // 
            // txtCcon
            // 
            this.txtCcon.Location = new System.Drawing.Point(249, 264);
            this.txtCcon.Name = "txtCcon";
            this.txtCcon.Size = new System.Drawing.Size(205, 22);
            this.txtCcon.TabIndex = 13;
            // 
            // txtCage
            // 
            this.txtCage.Location = new System.Drawing.Point(249, 200);
            this.txtCage.Name = "txtCage";
            this.txtCage.Size = new System.Drawing.Size(205, 22);
            this.txtCage.TabIndex = 14;
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(249, 132);
            this.txtCID.Name = "txtCID";
            this.txtCID.ReadOnly = true;
            this.txtCID.Size = new System.Drawing.Size(205, 22);
            this.txtCID.TabIndex = 15;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1125, 132);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 22);
            this.txtSearch.TabIndex = 16;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 705);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.txtCage);
            this.Controls.Add(this.txtCcon);
            this.Controls.Add(this.txtCN);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCustomerInfoes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCustomerInfoes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.TextBox txtCcon;
        private System.Windows.Forms.TextBox txtCage;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.TextBox txtSearch;
    }
}