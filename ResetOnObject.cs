namespace VRTK.Examples
{
	using UnityEngine;
	
	public class Reset : MonoBehaviour
	{
		private Vector3 defaultPosition;
		private Quaternion defaultRotation;
		
		public void ResetObj()
		{
			transform.position = defaultPosition;
			transform.rotation = defaultRotation;
		}
	}
}
