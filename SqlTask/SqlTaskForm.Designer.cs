namespace SqlTask
{
    partial class SqlTaskForm
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
            this.lbl_Id = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.txb_Id = new System.Windows.Forms.TextBox();
            this.txb_Price = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.rtxb_Task = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(36, 24);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(16, 13);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "Id";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(36, 148);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(31, 13);
            this.label_Price.TabIndex = 1;
            this.label_Price.Text = "Price";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(36, 86);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(39, 213);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 42);
            this.btn_Select.TabIndex = 3;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(244, 213);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 42);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(345, 213);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 42);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(144, 213);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 42);
            this.btn_Create.TabIndex = 6;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // txb_Id
            // 
            this.txb_Id.Location = new System.Drawing.Point(39, 40);
            this.txb_Id.Name = "txb_Id";
            this.txb_Id.Size = new System.Drawing.Size(100, 20);
            this.txb_Id.TabIndex = 7;
            // 
            // txb_Price
            // 
            this.txb_Price.Location = new System.Drawing.Point(39, 164);
            this.txb_Price.Name = "txb_Price";
            this.txb_Price.Size = new System.Drawing.Size(100, 20);
            this.txb_Price.TabIndex = 8;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(39, 102);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(100, 20);
            this.txb_Name.TabIndex = 9;
            // 
            // rtxb_Task
            // 
            this.rtxb_Task.Location = new System.Drawing.Point(212, 40);
            this.rtxb_Task.Name = "rtxb_Task";
            this.rtxb_Task.Size = new System.Drawing.Size(176, 144);
            this.rtxb_Task.TabIndex = 10;
            this.rtxb_Task.Text = "";
            // 
            // SqlTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 277);
            this.Controls.Add(this.rtxb_Task);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.txb_Price);
            this.Controls.Add(this.txb_Id);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.lbl_Id);
            this.Name = "SqlTaskForm";
            this.Text = "Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label lbl_Name;
        public System.Windows.Forms.Button btn_Select;
        public System.Windows.Forms.Button btn_Update;
        public System.Windows.Forms.Button btn_Delete;
        public System.Windows.Forms.Button btn_Create;
        public System.Windows.Forms.TextBox txb_Id;
        public System.Windows.Forms.TextBox txb_Price;
        public System.Windows.Forms.TextBox txb_Name;
        public System.Windows.Forms.RichTextBox rtxb_Task;
    }
}

