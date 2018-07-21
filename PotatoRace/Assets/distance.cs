using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distance : MonoBehaviour {
	GameObject gm;
	Text txt;
	// Use this for initialization
	void Start () {
		gm = GameObject.Find("ThirdPersonController");
		txt = GameObject.Find("Text").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(gm.transform.position, transform.position);
		txt.text = "Distance to potato: " + Mathf.RoundToInt(dist).ToString();
	}
}
