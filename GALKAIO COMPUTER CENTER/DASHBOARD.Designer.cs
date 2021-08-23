namespace SOMALI_COMPUTER_CENTER
{
    partial class DASHBOARD
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RESET_BTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FULLNAME_TXT = new System.Windows.Forms.TextBox();
            this.INVOICE_TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PRODUCTS_TXT = new System.Windows.Forms.ComboBox();
            this.PRICE_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QUANTITY_TXT = new System.Windows.Forms.TextBox();
            this.DISCOUNT_TXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SUBTOTAL_TXT = new System.Windows.Forms.TextBox();
            this.ERROR_FN = new System.Windows.Forms.ErrorProvider(this.components);
            this.ERROR_QUANTITY = new System.Windows.Forms.ErrorProvider(this.components);
            this.BUY_BTN = new System.Windows.Forms.Button();
            this.ERROR_PRODUCTS = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.GENDER_TXT = new System.Windows.Forms.ComboBox();
            this.ERROR_GENDER = new System.Windows.Forms.ErrorProvider(this.components);
            this.DELETE_BTN = new System.Windows.Forms.Button();
            this.UPDATE_BTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERROR_FN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERROR_QUANTITY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERROR_PRODUCTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERROR_GENDER)).BeginInit();
            this.SuspendLayout();
            // 
            // RESET_BTN
            // 
            this.RESET_BTN.BackColor = System.Drawing.Color.Black;
            this.RESET_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RESET_BTN.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESET_BTN.ForeColor = System.Drawing.Color.White;
            this.RESET_BTN.Location = new System.Drawing.Point(1080, 277);
            this.RESET_BTN.Name = "RESET_BTN";
            this.RESET_BTN.Size = new System.Drawing.Size(236, 38);
            this.RESET_BTN.TabIndex = 9;
            this.RESET_BTN.Text = "CLEAR";
            this.RESET_BTN.UseVisualStyleBackColor = false;
            this.RESET_BTN.Click += new System.EventHandler(this.RESET_BTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(61, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 283);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FULLNAME_TXT
            // 
            this.FULLNAME_TXT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FULLNAME_TXT.Location = new System.Drawing.Point(197, 144);
            this.FULLNAME_TXT.Name = "FULLNAME_TXT";
            this.FULLNAME_TXT.Size = new System.Drawing.Size(474, 26);
            this.FULLNAME_TXT.TabIndex = 1;
            this.FULLNAME_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FULLNAME_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FULLNAME_TXT_KeyPress);
            this.FULLNAME_TXT.Leave += new System.EventHandler(this.FULLNAME_TXT_Leave);
            // 
            // INVOICE_TXT
            // 
            this.INVOICE_TXT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INVOICE_TXT.Location = new System.Drawing.Point(197, 97);
            this.INVOICE_TXT.Name = "INVOICE_TXT";
            this.INVOICE_TXT.ReadOnly = true;
            this.INVOICE_TXT.Size = new System.Drawing.Size(474, 26);
            this.INVOICE_TXT.TabIndex = 0;
            this.INVOICE_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "PRODUCTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "FULLNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "INVOICE ID";
            // 
            // PRODUCTS_TXT
            // 
            this.PRODUCTS_TXT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRODUCTS_TXT.FormattingEnabled = true;
            this.PRODUCTS_TXT.Location = new System.Drawing.Point(197, 234);
            this.PRODUCTS_TXT.Name = "PRODUCTS_TXT";
            this.PRODUCTS_TXT.Size = new System.Drawing.Size(474, 27);
            this.PRODUCTS_TXT.TabIndex = 2;
            this.PRODUCTS_TXT.SelectedIndexChanged += new System.EventHandler(this.PRODUCTS_TXT_SelectedIndexChanged);
            // 
            // PRICE_TXT
            // 
            this.PRICE_TXT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRICE_TXT.Location = new System.Drawing.Point(838, 97);
            this.PRICE_TXT.Name = "PRICE_TXT";
            this.PRICE_TXT.ReadOnly = true;
            this.PRICE_TXT.Size = new System.Drawing.Size(478, 26);
            this.PRICE_TXT.TabIndex = 3;
            this.PRICE_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(699, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "PRICE";
            // 
            // QUANTITY_TXT
            // 
            this.QUANTITY_TXT.Enabled = false;
            this.QUANTITY_TXT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUANTITY_TXT.Location = new System.Drawing.Point(838, 183);
            this.QUANTITY_TXT.Name = "QUANTITY_TXT";
            this.QUANTITY_TXT.Size = new System.Drawing.Size(478, 26);
            this.QUANTITY_TXT.TabIndex = 5;
            this.QUANTITY_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QUANTITY_TXT.TextChanged += new System.EventHandler(this.QUANTITY_TXT_TextChanged);
            this.QUANTITY_TXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QUANTITY_TXT_KeyPress);
            // 
            // DISCOUNT_TXT
            // 
            this.DISCOUNT_TXT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DISCOUNT_TXT.Location = new System.Drawing.Point(838, 140);
            this.DISCOUNT_TXT.Name = "DISCOUNT_TXT";
            this.DISCOUNT_TXT.ReadOnly = true;
            this.DISCOUNT_TXT.Size = new System.Drawing.Size(478, 26);
            this.DISCOUNT_TXT.TabIndex = 4;
            this.DISCOUNT_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(700, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "TOTALCOST";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(700, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "QUANTITY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(699, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "DISCOUNT";
            // 
            // SUBTOTAL_TXT
            // 
            this.SUBTOTAL_TXT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBTOTAL_TXT.Location = new System.Drawing.Point(838, 228);
            this.SUBTOTAL_TXT.Name = "SUBTOTAL_TXT";
            this.SUBTOTAL_TXT.ReadOnly = true;
            this.SUBTOTAL_TXT.Size = new System.Drawing.Size(478, 26);
            this.SUBTOTAL_TXT.TabIndex = 6;
            this.SUBTOTAL_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ERROR_FN
            // 
            this.ERROR_FN.ContainerControl = this;
            // 
            // ERROR_QUANTITY
            // 
            this.ERROR_QUANTITY.ContainerControl = this;
            // 
            // BUY_BTN
            // 
            this.BUY_BTN.BackColor = System.Drawing.Color.Blue;
            this.BUY_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUY_BTN.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUY_BTN.ForeColor = System.Drawing.Color.White;
            this.BUY_BTN.Location = new System.Drawing.Point(197, 280);
            this.BUY_BTN.Name = "BUY_BTN";
            this.BUY_BTN.Size = new System.Drawing.Size(236, 38);
            this.BUY_BTN.TabIndex = 36;
            this.BUY_BTN.Text = "BUY NOW";
            this.BUY_BTN.UseVisualStyleBackColor = false;
            this.BUY_BTN.Click += new System.EventHandler(this.BUY_BTN_Click);
            // 
            // ERROR_PRODUCTS
            // 
            this.ERROR_PRODUCTS.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "GENDER";
            // 
            // GENDER_TXT
            // 
            this.GENDER_TXT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENDER_TXT.FormattingEnabled = true;
            this.GENDER_TXT.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.GENDER_TXT.Location = new System.Drawing.Point(197, 189);
            this.GENDER_TXT.Name = "GENDER_TXT";
            this.GENDER_TXT.Size = new System.Drawing.Size(474, 27);
            this.GENDER_TXT.TabIndex = 39;
            this.GENDER_TXT.Leave += new System.EventHandler(this.GENDER_TXT_Leave);
            // 
            // ERROR_GENDER
            // 
            this.ERROR_GENDER.ContainerControl = this;
            // 
            // DELETE_BTN
            // 
            this.DELETE_BTN.BackColor = System.Drawing.Color.Red;
            this.DELETE_BTN.Enabled = false;
            this.DELETE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DELETE_BTN.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE_BTN.ForeColor = System.Drawing.Color.White;
            this.DELETE_BTN.Location = new System.Drawing.Point(838, 277);
            this.DELETE_BTN.Name = "DELETE_BTN";
            this.DELETE_BTN.Size = new System.Drawing.Size(236, 38);
            this.DELETE_BTN.TabIndex = 40;
            this.DELETE_BTN.Text = "DELETE";
            this.DELETE_BTN.UseVisualStyleBackColor = false;
            this.DELETE_BTN.Click += new System.EventHandler(this.DELETE_BTN_Click);
            // 
            // UPDATE_BTN
            // 
            this.UPDATE_BTN.BackColor = System.Drawing.Color.Lime;
            this.UPDATE_BTN.Enabled = false;
            this.UPDATE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UPDATE_BTN.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE_BTN.ForeColor = System.Drawing.Color.White;
            this.UPDATE_BTN.Location = new System.Drawing.Point(435, 280);
            this.UPDATE_BTN.Name = "UPDATE_BTN";
            this.UPDATE_BTN.Size = new System.Drawing.Size(236, 38);
            this.UPDATE_BTN.TabIndex = 41;
            this.UPDATE_BTN.Text = "UPDATE";
            this.UPDATE_BTN.UseVisualStyleBackColor = false;
            this.UPDATE_BTN.Click += new System.EventHandler(this.UPDATE_BTN_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(61, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1255, 52);
            this.button1.TabIndex = 42;
            this.button1.Text = "GALKAIO           COMPUTER           CENTER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DASHBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1349, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UPDATE_BTN);
            this.Controls.Add(this.DELETE_BTN);
            this.Controls.Add(this.GENDER_TXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BUY_BTN);
            this.Controls.Add(this.SUBTOTAL_TXT);
            this.Controls.Add(this.QUANTITY_TXT);
            this.Controls.Add(this.DISCOUNT_TXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PRICE_TXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PRODUCTS_TXT);
            this.Controls.Add(this.RESET_BTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FULLNAME_TXT);
            this.Controls.Add(this.INVOICE_TXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "DASHBOARD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GALKAIO COMPUTER CENTER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERROR_FN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERROR_QUANTITY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERROR_PRODUCTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERROR_GENDER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RESET_BTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox FULLNAME_TXT;
        private System.Windows.Forms.TextBox INVOICE_TXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PRODUCTS_TXT;
        private System.Windows.Forms.TextBox PRICE_TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QUANTITY_TXT;
        private System.Windows.Forms.TextBox DISCOUNT_TXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SUBTOTAL_TXT;
        private System.Windows.Forms.ErrorProvider ERROR_FN;
        private System.Windows.Forms.ErrorProvider ERROR_QUANTITY;
        private System.Windows.Forms.Button BUY_BTN;
        private System.Windows.Forms.ErrorProvider ERROR_PRODUCTS;
        private System.Windows.Forms.ComboBox GENDER_TXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider ERROR_GENDER;
        private System.Windows.Forms.Button DELETE_BTN;
        private System.Windows.Forms.Button UPDATE_BTN;
        private System.Windows.Forms.Button button1;
    }
}

