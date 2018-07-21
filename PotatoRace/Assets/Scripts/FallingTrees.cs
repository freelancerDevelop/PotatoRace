using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTrees : MonoBehaviour {
    int test;
    void Start () {
		
	}
	//
	void Update () {
		
	}
    IEnumerator OnTriggerEnter(Collider tree)
    {
        if(tree.tag == "Tree")
        {
            tree.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX;
            tree.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
            tree.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 100);
            yield return new WaitForSeconds(2);
            tree.GetComponent<BoxCollider>().enabled = false;
            tree.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }
}
