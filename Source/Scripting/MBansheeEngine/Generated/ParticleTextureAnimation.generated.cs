using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BansheeEngine
{
	/** @addtogroup Particles
	 *  @{
	 */

	/// <summary>
	/// Provides functionality for particle texture animation. Uses the sprite texture assigned to the particle's material to 
	/// determine animation properties.
	/// </summary>
	public partial class ParticleTextureAnimation : ParticleEvolver
	{
		private ParticleTextureAnimation(bool __dummy0) { }

		/// <summary>Creates a new particle texture animation evolver.</summary>
		public ParticleTextureAnimation(ParticleTextureAnimationOptions desc)
		{
			Internal_create(this, ref desc);
		}

		/// <summary>Creates a new particle texture animation evolver.</summary>
		public ParticleTextureAnimation()
		{
			Internal_create0(this);
		}

		/// <summary>Options describing the evolver.</summary>
		public ParticleTextureAnimationOptions Options
		{
			get
			{
				ParticleTextureAnimationOptions temp;
				Internal_getOptions(mCachedPtr, out temp);
				return temp;
			}
			set { Internal_setOptions(mCachedPtr, ref value); }
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_setOptions(IntPtr thisPtr, ref ParticleTextureAnimationOptions options);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_getOptions(IntPtr thisPtr, out ParticleTextureAnimationOptions __output);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_create(ParticleTextureAnimation managedInstance, ref ParticleTextureAnimationOptions desc);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_create0(ParticleTextureAnimation managedInstance);
	}

	/** @} */
}
