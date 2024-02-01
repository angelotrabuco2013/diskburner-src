using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using IMAPI2.Interop;

namespace IMAPI2.MediaItem
{
	// Token: 0x02000008 RID: 8
	internal class DirectoryItem : IMediaItem
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00005650 File Offset: 0x00003850
		public DirectoryItem(string directoryPath)
		{
			if (!Directory.Exists(directoryPath))
			{
				throw new FileNotFoundException("The directory added to DirectoryItem was not found!", directoryPath);
			}
			this.m_directoryPath = directoryPath;
			FileInfo fileInfo = new FileInfo(this.m_directoryPath);
			this.displayName = fileInfo.Name;
			foreach (string text in Directory.GetFiles(this.m_directoryPath))
			{
				this.mediaItems.Add(new FileItem(text));
			}
			foreach (string text2 in Directory.GetDirectories(this.m_directoryPath))
			{
				this.mediaItems.Add(new DirectoryItem(text2));
			}
			SHFILEINFO shfileinfo = default(SHFILEINFO);
			Win32.SHGetFileInfo(this.m_directoryPath, 0U, ref shfileinfo, (uint)Marshal.SizeOf(shfileinfo), 257U);
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

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00005780 File Offset: 0x00003980
		public string Path
		{
			get
			{
				return this.m_directoryPath;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005788 File Offset: 0x00003988
		public override string ToString()
		{
			return this.displayName;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00005790 File Offset: 0x00003990
		public long SizeOnDisc
		{
			get
			{
				long num = 0L;
				foreach (IMediaItem mediaItem in this.mediaItems)
				{
					num += mediaItem.SizeOnDisc;
				}
				return num;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000057EC File Offset: 0x000039EC
		public Image FileIconImage
		{
			get
			{
				return this.fileIconImage;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000057F4 File Offset: 0x000039F4
		public bool AddToFileSystem(IFsiDirectoryItem rootItem)
		{
			bool flag;
			try
			{
				rootItem.AddTree(this.m_directoryPath, true);
				flag = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error adding folder", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				flag = false;
			}
			return flag;
		}

		// Token: 0x0400003C RID: 60
		private List<IMediaItem> mediaItems = new List<IMediaItem>();

		// Token: 0x0400003D RID: 61
		private string m_directoryPath;

		// Token: 0x0400003E RID: 62
		private string displayName;

		// Token: 0x0400003F RID: 63
		private Image fileIconImage;
	}
}
