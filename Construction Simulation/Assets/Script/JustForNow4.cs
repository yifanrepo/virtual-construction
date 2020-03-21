using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustForNow4 : MonoBehaviour {
    GameObject UI = null;
    // Use this for initialization
    void Start()
    {
        UI = GameObject.FindWithTag("UI");
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.transform.tag == "Player")
        {
            UI.transform.Find("Reticle6").gameObject.SetActive(false);
        }
    }
}
