using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour {
    // Use this for initialization

    public bool isOpen = false;

    void Start () {
	}

	void OnTriggerEnter (Collider col)
	{

		if (col.gameObject.transform.tag == "Door") {
            isOpen = true;
		}
	}
}
			