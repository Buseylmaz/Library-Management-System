
namespace LibraryManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.lblPublishingHouseUpdate = new System.Windows.Forms.Label();
            this.tbxPublishingHouseUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.tbxNumberPagesUpdate = new System.Windows.Forms.TextBox();
            this.lblAuthorNameUpdate = new System.Windows.Forms.Label();
            this.tbxAuthorNameUpdate = new System.Windows.Forms.TextBox();
            this.lblNumberPagesUpdate = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.lblPublishingHouseAdd = new System.Windows.Forms.Label();
            this.tbxPublishingHouseAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.tbxNumberPagesAdd = new System.Windows.Forms.TextBox();
            this.lblAuthorNameAdd = new System.Windows.Forms.Label();
            this.tbxAuthorNameAdd = new System.Windows.Forms.TextBox();
            this.lblNumberPagesAdd = new System.Windows.Forms.Label();
            this.tbxNameAdd = new System.Windows.Forms.TextBox();
            this.dgwLibrary = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(397, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(297, 24);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Library Management System";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRemove.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRemove.Location = new System.Drawing.Point(14, 97);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(140, 25);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.Color.White;
            this.gbxUpdate.Controls.Add(this.lblPublishingHouseUpdate);
            this.gbxUpdate.Controls.Add(this.tbxPublishingHouseUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNumberPagesUpdate);
            this.gbxUpdate.Controls.Add(this.lblAuthorNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxAuthorNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblNumberPagesUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbxUpdate.Location = new System.Drawing.Point(553, 311);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(490, 223);
            this.gbxUpdate.TabIndex = 27;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Book";
            // 
            // lblPublishingHouseUpdate
            // 
            this.lblPublishingHouseUpdate.AutoSize = true;
            this.lblPublishingHouseUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPublishingHouseUpdate.Location = new System.Drawing.Point(62, 133);
            this.lblPublishingHouseUpdate.Name = "lblPublishingHouseUpdate";
            this.lblPublishingHouseUpdate.Size = new System.Drawing.Size(106, 15);
            this.lblPublishingHouseUpdate.TabIndex = 20;
            this.lblPublishingHouseUpdate.Text = "Publishing House";
            // 
            // tbxPublishingHouseUpdate
            // 
            this.tbxPublishingHouseUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbxPublishingHouseUpdate.Location = new System.Drawing.Point(217, 130);
            this.tbxPublishingHouseUpdate.Name = "tbxPublishingHouseUpdate";
            this.tbxPublishingHouseUpdate.Size = new System.Drawing.Size(157, 21);
            this.tbxPublishingHouseUpdate.TabIndex = 21;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNameUpdate.Location = new System.Drawing.Point(62, 36);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(72, 15);
            this.lblNameUpdate.TabIndex = 14;
            this.lblNameUpdate.Text = "Book Name";
            // 
            // tbxNumberPagesUpdate
            // 
            this.tbxNumberPagesUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbxNumberPagesUpdate.Location = new System.Drawing.Point(217, 96);
            this.tbxNumberPagesUpdate.Name = "tbxNumberPagesUpdate";
            this.tbxNumberPagesUpdate.Size = new System.Drawing.Size(157, 21);
            this.tbxNumberPagesUpdate.TabIndex = 19;
            // 
            // lblAuthorNameUpdate
            // 
            this.lblAuthorNameUpdate.AutoSize = true;
            this.lblAuthorNameUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAuthorNameUpdate.Location = new System.Drawing.Point(62, 68);
            this.lblAuthorNameUpdate.Name = "lblAuthorNameUpdate";
            this.lblAuthorNameUpdate.Size = new System.Drawing.Size(79, 15);
            this.lblAuthorNameUpdate.TabIndex = 15;
            this.lblAuthorNameUpdate.Text = "Author Name";
            // 
            // tbxAuthorNameUpdate
            // 
            this.tbxAuthorNameUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbxAuthorNameUpdate.Location = new System.Drawing.Point(217, 65);
            this.tbxAuthorNameUpdate.Name = "tbxAuthorNameUpdate";
            this.tbxAuthorNameUpdate.Size = new System.Drawing.Size(157, 21);
            this.tbxAuthorNameUpdate.TabIndex = 18;
            // 
            // lblNumberPagesUpdate
            // 
            this.lblNumberPagesUpdate.AutoSize = true;
            this.lblNumberPagesUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNumberPagesUpdate.Location = new System.Drawing.Point(62, 99);
            this.lblNumberPagesUpdate.Name = "lblNumberPagesUpdate";
            this.lblNumberPagesUpdate.Size = new System.Drawing.Size(91, 15);
            this.lblNumberPagesUpdate.TabIndex = 16;
            this.lblNumberPagesUpdate.Text = "Number Pages";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbxNameUpdate.Location = new System.Drawing.Point(217, 33);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(157, 21);
            this.tbxNameUpdate.TabIndex = 17;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(238, 175);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbxAdd
            // 
            this.gbxAdd.BackColor = System.Drawing.Color.White;
            this.gbxAdd.Controls.Add(this.lblPublishingHouseAdd);
            this.gbxAdd.Controls.Add(this.tbxPublishingHouseAdd);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.lblNameAdd);
            this.gbxAdd.Controls.Add(this.tbxNumberPagesAdd);
            this.gbxAdd.Controls.Add(this.lblAuthorNameAdd);
            this.gbxAdd.Controls.Add(this.tbxAuthorNameAdd);
            this.gbxAdd.Controls.Add(this.lblNumberPagesAdd);
            this.gbxAdd.Controls.Add(this.tbxNameAdd);
            this.gbxAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbxAdd.Location = new System.Drawing.Point(14, 311);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(533, 223);
            this.gbxAdd.TabIndex = 26;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Book";
            // 
            // lblPublishingHouseAdd
            // 
            this.lblPublishingHouseAdd.AutoSize = true;
            this.lblPublishingHouseAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPublishingHouseAdd.Location = new System.Drawing.Point(36, 133);
            this.lblPublishingHouseAdd.Name = "lblPublishingHouseAdd";
            this.lblPublishingHouseAdd.Size = new System.Drawing.Size(106, 15);
            this.lblPublishingHouseAdd.TabIndex = 9;
            this.lblPublishingHouseAdd.Text = "Publishing House";
            // 
            // tbxPublishingHouseAdd
            // 
            this.tbxPublishingHouseAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbxPublishingHouseAdd.Location = new System.Drawing.Point(191, 130);
            this.tbxPublishingHouseAdd.Name = "tbxPublishingHouseAdd";
            this.tbxPublishingHouseAdd.Size = new System.Drawing.Size(157, 21);
            this.tbxPublishingHouseAdd.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(206, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNameAdd.Location = new System.Drawing.Point(36, 36);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(72, 15);
            this.lblNameAdd.TabIndex = 1;
            this.lblNameAdd.Text = "Book Name";
            // 
            // tbxNumberPagesAdd
            // 
            this.tbxNumberPagesAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbxNumberPagesAdd.Location = new System.Drawing.Point(191, 96);
            this.tbxNumberPagesAdd.Name = "tbxNumberPagesAdd";
            this.tbxNumberPagesAdd.Size = new System.Drawing.Size(157, 21);
            this.tbxNumberPagesAdd.TabIndex = 6;
            // 
            // lblAuthorNameAdd
            // 
            this.lblAuthorNameAdd.AutoSize = true;
            this.lblAuthorNameAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAuthorNameAdd.Location = new System.Drawing.Point(36, 68);
            this.lblAuthorNameAdd.Name = "lblAuthorNameAdd";
            this.lblAuthorNameAdd.Size = new System.Drawing.Size(79, 15);
            this.lblAuthorNameAdd.TabIndex = 2;
            this.lblAuthorNameAdd.Text = "Author Name";
            // 
            // tbxAuthorNameAdd
            // 
            this.tbxAuthorNameAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbxAuthorNameAdd.Location = new System.Drawing.Point(191, 65);
            this.tbxAuthorNameAdd.Name = "tbxAuthorNameAdd";
            this.tbxAuthorNameAdd.Size = new System.Drawing.Size(157, 21);
            this.tbxAuthorNameAdd.TabIndex = 5;
            // 
            // lblNumberPagesAdd
            // 
            this.lblNumberPagesAdd.AutoSize = true;
            this.lblNumberPagesAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNumberPagesAdd.Location = new System.Drawing.Point(36, 99);
            this.lblNumberPagesAdd.Name = "lblNumberPagesAdd";
            this.lblNumberPagesAdd.Size = new System.Drawing.Size(91, 15);
            this.lblNumberPagesAdd.TabIndex = 3;
            this.lblNumberPagesAdd.Text = "Number Pages";
            // 
            // tbxNameAdd
            // 
            this.tbxNameAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbxNameAdd.Location = new System.Drawing.Point(191, 33);
            this.tbxNameAdd.Name = "tbxNameAdd";
            this.tbxNameAdd.Size = new System.Drawing.Size(157, 21);
            this.tbxNameAdd.TabIndex = 4;
            // 
            // dgwLibrary
            // 
            this.dgwLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLibrary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgwLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLibrary.Location = new System.Drawing.Point(14, 137);
            this.dgwLibrary.Name = "dgwLibrary";
            this.dgwLibrary.Size = new System.Drawing.Size(1029, 154);
            this.dgwLibrary.TabIndex = 25;
            this.dgwLibrary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwLibrary_CellClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSearch.Location = new System.Drawing.Point(690, 99);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(114, 15);
            this.lblSearch.TabIndex = 30;
            this.lblSearch.Text = "Book Name Search";
            // 
            // tbxSearch
            // 
            this.tbxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbxSearch.Location = new System.Drawing.Point(810, 97);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(233, 20);
            this.tbxSearch.TabIndex = 31;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 546);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwLibrary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label lblPublishingHouseAdd;
        private System.Windows.Forms.TextBox tbxPublishingHouseAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.TextBox tbxNumberPagesAdd;
        private System.Windows.Forms.Label lblAuthorNameAdd;
        private System.Windows.Forms.TextBox tbxAuthorNameAdd;
        private System.Windows.Forms.Label lblNumberPagesAdd;
        private System.Windows.Forms.TextBox tbxNameAdd;
        private System.Windows.Forms.DataGridView dgwLibrary;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblPublishingHouseUpdate;
        private System.Windows.Forms.TextBox tbxPublishingHouseUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox tbxNumberPagesUpdate;
        private System.Windows.Forms.Label lblAuthorNameUpdate;
        private System.Windows.Forms.TextBox tbxAuthorNameUpdate;
        private System.Windows.Forms.Label lblNumberPagesUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
    }
}

