using UnityEngine;
using System.Collections;

public class AntCreate : MonoBehaviour {
	
	public GameObject pfAnt;
	Vector3 startPos;
	
	int nAntCount = 0;					// 개미 생성 제한

	// Use this for initialization
	void Start () {
		StartCoroutine (create (1.0f));	// 최초 개미 생성 1초
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator create(float fWaitTime)
	{
		yield return new WaitForSeconds (fWaitTime);

		if(nAntCount < 3)				// 생성제한 (임시)
		{
			startPos = new Vector3 (9, -3, 3.42f);						//개미들의 생성위치
			Instantiate (pfAnt, startPos, Quaternion.Euler(0, 0, 0));	//생성

			nAntCount++;
		}

		StartCoroutine (create(2.0f));								//매 2초마다 생성(타이머)
	}
}
