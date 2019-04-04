using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	public GameObject newObject;
	NetworkPlayerScript playerScript;
	GameObject networkPlayerObject;
	void Start () {
		 playerScript = newObject.GetComponent<NetworkPlayerScript> ();
		networkPlayerObject = playerScript.playerUnit;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
