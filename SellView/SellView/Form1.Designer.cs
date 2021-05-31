namespace SellView
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
            this.btnToi = new System.Windows.Forms.Button();
            this.btnLui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCust = new System.Windows.Forms.ComboBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtFaxNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdOrderDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToi
            // 
            this.btnToi.Location = new System.Drawing.Point(37, 32);
            this.btnToi.Name = "btnToi";
            this.btnToi.Size = new System.Drawing.Size(75, 23);
            this.btnToi.TabIndex = 0;
            this.btnToi.Text = "Tới";
            this.btnToi.UseVisualStyleBackColor = true;
            this.btnToi.Click += new System.EventHandler(this.btnToi_Click);
            // 
            // btnLui
            // 
            this.btnLui.Location = new System.Drawing.Point(37, 110);
            this.btnLui.Name = "btnLui";
            this.btnLui.Size = new System.Drawing.Size(75, 23);
            this.btnLui.TabIndex = 1;
            this.btnLui.Text = "Lùi";
            this.btnLui.UseVisualStyleBackColor = true;
            this.btnLui.Click += new System.EventHandler(this.btnLui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên khách hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa chỉ liên hệ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Phone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Fax :";
            // 
            // cbCust
            // 
            this.cbCust.FormattingEnabled = true;
            this.cbCust.Location = new System.Drawing.Point(359, 32);
            this.cbCust.Name = "cbCust";
            this.cbCust.Size = new System.Drawing.Size(403, 21);
            this.cbCust.TabIndex = 6;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(359, 65);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(403, 20);
            this.txtContact.TabIndex = 7;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(359, 95);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(403, 20);
            this.txtPhoneNo.TabIndex = 8;
            // 
            // txtFaxNo
            // 
            this.txtFaxNo.Location = new System.Drawing.Point(359, 128);
            this.txtFaxNo.Name = "txtFaxNo";
            this.txtFaxNo.Size = new System.Drawing.Size(403, 20);
            this.txtFaxNo.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdOrders);
            this.groupBox1.Location = new System.Drawing.Point(37, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các đơn đặt hàng của khách hàng đang được chọn :";
            // 
            // grdOrders
            // 
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Location = new System.Drawing.Point(6, 19);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.Size = new System.Drawing.Size(713, 75);
            this.grdOrders.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdOrderDetails);
            this.groupBox2.Location = new System.Drawing.Point(37, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết của đơn đặt hàng đang được chọn  :";
            // 
            // grdOrderDetails
            // 
            this.grdOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderDetails.Location = new System.Drawing.Point(6, 19);
            this.grdOrderDetails.Name = "grdOrderDetails";
            this.grdOrderDetails.Size = new System.Drawing.Size(713, 75);
            this.grdOrderDetails.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFaxNo);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.cbCust);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLui);
            this.Controls.Add(this.btnToi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToi;
        private System.Windows.Forms.Button btnLui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCust;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtFaxNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdOrderDetails;
    }
}

