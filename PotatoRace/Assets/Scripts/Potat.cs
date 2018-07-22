using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potat : MonoBehaviour {
    public GameObject unipotat;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider ferty)
    {//
        if(ferty.tag == "Fertyliser")
        {
            GameObject.Destroy(ferty.gameObject);
            unipotat.SetActive(true);
            unipotat.transform.position = this.transform.position;
            unipotat.transform.rotation = this.transform.rotation;
            Destroy(this.gameObject);
            

        }
    }
}
