using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {
    int activeplayers = 0;

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {

        while (Mathf.Abs(Input.GetAxis("Horizontal_p2")) < 0.2F || Mathf.Abs(Input.GetAxis("Vertical_p2")) < 0.2F)
            {
            for (int i = 2; i < 6; i++)
            {
                if (Mathf.Abs(Input.GetAxis("Horizontal_p" + i)) > 0.2F || Mathf.Abs(Input.GetAxis("Vertical_p" + i)) > 0.2F)
                {
                    Debug.Log(Input.GetJoystickNames()[i - 2] + " is moved");
                    activeplayers++;
                }
            }
   

        }
        switch (activeplayers)
        {
            case 1:
                Destroy(GameObject.Find("secondMan"));
                Destroy(GameObject.Find("laska 2"));
                Destroy(GameObject.Find("person02a"));

                break;
            case 2:
                Destroy(GameObject.Find("laska 2"));
                Destroy(GameObject.Find("person02a"));
                break;
            case 3:
                Destroy(GameObject.Find("person02a"));
                break;
            default:
                break;
        }
        Destroy(this.gameObject);
    }
}
