
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace myro
{
	[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
	public class HUDAndroidTeleporter : UdonSharpBehaviour
	{
		public GameObject Menu;
		public GameObject Canvas;

		void Start()
		{
			Canvas.SetActive(false);
			Menu.SetActive(false);
		}

		public void ToggleMenu()
		{
			Menu.SetActive(!Menu.activeSelf);
		}

		public bool IsPlayerOnAndroid()
		{
#if UNITY_ANDROID
		return !Networking.LocalPlayer.IsUserInVR();
#else
			return false;
#endif
		}

		public override void OnPlayerJoined(VRCPlayerApi player)
		{
			if (player.isLocal)
			{
				Canvas.SetActive(IsPlayerOnAndroid());
			}
		}
	}
}
