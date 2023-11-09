
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace myro
{
	[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
	public class TeleportPlayer : UdonSharpBehaviour
	{
		public Transform Location;

		public void Teleport()
		{
			Networking.LocalPlayer.TeleportTo(Location.position, Location.rotation);
			Then();
		}

		public virtual void Then()
		{

		}
	}
}