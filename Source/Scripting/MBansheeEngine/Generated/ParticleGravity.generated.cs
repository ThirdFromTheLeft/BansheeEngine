using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BansheeEngine
{
	/** @addtogroup Particles
	 *  @{
	 */

	/// <summary>Applies gravity to the particles.</summary>
	public partial class ParticleGravity : ParticleEvolver
	{
		private ParticleGravity(bool __dummy0) { }

		/// <summary>Creates a new particle gravity evolver.</summary>
		public ParticleGravity(ParticleGravityOptions desc)
		{
			Internal_create(this, ref desc);
		}

		/// <summary>Creates a new particle gravity evolver.</summary>
		public ParticleGravity()
		{
			Internal_create0(this);
		}

		/// <summary>Options describing the evolver.</summary>
		public ParticleGravityOptions Options
		{
			get
			{
				ParticleGravityOptions temp;
				Internal_getOptions(mCachedPtr, out temp);
				return temp;
			}
			set { Internal_setOptions(mCachedPtr, ref value); }
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setOptions(IntPtr thisPtr, ref ParticleGravityOptions options);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_getOptions(IntPtr thisPtr, out ParticleGravityOptions __output);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_create(ParticleGravity managedInstance, ref ParticleGravityOptions desc);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_create0(ParticleGravity managedInstance);
	}

	/** @} */
}
