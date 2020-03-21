using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proceed1 : MonoBehaviour {

    public bool isOn = false;

    void Start()
    {
    }

    void OnTriggerEnter (Collider col)
    {

        if (col.gameObject.transform.tag == "Slab4")
        {
            isOn = true;
        }
    }
}
