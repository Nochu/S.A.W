using UnityEngine;
using System.Collections;

public class ChocoScript : MonoBehaviour {

	static int nQueenHit =  8;
	static int nWkAntHit =  3;
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "WALL")
		{
			Destroy(this.gameObject);
		}
		if(other.gameObject.tag == "ANT")
		{
			if (nWkAntHit == 1) {
				GameObject.Destroy (other.gameObject);
				GameObject.Destroy (this.gameObject);
				Score.nScore++;
				nWkAntHit = 3;
			} 
			else 
			{
				nWkAntHit--;
				GameObject.Destroy (this.gameObject);
			}
		}
		if(other.gameObject.tag == "QUEENANT")
		{
			if (nQueenHit == 1) {
				GameObject.Destroy (other.gameObject);
				GameObject.Destroy (this.gameObject);
				Score.nScore *= 2;
				nQueenHit = 8;
			} 
			else 
			{
				nQueenHit--;
				GameObject.Destroy (this.gameObject);
			}
		}
	}

}