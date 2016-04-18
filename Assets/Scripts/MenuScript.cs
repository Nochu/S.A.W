using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			Application.LoadLevel ("SAWGame");
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			Application.LoadLevel ("SAWHow");
		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			Application.Quit ();
		}
	}

}
