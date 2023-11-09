
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace myro
{
	[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
	public class GameObjectToggle : UdonSharpBehaviour
	{
		public bool ShownByDefault;
		public GameObject[] GameObjectList;

		[Header("Do not touch this")]
		public UnityEngine.UI.Toggle Toggle;

		void Start()
		{
			Toggle.isOn = ShownByDefault;
		}

		public void Toggled()
		{
			foreach(var go in GameObjectList)
			{
				go.SetActive(Toggle.isOn);
			}
		}

		public void Pressed()
		{
			Toggle.isOn = !Toggle.isOn;
		}
	}
}