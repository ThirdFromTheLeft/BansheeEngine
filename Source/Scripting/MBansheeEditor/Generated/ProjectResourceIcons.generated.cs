using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BansheeEngine;

namespace BansheeEditor
{
	/// <summary>Different icon sizes for project resource preview icons.</summary>
	[StructLayout(LayoutKind.Sequential), SerializeObject]
	public partial struct ProjectResourceIcons
	{
		public RRef<Texture> icon16;
		public RRef<Texture> icon32;
		public RRef<Texture> icon48;
		public RRef<Texture> icon64;
		public RRef<Texture> icon96;
		public RRef<Texture> icon128;
		public RRef<Texture> icon192;
		public RRef<Texture> icon256;
	}
}
