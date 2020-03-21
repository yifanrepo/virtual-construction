using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

    public Transform player;

	void Update () {
        this.transform.LookAt(player);
    }
}
