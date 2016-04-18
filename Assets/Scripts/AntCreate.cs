using UnityEngine;
using System.Collections;

public class AntCreate : MonoBehaviour {
	
	public GameObject pfWorkAnt;
	public GameObject pfQueenAnt;
	Vector3 startPos;
	
	static int nAntCount = 0;					// 개미 생성 제한

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

		if (Score.nRound == 1) 
		{	// 1 ROUND
			startPos = new Vector3 (9, -3, 3.42f);						//개미들의 생성위치
			Instantiate (pfWorkAnt, startPos, Quaternion.Euler (0, 0, 0));	//생성

			++nAntCount;

			StartCoroutine (create (2.0f));								//매 2초마다 생성(타이머)

			if (nAntCount >= 10)
			{
				Score.nRound = 2;
				nAntCount = 0;
			}
		} 
		else if (Score.nRound == 2) 
		{	// 2 ROUND
			if (nAntCount == 5) 				
			{	// 일개미 생성 5마리째
				StartCoroutine (create (0.3f));

				startPos = new Vector3 (9, -3, 3.42f);
				Instantiate (pfQueenAnt, startPos, Quaternion.Euler (0, 0, 0));		// 여왕개미 생성
			}
			startPos = new Vector3 (9, -3, 3.42f);						//개미들의 생성위치
			Instantiate (pfWorkAnt, startPos, Quaternion.Euler (0, 0, 0));	//생성

			++nAntCount;

			StartCoroutine (create (1.0f));								//매 2초마다 생성(타이머)

			if (nAntCount >= 20)
			{
				Score.nRound = 3;
				nAntCount = 0;
			}
		} 
		else
		{	// 3 ROUND
			if (nAntCount == 5 || nAntCount == 30 || nAntCount == 40) 
			{	// 일개미 생성 5, 10, 20마리째
				StartCoroutine (create (0.2f));

				startPos = new Vector3 (9, -3, 3.42f);
				Instantiate (pfQueenAnt, startPos, Quaternion.Euler (0, 0, 0));		// 여왕개미 생성
			}
			startPos = new Vector3 (9, -3, 3.42f);						//개미들의 생성위치
			Instantiate (pfWorkAnt, startPos, Quaternion.Euler (0, 0, 0));	//생성

			++nAntCount;

			StartCoroutine (create (0.5f));								//매 2초마다 생성(타이머)

			if (nAntCount >= 80)
				Score.nRound = 4;
		}
	}
}
