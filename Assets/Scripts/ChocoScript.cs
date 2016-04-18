using UnityEngine;
using System.Collections;

public class ChocoScript : MonoBehaviour {

	static int nQueenHit = 0;
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "WALL")
		{
			Destroy(this.gameObject);
		}
		if(other.gameObject.tag == "ANT")
		{
			GameObject.Destroy(other.gameObject);
			GameObject.Destroy(this.gameObject);
			Score.nScore += 1;
		}
		if(other.gameObject.tag == "QUEENANT")
		{
			if (nQueenHit == 5) {
				GameObject.Destroy (other.gameObject);
				GameObject.Destroy (this.gameObject);
				Score.nScore *= 2;
			} 
			else 
			{
				GameObject.Destroy (this.gameObject);
				nQueenHit++;
			}
		}
	}

}