namespace DesktopClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBUsers = new System.Windows.Forms.ComboBox();
            this.TbID = new System.Windows.Forms.TextBox();
            this.TbDesc = new System.Windows.Forms.TextBox();
            this.DtPDate = new System.Windows.Forms.DateTimePicker();
            this.ListBoxItems = new System.Windows.Forms.ListBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // CBUsers
            // 
            this.CBUsers.FormattingEnabled = true;
            this.CBUsers.Location = new System.Drawing.Point(348, 50);
            this.CBUsers.Name = "CBUsers";
            this.CBUsers.Size = new System.Drawing.Size(121, 21);
            this.CBUsers.TabIndex = 4;
            // 
            // TbID
            // 
            this.TbID.Location = new System.Drawing.Point(347, 90);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(121, 20);
            this.TbID.TabIndex = 5;
            // 
            // TbDesc
            // 
            this.TbDesc.Location = new System.Drawing.Point(347, 129);
            this.TbDesc.Name = "TbDesc";
            this.TbDesc.Size = new System.Drawing.Size(121, 20);
            this.TbDesc.TabIndex = 6;
            // 
            // DtPDate
            // 
            this.DtPDate.Location = new System.Drawing.Point(347, 172);
            this.DtPDate.Name = "DtPDate";
            this.DtPDate.Size = new System.Drawing.Size(121, 20);
            this.DtPDate.TabIndex = 7;
            // 
            // ListBoxItems
            // 
            this.ListBoxItems.FormattingEnabled = true;
            this.ListBoxItems.Location = new System.Drawing.Point(632, 50);
            this.ListBoxItems.Name = "ListBoxItems";
            this.ListBoxItems.Size = new System.Drawing.Size(229, 212);
            this.ListBoxItems.TabIndex = 8;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(392, 238);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 9;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 319);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ListBoxItems);
            this.Controls.Add(this.DtPDate);
            this.Controls.Add(this.TbDesc);
            this.Controls.Add(this.TbID);
            this.Controls.Add(this.CBUsers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBUsers;
        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.TextBox TbDesc;
        private System.Windows.Forms.DateTimePicker DtPDate;
        private System.Windows.Forms.ListBox ListBoxItems;
        private System.Windows.Forms.Button ButtonAdd;
    }
}

