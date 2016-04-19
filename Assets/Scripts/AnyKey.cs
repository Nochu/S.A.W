using UnityEngine;
using System.Collections;

public class AnyKey : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown)
		{
			Application.LoadLevel ("SAWMenu");
		}
	}

	void OnGUI()
	{
		GUI.Label (new Rect (302, 300, 200, 50), "Press Any Key to Go to the Menu");
	}
}
