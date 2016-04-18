using UnityEngine;
using System.Collections;

public class AntControl : MonoBehaviour {

	public 	float 	fSpeed = 2f;	// 개미의 이동 속도
			float 	fAmtToMove;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		fAmtToMove = fSpeed * Time.smoothDeltaTime;			// 프레임에 이동할 거리
		transform.Translate(Vector3.left * fAmtToMove);		// 개미 이동

		if (transform.position.x <= -9) 
		{
			Destroy(gameObject);
			Score.nLife -= 10;
		}
	}
}