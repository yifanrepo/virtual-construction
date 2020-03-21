using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFollow : MonoBehaviour {

    public GameObject myObject;

	void Update () {

        //Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        Vector3 namePos = this.transform.position;
        myObject.transform.position = namePos;
	}
}
