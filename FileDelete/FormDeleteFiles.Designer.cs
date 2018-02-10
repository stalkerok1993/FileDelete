namespace FileDelete {
    partial class FormDeleteFiles {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.folderBrowserDialogDeleteRoot = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogCompareRoot = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxDeleteRoot = new System.Windows.Forms.TextBox();
            this.textBoxCompareRoot = new System.Windows.Forms.TextBox();
            this.labelDeleteFrom = new System.Windows.Forms.Label();
            this.labelCompareWith = new System.Windows.Forms.Label();
            this.buttonBrowseDelete = new System.Windows.Forms.Button();
            this.buttonBrowseCompare = new System.Windows.Forms.Button();
            this.textBoxSubFolders = new System.Windows.Forms.TextBox();
            this.textBoxMarked = new System.Windows.Forms.TextBox();
            this.labelSubfolders = new System.Windows.Forms.Label();
            this.labelMarked = new System.Windows.Forms.Label();
            this.buttonDeleteMarked = new System.Windows.Forms.Button();
            this.textBoxBackup = new System.Windows.Forms.TextBox();
            this.buttonBrowseBackup = new System.Windows.Forms.Button();
            this.labelBackup = new System.Windows.Forms.Label();
            this.folderBrowserDialogBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBoxDeleteRoot
            // 
            this.textBoxDeleteRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeleteRoot.Location = new System.Drawing.Point(155, 12);
            this.textBoxDeleteRoot.Name = "textBoxDeleteRoot";
            this.textBoxDeleteRoot.Size = new System.Drawing.Size(453, 20);
            this.textBoxDeleteRoot.TabIndex = 0;
            this.textBoxDeleteRoot.TextChanged += new System.EventHandler(this.textBoxDeleteRoot_TextChanged);
            // 
            // textBoxCompareRoot
            // 
            this.textBoxCompareRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCompareRoot.Location = new System.Drawing.Point(155, 38);
            this.textBoxCompareRoot.Name = "textBoxCompareRoot";
            this.textBoxCompareRoot.Size = new System.Drawing.Size(453, 20);
            this.textBoxCompareRoot.TabIndex = 1;
            this.textBoxCompareRoot.Text = "\\\\Dk01sv7033\\MO-P\\DEV\\MO-P\\APLUNIT";
            this.textBoxCompareRoot.TextChanged += new System.EventHandler(this.textBoxCompareRoot_TextChanged);
            // 
            // labelDeleteFrom
            // 
            this.labelDeleteFrom.AutoSize = true;
            this.labelDeleteFrom.Location = new System.Drawing.Point(12, 15);
            this.labelDeleteFrom.Name = "labelDeleteFrom";
            this.labelDeleteFrom.Size = new System.Drawing.Size(129, 13);
            this.labelDeleteFrom.TabIndex = 2;
            this.labelDeleteFrom.Text = "Root folder to delete from:";
            // 
            // labelCompareWith
            // 
            this.labelCompareWith.AutoSize = true;
            this.labelCompareWith.Location = new System.Drawing.Point(12, 41);
            this.labelCompareWith.Name = "labelCompareWith";
            this.labelCompareWith.Size = new System.Drawing.Size(140, 13);
            this.labelCompareWith.TabIndex = 3;
            this.labelCompareWith.Text = "Root folder to compare with:";
            // 
            // buttonBrowseDelete
            // 
            this.buttonBrowseDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseDelete.Location = new System.Drawing.Point(614, 10);
            this.buttonBrowseDelete.Name = "buttonBrowseDelete";
            this.buttonBrowseDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseDelete.TabIndex = 4;
            this.buttonBrowseDelete.Text = "Browse";
            this.buttonBrowseDelete.UseVisualStyleBackColor = true;
            this.buttonBrowseDelete.Click += new System.EventHandler(this.buttonBrouseDelete_Click);
            // 
            // buttonBrowseCompare
            // 
            this.buttonBrowseCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseCompare.Location = new System.Drawing.Point(614, 36);
            this.buttonBrowseCompare.Name = "buttonBrowseCompare";
            this.buttonBrowseCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseCompare.TabIndex = 5;
            this.buttonBrowseCompare.Text = "Browse";
            this.buttonBrowseCompare.UseVisualStyleBackColor = true;
            this.buttonBrowseCompare.Click += new System.EventHandler(this.buttonBrouseCompare_Click);
            // 
            // textBoxSubFolders
            // 
            this.textBoxSubFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSubFolders.Location = new System.Drawing.Point(15, 77);
            this.textBoxSubFolders.Multiline = true;
            this.textBoxSubFolders.Name = "textBoxSubFolders";
            this.textBoxSubFolders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSubFolders.Size = new System.Drawing.Size(340, 195);
            this.textBoxSubFolders.TabIndex = 6;
            this.textBoxSubFolders.Text = "mTEST_FMRFMAN\r\nmTEST_RISKMEAS_APPL\r\nmTEST_REPSTRGET\r\nmTEST_RF\r\nmTEST_RFRETURNS\r\nm" +
    "TEST_RFMAN\r\nmTEST_RMEXECLIM\r\nmTEST_RISKMEAS_EXEC\r\nmTEST_APTXML\r\nmTEST_REPMAN_COR" +
    "E\r\nmTEST_APTT";
            this.textBoxSubFolders.TextChanged += new System.EventHandler(this.textBoxSubFolders_TextChanged);
            // 
            // textBoxMarked
            // 
            this.textBoxMarked.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMarked.Location = new System.Drawing.Point(361, 77);
            this.textBoxMarked.Multiline = true;
            this.textBoxMarked.Name = "textBoxMarked";
            this.textBoxMarked.ReadOnly = true;
            this.textBoxMarked.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMarked.Size = new System.Drawing.Size(328, 195);
            this.textBoxMarked.TabIndex = 7;
            // 
            // labelSubfolders
            // 
            this.labelSubfolders.AutoSize = true;
            this.labelSubfolders.Location = new System.Drawing.Point(12, 61);
            this.labelSubfolders.Name = "labelSubfolders";
            this.labelSubfolders.Size = new System.Drawing.Size(160, 13);
            this.labelSubfolders.TabIndex = 8;
            this.labelSubfolders.Text = "Subfolders to look (one per row):";
            // 
            // labelMarked
            // 
            this.labelMarked.AutoSize = true;
            this.labelMarked.Location = new System.Drawing.Point(358, 61);
            this.labelMarked.Name = "labelMarked";
            this.labelMarked.Size = new System.Drawing.Size(159, 13);
            this.labelMarked.TabIndex = 9;
            this.labelMarked.Text = "Different files (marked to delete):";
            // 
            // buttonDeleteMarked
            // 
            this.buttonDeleteMarked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteMarked.Location = new System.Drawing.Point(361, 278);
            this.buttonDeleteMarked.Name = "buttonDeleteMarked";
            this.buttonDeleteMarked.Size = new System.Drawing.Size(328, 23);
            this.buttonDeleteMarked.TabIndex = 10;
            this.buttonDeleteMarked.Text = "Delete marked";
            this.buttonDeleteMarked.UseVisualStyleBackColor = true;
            this.buttonDeleteMarked.Click += new System.EventHandler(this.buttonDeleteMarked_Click);
            // 
            // textBoxBackup
            // 
            this.textBoxBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxBackup.Location = new System.Drawing.Point(106, 280);
            this.textBoxBackup.Name = "textBoxBackup";
            this.textBoxBackup.Size = new System.Drawing.Size(168, 20);
            this.textBoxBackup.TabIndex = 11;
            this.textBoxBackup.Text = "U:\\_backup";
            this.textBoxBackup.TextChanged += new System.EventHandler(this.textBoxBackup_TextChanged);
            // 
            // buttonBrowseBackup
            // 
            this.buttonBrowseBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBrowseBackup.Location = new System.Drawing.Point(280, 278);
            this.buttonBrowseBackup.Name = "buttonBrowseBackup";
            this.buttonBrowseBackup.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseBackup.TabIndex = 12;
            this.buttonBrowseBackup.Text = "Browse";
            this.buttonBrowseBackup.UseVisualStyleBackColor = true;
            this.buttonBrowseBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // labelBackup
            // 
            this.labelBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBackup.AutoSize = true;
            this.labelBackup.Location = new System.Drawing.Point(12, 283);
            this.labelBackup.Name = "labelBackup";
            this.labelBackup.Size = new System.Drawing.Size(88, 13);
            this.labelBackup.TabIndex = 13;
            this.labelBackup.Text = "Backup to folder:";
            // 
            // FormDeleteFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 313);
            this.Controls.Add(this.labelBackup);
            this.Controls.Add(this.buttonBrowseBackup);
            this.Controls.Add(this.textBoxBackup);
            this.Controls.Add(this.buttonDeleteMarked);
            this.Controls.Add(this.labelMarked);
            this.Controls.Add(this.labelSubfolders);
            this.Controls.Add(this.textBoxMarked);
            this.Controls.Add(this.textBoxSubFolders);
            this.Controls.Add(this.buttonBrowseCompare);
            this.Controls.Add(this.buttonBrowseDelete);
            this.Controls.Add(this.labelCompareWith);
            this.Controls.Add(this.labelDeleteFrom);
            this.Controls.Add(this.textBoxCompareRoot);
            this.Controls.Add(this.textBoxDeleteRoot);
            this.Name = "FormDeleteFiles";
            this.Text = "Delete Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDeleteRoot;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogCompareRoot;
        private System.Windows.Forms.TextBox textBoxDeleteRoot;
        private System.Windows.Forms.TextBox textBoxCompareRoot;
        private System.Windows.Forms.Label labelDeleteFrom;
        private System.Windows.Forms.Label labelCompareWith;
        private System.Windows.Forms.Button buttonBrowseDelete;
        private System.Windows.Forms.Button buttonBrowseCompare;
        private System.Windows.Forms.TextBox textBoxSubFolders;
        private System.Windows.Forms.TextBox textBoxMarked;
        private System.Windows.Forms.Label labelSubfolders;
        private System.Windows.Forms.Label labelMarked;
        private System.Windows.Forms.Button buttonDeleteMarked;
        private System.Windows.Forms.TextBox textBoxBackup;
        private System.Windows.Forms.Button buttonBrowseBackup;
        private System.Windows.Forms.Label labelBackup;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogBackup;
    }
}

