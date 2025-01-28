namespace HotelBillingSystem
{
    partial class SalesBilling
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
            this.gv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.bn = new System.Windows.Forms.TextBox();
            this.pr = new System.Windows.Forms.TextBox();
            this.qn = new System.Windows.Forms.TextBox();
            this.amt = new System.Windows.Forms.TextBox();
            this.fd = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Billing";
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(436, 137);
            this.gv.Name = "gv";
            this.gv.RowHeadersWidth = 51;
            this.gv.RowTemplate.Height = 24;
            this.gv.Size = new System.Drawing.Size(680, 247);
            this.gv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(67, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bill No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(67, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(67, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(67, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(67, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Amount";
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add.Location = new System.Drawing.Point(86, 460);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(97, 40);
            this.add.TabIndex = 7;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // print
            // 
            this.print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.print.Location = new System.Drawing.Point(225, 460);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(97, 40);
            this.print.TabIndex = 8;
            this.print.Text = "PRINT";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // bn
            // 
            this.bn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bn.Location = new System.Drawing.Point(203, 137);
            this.bn.Name = "bn";
            this.bn.Size = new System.Drawing.Size(148, 26);
            this.bn.TabIndex = 14;
            // 
            // pr
            // 
            this.pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pr.Location = new System.Drawing.Point(203, 269);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(148, 26);
            this.pr.TabIndex = 10;
            // 
            // qn
            // 
            this.qn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.qn.Location = new System.Drawing.Point(203, 329);
            this.qn.Name = "qn";
            this.qn.Size = new System.Drawing.Size(148, 26);
            this.qn.TabIndex = 11;
            // 
            // amt
            // 
            this.amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.amt.Location = new System.Drawing.Point(203, 393);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(148, 26);
            this.amt.TabIndex = 12;
            this.amt.TextChanged += new System.EventHandler(this.amt_TextChanged);
            // 
            // fd
            // 
            this.fd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fd.FormattingEnabled = true;
            this.fd.Location = new System.Drawing.Point(203, 204);
            this.fd.Name = "fd";
            this.fd.Size = new System.Drawing.Size(148, 28);
            this.fd.TabIndex = 13;
            this.fd.SelectedIndexChanged += new System.EventHandler(this.fd_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1030, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(1004, 428);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 22);
            this.total.TabIndex = 16;
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = global::HotelBillingSystem.Properties.Resources.arrow;
            this.back.Location = new System.Drawing.Point(21, 23);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(39, 32);
            this.back.TabIndex = 17;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // SalesBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 550);
            this.Controls.Add(this.back);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fd);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.qn);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.bn);
            this.Controls.Add(this.print);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.label1);
            this.Name = "SalesBilling";
            this.Text = "Sales Billing";
            this.Load += new System.EventHandler(this.SalesBilling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.TextBox bn;
        private System.Windows.Forms.TextBox pr;
        private System.Windows.Forms.TextBox qn;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.ComboBox fd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Button back;
    }
}