using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Housekeeping1 : MonoBehaviour {
    // Use this for initialization

    public bool isOn = false;

    void Start () {
	}

	void OnTriggerEnter (Collider col)
	{

		if (col.gameObject.transform.tag == "Slab2") {
            isOn = true;
		}
	}
}
			