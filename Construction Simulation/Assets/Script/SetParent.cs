using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParent : MonoBehaviour {
    public Transform Parent;
    GameObject p1 = null;
    GameObject p2 = null;
    GameObject p3 = null;
    // Use this for initialization
    void Start() {
        p1 = GameObject.FindWithTag("p1");
        p2 = GameObject.FindWithTag("p2");
        p3 = GameObject.FindWithTag("p3");
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
    }
    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.transform.tag == "Parent")
        {
            //transform.SetParent(Parent);
            p1.SetActive(true);
            p2.SetActive(true);
            p3.SetActive(true);
        }
    }
}
