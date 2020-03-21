using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParent1 : MonoBehaviour {
    public Transform Parent1;
    GameObject p4 = null;
    GameObject p5 = null;
    GameObject p6 = null;
    // Use this for initialization
    void Start() {
        p4 = GameObject.FindWithTag("p4");
        p5 = GameObject.FindWithTag("p5");
        p6 = GameObject.FindWithTag("p6");
        p4.SetActive(false);
        p5.SetActive(false);
        p6.SetActive(false);
    }
    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.transform.tag == "Parent1")
        {
            //transform.SetParent(Parent1);
            p4.SetActive(true);
            p5.SetActive(true);
            p6.SetActive(true);
        }
    }
}
