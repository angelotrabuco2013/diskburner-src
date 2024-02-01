using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using IMAPI2.Interop;

namespace IMAPI2.MediaItem
{
	// Token: 0x02000009 RID: 9
	internal class FileItem : IMediaItem
	{
		// Token: 0x0600003B RID: 59 RVA: 0x0000583C File Offset: 0x00003A3C
		public FileItem(string path)
		{
			if (!File.Exists(path))
			{
				throw new FileNotFoundException("The file added to FileItem was not found!", path);
			}
			this.filePath = path;
			FileInfo fileInfo = new FileInfo(this.filePath);
			this.displayName = fileInfo.Name;
			this.m_fileLength = fileInfo.Length;
			SHFILEINFO shfileinfo = default(SHFILEINFO);
			Win32.SHGetFileInfo(this.filePath, 0U, ref shfileinfo, (uint)Marshal.SizeOf(shfileinfo), 257U);
			IconConverter iconConverter = new IconConverter();
			Icon icon = Icon.FromHandle(shfileinfo.hIcon);
			try
			{
				this.fileIconImage = (Image)iconConverter.ConvertTo(icon, typeof(Image));
			}
			catch (NotSupportedException)
			{
			}
			Win32.DestroyIcon(shfileinfo.hIcon);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00005904 File Offset: 0x00003B04
		public long SizeOnDisc
		{
			get
			{
				if (this.m_fileLength > 0L)
				{
					return (this.m_fileLength / 2048L + 1L) * 2048L;
				}
				return 0L;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000592A File Offset: 0x00003B2A
		public string Path
		{
			get
			{
				return this.filePath;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00005932 File Offset: 0x00003B32
		public Image FileIconImage
		{
			get
			{
				return this.fileIconImage;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000593A File Offset: 0x00003B3A
		public override string ToString()
		{
			return this.displayName;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005944 File Offset: 0x00003B44
		public bool AddToFileSystem(IFsiDirectoryItem rootItem)
		{
			IStream stream = null;
			try
			{
				Win32.SHCreateStreamOnFile(this.filePath, 32U, ref stream);
				if (stream != null)
				{
					rootItem.AddFile(this.displayName, stream);
					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error adding file", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			finally
			{
				if (stream != null)
				{
					Marshal.FinalReleaseComObject(stream);
				}
			}
			return false;
		}

		// Token: 0x04000040 RID: 64
		private const long SECTOR_SIZE = 2048L;

		// Token: 0x04000041 RID: 65
		private long m_fileLength;

		// Token: 0x04000042 RID: 66
		private string filePath;

		// Token: 0x04000043 RID: 67
		private Image fileIconImage;

		// Token: 0x04000044 RID: 68
		private string displayName;
	}
}
