using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proceed : MonoBehaviour {

    public bool isOn = false;

    void Start()
    {
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.transform.tag == "Slab3")
        {
            isOn = true;
        }
    }
}
