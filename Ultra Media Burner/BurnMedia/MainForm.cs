using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;
using IMAPI2.Interop;
using IMAPI2.MediaItem;

namespace BurnMedia
{
	// Token: 0x02000002 RID: 2
	public partial class MainForm : Form
	{
		// Token: 0x06000001 RID: 1
		public MainForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2
		private void MainForm_Load(object sender, EventArgs e)
		{
			MsftDiscMaster2 msftDiscMaster = null;
			try
			{
				msftDiscMaster = (MsftDiscMaster2)new MsftDiscMaster2Class();
				if (!msftDiscMaster.IsSupportedEnvironment)
				{
					return;
				}
				foreach (object obj in msftDiscMaster)
				{
					string text = (string)obj;
					MsftDiscRecorder2 msftDiscRecorder = (MsftDiscRecorder2)new MsftDiscRecorder2Class();
					msftDiscRecorder.InitializeDiscRecorder(text);
					this.devicesComboBox.Items.Add(msftDiscRecorder);
				}
				if (this.devicesComboBox.Items.Count > 0)
				{
					this.devicesComboBox.SelectedIndex = 0;
				}
			}
			catch (COMException ex)
			{
				MessageBox.Show(ex.Message, string.Format("Error:{0} - Please install IMAPI2", ex.ErrorCode), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			finally
			{
				if (msftDiscMaster != null)
				{
					Marshal.ReleaseComObject(msftDiscMaster);
				}
			}
			DateTime now = DateTime.Now;
			this.textBoxLabel.Text = string.Concat(new object[] { now.Year, "_", now.Month, "_", now.Day });
			this.labelStatusText.Text = string.Empty;
			this.labelFormatStatusText.Text = string.Empty;
			this.comboBoxVerification.SelectedIndex = 0;
			this.UpdateCapacity();
		}

		// Token: 0x06000003 RID: 3
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (object obj in this.devicesComboBox.Items)
			{
				MsftDiscRecorder2 msftDiscRecorder = (MsftDiscRecorder2)obj;
				if (msftDiscRecorder != null)
				{
					Marshal.ReleaseComObject(msftDiscRecorder);
				}
			}
		}

		// Token: 0x06000004 RID: 4
		private void devicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.devicesComboBox.SelectedIndex == -1)
			{
				return;
			}
			IDiscRecorder2 discRecorder = (IDiscRecorder2)this.devicesComboBox.Items[this.devicesComboBox.SelectedIndex];
			this.supportedMediaLabel.Text = string.Empty;
			IDiscFormat2Data discFormat2Data = null;
			try
			{
				discFormat2Data = (MsftDiscFormat2Data)new MsftDiscFormat2DataClass();
				if (!discFormat2Data.IsRecorderSupported(discRecorder))
				{
					MessageBox.Show("Recorder not supported", "BurnMedia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder();
					object[] supportedProfiles = discRecorder.SupportedProfiles;
					for (int i = 0; i < supportedProfiles.Length; i++)
					{
						string profileTypeString = MainForm.GetProfileTypeString((IMAPI_PROFILE_TYPE)supportedProfiles[i]);
						if (!string.IsNullOrEmpty(profileTypeString))
						{
							if (stringBuilder.Length > 0)
							{
								stringBuilder.Append(", ");
							}
							stringBuilder.Append(profileTypeString);
						}
					}
					this.supportedMediaLabel.Text = stringBuilder.ToString();
				}
			}
			catch (COMException)
			{
				this.supportedMediaLabel.Text = "Error getting supported media types";
			}
			finally
			{
				if (discFormat2Data != null)
				{
					Marshal.ReleaseComObject(discFormat2Data);
				}
			}
		}

