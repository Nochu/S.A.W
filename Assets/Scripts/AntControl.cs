using UnityEngine;
using System.Collections;

public class AntScript : MonoBehaviour {

	float fSpeed = 2f;	// 개미의 이동 속도
	float fAmtToMove;
//	bool bAntCountCheck = true;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		fAmtToMove = fSpeed * Time.smoothDeltaTime;			// 프레임에 이동할 거리
		transform.Translate(Vector3.forward * fAmtToMove);		// 개미 이동
		//fAmtToMove = transform.position.y - (fSpeed * Time.deltaTime);								// 프레임에 이동할 거리
		//transform.position = new Vector3 (transform.position.x, fAmtToMove, transform.position.z);// 개미 이동

		//fAmtToMove = transform.position.x - (fSpeed * Time.deltaTime);								// 프레임에 이동할 거리
		//transform.position = new Vector3 (fAmtToMove, transform.position.y, transform.position.z);	// 개미 이동
	}

	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject.name == "Castle")
		{
			//GameObject.Destroy(other.gameObject);
			GameObject.Destroy(this.gameObject);
		}
	}
}