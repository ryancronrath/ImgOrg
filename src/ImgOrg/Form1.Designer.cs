namespace ImgOrg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgPath = new System.Windows.Forms.TextBox();
            this.imgPathBtn = new System.Windows.Forms.Button();
            this.imgOrgBtn = new System.Windows.Forms.Button();
            this.resultList = new System.Windows.Forms.DataGridView();
            this.ImageCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovedToCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.outputPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dryRunBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultList)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPath
            // 
            this.imgPath.Enabled = false;
            this.imgPath.Location = new System.Drawing.Point(12, 36);
            this.imgPath.Name = "imgPath";
            this.imgPath.Size = new System.Drawing.Size(597, 23);
            this.imgPath.TabIndex = 0;
            // 
            // imgPathBtn
            // 
            this.imgPathBtn.Location = new System.Drawing.Point(615, 35);
            this.imgPathBtn.Name = "imgPathBtn";
            this.imgPathBtn.Size = new System.Drawing.Size(157, 23);
            this.imgPathBtn.TabIndex = 1;
            this.imgPathBtn.Text = "Set Image(s) Location";
            this.imgPathBtn.UseVisualStyleBackColor = true;
            this.imgPathBtn.Click += new System.EventHandler(this.imgPathBtn_Click);
            // 
            // imgOrgBtn
            // 
            this.imgOrgBtn.Location = new System.Drawing.Point(615, 137);
            this.imgOrgBtn.Name = "imgOrgBtn";
            this.imgOrgBtn.Size = new System.Drawing.Size(157, 23);
            this.imgOrgBtn.TabIndex = 2;
            this.imgOrgBtn.Text = "Organize Images";
            this.imgOrgBtn.UseVisualStyleBackColor = true;
            this.imgOrgBtn.Click += new System.EventHandler(this.imgOrgBtn_Click);
            // 
            // resultList
            // 
            this.resultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageCol,
            this.MovedToCol});
            this.resultList.Location = new System.Drawing.Point(12, 166);
            this.resultList.Name = "resultList";
            this.resultList.RowHeadersVisible = false;
            this.resultList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.resultList.RowTemplate.Height = 25;
            this.resultList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.resultList.Size = new System.Drawing.Size(760, 383);
            this.resultList.TabIndex = 3;
            this.resultList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultList_CellContentDoubleClick);
            // 
            // ImageCol
            // 
            this.ImageCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImageCol.HeaderText = "Image";
            this.ImageCol.Name = "ImageCol";
            this.ImageCol.ReadOnly = true;
            // 
            // MovedToCol
            // 
            this.MovedToCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MovedToCol.HeaderText = "MovedTo";
            this.MovedToCol.Name = "MovedToCol";
            this.MovedToCol.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Organization Results";
            // 
            // outputPath
            // 
            this.outputPath.Enabled = false;
            this.outputPath.Location = new System.Drawing.Point(12, 90);
            this.outputPath.Name = "outputPath";
            this.outputPath.Size = new System.Drawing.Size(597, 23);
            this.outputPath.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Set Output Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Image Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output Location";
            // 
            // dryRunBtn
            // 
            this.dryRunBtn.Location = new System.Drawing.Point(520, 137);
            this.dryRunBtn.Name = "dryRunBtn";
            this.dryRunBtn.Size = new System.Drawing.Size(89, 23);
            this.dryRunBtn.TabIndex = 9;
            this.dryRunBtn.Text = "Dry Run";
            this.dryRunBtn.UseVisualStyleBackColor = true;
            this.dryRunBtn.Click += new System.EventHandler(this.dryRunBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dryRunBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.imgOrgBtn);
            this.Controls.Add(this.imgPathBtn);
            this.Controls.Add(this.imgPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImgOrg - v.1.0.0";
            ((System.ComponentModel.ISupportInitialize)(this.resultList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox imgPath;
        private Button imgPathBtn;
        private Button imgOrgBtn;
        private DataGridView resultList;
        private Label label1;
        private TextBox outputPath;
        private Button button1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn ImageCol;
        private DataGridViewTextBoxColumn MovedToCol;
        private Button dryRunBtn;
    }
}