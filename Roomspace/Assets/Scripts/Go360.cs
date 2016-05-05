using UnityEngine;
using System.Collections;

public class Go360 : MonoBehaviour {
	public void OnTriggerEnter(Collider other)
	{
		Application.LoadLevel ("360Scene");
	}
}