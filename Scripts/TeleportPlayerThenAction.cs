
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace myro
{
	public class TeleportPlayerThenAction : TeleportPlayer
	{
		public UdonBehaviour UdonBehaviourInstance;
		public string EventString;

		public override void Then()
		{
			UdonBehaviourInstance.SendCustomEvent(EventString);
		}
	}
}
