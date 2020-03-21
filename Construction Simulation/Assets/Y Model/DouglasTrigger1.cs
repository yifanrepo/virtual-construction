using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DouglasTrigger1 : MonoBehaviour {

    private Animator anim;
  

	// Use this for initialization
	void Start () {
        anim = GetComponent <Animator> ();
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && anim.GetCurrentAnimatorStateInfo (0).IsName ("S_Use_object"))
        {
            anim.SetTrigger ("StopUse");
        }
    }
}
