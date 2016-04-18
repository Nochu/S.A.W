using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Score.nRound == 4)
			Application.LoadLevel ("SAWMenu");
	}
}
