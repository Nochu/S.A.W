using UnityEngine;
using System.Collections;

public class TurretScript : MonoBehaviour {

	float fRotSpeed = 200f;	// 포탑의 회전속도

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float fAmtToRot = fRotSpeed * Time.smoothDeltaTime;	// 프레임에 이동할 거리
		float fAngle	= Input.GetAxis( "Vertical" );		// 포탑 각도 방향(벡터)

		transform.Rotate(Vector3.forward * fAngle * fAmtToRot);	// 포탑 각도 조절
	}
}