		// Token: 0x06000005 RID: 5
		private static string GetMediaTypeString(IMAPI_MEDIA_PHYSICAL_TYPE mediaType)
		{
			switch (mediaType)
			{
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_CDROM:
				return "CD-ROM";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_CDR:
				return "CD-R";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_CDRW:
				return "CD-RW";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDROM:
				return "DVD ROM";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDRAM:
				return "DVD-RAM";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDPLUSR:
				return "DVD+R";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDPLUSRW:
				return "DVD+RW";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDPLUSR_DUALLAYER:
				return "DVD+R Dual Layer";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDDASHR:
				return "DVD-R";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDDASHRW:
				return "DVD-RW";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDDASHR_DUALLAYER:
				return "DVD-R Dual Layer";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DISK:
				return "random-access writes";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDPLUSRW_DUALLAYER:
				return "DVD+RW DL";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_HDDVDROM:
				return "HD DVD-ROM";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_HDDVDR:
				return "HD DVD-R";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_HDDVDRAM:
				return "HD DVD-RAM";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_BDROM:
				return "Blu-ray DVD (BD-ROM)";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_BDR:
				return "Blu-ray media";
			case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_BDRE:
				return "Blu-ray Rewritable media";
			default:
				return "Unknown Media Type";
			}
		}

		// Token: 0x06000006 RID: 6
		private static string GetProfileTypeString(IMAPI_PROFILE_TYPE profileType)
		{
			if (profileType <= IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_PLUS_RW_DUAL)
			{
				switch (profileType)
				{
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_CD_RECORDABLE:
					return "CD-R";
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_CD_REWRITABLE:
					return "CD-RW";
				case (IMAPI_PROFILE_TYPE)11:
				case (IMAPI_PROFILE_TYPE)12:
				case (IMAPI_PROFILE_TYPE)13:
				case (IMAPI_PROFILE_TYPE)14:
				case (IMAPI_PROFILE_TYPE)15:
				case (IMAPI_PROFILE_TYPE)23:
				case (IMAPI_PROFILE_TYPE)24:
				case (IMAPI_PROFILE_TYPE)25:
					break;
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVDROM:
					return "DVD ROM";
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_RECORDABLE:
					return "DVD-R";
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_RAM:
					return "DVD-RAM";
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_REWRITABLE:
					return "DVD-RW";
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_RW_SEQUENTIAL:
					return "DVD-RW Sequential";
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_R_DUAL_SEQUENTIAL:
					return "DVD-R DL Sequential";
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_R_DUAL_LAYER_JUMP:
					return "DVD-R Dual Layer";
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_PLUS_RW:
					return "DVD+RW";
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_PLUS_R:
					return "DVD+R";
				default:
					if (profileType == IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_PLUS_RW_DUAL)
					{
						return "DVD+RW DL";
					}
					break;
				}
			}
			else
			{
				if (profileType == IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_PLUS_R_DUAL)
				{
					return "DVD+R Dual Layer";
				}
				switch (profileType)
				{
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_BD_ROM:
					return "Blu-ray DVD (BD-ROM)";
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_BD_R_SEQUENTIAL:
					return "Blu-ray media Sequential";
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_BD_R_RANDOM_RECORDING:
					return "Blu-ray media";
				case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_BD_REWRITABLE:
					return "Blu-ray Rewritable media";
				default:
					switch (profileType)
					{
					case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_HD_DVD_ROM:
						return "HD DVD-ROM";
					case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_HD_DVD_RECORDABLE:
						return "HD DVD-R";
					case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_HD_DVD_RAM:
						return "HD DVD-RAM";
					}
					break;
				}
			}
			return string.Empty;
		}

		// Token: 0x06000007 RID: 7
		private void devicesComboBox_Format(object sender, ListControlConvertEventArgs e)
		{
			IDiscRecorder2 discRecorder = (IDiscRecorder2)e.ListItem;
			string text = string.Empty;
			string text2 = (string)discRecorder.VolumePathNames.GetValue(0);
			foreach (string text3 in discRecorder.VolumePathNames)
			{
				if (!string.IsNullOrEmpty(text))
				{
					text += ",";
				}
				text += text2;
			}
			e.Value = string.Format("{0} [{1}]", text, discRecorder.ProductId);
		}

