using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fol : MonoBehaviour
{

    public GameObject[] players;
    GameObject mainPlayer, potato, secondLastPlayer;

    // Use this for initialization
    void Start()
    {

        mainPlayer = GameObject.Find("MainCharacter");

    }

    // Update is called once per frame
    void Update()
    {
        //players = GameObject.FindGameObjectsWithTag("player");
        //potato = GameObject.FindGameObjectsWithTag("potato")[0];
        //int i = 2;
        //int activeplayers = 0;
        //while (i < 6)
        //{
        //    if (Mathf.Abs(Input.GetAxis("Horizontal_p" + i)) > 0.2F || Mathf.Abs(Input.GetAxis("Vertical_p" + i)) > 0.2F)
        //    {
        //        Debug.Log(Input.GetJoystickNames()[i-2] + " is moved");
        //        activeplayers++;
        //    }


        //    i++;
        //}
        //switch (activeplayers)
        //{
        //    case 1:
        //        Destroy(GameObject.Find("secondMan"));
        //        Destroy(GameObject.Find("laska 2"));
        //        Destroy(GameObject.Find("person02a"));

        //        break;
        //    case 2:
        //        Destroy(GameObject.Find("laska 2"));
        //        Destroy(GameObject.Find("person02a"));
        //        break;
        //    case 3:
        //        Destroy(GameObject.Find("person02a"));
        //        break;
        //    default:
        //        break;
        //}
        //foreach (GameObject player in players)
        //{
        //    float cameraToPotato = Vector3.Distance(mainPlayer.transform.position, potato.transform.position);
        //    if (cameraToPotato < Vector3.Distance(player.transform.position, potato.transform.position)
        //        && Vector3.Distance(player.transform.position, potato.transform.position) < 240 && player)
        //    {
        //        secondLastPlayer = mainPlayer;
        //        mainPlayer = player;
        //        this.transform.position = mainPlayer.transform.position;


        //    }
        //    if (Vector3.Distance(player.transform.position, potato.transform.position) >= 240)
        //    {
        //        Destroy(player);
        //        if (secondLastPlayer != null)
        //            mainPlayer = secondLastPlayer;
        //        else mainPlayer = GameObject.Find("secondMan");

        //    }


        //}
        this.transform.position = mainPlayer.transform.position;

    }
}
