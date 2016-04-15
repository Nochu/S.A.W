using UnityEngine;
using System.Collections;

public class TurretScript : MonoBehaviour {

	private float fZ, fDistance = 0.0f;
	public Transform target;

	float fRotSpeed = 100f;	// 포탑의 회전속도

	// Use this for initialization
	void Start () 
	{
		fZ = transform.eulerAngles.z;

		fDistance = (transform.position - target.position).magnitude;
	}
	
	// Update is called once per frame

	void Update () {
		float fDt = Time.deltaTime;
		fZ -= Input.GetAxis("Vertical") * fRotSpeed * fDt;

		fZ = ClampAngle(fZ, 0f, 90f);

		Quaternion rotation = Quaternion.Euler(0, 0, -fZ);
		Vector3 position = rotation * (new Vector3(0.0f, 0.0f, -fDistance)) + target.position;

		transform.rotation = rotation;
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