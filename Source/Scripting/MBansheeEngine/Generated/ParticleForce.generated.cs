using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BansheeEngine
{
	/** @addtogroup Particles
	 *  @{
	 */

	/// <summary>Applies an arbitrary force to the particles.</summary>
	public partial class ParticleForce : ParticleEvolver
	{
		private ParticleForce(bool __dummy0) { }

		/// <summary>Creates a new particle force evolver.</summary>
		public ParticleForce(ParticleForceOptions desc)
		{
			Internal_create(this, ref desc);
		}

		/// <summary>Creates a new particle force evolver.</summary>
		public ParticleForce()
		{
			Internal_create0(this);
		}

		/// <summary>Options describing the evolver.</summary>
		public ParticleForceOptions Options
		{
			get
			{
				ParticleForceOptions temp;
				Internal_getOptions(mCachedPtr, out temp);
				return temp;
			}
			set { Internal_setOptions(mCachedPtr, ref value); }
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setOptions(IntPtr thisPtr, ref ParticleForceOptions options);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_getOptions(IntPtr thisPtr, out ParticleForceOptions __output);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_create(ParticleForce managedInstance, ref ParticleForceOptions desc);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_create0(ParticleForce managedInstance);
	}

	/** @} */
}
