namespace MyContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.dgContact = new System.Windows.Forms.DataGridView();
            this.ContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ایمل = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.شماره = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.سن = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tspInsert = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grbSearch.SuspendLayout();
            this.grbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContact)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.txtSearch);
            this.grbSearch.Controls.Add(this.label1);
            this.grbSearch.Location = new System.Drawing.Point(6, 26);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(664, 100);
            this.grbSearch.TabIndex = 0;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "جستجو";
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.btnUpdate);
            this.grbList.Controls.Add(this.dgContact);
            this.grbList.Location = new System.Drawing.Point(9, 132);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(664, 368);
            this.grbList.TabIndex = 1;
            this.grbList.TabStop = false;
            this.grbList.Text = "لیست";
            // 
            // dgContact
            // 
            this.dgContact.AllowUserToAddRows = false;
            this.dgContact.AllowUserToDeleteRows = false;
            this.dgContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactId,
            this.ContactName,
            this.ContactFamily,
            this.ایمل,
            this.شماره,
            this.سن});
            this.dgContact.Location = new System.Drawing.Point(3, 20);
            this.dgContact.Name = "dgContact";
            this.dgContact.ReadOnly = true;
            this.dgContact.Size = new System.Drawing.Size(658, 316);
            this.dgContact.TabIndex = 0;
            // 
            // ContactId
            // 
            this.ContactId.DataPropertyName = "Id";
            this.ContactId.HeaderText = "آیدی";
            this.ContactId.Name = "ContactId";
            this.ContactId.ReadOnly = true;
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "Name";
            this.ContactName.HeaderText = "نام";
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            // 
            // ContactFamily
            // 
            this.ContactFamily.DataPropertyName = "Family";
            this.ContactFamily.HeaderText = "نام خانوادگی";
            this.ContactFamily.Name = "ContactFamily";
            this.ContactFamily.ReadOnly = true;
            // 
            // ایمل
            // 
            this.ایمل.DataPropertyName = "Email";
            this.ایمل.HeaderText = "ایمل";
            this.ایمل.Name = "ایمل";
            this.ایمل.ReadOnly = true;
            // 
            // شماره
            // 
            this.شماره.DataPropertyName = "Mobile";
            this.شماره.HeaderText = "شماره";
            this.شماره.Name = "شماره";
            this.شماره.ReadOnly = true;
            // 
            // سن
            // 
            this.سن.DataPropertyName = "Age";
            this.سن.HeaderText = "سن";
            this.سن.Name = "سن";
            this.سن.ReadOnly = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspInsert,
            this.tsbUpdate});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(682, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tspInsert
            // 
            this.tspInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tspInsert.Image = ((System.Drawing.Image)(resources.GetObject("tspInsert.Image")));
            this.tspInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspInsert.Name = "tspInsert";
            this.tspInsert.Size = new System.Drawing.Size(104, 22);
            this.tspInsert.Text = "اضافه کردن شخص";
            this.tspInsert.Click += new System.EventHandler(this.tspInsert_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(60, 22);
            this.tsbUpdate.Text = "بروزرسانی";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(583, 343);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(511, 477);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(280, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(315, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(682, 512);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.grbSearch);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفترچه مخاطبین";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.grbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgContact)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.DataGridView dgContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAge;
        private System.Windows.Forms.ToolStripButton btnInsert;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.DataGridView dgContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn ایمل;
        private System.Windows.Forms.DataGridViewTextBoxColumn شماره;
        private System.Windows.Forms.DataGridViewTextBoxColumn سن;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tspInsert;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

