namespace FlatManagementSystem
{
    partial class Building
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtRd = new System.Windows.Forms.TextBox();
            this.txtbl = new System.Windows.Forms.TextBox();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.RichTextBox();
            this.dgvBuilding = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Road :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Block :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "BID :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1123, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 22);
            this.txtSearch.TabIndex = 20;
            // 
            // txtRd
            // 
            this.txtRd.Location = new System.Drawing.Point(172, 179);
            this.txtRd.Name = "txtRd";
            this.txtRd.Size = new System.Drawing.Size(205, 22);
            this.txtRd.TabIndex = 22;
            this.txtRd.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtbl
            // 
            this.txtbl.Location = new System.Drawing.Point(172, 114);
            this.txtbl.Name = "txtbl";
            this.txtbl.Size = new System.Drawing.Size(205, 22);
            this.txtbl.TabIndex = 23;
            // 
            // txtBID
            // 
            this.txtBID.Location = new System.Drawing.Point(172, 52);
            this.txtBID.Name = "txtBID";
            this.txtBID.ReadOnly = true;
            this.txtBID.Size = new System.Drawing.Size(205, 22);
            this.txtBID.TabIndex = 25;
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(172, 255);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(205, 96);
            this.txtadd.TabIndex = 26;
            this.txtadd.Text = "";
            // 
            // dgvBuilding
            // 
            this.dgvBuilding.AllowUserToAddRows = false;
            this.dgvBuilding.AllowUserToDeleteRows = false;
            this.dgvBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuilding.Location = new System.Drawing.Point(596, 114);
            this.dgvBuilding.Name = "dgvBuilding";
            this.dgvBuilding.ReadOnly = true;
            this.dgvBuilding.RowHeadersWidth = 51;
            this.dgvBuilding.RowTemplate.Height = 24;
            this.dgvBuilding.Size = new System.Drawing.Size(732, 333);
            this.dgvBuilding.TabIndex = 27;
            this.dgvBuilding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBuilding_CellClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(172, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 50);
            this.button2.TabIndex = 28;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(596, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 50);
            this.button4.TabIndex = 29;
            this.button4.Text = "New";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(734, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 50);
            this.button6.TabIndex = 30;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(865, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 50);
            this.button3.TabIndex = 31;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(998, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 50);
            this.button1.TabIndex = 32;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(536, 538);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 50);
            this.button5.TabIndex = 33;
            this.button5.Text = "Advertisement";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Building
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 671);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvBuilding);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txtBID);
            this.Controls.Add(this.txtbl);
            this.Controls.Add(this.txtRd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Building";
            this.Text = "Building";
            this.Load += new System.EventHandler(this.Building_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtRd;
        private System.Windows.Forms.TextBox txtbl;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.RichTextBox txtadd;
        private System.Windows.Forms.DataGridView dgvBuilding;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}