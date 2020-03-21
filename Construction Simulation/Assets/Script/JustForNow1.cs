using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustForNow1 : MonoBehaviour {
    GameObject UI = null;
    AudioSource audioSource;
    // Use this for initialization
    void Start () {
        UI = GameObject.FindWithTag("UI");
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
        if (col.gameObject.transform.tag == "Player")
        {
            UI.transform.Find("Reticle5").gameObject.SetActive(true);
            audioSource.Play();
        }
    }
}
