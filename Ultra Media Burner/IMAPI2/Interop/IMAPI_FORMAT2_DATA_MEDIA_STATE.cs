﻿using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000016 RID: 22
	public enum IMAPI_FORMAT2_DATA_MEDIA_STATE
	{
		// Token: 0x040000BB RID: 187
		[TypeLibVar(64)]
		IMAPI_FORMAT2_DATA_MEDIA_STATE_UNKNOWN,
		// Token: 0x040000BC RID: 188
		IMAPI_FORMAT2_DATA_MEDIA_STATE_OVERWRITE_ONLY,
		// Token: 0x040000BD RID: 189
		IMAPI_FORMAT2_DATA_MEDIA_STATE_RANDOMLY_WRITABLE = 1,
		// Token: 0x040000BE RID: 190
		IMAPI_FORMAT2_DATA_MEDIA_STATE_BLANK,
		// Token: 0x040000BF RID: 191
		IMAPI_FORMAT2_DATA_MEDIA_STATE_APPENDABLE = 4,
		// Token: 0x040000C0 RID: 192
		IMAPI_FORMAT2_DATA_MEDIA_STATE_FINAL_SESSION = 8,
		// Token: 0x040000C1 RID: 193
		IMAPI_FORMAT2_DATA_MEDIA_STATE_INFORMATIONAL_MASK = 15,
		// Token: 0x040000C2 RID: 194
		IMAPI_FORMAT2_DATA_MEDIA_STATE_DAMAGED = 1024,
		// Token: 0x040000C3 RID: 195
		IMAPI_FORMAT2_DATA_MEDIA_STATE_ERASE_REQUIRED = 2048,
		// Token: 0x040000C4 RID: 196
		IMAPI_FORMAT2_DATA_MEDIA_STATE_NON_EMPTY_SESSION = 4096,
		// Token: 0x040000C5 RID: 197
		IMAPI_FORMAT2_DATA_MEDIA_STATE_WRITE_PROTECTED = 8192,
		// Token: 0x040000C6 RID: 198
		IMAPI_FORMAT2_DATA_MEDIA_STATE_FINALIZED = 16384,
		// Token: 0x040000C7 RID: 199
		IMAPI_FORMAT2_DATA_MEDIA_STATE_UNSUPPORTED_MEDIA = 32768,
		// Token: 0x040000C8 RID: 200
		IMAPI_FORMAT2_DATA_MEDIA_STATE_UNSUPPORTED_MASK = 64512
	}
}