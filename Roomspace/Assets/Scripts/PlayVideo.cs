using UnityEngine;
using System.Collections;

public class PlayVideo : MonoBehaviour {

	public MovieTexture movTexture;

	// Use this for initialization
	void Start () {
		movTexture.loop = true;
		GetComponent<Renderer> ().material.mainTexture = movTexture;

		movTexture.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
