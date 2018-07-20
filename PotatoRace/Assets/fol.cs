using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fol : MonoBehaviour {

	GameObject gm;

	// Use this for initialization
	void Start () {
		gm = GameObject.Find("ThirdPersonController");
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = gm.transform.position;

		 int i = 1;
        while (i < 2) {
            //if (Mathf.Abs(Input.GetAxis("Joy" + i + "X")) > 0.2F || Mathf.Abs(Input.GetAxis("Joy" + i + "Y")) > 0.2F)
                Debug.Log(Input.GetJoystickNames()[i] + " is moved");
            
            i++;
        }
		
	}
}