		// Token: 0x06000008 RID: 8
		private void buttonDetectMedia_Click(object sender, EventArgs e)
		{
			if (this.devicesComboBox.SelectedIndex == -1)
			{
				return;
			}
			IDiscRecorder2 discRecorder = (IDiscRecorder2)this.devicesComboBox.Items[this.devicesComboBox.SelectedIndex];
			MsftFileSystemImage msftFileSystemImage = null;
			MsftDiscFormat2Data msftDiscFormat2Data = null;
			try
			{
				msftDiscFormat2Data = (MsftDiscFormat2Data)new MsftDiscFormat2DataClass();
				if (!msftDiscFormat2Data.IsCurrentMediaSupported(discRecorder))
				{
					this.labelMediaType.Text = "Media not supported!";
					this._totalDiscSize = 0L;
					return;
				}
				msftDiscFormat2Data.Recorder = discRecorder;
				IMAPI_MEDIA_PHYSICAL_TYPE currentPhysicalMediaType = msftDiscFormat2Data.CurrentPhysicalMediaType;
				this.labelMediaType.Text = MainForm.GetMediaTypeString(currentPhysicalMediaType);
				msftFileSystemImage = (MsftFileSystemImage)new MsftFileSystemImageClass();
				msftFileSystemImage.ChooseImageDefaultsForMediaType(currentPhysicalMediaType);
				if (!msftDiscFormat2Data.MediaHeuristicallyBlank)
				{
					msftFileSystemImage.MultisessionInterfaces = msftDiscFormat2Data.MultisessionInterfaces;
					msftFileSystemImage.ImportFileSystem();
				}
				long num = (long)msftFileSystemImage.FreeMediaBlocks;
				this._totalDiscSize = 2048L * num;
			}
			catch (COMException ex)
			{
				MessageBox.Show(this, ex.Message, "Detect Media Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				if (msftDiscFormat2Data != null)
				{
					Marshal.ReleaseComObject(msftDiscFormat2Data);
				}
				if (msftFileSystemImage != null)
				{
					Marshal.ReleaseComObject(msftFileSystemImage);
				}
			}
			this.UpdateCapacity();
		}

		// Token: 0x06000009 RID: 9
		private void UpdateCapacity()
		{
			if (this._totalDiscSize == 0L)
			{
				this.labelTotalSize.Text = "0MB";
				return;
			}
			this.labelTotalSize.Text = ((this._totalDiscSize < 1000000000L) ? string.Format("{0}MB", this._totalDiscSize / 1000000L) : string.Format("{0:F2}GB", (double)((float)this._totalDiscSize) / 1000000000.0));
			long num = 0L;
			foreach (object obj in this.listBoxFiles.Items)
			{
				IMediaItem mediaItem = (IMediaItem)obj;
				num += mediaItem.SizeOnDisc;
			}
			if (num == 0L)
			{
				this.progressBarCapacity.Value = 0;
				this.progressBarCapacity.ForeColor = SystemColors.Highlight;
				return;
			}
			int num2 = (int)(num * 100L / this._totalDiscSize);
			if (num2 > 100)
			{
				this.progressBarCapacity.Value = 100;
				this.progressBarCapacity.ForeColor = Color.Red;
				return;
			}
			this.progressBarCapacity.Value = num2;
			this.progressBarCapacity.ForeColor = SystemColors.Highlight;
		}

		// Token: 0x0600000A RID: 10
		private void buttonBurn_Click(object sender, EventArgs e)
		{
			if (this.devicesComboBox.SelectedIndex == -1)
			{
				return;
			}
			if (this._isBurning)
			{
				this.buttonBurn.Enabled = false;
				this.backgroundBurnWorker.CancelAsync();
				return;
			}
			this._isBurning = true;
			this._closeMedia = this.checkBoxCloseMedia.Checked;
			this._ejectMedia = this.checkBoxEject.Checked;
			this.EnableBurnUI(false);
			IDiscRecorder2 discRecorder = (IDiscRecorder2)this.devicesComboBox.Items[this.devicesComboBox.SelectedIndex];
			this._burnData.uniqueRecorderId = discRecorder.ActiveDiscRecorder;
			this.backgroundBurnWorker.RunWorkerAsync(this._burnData);
		}

		// Token: 0x0600000B RID: 11
		private void backgroundBurnWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			MsftDiscRecorder2 msftDiscRecorder = null;
			MsftDiscFormat2Data msftDiscFormat2Data = null;
			try
			{
				msftDiscRecorder = (MsftDiscRecorder2)new MsftDiscRecorder2Class();
				BurnData burnData = (BurnData)e.Argument;
				msftDiscRecorder.InitializeDiscRecorder(burnData.uniqueRecorderId);
				MsftDiscFormat2Data msftDiscFormat2Data2 = (MsftDiscFormat2Data)new MsftDiscFormat2DataClass();
				msftDiscFormat2Data2.Recorder = msftDiscRecorder;
				msftDiscFormat2Data2.ClientName = "BurnMedia";
				msftDiscFormat2Data2.ForceMediaToBeClosed = this._closeMedia;
				msftDiscFormat2Data = msftDiscFormat2Data2;
				((IBurnVerification)msftDiscFormat2Data).BurnVerificationLevel = this._verificationLevel;
				object[] array = null;
				if (!msftDiscFormat2Data.MediaHeuristicallyBlank)
				{
					array = msftDiscFormat2Data.MultisessionInterfaces;
				}
				IStream stream;
				if (!this.CreateMediaFileSystem(msftDiscRecorder, array, out stream))
				{
					e.Result = -1;
				}
				else
				{
					msftDiscFormat2Data.Update += this.discFormatData_Update;
					try
					{
						msftDiscFormat2Data.Write(stream);
						e.Result = 0;
					}
					catch (COMException ex)
					{
						e.Result = ex.ErrorCode;
						MessageBox.Show(ex.Message, "IDiscFormat2Data.Write failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					finally
					{
						if (stream != null)
						{
							Marshal.FinalReleaseComObject(stream);
						}
					}
					msftDiscFormat2Data.Update -= this.discFormatData_Update;
					if (this._ejectMedia)
					{
						msftDiscRecorder.EjectMedia();
					}
				}
			}
			catch (COMException ex2)
			{
				MessageBox.Show(ex2.Message);
				e.Result = ex2.ErrorCode;
			}
			finally
			{
				if (msftDiscRecorder != null)
				{
					Marshal.ReleaseComObject(msftDiscRecorder);
				}
				if (msftDiscFormat2Data != null)
				{
					Marshal.ReleaseComObject(msftDiscFormat2Data);
				}
			}
		}

		// Token: 0x0600000C RID: 12
		private void discFormatData_Update([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, [MarshalAs(UnmanagedType.IDispatch)] [In] object progress)
		{
			if (this.backgroundBurnWorker.CancellationPending)
			{
				((IDiscFormat2Data)sender).CancelWrite();
				return;
			}
			IDiscFormat2DataEventArgs discFormat2DataEventArgs = (IDiscFormat2DataEventArgs)progress;
			this._burnData.task = BURN_MEDIA_TASK.BURN_MEDIA_TASK_WRITING;
			this._burnData.elapsedTime = (long)discFormat2DataEventArgs.ElapsedTime;
			this._burnData.remainingTime = (long)discFormat2DataEventArgs.RemainingTime;
			this._burnData.totalTime = (long)discFormat2DataEventArgs.TotalTime;
			this._burnData.currentAction = discFormat2DataEventArgs.CurrentAction;
			this._burnData.startLba = (long)discFormat2DataEventArgs.StartLba;
			this._burnData.sectorCount = (long)discFormat2DataEventArgs.SectorCount;
			this._burnData.lastReadLba = (long)discFormat2DataEventArgs.LastReadLba;
			this._burnData.lastWrittenLba = (long)discFormat2DataEventArgs.LastWrittenLba;
			this._burnData.totalSystemBuffer = (long)discFormat2DataEventArgs.TotalSystemBuffer;
			this._burnData.usedSystemBuffer = (long)discFormat2DataEventArgs.UsedSystemBuffer;
			this._burnData.freeSystemBuffer = (long)discFormat2DataEventArgs.FreeSystemBuffer;
			this.backgroundBurnWorker.ReportProgress(0, this._burnData);
		}

		// Token: 0x0600000D RID: 13
		private void backgroundBurnWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.labelStatusText.Text = (((int)e.Result == 0) ? "Finished Burning Disc!" : "Error Burning Disc!");
			this.statusProgressBar.Value = 0;
			this._isBurning = false;
			this.EnableBurnUI(true);
			this.buttonBurn.Enabled = true;
		}

		// Token: 0x0600000E RID: 14
		private void EnableBurnUI(bool enable)
		{
			this.buttonBurn.Text = (enable ? "&Burn" : "&Cancel");
			this.buttonDetectMedia.Enabled = enable;
			this.devicesComboBox.Enabled = enable;
			this.listBoxFiles.Enabled = enable;
			this.buttonAddFiles.Enabled = enable;
			this.buttonAddFolders.Enabled = enable;
			this.buttonRemoveFiles.Enabled = enable;
			this.checkBoxEject.Enabled = enable;
			this.checkBoxCloseMedia.Enabled = enable;
			this.textBoxLabel.Enabled = enable;
			this.comboBoxVerification.Enabled = enable;
		}

		// Token: 0x0600000F RID: 15
		private void backgroundBurnWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			BurnData burnData = (BurnData)e.UserState;
			if (burnData.task == BURN_MEDIA_TASK.BURN_MEDIA_TASK_FILE_SYSTEM)
			{
				this.labelStatusText.Text = burnData.statusMessage;
				return;
			}
			if (burnData.task != BURN_MEDIA_TASK.BURN_MEDIA_TASK_WRITING)
			{
				return;
			}
			switch (burnData.currentAction)
			{
			case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_VALIDATING_MEDIA:
				this.labelStatusText.Text = "Validating current media...";
				return;
			case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_FORMATTING_MEDIA:
				this.labelStatusText.Text = "Formatting media...";
				return;
			case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_INITIALIZING_HARDWARE:
				this.labelStatusText.Text = "Initializing hardware...";
				return;
			case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_CALIBRATING_POWER:
				this.labelStatusText.Text = "Optimizing laser intensity...";
				return;
			case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_WRITING_DATA:
			{
				long num = burnData.lastWrittenLba - burnData.startLba;
				if (num > 0L && burnData.sectorCount > 0L)
				{
					int num2 = (int)(100L * num / burnData.sectorCount);
					this.labelStatusText.Text = string.Format("Progress: {0}%", num2);
					this.statusProgressBar.Value = num2;
					return;
				}
				this.labelStatusText.Text = "Progress 0%";
				this.statusProgressBar.Value = 0;
				return;
			}
			case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_FINALIZATION:
				this.labelStatusText.Text = "Finalizing writing...";
				return;
			case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_COMPLETED:
				this.labelStatusText.Text = "Completed!";
				return;
			case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_VERIFYING:
				this.labelStatusText.Text = "Verifying";
				return;
			default:
				return;
			}
		}

		// Token: 0x06000010 RID: 16
		private void EnableBurnButton()
		{
			this.buttonBurn.Enabled = this.listBoxFiles.Items.Count > 0;
		}

		// Token: 0x06000011 RID: 17
		private bool CreateMediaFileSystem(IDiscRecorder2 discRecorder, object[] multisessionInterfaces, out IStream dataStream)
		{
			MsftFileSystemImage msftFileSystemImage = null;
			try
			{
				msftFileSystemImage = (MsftFileSystemImage)new MsftFileSystemImageClass();
				msftFileSystemImage.ChooseImageDefaults(discRecorder);
				msftFileSystemImage.FileSystemsToCreate = FsiFileSystems.FsiFileSystemISO9660 | FsiFileSystems.FsiFileSystemJoliet;
				msftFileSystemImage.VolumeName = this.textBoxLabel.Text;
				msftFileSystemImage.Update += this.fileSystemImage_Update;
				if (multisessionInterfaces != null)
				{
					msftFileSystemImage.MultisessionInterfaces = multisessionInterfaces;
					msftFileSystemImage.ImportFileSystem();
				}
				IFsiDirectoryItem root = msftFileSystemImage.Root;
				foreach (object obj in this.listBoxFiles.Items)
				{
					IMediaItem mediaItem = (IMediaItem)obj;
					if (this.backgroundBurnWorker.CancellationPending)
					{
						break;
					}
					mediaItem.AddToFileSystem(root);
				}
				msftFileSystemImage.Update -= this.fileSystemImage_Update;
				if (this.backgroundBurnWorker.CancellationPending)
				{
					dataStream = null;
					return false;
				}
				dataStream = msftFileSystemImage.CreateResultImage().ImageStream;
			}
			catch (COMException ex)
			{
				MessageBox.Show(this, ex.Message, "Create File System Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				dataStream = null;
				return false;
			}
			finally
			{
				if (msftFileSystemImage != null)
				{
					Marshal.ReleaseComObject(msftFileSystemImage);
				}
			}
			return true;
		}

		// Token: 0x06000012 RID: 18
		private void fileSystemImage_Update([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, [MarshalAs(UnmanagedType.BStr)] [In] string currentFile, [In] int copiedSectors, [In] int totalSectors)
		{
			int num = 0;
			if (copiedSectors > 0 && totalSectors > 0)
			{
				num = copiedSectors * 100 / totalSectors;
			}
			if (!string.IsNullOrEmpty(currentFile))
			{
				FileInfo fileInfo = new FileInfo(currentFile);
				this._burnData.statusMessage = "Adding \"" + fileInfo.Name + "\" to image...";
				this._burnData.task = BURN_MEDIA_TASK.BURN_MEDIA_TASK_FILE_SYSTEM;
				this.backgroundBurnWorker.ReportProgress(num, this._burnData);
			}
		}

		// Token: 0x06000013 RID: 19
		private void buttonAddFiles_Click(object sender, EventArgs e)
		{
			if (this.openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				FileItem fileItem = new FileItem(this.openFileDialog.FileName);
				this.listBoxFiles.Items.Add(fileItem);
				this.UpdateCapacity();
				this.EnableBurnButton();
			}
		}

		// Token: 0x06000014 RID: 20
		private void buttonAddFolders_Click(object sender, EventArgs e)
		{
			if (this.folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
			{
				DirectoryItem directoryItem = new DirectoryItem(this.folderBrowserDialog.SelectedPath);
				this.listBoxFiles.Items.Add(directoryItem);
				this.UpdateCapacity();
				this.EnableBurnButton();
			}
		}

		// Token: 0x06000015 RID: 21
		private void buttonRemoveFiles_Click(object sender, EventArgs e)
		{
			IMediaItem mediaItem = (IMediaItem)this.listBoxFiles.SelectedItem;
			if (mediaItem == null)
			{
				return;
			}
			string text = "Are you sure you want to remove \"";
			IMediaItem mediaItem2 = mediaItem;
			if (MessageBox.Show(text + ((mediaItem2 != null) ? mediaItem2.ToString() : null) + "\"?", "Remove item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.listBoxFiles.Items.Remove(mediaItem);
				this.EnableBurnButton();
				this.UpdateCapacity();
			}
		}

		// Token: 0x06000016 RID: 22
		private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.buttonRemoveFiles.Enabled = this.listBoxFiles.SelectedIndex != -1;
		}

		// Token: 0x06000017 RID: 23
		private void listBoxFiles_DrawItem(object sender, DrawItemEventArgs e)
		{
			IMediaItem mediaItem = (IMediaItem)this.listBoxFiles.Items[e.Index];
			if (mediaItem == null)
			{
				return;
			}
			e.DrawBackground();
			if ((e.State & DrawItemState.Focus) != DrawItemState.None)
			{
				e.DrawFocusRectangle();
			}
			if (mediaItem.FileIconImage != null)
			{
				e.Graphics.DrawImage(mediaItem.FileIconImage, new Rectangle(4, e.Bounds.Y + 4, 16, 16));
			}
			RectangleF rectangleF = new RectangleF((float)(e.Bounds.X + 24), (float)e.Bounds.Y, (float)(e.Bounds.Width - 24), (float)e.Bounds.Height);
			Font font = new Font(FontFamily.GenericSansSerif, 11f);
			StringFormat stringFormat = new StringFormat
			{
				LineAlignment = StringAlignment.Center,
				Alignment = StringAlignment.Near,
				Trimming = StringTrimming.EllipsisCharacter
			};
			e.Graphics.DrawString(mediaItem.ToString(), font, new SolidBrush(e.ForeColor), rectangleF, stringFormat);
		}

		// Token: 0x06000018 RID: 24
		private void buttonFormat_Click(object sender, EventArgs e)
		{
			if (this.devicesComboBox.SelectedIndex == -1)
			{
				return;
			}
			this._isFormatting = true;
			this.EnableFormatUI(false);
			IDiscRecorder2 discRecorder = (IDiscRecorder2)this.devicesComboBox.Items[this.devicesComboBox.SelectedIndex];
			this.backgroundFormatWorker.RunWorkerAsync(discRecorder.ActiveDiscRecorder);
		}

		// Token: 0x06000019 RID: 25
		private void EnableFormatUI(bool enable)
		{
			this.buttonFormat.Enabled = enable;
			this.checkBoxEjectFormat.Enabled = enable;
			this.checkBoxQuickFormat.Enabled = enable;
		}

		// Token: 0x0600001A RID: 26
		private void backgroundFormatWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			MsftDiscRecorder2 msftDiscRecorder = null;
			MsftDiscFormat2Erase msftDiscFormat2Erase = null;
			try
			{
				msftDiscRecorder = (MsftDiscRecorder2)new MsftDiscRecorder2Class();
				string text = (string)e.Argument;
				msftDiscRecorder.InitializeDiscRecorder(text);
				MsftDiscFormat2Erase msftDiscFormat2Erase2 = (MsftDiscFormat2Erase)new MsftDiscFormat2EraseClass();
				msftDiscFormat2Erase2.Recorder = msftDiscRecorder;
				msftDiscFormat2Erase2.ClientName = "BurnMedia";
				msftDiscFormat2Erase2.FullErase = !this.checkBoxQuickFormat.Checked;
				msftDiscFormat2Erase = msftDiscFormat2Erase2;
				msftDiscFormat2Erase.Update += this.discFormatErase_Update;
				try
				{
					msftDiscFormat2Erase.EraseMedia();
					e.Result = 0;
				}
				catch (COMException ex)
				{
					e.Result = ex.ErrorCode;
					MessageBox.Show(ex.Message, "IDiscFormat2.EraseMedia failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				msftDiscFormat2Erase.Update -= this.discFormatErase_Update;
				if (this.checkBoxEjectFormat.Checked)
				{
					msftDiscRecorder.EjectMedia();
				}
			}
			catch (COMException ex2)
			{
				MessageBox.Show(ex2.Message);
			}
			finally
			{
				if (msftDiscRecorder != null)
				{
					Marshal.ReleaseComObject(msftDiscRecorder);
				}
				if (msftDiscFormat2Erase != null)
				{
					Marshal.ReleaseComObject(msftDiscFormat2Erase);
				}
			}
		}

		// Token: 0x0600001B RID: 27
		private void discFormatErase_Update([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, int elapsedSeconds, int estimatedTotalSeconds)
		{
			int num = elapsedSeconds * 100 / estimatedTotalSeconds;
			this.backgroundFormatWorker.ReportProgress(num);
		}

		// Token: 0x0600001C RID: 28
		private void backgroundFormatWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.labelFormatStatusText.Text = string.Format("Formatting {0}%...", e.ProgressPercentage);
			this.formatProgressBar.Value = e.ProgressPercentage;
		}

		// Token: 0x0600001D RID: 29
		private void backgroundFormatWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.labelFormatStatusText.Text = (((int)e.Result == 0) ? "Finished Formatting Disc!" : "Error Formatting Disc!");
			this.formatProgressBar.Value = 0;
			this._isFormatting = false;
			this.EnableFormatUI(true);
		}

		// Token: 0x0600001E RID: 30
		private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
		{
			if (this._isBurning || this._isFormatting)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x0600001F RID: 31
		private void comboBoxVerification_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._verificationLevel = (IMAPI_BURN_VERIFICATION_LEVEL)this.comboBoxVerification.SelectedIndex;
		}

		// Token: 0x06000020 RID: 32
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				MainForm.ReleaseCapture();
				MainForm.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000021 RID: 33
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000022 RID: 34
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000023 RID: 35
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you really want to exit?", "Penguin OS Disk Burner", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				base.Close();
			}
		}

		// Token: 0x06000024 RID: 36
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x04000001 RID: 1
		private const string ClientName = "BurnMedia";

		// Token: 0x04000002 RID: 2
		private long _totalDiscSize;

		// Token: 0x04000003 RID: 3
		private bool _isBurning;

		// Token: 0x04000004 RID: 4
		private bool _isFormatting;

		// Token: 0x04000005 RID: 5
		private IMAPI_BURN_VERIFICATION_LEVEL _verificationLevel;

		// Token: 0x04000006 RID: 6
		private bool _closeMedia;

		// Token: 0x04000007 RID: 7
		private bool _ejectMedia;

		// Token: 0x04000008 RID: 8
		private BurnData _burnData = new BurnData();

		// Token: 0x04000009 RID: 9
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400000A RID: 10
		public const int HT_CAPTION = 2;
	}
}
