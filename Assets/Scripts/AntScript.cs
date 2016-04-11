using UnityEngine;
using System.Collections;

public class AntScript : MonoBehaviour {

	float fSpeed = 0.5f;	// 개미의 이동 속도

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float fAmtToMove = fSpeed * Time.smoothDeltaTime;	// 프레임에 이동할 거리

		transform.Translate(Vector3.left * fAmtToMove);		// 개미 이동
	}
}