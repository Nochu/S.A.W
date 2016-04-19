using UnityEngine;
using System.Collections;

public class AnyKey : MonoBehaviour {

	void Start()
	{
		StartCoroutine(DelayforChange(3.0f));			// 대기시간 3초
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{
		GUI.Label (new Rect (302, 300, 200, 50), "Press Any Key to Go to the Menu");
	}

	IEnumerator DelayforChange(float fWaitTime)
	{
		yield return new WaitForSeconds (fWaitTime);

		StartCoroutine(DelayforChange(0f));			// 대기시간 3초 뒤 anykeydown 활성

		if (Input.anyKeyDown)
		{
			Application.LoadLevel ("SAWMenu");
		}
	}
}
