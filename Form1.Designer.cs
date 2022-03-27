namespace CoffeeShop2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.CoffeeGrid = new System.Windows.Forms.DataGridView();
            this.grpEmp = new System.Windows.Forms.GroupBox();
            this.comboOrdType = new System.Windows.Forms.ComboBox();
            this.CoffPlaceOrderButt = new System.Windows.Forms.Button();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtOrdId = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.textBoxOrdType = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblEid = new System.Windows.Forms.Label();
            this.RomanOrdBox = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAckMe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeGrid)).BeginInit();
            this.grpEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RomanOrdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(502, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bloodline Cafe \r\n\"It\'s in Your Veins\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CoffeeGrid
            // 
            this.CoffeeGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CoffeeGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CoffeeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CoffeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoffeeGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CoffeeGrid.Location = new System.Drawing.Point(249, 78);
            this.CoffeeGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CoffeeGrid.Name = "CoffeeGrid";
            this.CoffeeGrid.RowHeadersWidth = 51;
            this.CoffeeGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CoffeeGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CoffeeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CoffeeGrid.Size = new System.Drawing.Size(772, 247);
            this.CoffeeGrid.TabIndex = 1;
            // 
            // grpEmp
            // 
            this.grpEmp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpEmp.Controls.Add(this.comboOrdType);
            this.grpEmp.Controls.Add(this.CoffPlaceOrderButt);
            this.grpEmp.Controls.Add(this.comboSize);
            this.grpEmp.Controls.Add(this.txtFname);
            this.grpEmp.Controls.Add(this.txtOrdId);
            this.grpEmp.Controls.Add(this.lblDept);
            this.grpEmp.Controls.Add(this.textBoxOrdType);
            this.grpEmp.Controls.Add(this.lblFname);
            this.grpEmp.Controls.Add(this.lblEid);
            this.grpEmp.Controls.Add(this.RomanOrdBox);
            this.grpEmp.Location = new System.Drawing.Point(32, 355);
            this.grpEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEmp.Name = "grpEmp";
            this.grpEmp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEmp.Size = new System.Drawing.Size(500, 395);
            this.grpEmp.TabIndex = 2;
            this.grpEmp.TabStop = false;
            this.grpEmp.Text = "Coffee Information";
            // 
            // comboOrdType
            // 
            this.comboOrdType.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboOrdType.ForeColor = System.Drawing.SystemColors.Window;
            this.comboOrdType.FormattingEnabled = true;
            this.comboOrdType.Location = new System.Drawing.Point(317, 170);
            this.comboOrdType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboOrdType.Name = "comboOrdType";
            this.comboOrdType.Size = new System.Drawing.Size(160, 28);
            this.comboOrdType.TabIndex = 9;
            this.comboOrdType.SelectedIndexChanged += new System.EventHandler(this.comboOrdType_SelectedIndexChanged);
            // 
            // CoffPlaceOrderButt
            // 
            this.CoffPlaceOrderButt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CoffPlaceOrderButt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CoffPlaceOrderButt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CoffPlaceOrderButt.Location = new System.Drawing.Point(158, 323);
            this.CoffPlaceOrderButt.Name = "CoffPlaceOrderButt";
            this.CoffPlaceOrderButt.Size = new System.Drawing.Size(143, 46);
            this.CoffPlaceOrderButt.TabIndex = 8;
            this.CoffPlaceOrderButt.Text = "Place Order";
            this.CoffPlaceOrderButt.UseVisualStyleBackColor = false;
            this.CoffPlaceOrderButt.Click += new System.EventHandler(this.CoffPlaceOrderButt_Click);
            // 
            // comboSize
            // 
            this.comboSize.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboSize.ForeColor = System.Drawing.SystemColors.Window;
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Location = new System.Drawing.Point(317, 257);
            this.comboSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(160, 28);
            this.comboSize.TabIndex = 6;
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtFname.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFname.Location = new System.Drawing.Point(317, 109);
            this.txtFname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(132, 27);
            this.txtFname.TabIndex = 5;
            // 
            // txtOrdId
            // 
            this.txtOrdId.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtOrdId.ForeColor = System.Drawing.SystemColors.Window;
            this.txtOrdId.Location = new System.Drawing.Point(317, 52);
            this.txtOrdId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrdId.Name = "txtOrdId";
            this.txtOrdId.Size = new System.Drawing.Size(132, 27);
            this.txtOrdId.TabIndex = 4;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDept.Location = new System.Drawing.Point(51, 257);
            this.lblDept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(109, 22);
            this.lblDept.TabIndex = 3;
            this.lblDept.Text = "Coffee Size";
            // 
            // textBoxOrdType
            // 
            this.textBoxOrdType.AutoSize = true;
            this.textBoxOrdType.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxOrdType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textBoxOrdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxOrdType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxOrdType.Location = new System.Drawing.Point(56, 196);
            this.textBoxOrdType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textBoxOrdType.Name = "textBoxOrdType";
            this.textBoxOrdType.Size = new System.Drawing.Size(99, 22);
            this.textBoxOrdType.TabIndex = 2;
            this.textBoxOrdType.Text = "OrderType";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFname.Location = new System.Drawing.Point(56, 124);
            this.lblFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(104, 22);
            this.lblFname.TabIndex = 1;
            this.lblFname.Text = "First Name";
            // 
            // lblEid
            // 
            this.lblEid.AutoSize = true;
            this.lblEid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEid.Location = new System.Drawing.Point(56, 57);
            this.lblEid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEid.Name = "lblEid";
            this.lblEid.Size = new System.Drawing.Size(80, 22);
            this.lblEid.TabIndex = 0;
            this.lblEid.Text = "Order Id";
            // 
            // RomanOrdBox
            // 
            this.RomanOrdBox.Image = global::CoffeeShop2.Properties.Resources.Roman_Reigns_page_background;
            this.RomanOrdBox.Location = new System.Drawing.Point(0, 0);
            this.RomanOrdBox.Name = "RomanOrdBox";
            this.RomanOrdBox.Size = new System.Drawing.Size(500, 395);
            this.RomanOrdBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RomanOrdBox.TabIndex = 7;
            this.RomanOrdBox.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(644, 391);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 48);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Coffee";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDel.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Location = new System.Drawing.Point(896, 391);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(175, 48);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Delete Coffee";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShow.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShow.Location = new System.Drawing.Point(771, 525);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(175, 48);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Menu";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeeShop2.Properties.Resources.The_BloodLine_Background__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 849);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnAckMe
            // 
            this.btnAckMe.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAckMe.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAckMe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAckMe.Location = new System.Drawing.Point(747, 624);
            this.btnAckMe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAckMe.Name = "btnAckMe";
            this.btnAckMe.Size = new System.Drawing.Size(228, 100);
            this.btnAckMe.TabIndex = 7;
            this.btnAckMe.Text = "ACKNOWLEDGE ME!!";
            this.btnAckMe.UseVisualStyleBackColor = false;
            this.btnAckMe.Click += new System.EventHandler(this.btnAckMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 798);
            this.Controls.Add(this.btnAckMe);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpEmp);
            this.Controls.Add(this.CoffeeGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeGrid)).EndInit();
            this.grpEmp.ResumeLayout(false);
            this.grpEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RomanOrdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CoffeeGrid;
        private System.Windows.Forms.GroupBox grpEmp;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtOrdId;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label textBoxOrdType;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblEid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnShow;
        private PictureBox pictureBox1;
        private PictureBox RomanOrdBox;
        private Button btnAckMe;
        private ComboBox comboOrdType;
        private Button CoffPlaceOrderButt;
    }
}