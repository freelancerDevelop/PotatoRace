using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Button btn1 = this.GetComponent<Button>();
       

        //Calls the TaskOnClick/TaskWithParameters method when you click the Button
        btn1.onClick.AddListener(TaskOnClick);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	 void TaskOnClick()
    {
       SceneManager.LoadScene("SampleScene2");
    }
}
