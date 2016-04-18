using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	static public int nScore = 0;
	static public int nLife  = 100;
	static public int nRound = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 120, 20), "NOW ROUND : " + nRound);
		GUI.Label (new Rect (10, 30, 120, 20), "KILL ANT : " + nScore);
		GUI.Label (new Rect (10, 50, 120, 20), "CASTLE HP : " + nLife);
	}
}
