using UnityEngine;

namespace CGTK.Utilities.Extensions
{
	namespace Tweening
	{
		public static partial class Tweening
		{
			public enum UpdateType
			{
				Update,
				FixedUpdate
			}

			private static readonly YieldInstruction WaitForFixedUpdate = new WaitForFixedUpdate();
		}
	}
}