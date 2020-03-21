using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tripping : MonoBehaviour {
	// Use this for initialization
	GameObject Box =null;
	void Start () {
		Box = GameObject.FindWithTag("Box");
	}
	
//	void OnCollisionEnter (Collision col)
//	{
//
//		if (col.gameObject.transform.parent.tag == "Bricks_Pile") {
//			GetComponent<Animator> ().SetBool ("Tripping", true);
//			Debug.Log ("Tripping is found");
//			StartCoroutine (StartWait ());
////			Box.GetComponent<Rigidbody> ().useGravity = true;
//		}
//	}

	void OnTriggerEnter (Collider col)
	{

		if (col.gameObject.transform.parent.tag == "Bricks_Pile") {
			GetComponent<Animator> ().SetBool ("Tripping", true);
			Debug.Log ("Tripping is found");
			StartCoroutine (StartWait ());
			//			Box.GetComponent<Rigidbody> ().useGravity = true;
		}
	}

	IEnumerator StartWait()
	{
		yield return new WaitForSeconds (2);
		Debug.Log ("123");
		Dosomething ();
//
	}

	void Dosomething(){
		Box.GetComponent<Rigidbody> ().useGravity = true;
	}
}
			