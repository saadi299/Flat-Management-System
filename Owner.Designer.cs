namespace FlatManagementSystem
{
    partial class Owner
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtOcon = new System.Windows.Forms.TextBox();
            this.txtOage = new System.Windows.Forms.TextBox();
            this.txtOID = new System.Windows.Forms.TextBox();
            this.txtON = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvOwnerInfoes = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerInfoes)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Owner Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Owner Contact :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Owner Age :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "OID :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1258, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 22);
            this.txtSearch.TabIndex = 13;
            // 
            // txtOcon
            // 
            this.txtOcon.Location = new System.Drawing.Point(237, 268);
            this.txtOcon.Name = "txtOcon";
            this.txtOcon.Size = new System.Drawing.Size(205, 22);
            this.txtOcon.TabIndex = 14;
            this.txtOcon.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtOage
            // 
            this.txtOage.Location = new System.Drawing.Point(237, 193);
            this.txtOage.Name = "txtOage";
            this.txtOage.Size = new System.Drawing.Size(205, 22);
            this.txtOage.TabIndex = 15;
            // 
            // txtOID
            // 
            this.txtOID.Location = new System.Drawing.Point(237, 125);
            this.txtOID.Name = "txtOID";
            this.txtOID.ReadOnly = true;
            this.txtOID.Size = new System.Drawing.Size(205, 22);
            this.txtOID.TabIndex = 16;
            // 
            // txtON
            // 
            this.txtON.Location = new System.Drawing.Point(237, 63);
            this.txtON.Name = "txtON";
            this.txtON.Size = new System.Drawing.Size(205, 22);
            this.txtON.TabIndex = 17;
            this.txtON.TextChanged += new System.EventHandler(this.TxtON_TextChanged);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(729, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 50);
            this.button6.TabIndex = 18;
            this.button6.Text = "New";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(875, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 50);
            this.button5.TabIndex = 19;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1006, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 50);
            this.button4.TabIndex = 20;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1136, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 50);
            this.button2.TabIndex = 21;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(237, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgvOwnerInfoes
            // 
            this.dgvOwnerInfoes.AllowUserToAddRows = false;
            this.dgvOwnerInfoes.AllowUserToDeleteRows = false;
            this.dgvOwnerInfoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwnerInfoes.Location = new System.Drawing.Point(729, 154);
            this.dgvOwnerInfoes.Name = "dgvOwnerInfoes";
            this.dgvOwnerInfoes.ReadOnly = true;
            this.dgvOwnerInfoes.RowHeadersWidth = 51;
            this.dgvOwnerInfoes.RowTemplate.Height = 24;
            this.dgvOwnerInfoes.Size = new System.Drawing.Size(734, 236);
            this.dgvOwnerInfoes.TabIndex = 23;
            this.dgvOwnerInfoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOwnerInfoes_CellClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(638, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 50);
            this.button3.TabIndex = 24;
            this.button3.Text = "BuildingInfo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 557);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvOwnerInfoes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtON);
            this.Controls.Add(this.txtOID);
            this.Controls.Add(this.txtOage);
            this.Controls.Add(this.txtOcon);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "Owner";
            this.Text = "Owner";
            this.Load += new System.EventHandler(this.Owner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerInfoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtOcon;
        private System.Windows.Forms.TextBox txtOage;
        private System.Windows.Forms.TextBox txtOID;
        private System.Windows.Forms.TextBox txtON;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvOwnerInfoes;
        private System.Windows.Forms.Button button3;
    }
}