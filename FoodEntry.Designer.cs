namespace HotelBillingSystem
{
    partial class FoodEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodEntry));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.TextBox();
            this.nv = new System.Windows.Forms.RadioButton();
            this.v = new System.Windows.Forms.RadioButton();
            this.fa = new System.Windows.Forms.ComboBox();
            this.fp = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.gv = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food New Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(73, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(73, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Food Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(73, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Food Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(73, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Food Availability";
            // 
            // fn
            // 
            this.fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fn.Location = new System.Drawing.Point(263, 169);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(163, 26);
            this.fn.TabIndex = 5;
            // 
            // nv
            // 
            this.nv.AutoSize = true;
            this.nv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nv.Location = new System.Drawing.Point(337, 240);
            this.nv.Name = "nv";
            this.nv.Size = new System.Drawing.Size(89, 24);
            this.nv.TabIndex = 7;
            this.nv.TabStop = true;
            this.nv.Text = "NonVeg";
            this.nv.UseVisualStyleBackColor = true;
            this.nv.CheckedChanged += new System.EventHandler(this.nv_CheckedChanged);
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.v.Location = new System.Drawing.Point(263, 240);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(59, 24);
            this.v.TabIndex = 8;
            this.v.TabStop = true;
            this.v.Text = "Veg";
            this.v.UseVisualStyleBackColor = true;
            this.v.CheckedChanged += new System.EventHandler(this.v_CheckedChanged);
            // 
            // fa
            // 
            this.fa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fa.FormattingEnabled = true;
            this.fa.Location = new System.Drawing.Point(263, 385);
            this.fa.Name = "fa";
            this.fa.Size = new System.Drawing.Size(163, 28);
            this.fa.TabIndex = 9;
            // 
            // fp
            // 
            this.fp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fp.Location = new System.Drawing.Point(263, 310);
            this.fp.Name = "fp";
            this.fp.Size = new System.Drawing.Size(163, 26);
            this.fp.TabIndex = 10;
            // 
            // submit
            // 
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submit.Location = new System.Drawing.Point(82, 502);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(86, 35);
            this.submit.TabIndex = 11;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.delete.Location = new System.Drawing.Point(190, 502);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(86, 35);
            this.delete.TabIndex = 12;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // load
            // 
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.load.Location = new System.Drawing.Point(306, 502);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(86, 35);
            this.load.TabIndex = 13;
            this.load.Text = "LOAD";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // update
            // 
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.update.Location = new System.Drawing.Point(415, 502);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(86, 35);
            this.update.TabIndex = 14;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // view
            // 
            this.view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.view.Location = new System.Drawing.Point(529, 502);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(86, 35);
            this.view.TabIndex = 15;
            this.view.Text = "VIEW";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(467, 149);
            this.gv.Name = "gv";
            this.gv.RowHeadersWidth = 51;
            this.gv.RowTemplate.Height = 24;
            this.gv.Size = new System.Drawing.Size(699, 295);
            this.gv.TabIndex = 16;
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(21, 27);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(38, 32);
            this.back.TabIndex = 17;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // FoodEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 599);
            this.Controls.Add(this.back);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.view);
            this.Controls.Add(this.update);
            this.Controls.Add(this.load);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.fp);
            this.Controls.Add(this.fa);
            this.Controls.Add(this.v);
            this.Controls.Add(this.nv);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FoodEntry";
            this.Text = "FoodEntry";
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.RadioButton nv;
        private System.Windows.Forms.RadioButton v;
        private System.Windows.Forms.ComboBox fa;
        private System.Windows.Forms.TextBox fp;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Button back;
    }
}