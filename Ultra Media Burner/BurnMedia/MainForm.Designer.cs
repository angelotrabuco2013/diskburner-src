namespace BurnMedia
{
	// Token: 0x02000002 RID: 2
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000025 RID: 37
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000026 RID: 38
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::BurnMedia.MainForm));
			this.devicesComboBox = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.supportedMediaLabel = new global::System.Windows.Forms.Label();
			this.backgroundBurnWorker = new global::System.ComponentModel.BackgroundWorker();
			this.folderBrowserDialog = new global::System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog = new global::System.Windows.Forms.OpenFileDialog();
			this.label3 = new global::System.Windows.Forms.Label();
			this.labelTotalSize = new global::System.Windows.Forms.Label();
			this.progressBarCapacity = new global::System.Windows.Forms.ProgressBar();
			this.buttonFormat = new global::System.Windows.Forms.Button();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPageBurn = new global::System.Windows.Forms.TabPage();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.statusProgressBar = new global::System.Windows.Forms.ProgressBar();
			this.labelStatusText = new global::System.Windows.Forms.Label();
			this.buttonBurn = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.labelMediaType = new global::System.Windows.Forms.Label();
			this.buttonDetectMedia = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.comboBoxVerification = new global::System.Windows.Forms.ComboBox();
			this.labelVerification = new global::System.Windows.Forms.Label();
			this.checkBoxEject = new global::System.Windows.Forms.CheckBox();
			this.checkBoxCloseMedia = new global::System.Windows.Forms.CheckBox();
			this.textBoxLabel = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.buttonRemoveFiles = new global::System.Windows.Forms.Button();
			this.buttonAddFolders = new global::System.Windows.Forms.Button();
			this.buttonAddFiles = new global::System.Windows.Forms.Button();
			this.listBoxFiles = new global::System.Windows.Forms.ListBox();
			this.tabPageFormat = new global::System.Windows.Forms.TabPage();
			this.checkBoxQuickFormat = new global::System.Windows.Forms.CheckBox();
			this.checkBoxEjectFormat = new global::System.Windows.Forms.CheckBox();
			this.formatProgressBar = new global::System.Windows.Forms.ProgressBar();
			this.labelFormatStatusText = new global::System.Windows.Forms.Label();
			this.backgroundFormatWorker = new global::System.ComponentModel.BackgroundWorker();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.tabControl1.SuspendLayout();
			this.tabPageBurn.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPageFormat.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			base.SuspendLayout();
			this.devicesComboBox.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.devicesComboBox.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.devicesComboBox.FormattingEnabled = true;
			this.devicesComboBox.Location = new global::System.Drawing.Point(19, 73);
			this.devicesComboBox.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.devicesComboBox.Name = "devicesComboBox";
			this.devicesComboBox.Size = new global::System.Drawing.Size(260, 24);
			this.devicesComboBox.TabIndex = 1;
			this.devicesComboBox.SelectedIndexChanged += new global::System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
			this.devicesComboBox.Format += new global::System.Windows.Forms.ListControlConvertEventHandler(this.devicesComboBox_Format);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(305, 76);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(120, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Supported media types:";
			this.supportedMediaLabel.Location = new global::System.Drawing.Point(436, 93);
			this.supportedMediaLabel.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.supportedMediaLabel.Name = "supportedMediaLabel";
			this.supportedMediaLabel.Size = new global::System.Drawing.Size(403, 57);
			this.supportedMediaLabel.TabIndex = 3;
			this.backgroundBurnWorker.WorkerReportsProgress = true;
			this.backgroundBurnWorker.WorkerSupportsCancellation = true;
			this.backgroundBurnWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundBurnWorker_DoWork);
			this.backgroundBurnWorker.ProgressChanged += new global::System.ComponentModel.ProgressChangedEventHandler(this.backgroundBurnWorker_ProgressChanged);
			this.backgroundBurnWorker.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundBurnWorker_RunWorkerCompleted);
			this.openFileDialog.Filter = "All Files (*.*)|*.*";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(8, 90);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(16, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "0";
			this.labelTotalSize.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.labelTotalSize.AutoSize = true;
			this.labelTotalSize.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.labelTotalSize.Location = new global::System.Drawing.Point(257, 90);
			this.labelTotalSize.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTotalSize.Name = "labelTotalSize";
			this.labelTotalSize.Size = new global::System.Drawing.Size(62, 17);
			this.labelTotalSize.TabIndex = 7;
			this.labelTotalSize.Text = "totalSize";
			this.progressBarCapacity.Location = new global::System.Drawing.Point(8, 113);
			this.progressBarCapacity.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.progressBarCapacity.Name = "progressBarCapacity";
			this.progressBarCapacity.Size = new global::System.Drawing.Size(307, 15);
			this.progressBarCapacity.Step = 1;
			this.progressBarCapacity.Style = global::System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarCapacity.TabIndex = 8;
			this.buttonFormat.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.buttonFormat.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 0, 0, 0);
			this.buttonFormat.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonFormat.ForeColor = global::System.Drawing.Color.Ivory;
			this.buttonFormat.Location = new global::System.Drawing.Point(325, 124);
			this.buttonFormat.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonFormat.Name = "buttonFormat";
			this.buttonFormat.Size = new global::System.Drawing.Size(111, 36);
			this.buttonFormat.TabIndex = 10;
			this.buttonFormat.Text = "Format Disk";
			this.buttonFormat.UseVisualStyleBackColor = false;
			this.buttonFormat.Click += new global::System.EventHandler(this.buttonFormat_Click);
			this.tabControl1.Controls.Add(this.tabPageBurn);
			this.tabControl1.Controls.Add(this.tabPageFormat);
			this.tabControl1.Location = new global::System.Drawing.Point(19, 129);
			this.tabControl1.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(824, 407);
			this.tabControl1.TabIndex = 11;
			this.tabControl1.Selecting += new global::System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
			this.tabPageBurn.BackColor = global::System.Drawing.SystemColors.ButtonFace;
			this.tabPageBurn.Controls.Add(this.groupBox3);
			this.tabPageBurn.Controls.Add(this.groupBox2);
			this.tabPageBurn.Controls.Add(this.groupBox1);
			this.tabPageBurn.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.tabPageBurn.Location = new global::System.Drawing.Point(4, 25);
			this.tabPageBurn.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPageBurn.Name = "tabPageBurn";
			this.tabPageBurn.Padding = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPageBurn.Size = new global::System.Drawing.Size(816, 378);
			this.tabPageBurn.TabIndex = 0;
			this.tabPageBurn.Text = "Burn Files";
			this.groupBox3.Controls.Add(this.statusProgressBar);
			this.groupBox3.Controls.Add(this.labelStatusText);
			this.groupBox3.Controls.Add(this.buttonBurn);
			this.groupBox3.Location = new global::System.Drawing.Point(479, 177);
			this.groupBox3.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Size = new global::System.Drawing.Size(327, 191);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Progress";
			this.statusProgressBar.Location = new global::System.Drawing.Point(16, 86);
			this.statusProgressBar.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.statusProgressBar.Name = "statusProgressBar";
			this.statusProgressBar.Size = new global::System.Drawing.Size(299, 20);
			this.statusProgressBar.TabIndex = 8;
			this.labelStatusText.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.labelStatusText.Location = new global::System.Drawing.Point(12, 22);
			this.labelStatusText.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatusText.Name = "labelStatusText";
			this.labelStatusText.Size = new global::System.Drawing.Size(303, 55);
			this.labelStatusText.TabIndex = 7;
			this.labelStatusText.Text = "status";
			this.labelStatusText.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.buttonBurn.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.buttonBurn.FlatAppearance.BorderSize = 0;
			this.buttonBurn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonBurn.ForeColor = global::System.Drawing.Color.Ivory;
			this.buttonBurn.Location = new global::System.Drawing.Point(112, 113);
			this.buttonBurn.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonBurn.Name = "buttonBurn";
			this.buttonBurn.Size = new global::System.Drawing.Size(117, 37);
			this.buttonBurn.TabIndex = 6;
			this.buttonBurn.Text = "&Burn";
			this.buttonBurn.UseVisualStyleBackColor = false;
			this.buttonBurn.Click += new global::System.EventHandler(this.buttonBurn_Click);
			this.groupBox2.Controls.Add(this.labelMediaType);
			this.groupBox2.Controls.Add(this.buttonDetectMedia);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.labelTotalSize);
			this.groupBox2.Controls.Add(this.progressBarCapacity);
			this.groupBox2.Location = new global::System.Drawing.Point(479, 7);
			this.groupBox2.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new global::System.Drawing.Size(327, 162);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Selected media type:";
			this.labelMediaType.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.labelMediaType.Location = new global::System.Drawing.Point(156, 25);
			this.labelMediaType.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMediaType.Name = "labelMediaType";
			this.labelMediaType.Size = new global::System.Drawing.Size(159, 49);
			this.labelMediaType.TabIndex = 10;
			this.labelMediaType.Text = "Press 'Detect Media' Button";
			this.buttonDetectMedia.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.buttonDetectMedia.FlatAppearance.BorderSize = 0;
			this.buttonDetectMedia.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonDetectMedia.Font = new global::System.Drawing.Font("Baskerville Old Face", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonDetectMedia.ForeColor = global::System.Drawing.Color.Ivory;
			this.buttonDetectMedia.Location = new global::System.Drawing.Point(16, 25);
			this.buttonDetectMedia.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonDetectMedia.Name = "buttonDetectMedia";
			this.buttonDetectMedia.Size = new global::System.Drawing.Size(131, 34);
			this.buttonDetectMedia.TabIndex = 9;
			this.buttonDetectMedia.Text = "Detect Media";
			this.buttonDetectMedia.UseVisualStyleBackColor = false;
			this.buttonDetectMedia.Click += new global::System.EventHandler(this.buttonDetectMedia_Click);
			this.groupBox1.Controls.Add(this.comboBoxVerification);
			this.groupBox1.Controls.Add(this.labelVerification);
			this.groupBox1.Controls.Add(this.checkBoxEject);
			this.groupBox1.Controls.Add(this.checkBoxCloseMedia);
			this.groupBox1.Controls.Add(this.textBoxLabel);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.buttonRemoveFiles);
			this.groupBox1.Controls.Add(this.buttonAddFolders);
			this.groupBox1.Controls.Add(this.buttonAddFiles);
			this.groupBox1.Controls.Add(this.listBoxFiles);
			this.groupBox1.Location = new global::System.Drawing.Point(15, 7);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new global::System.Drawing.Size(449, 361);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Files to burn";
			this.comboBoxVerification.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVerification.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxVerification.FormattingEnabled = true;
			this.comboBoxVerification.Items.AddRange(new object[] { "None", "Quick", "Full" });
			this.comboBoxVerification.Location = new global::System.Drawing.Point(105, 316);
			this.comboBoxVerification.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBoxVerification.Name = "comboBoxVerification";
			this.comboBoxVerification.Size = new global::System.Drawing.Size(160, 24);
			this.comboBoxVerification.TabIndex = 9;
			this.comboBoxVerification.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxVerification_SelectedIndexChanged);
			this.labelVerification.AutoSize = true;
			this.labelVerification.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.labelVerification.Location = new global::System.Drawing.Point(13, 320);
			this.labelVerification.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelVerification.Name = "labelVerification";
			this.labelVerification.Size = new global::System.Drawing.Size(82, 17);
			this.labelVerification.TabIndex = 8;
			this.labelVerification.Text = "Verification:";
			this.checkBoxEject.AutoSize = true;
			this.checkBoxEject.Checked = true;
			this.checkBoxEject.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkBoxEject.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxEject.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.checkBoxEject.Location = new global::System.Drawing.Point(217, 272);
			this.checkBoxEject.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.checkBoxEject.Name = "checkBoxEject";
			this.checkBoxEject.Size = new global::System.Drawing.Size(147, 21);
			this.checkBoxEject.TabIndex = 7;
			this.checkBoxEject.Text = "Eject when finished";
			this.checkBoxEject.UseVisualStyleBackColor = true;
			this.checkBoxCloseMedia.AutoSize = true;
			this.checkBoxCloseMedia.Checked = true;
			this.checkBoxCloseMedia.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkBoxCloseMedia.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxCloseMedia.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.checkBoxCloseMedia.Location = new global::System.Drawing.Point(13, 272);
			this.checkBoxCloseMedia.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.checkBoxCloseMedia.Name = "checkBoxCloseMedia";
			this.checkBoxCloseMedia.Size = new global::System.Drawing.Size(103, 21);
			this.checkBoxCloseMedia.TabIndex = 6;
			this.checkBoxCloseMedia.Text = "Close media";
			this.checkBoxCloseMedia.UseVisualStyleBackColor = true;
			this.textBoxLabel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxLabel.Location = new global::System.Drawing.Point(164, 235);
			this.textBoxLabel.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxLabel.Name = "textBoxLabel";
			this.textBoxLabel.Size = new global::System.Drawing.Size(170, 22);
			this.textBoxLabel.TabIndex = 5;
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new global::System.Drawing.Point(56, 239);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(98, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Volume label:";
			this.buttonRemoveFiles.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.buttonRemoveFiles.FlatAppearance.BorderSize = 0;
			this.buttonRemoveFiles.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonRemoveFiles.Font = new global::System.Drawing.Font("Baskerville Old Face", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonRemoveFiles.ForeColor = global::System.Drawing.Color.Ivory;
			this.buttonRemoveFiles.Location = new global::System.Drawing.Point(291, 193);
			this.buttonRemoveFiles.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonRemoveFiles.Name = "buttonRemoveFiles";
			this.buttonRemoveFiles.Size = new global::System.Drawing.Size(141, 33);
			this.buttonRemoveFiles.TabIndex = 3;
			this.buttonRemoveFiles.Text = "Remove file(s)...";
			this.buttonRemoveFiles.UseVisualStyleBackColor = false;
			this.buttonRemoveFiles.Click += new global::System.EventHandler(this.buttonRemoveFiles_Click);
			this.buttonAddFolders.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.buttonAddFolders.FlatAppearance.BorderSize = 0;
			this.buttonAddFolders.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddFolders.Font = new global::System.Drawing.Font("Baskerville Old Face", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonAddFolders.ForeColor = global::System.Drawing.Color.Ivory;
			this.buttonAddFolders.Location = new global::System.Drawing.Point(143, 193);
			this.buttonAddFolders.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonAddFolders.Name = "buttonAddFolders";
			this.buttonAddFolders.Size = new global::System.Drawing.Size(131, 33);
			this.buttonAddFolders.TabIndex = 2;
			this.buttonAddFolders.Text = "Add Folders...";
			this.buttonAddFolders.UseVisualStyleBackColor = false;
			this.buttonAddFolders.Click += new global::System.EventHandler(this.buttonAddFolders_Click);
			this.buttonAddFiles.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.buttonAddFiles.FlatAppearance.BorderSize = 0;
			this.buttonAddFiles.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddFiles.Font = new global::System.Drawing.Font("Baskerville Old Face", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonAddFiles.ForeColor = global::System.Drawing.Color.Ivory;
			this.buttonAddFiles.Location = new global::System.Drawing.Point(13, 193);
			this.buttonAddFiles.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonAddFiles.Name = "buttonAddFiles";
			this.buttonAddFiles.Size = new global::System.Drawing.Size(112, 33);
			this.buttonAddFiles.TabIndex = 1;
			this.buttonAddFiles.Text = "Add Files...";
			this.buttonAddFiles.UseVisualStyleBackColor = false;
			this.buttonAddFiles.Click += new global::System.EventHandler(this.buttonAddFiles_Click);
			this.listBoxFiles.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBoxFiles.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.listBoxFiles.FormattingEnabled = true;
			this.listBoxFiles.ItemHeight = 24;
			this.listBoxFiles.Location = new global::System.Drawing.Point(13, 23);
			this.listBoxFiles.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.listBoxFiles.Name = "listBoxFiles";
			this.listBoxFiles.Size = new global::System.Drawing.Size(419, 146);
			this.listBoxFiles.TabIndex = 0;
			this.listBoxFiles.DrawItem += new global::System.Windows.Forms.DrawItemEventHandler(this.listBoxFiles_DrawItem);
			this.listBoxFiles.SelectedIndexChanged += new global::System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
			this.tabPageFormat.BackColor = global::System.Drawing.SystemColors.ButtonFace;
			this.tabPageFormat.Controls.Add(this.checkBoxQuickFormat);
			this.tabPageFormat.Controls.Add(this.checkBoxEjectFormat);
			this.tabPageFormat.Controls.Add(this.formatProgressBar);
			this.tabPageFormat.Controls.Add(this.labelFormatStatusText);
			this.tabPageFormat.Controls.Add(this.buttonFormat);
			this.tabPageFormat.ForeColor = global::System.Drawing.SystemColors.ActiveBorder;
			this.tabPageFormat.Location = new global::System.Drawing.Point(4, 25);
			this.tabPageFormat.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPageFormat.Name = "tabPageFormat";
			this.tabPageFormat.Padding = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPageFormat.Size = new global::System.Drawing.Size(816, 378);
			this.tabPageFormat.TabIndex = 1;
			this.tabPageFormat.Text = "Format Disk";
			this.checkBoxQuickFormat.AutoSize = true;
			this.checkBoxQuickFormat.Checked = true;
			this.checkBoxQuickFormat.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkBoxQuickFormat.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxQuickFormat.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.checkBoxQuickFormat.Location = new global::System.Drawing.Point(321, 76);
			this.checkBoxQuickFormat.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.checkBoxQuickFormat.Name = "checkBoxQuickFormat";
			this.checkBoxQuickFormat.Size = new global::System.Drawing.Size(110, 21);
			this.checkBoxQuickFormat.TabIndex = 14;
			this.checkBoxQuickFormat.Text = "Quick format";
			this.checkBoxQuickFormat.UseVisualStyleBackColor = true;
			this.checkBoxEjectFormat.AutoSize = true;
			this.checkBoxEjectFormat.Checked = true;
			this.checkBoxEjectFormat.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkBoxEjectFormat.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxEjectFormat.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.checkBoxEjectFormat.Location = new global::System.Drawing.Point(303, 48);
			this.checkBoxEjectFormat.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.checkBoxEjectFormat.Name = "checkBoxEjectFormat";
			this.checkBoxEjectFormat.Size = new global::System.Drawing.Size(147, 21);
			this.checkBoxEjectFormat.TabIndex = 12;
			this.checkBoxEjectFormat.Text = "Eject when finished";
			this.checkBoxEjectFormat.UseVisualStyleBackColor = true;
			this.formatProgressBar.ForeColor = global::System.Drawing.Color.ForestGreen;
			this.formatProgressBar.Location = new global::System.Drawing.Point(168, 273);
			this.formatProgressBar.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.formatProgressBar.Name = "formatProgressBar";
			this.formatProgressBar.Size = new global::System.Drawing.Size(424, 20);
			this.formatProgressBar.TabIndex = 13;
			this.labelFormatStatusText.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelFormatStatusText.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.labelFormatStatusText.Location = new global::System.Drawing.Point(164, 178);
			this.labelFormatStatusText.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelFormatStatusText.Name = "labelFormatStatusText";
			this.labelFormatStatusText.Size = new global::System.Drawing.Size(428, 68);
			this.labelFormatStatusText.TabIndex = 11;
			this.labelFormatStatusText.Text = "status";
			this.labelFormatStatusText.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.backgroundFormatWorker.WorkerReportsProgress = true;
			this.backgroundFormatWorker.WorkerSupportsCancellation = true;
			this.backgroundFormatWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundFormatWorker_DoWork);
			this.backgroundFormatWorker.ProgressChanged += new global::System.ComponentModel.ProgressChangedEventHandler(this.backgroundFormatWorker_ProgressChanged);
			this.backgroundFormatWorker.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundFormatWorker_RunWorkerCompleted);
			this.button1.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Baskerville Old Face", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.Ivory;
			this.button1.Location = new global::System.Drawing.Point(573, 44);
			this.button1.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(131, 34);
			this.button1.TabIndex = 11;
			this.button1.Text = "Burn Media";
			this.button1.UseVisualStyleBackColor = false;
			this.button2.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Baskerville Old Face", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.Ivory;
			this.button2.Location = new global::System.Drawing.Point(712, 44);
			this.button2.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(131, 34);
			this.button2.TabIndex = 13;
			this.button2.Text = "Format Disk";
			this.button2.UseVisualStyleBackColor = false;
			this.pictureBox1.Location = new global::System.Drawing.Point(-1, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(858, 37);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(821, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(36, 36);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
			this.pictureBox3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new global::System.Drawing.Point(766, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(36, 36);
			this.pictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 16;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new global::System.EventHandler(this.pictureBox3_Click);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 22.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(92, 9);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(279, 46);
			this.label4.TabIndex = 17;
			this.label4.Text = "Disk Burner v1.0";
			this.pictureBox4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox4.Image");
			this.pictureBox4.Location = new global::System.Drawing.Point(12, 9);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(74, 57);
			this.pictureBox4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 18;
			this.pictureBox4.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ButtonHighlight;
			base.ClientSize = new global::System.Drawing.Size(855, 549);
			base.Controls.Add(this.pictureBox4);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.supportedMediaLabel);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.devicesComboBox);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			base.Name = "MainForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BurnMedia";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			base.Load += new global::System.EventHandler(this.MainForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPageBurn.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPageFormat.ResumeLayout(false);
			this.tabPageFormat.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000B RID: 11
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.ComboBox devicesComboBox;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label supportedMediaLabel;

		// Token: 0x0400000F RID: 15
		private global::System.ComponentModel.BackgroundWorker backgroundBurnWorker;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.OpenFileDialog openFileDialog;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Label labelTotalSize;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ProgressBar progressBarCapacity;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Button buttonFormat;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.TabPage tabPageBurn;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.CheckBox checkBoxEject;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.CheckBox checkBoxCloseMedia;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.TextBox textBoxLabel;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Button buttonRemoveFiles;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Button buttonAddFolders;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Button buttonAddFiles;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.ListBox listBoxFiles;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Button buttonBurn;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.TabPage tabPageFormat;

		// Token: 0x04000023 RID: 35
		private global::System.ComponentModel.BackgroundWorker backgroundFormatWorker;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label labelStatusText;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.ProgressBar statusProgressBar;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.CheckBox checkBoxEjectFormat;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.ProgressBar formatProgressBar;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label labelFormatStatusText;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.CheckBox checkBoxQuickFormat;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label labelMediaType;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Button buttonDetectMedia;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.ComboBox comboBoxVerification;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label labelVerification;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.PictureBox pictureBox4;
	}
}
