namespace BatchMerge
{
    partial class MainForm
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
            btnOpenFolderDest = new Button();
            btnOpenFolderSrc = new Button();
            lstFilesDest = new ListView();
            header = new ColumnHeader();
            lstFilesSrc = new ListView();
            header2 = new ColumnHeader();
            tbxPathDest = new TextBox();
            tbxPathSrc = new TextBox();
            fbdDest = new FolderBrowserDialog();
            fbdSrc = new FolderBrowserDialog();
            tbxInfoDest = new TextBox();
            tbxInfoSrc = new TextBox();
            numTrackID = new NumericUpDown();
            label2 = new Label();
            btnStartMerge = new Button();
            label1 = new Label();
            label3 = new Label();
            cbxTrackDefault = new CheckBox();
            cbxTrackForced = new CheckBox();
            pbrCurrentFile = new ProgressBar();
            pbrTotalProgress = new ProgressBar();
            label4 = new Label();
            label5 = new Label();
            btnCancelMerge = new Button();
            ((System.ComponentModel.ISupportInitialize)numTrackID).BeginInit();
            SuspendLayout();
            // 
            // btnOpenFolderDest
            // 
            btnOpenFolderDest.Location = new Point(649, 26);
            btnOpenFolderDest.Name = "btnOpenFolderDest";
            btnOpenFolderDest.Size = new Size(82, 23);
            btnOpenFolderDest.TabIndex = 0;
            btnOpenFolderDest.Text = "Open folder";
            btnOpenFolderDest.UseVisualStyleBackColor = true;
            btnOpenFolderDest.Click += btnOpenFolderDest_Click;
            // 
            // btnOpenFolderSrc
            // 
            btnOpenFolderSrc.Location = new Point(280, 27);
            btnOpenFolderSrc.Name = "btnOpenFolderSrc";
            btnOpenFolderSrc.Size = new Size(82, 23);
            btnOpenFolderSrc.TabIndex = 1;
            btnOpenFolderSrc.Text = "Open folder";
            btnOpenFolderSrc.UseVisualStyleBackColor = true;
            btnOpenFolderSrc.Click += btnOpenFolderSrc_Click;
            // 
            // lstFilesDest
            // 
            lstFilesDest.Columns.AddRange(new ColumnHeader[] { header });
            lstFilesDest.Location = new Point(381, 56);
            lstFilesDest.MultiSelect = false;
            lstFilesDest.Name = "lstFilesDest";
            lstFilesDest.Size = new Size(350, 400);
            lstFilesDest.TabIndex = 2;
            lstFilesDest.UseCompatibleStateImageBehavior = false;
            lstFilesDest.View = View.Details;
            // 
            // header
            // 
            header.Text = "File";
            header.Width = 325;
            // 
            // lstFilesSrc
            // 
            lstFilesSrc.Columns.AddRange(new ColumnHeader[] { header2 });
            lstFilesSrc.Location = new Point(12, 55);
            lstFilesSrc.Name = "lstFilesSrc";
            lstFilesSrc.Size = new Size(350, 400);
            lstFilesSrc.TabIndex = 3;
            lstFilesSrc.UseCompatibleStateImageBehavior = false;
            lstFilesSrc.View = View.Details;
            // 
            // header2
            // 
            header2.Text = "File";
            header2.Width = 325;
            // 
            // tbxPathDest
            // 
            tbxPathDest.Enabled = false;
            tbxPathDest.Location = new Point(381, 27);
            tbxPathDest.Name = "tbxPathDest";
            tbxPathDest.Size = new Size(262, 23);
            tbxPathDest.TabIndex = 4;
            // 
            // tbxPathSrc
            // 
            tbxPathSrc.Enabled = false;
            tbxPathSrc.Location = new Point(12, 27);
            tbxPathSrc.Name = "tbxPathSrc";
            tbxPathSrc.Size = new Size(262, 23);
            tbxPathSrc.TabIndex = 5;
            // 
            // tbxInfoDest
            // 
            tbxInfoDest.Location = new Point(381, 462);
            tbxInfoDest.Multiline = true;
            tbxInfoDest.Name = "tbxInfoDest";
            tbxInfoDest.ReadOnly = true;
            tbxInfoDest.ScrollBars = ScrollBars.Both;
            tbxInfoDest.Size = new Size(350, 206);
            tbxInfoDest.TabIndex = 6;
            tbxInfoDest.WordWrap = false;
            // 
            // tbxInfoSrc
            // 
            tbxInfoSrc.Location = new Point(12, 461);
            tbxInfoSrc.Multiline = true;
            tbxInfoSrc.Name = "tbxInfoSrc";
            tbxInfoSrc.ReadOnly = true;
            tbxInfoSrc.ScrollBars = ScrollBars.Both;
            tbxInfoSrc.Size = new Size(350, 206);
            tbxInfoSrc.TabIndex = 7;
            tbxInfoSrc.WordWrap = false;
            // 
            // numTrackID
            // 
            numTrackID.Location = new Point(138, 685);
            numTrackID.Name = "numTrackID";
            numTrackID.Size = new Size(53, 23);
            numTrackID.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 687);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 11;
            label2.Text = "Track ID to copy over:";
            // 
            // btnStartMerge
            // 
            btnStartMerge.Location = new Point(496, 683);
            btnStartMerge.Name = "btnStartMerge";
            btnStartMerge.Size = new Size(95, 23);
            btnStartMerge.TabIndex = 12;
            btnStartMerge.Text = "Start merge";
            btnStartMerge.UseVisualStyleBackColor = true;
            btnStartMerge.Click += btnStartMerge_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 13;
            label1.Text = "Files to merge audio track INTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(179, 15);
            label3.TabIndex = 14;
            label3.Text = "Files to merge audio track FROM";
            // 
            // cbxTrackDefault
            // 
            cbxTrackDefault.AutoSize = true;
            cbxTrackDefault.Location = new Point(213, 686);
            cbxTrackDefault.Name = "cbxTrackDefault";
            cbxTrackDefault.Size = new Size(124, 19);
            cbxTrackDefault.TabIndex = 15;
            cbxTrackDefault.Text = "Make track default";
            cbxTrackDefault.UseVisualStyleBackColor = true;
            // 
            // cbxTrackForced
            // 
            cbxTrackForced.AutoSize = true;
            cbxTrackForced.Location = new Point(353, 686);
            cbxTrackForced.Name = "cbxTrackForced";
            cbxTrackForced.Size = new Size(121, 19);
            cbxTrackForced.TabIndex = 16;
            cbxTrackForced.Text = "Make track forced";
            cbxTrackForced.UseVisualStyleBackColor = true;
            // 
            // pbrCurrentFile
            // 
            pbrCurrentFile.Location = new Point(12, 742);
            pbrCurrentFile.Name = "pbrCurrentFile";
            pbrCurrentFile.Size = new Size(340, 23);
            pbrCurrentFile.TabIndex = 17;
            // 
            // pbrTotalProgress
            // 
            pbrTotalProgress.Location = new Point(381, 742);
            pbrTotalProgress.Name = "pbrTotalProgress";
            pbrTotalProgress.Size = new Size(350, 23);
            pbrTotalProgress.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 724);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 19;
            label4.Text = "Current file progress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 724);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 20;
            label5.Text = "Global progress";
            // 
            // btnCancelMerge
            // 
            btnCancelMerge.Enabled = false;
            btnCancelMerge.Location = new Point(610, 683);
            btnCancelMerge.Name = "btnCancelMerge";
            btnCancelMerge.Size = new Size(95, 23);
            btnCancelMerge.TabIndex = 21;
            btnCancelMerge.Text = "Cancel merge";
            btnCancelMerge.UseVisualStyleBackColor = true;
            btnCancelMerge.Click += btnCancelMerge_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 787);
            Controls.Add(btnCancelMerge);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pbrTotalProgress);
            Controls.Add(pbrCurrentFile);
            Controls.Add(cbxTrackForced);
            Controls.Add(cbxTrackDefault);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnStartMerge);
            Controls.Add(label2);
            Controls.Add(numTrackID);
            Controls.Add(tbxInfoSrc);
            Controls.Add(tbxInfoDest);
            Controls.Add(tbxPathSrc);
            Controls.Add(tbxPathDest);
            Controls.Add(lstFilesSrc);
            Controls.Add(lstFilesDest);
            Controls.Add(btnOpenFolderSrc);
            Controls.Add(btnOpenFolderDest);
            Name = "MainForm";
            Text = "MKV Audio Merger";
            ((System.ComponentModel.ISupportInitialize)numTrackID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFolderDest;
        private Button btnOpenFolderSrc;
        private ListView lstFilesDest;
        private ListView lstFilesSrc;
        private TextBox tbxPathDest;
        private TextBox tbxPathSrc;
        private FolderBrowserDialog fbdDest;
        private FolderBrowserDialog fbdSrc;
        private ColumnHeader header;
        private ColumnHeader header2;
        private TextBox tbxInfoDest;
        private TextBox tbxInfoSrc;
        private NumericUpDown numTrackID;
        private Label label2;
        private Button btnStartMerge;
        private Label label1;
        private Label label3;
        private CheckBox cbxTrackDefault;
        private CheckBox cbxTrackForced;
        private ProgressBar pbrCurrentFile;
        private ProgressBar pbrTotalProgress;
        private Label label4;
        private Label label5;
        private Button btnCancelMerge;
    }
}
