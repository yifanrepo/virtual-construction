using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proceed2 : MonoBehaviour {

    public bool isOn = false;

    void Start()
    {
    }

    void OnTriggerEnter (Collider col)
    {

        if (col.gameObject.transform.tag == "Slab5")
        {
            isOn = true;
        }
    }
}
