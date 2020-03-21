using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Housekeeping : MonoBehaviour {
    // Use this for initialization

    public bool isOn = false;

    void Start () {
	}

	void OnCollisionEnter (Collision col)
	{

		if (col.gameObject.transform.tag == "Slab") {
            isOn = true;
		}
	}
}
			