using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cakeslice
{
    public class Toggle : MonoBehaviour
    {
		public bool isViewed = false;

        // Update is called once per frame
        void Update()
        {
            //if(Input.GetKeyDown(KeyCode.K))
			if (isViewed) {
				//GetComponent<Outline>().enabled = !GetComponent<Outline>().enabled;
				GetComponent<Outline> ().enabled = true;
			} else {
				GetComponent<Outline> ().enabled = false;		
			}
        }
    }
}