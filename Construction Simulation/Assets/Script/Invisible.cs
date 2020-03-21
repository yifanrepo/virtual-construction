using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        gameObject.active = false;

    }
}
