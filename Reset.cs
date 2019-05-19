namespace VRTK.Examples
{
	using UnityEngine;
	
	public class Reset : MonoBehaviour
	{
		public GameObject obj1;
		public GameObject obj2;
		public GameObject obj3;
		public GameObject obj4;
		private ResetOnObject1 ResetScript1;
		private ResetOnObject2 ResetScript2;
		private ResetOnObject3 ResetScript3;
		private ResetOnObject4 ResetScript4;
		
		private void Start()
		{
			ResetScript1 = obj1.GetComponent<ResetOnObject>;
			ResetScript2 = obj2.GetComponent<ResetOnObject>;
			ResetScript3 = obj3.GetComponent<ResetOnObject>;
			ResetScript4 = obj1.GetComponent<ResetOnObject>;
			GetComponent<VRTK_ControllerEvents>().ButtonTwoPressed += new ControllerInteractionEventHandler(DoObjReset);
		}
		
		private void DoObjReset (object sender, ControllerInteractionEventArgs e)
		{
			ResetOnObject1.ResetObj();
			ResetOnObject2.ResetObj();
			ResetOnObject3.ResetObj();
			ResetOnObject4.ResetObj();
		}
		
	}
}
