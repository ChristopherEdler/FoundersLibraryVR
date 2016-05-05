using UnityEngine;
using System.Collections;

public class Return : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
	
		yield return new WaitForSeconds (55f);
		Application.LoadLevel ("RoomspaceVR");

	}

}
	

