using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustForNow : MonoBehaviour {
    GameObject Door_Left = null;
    GameObject Door_Right = null;
    AudioSource audioSource;
    public bool isOpen = false;
    // Use this for initialization
    void Start () {
        Door_Left = GameObject.FindWithTag("Door_Left");
        Door_Right = GameObject.FindWithTag("Door_Right");
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
        if (col.gameObject.transform.tag == "CardReader")
        {
            audioSource.Play();
            Door_Left.GetComponent<Animator>().SetBool("Door_Left", true);
            Door_Right.GetComponent<Animator>().SetBool("Door_Right", true);
            isOpen = true;
        }
    }
}
