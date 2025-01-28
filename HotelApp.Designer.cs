namespace HotelBillingSystem
{
    partial class HotelApp
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
            this.NewEntry = new System.Windows.Forms.Button();
            this.Billing = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewEntry
            // 
            this.NewEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewEntry.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NewEntry.Location = new System.Drawing.Point(113, 243);
            this.NewEntry.Name = "NewEntry";
            this.NewEntry.Size = new System.Drawing.Size(88, 37);
            this.NewEntry.TabIndex = 0;
            this.NewEntry.Text = "New Entry";
            this.NewEntry.UseVisualStyleBackColor = true;
            this.NewEntry.Click += new System.EventHandler(this.NewEntry_Click);
            // 
            // Billing
            // 
            this.Billing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Billing.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Billing.Location = new System.Drawing.Point(361, 243);
            this.Billing.Name = "Billing";
            this.Billing.Size = new System.Drawing.Size(88, 37);
            this.Billing.TabIndex = 1;
            this.Billing.Text = "Billing";
            this.Billing.UseVisualStyleBackColor = true;
            this.Billing.Click += new System.EventHandler(this.Billing_Click);
            // 
            // Search
            // 
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Search.Location = new System.Drawing.Point(609, 243);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(88, 37);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(314, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rainbow Hotel";
            // 
            // HotelApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Billing);
            this.Controls.Add(this.NewEntry);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "HotelApp";
            this.Text = "Hotel App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewEntry;
        private System.Windows.Forms.Button Billing;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
    }
}

