namespace QKKS_ver_1._4_
{
    partial class Room
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCharnge = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dateEnd = new MetroFramework.Controls.MetroDateTime();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbLP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dateStart = new MetroFramework.Controls.MetroDateTime();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDayTimeStrart = new MetroFramework.Controls.MetroDateTime();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgShowRoom = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(11, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 305);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnCharnge);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(388, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 66);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(278, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCharnge
            // 
            this.btnCharnge.Location = new System.Drawing.Point(151, 22);
            this.btnCharnge.Name = "btnCharnge";
            this.btnCharnge.Size = new System.Drawing.Size(75, 23);
            this.btnCharnge.TabIndex = 4;
            this.btnCharnge.Text = "Sửa";
            this.btnCharnge.UseVisualStyleBackColor = true;
            this.btnCharnge.Click += new System.EventHandler(this.btnCharnge_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.txtNote);
            this.panel9.Location = new System.Drawing.Point(20, 152);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(362, 126);
            this.panel9.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ghi Chú:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(122, 10);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(226, 97);
            this.txtNote.TabIndex = 0;
            this.txtNote.Text = "";
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbStatus);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(542, 19);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(217, 45);
            this.panel8.TabIndex = 11;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Có Khách",
            "Dơ",
            "Bão Trì"});
            this.cbStatus.Location = new System.Drawing.Point(81, 12);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(126, 21);
            this.cbStatus.TabIndex = 2;
            this.cbStatus.Text = "Trống";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tình Trạng:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.dateEnd);
            this.panel7.Location = new System.Drawing.Point(536, 82);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(223, 45);
            this.panel7.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày áp dụng:";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(87, 6);
            this.dateEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(118, 29);
            this.dateEnd.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtPrice);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(20, 82);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 45);
            this.panel6.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(75, 13);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(130, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giá:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbLP);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(395, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(136, 45);
            this.panel5.TabIndex = 3;
            // 
            // cbLP
            // 
            this.cbLP.FormattingEnabled = true;
            this.cbLP.Location = new System.Drawing.Point(73, 12);
            this.cbLP.Name = "cbLP";
            this.cbLP.Size = new System.Drawing.Size(43, 21);
            this.cbLP.TabIndex = 2;
            this.cbLP.SelectedIndexChanged += new System.EventHandler(this.cbLP_SelectedIndexChanged);
            this.cbLP.SelectionChangeCommitted += new System.EventHandler(this.cbLP_SelectionChangeCommitted);
            this.cbLP.SelectedValueChanged += new System.EventHandler(this.cbLP_SelectedValueChanged);
            this.cbLP.TextChanged += new System.EventHandler(this.cbLP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại Phòng:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.dateStart);
            this.panel4.Location = new System.Drawing.Point(278, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 45);
            this.panel4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày áp dụng:";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(95, 6);
            this.dateStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(118, 29);
            this.dateStart.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbDayTimeStrart);
            this.panel1.Location = new System.Drawing.Point(278, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 45);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày áp dụng:";
            // 
            // cbDayTimeStrart
            // 
            this.cbDayTimeStrart.Location = new System.Drawing.Point(87, 6);
            this.cbDayTimeStrart.MinimumSize = new System.Drawing.Size(4, 29);
            this.cbDayTimeStrart.Name = "cbDayTimeStrart";
            this.cbDayTimeStrart.Size = new System.Drawing.Size(144, 29);
            this.cbDayTimeStrart.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbFloor);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(278, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 45);
            this.panel3.TabIndex = 2;
            // 
            // cbFloor
            // 
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Items.AddRange(new object[] {
            "2",
            "3",
            ""});
            this.cbFloor.Location = new System.Drawing.Point(46, 12);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(34, 21);
            this.cbFloor.TabIndex = 2;
            this.cbFloor.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tầng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtRoom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 45);
            this.panel2.TabIndex = 1;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(75, 13);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(130, 20);
            this.txtRoom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Phòng";
            // 
            // dgShowRoom
            // 
            this.dgShowRoom.AllowUserToResizeRows = false;
            this.dgShowRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgShowRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgShowRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgShowRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgShowRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgShowRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgShowRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgShowRoom.EnableHeadersVisualStyles = false;
            this.dgShowRoom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgShowRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgShowRoom.Location = new System.Drawing.Point(11, 374);
            this.dgShowRoom.Name = "dgShowRoom";
            this.dgShowRoom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgShowRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgShowRoom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgShowRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgShowRoom.Size = new System.Drawing.Size(776, 276);
            this.dgShowRoom.TabIndex = 6;
            this.dgShowRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShowRoom_CellClick);
            this.dgShowRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShowRoom_CellContentClick);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.dgShowRoom);
            this.Controls.Add(this.groupBox1);
            this.Name = "Room";
            this.Text = "Phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Room_FormClosed);
            this.Load += new System.EventHandler(this.Room_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCharnge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroGrid dgShowRoom;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroDateTime dateEnd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroDateTime dateStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime cbDayTimeStrart;
    }
}