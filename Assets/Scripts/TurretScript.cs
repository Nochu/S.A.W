using UnityEngine;
using System.Collections;

public class TurretScript : MonoBehaviour {

	private float 		fZ = 0.0f;
	public float 		fPower = 500;		// 초코 발사 속도
	public Transform 	Choco;				// 초코 추가

	public AudioClip chocoSnd;

	float fRotSpeed = 100f;			// 포탑의 회전속도


	// Use this for initialization
	void Start () 
	{
		fZ = transform.eulerAngles.z;
	}
	
	// Update is called once per frame

	void Update () {
		float fDt = Time.deltaTime;
		fZ -= Input.GetAxis("Vertical") * fRotSpeed * fDt;

		fZ = ClampAngle(fZ, 0f, 90f);

		Quaternion rotation = Quaternion.Euler(0, 0, -fZ);

		transform.rotation = rotation;

		if (Input.GetKeyDown(KeyCode.Space)/*GetButtonDown ("Fire Choco")*/) 			// 스페이스바를 누르면 초코발사
		{
			GameObject spPoint = GameObject.Find ("SpawnPoint");

			Transform myChoco = (Transform)Instantiate (Choco, spPoint.transform.position, spPoint.transform.rotation);
			AudioSource.PlayClipAtPoint (chocoSnd, transform.position);
			myChoco.GetComponent<Rigidbody>().AddForce (spPoint.transform.up * fPower);				
			// 그냥 rigidbody쓰면 안됨.
		}
	}

	static float ClampAngle(float angle, float min, float max) {
		if(angle < -360) {
			angle += 360;
		}
		if(angle > 360) {
			angle -= 360;
		}
		return Mathf.Clamp(angle, min, max);
	}

}