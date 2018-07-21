using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    GameObject ply;
    GameObject potat;
	// Use this for initialization
	void Start () {
        ply = GameObject.Find("ThirdPersonController");
        potat = GameObject.Find("RollerBall");
        Camera cam = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update(){
        Vector3 middle = (ply.transform.position - potat.transform.position) / 2f;
        float dist = (ply.transform.position - potat.transform.position).magnitude;
        Vector3 camdist = middle - this.transform.forward * dist * 2;
        //this.transform.position = new Vector3(camdist.x/4f, ply.transform.position.y + 50, ply.transform.position.z -50);
    }
}
