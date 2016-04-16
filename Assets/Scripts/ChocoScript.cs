using UnityEngine;
using System.Collections;

public class ChocoScript : MonoBehaviour {
	static void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "WALL" || other.gameObject.tag == "ANT")
		{
			Destroy(other.gameObject);
		}
	}
}