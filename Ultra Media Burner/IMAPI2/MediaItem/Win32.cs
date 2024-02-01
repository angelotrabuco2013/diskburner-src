using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace IMAPI2.MediaItem
{
	// Token: 0x0200000C RID: 12
	internal class Win32
	{
		// Token: 0x06000045 RID: 69
		[DllImport("shell32.dll")]
		public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

		// Token: 0x06000046 RID: 70
		[DllImport("user32.dll")]
		public static extern bool DestroyIcon(IntPtr handle);

		// Token: 0x06000047 RID: 71
		[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, EntryPoint = "SHCreateStreamOnFileW", ExactSpelling = true, PreserveSig = false)]
		public static extern void SHCreateStreamOnFile(string fileName, uint mode, ref IStream stream);

		// Token: 0x0400004A RID: 74
		public const uint SHGFI_ICON = 256U;

		// Token: 0x0400004B RID: 75
		public const uint SHGFI_LARGEICON = 0U;

		// Token: 0x0400004C RID: 76
		public const uint SHGFI_SMALLICON = 1U;

		// Token: 0x0400004D RID: 77
		public const uint FILE_ATTRIBUTE_NORMAL = 128U;

		// Token: 0x0400004E RID: 78
		public const uint STGM_DELETEONRELEASE = 67108864U;

		// Token: 0x0400004F RID: 79
		public const uint STGM_SHARE_DENY_WRITE = 32U;

		// Token: 0x04000050 RID: 80
		public const uint STGM_SHARE_DENY_NONE = 64U;

		// Token: 0x04000051 RID: 81
		public const uint STGM_READ = 0U;
	}
}
