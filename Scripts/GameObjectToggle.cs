
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
		public GameObject CheckmarkImage;

		private bool _isVisible;
		void Start()
		{
			SetVisibility(ShownByDefault);
		}

		private void SetVisibility(bool val)
		{
			_isVisible = val;
			CheckmarkImage.SetActive(val);
			foreach (var go in GameObjectList)
			{
				go.SetActive(val);
			}
		}

		public void Pressed()
		{
			SetVisibility(!_isVisible);
		}
	}
}