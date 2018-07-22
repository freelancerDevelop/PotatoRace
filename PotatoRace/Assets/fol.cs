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
        this.transform.position = mainPlayer.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        players = GameObject.FindGameObjectsWithTag("player");
        potato = GameObject.FindGameObjectsWithTag("potato")[0];

        foreach (GameObject player in players)
        {
            float cameraToPotato = Vector3.Distance(mainPlayer.transform.position, potato.transform.position);
            if (cameraToPotato < Vector3.Distance(player.transform.position, potato.transform.position)
                && Vector3.Distance(player.transform.position, potato.transform.position) < 240)
            {
                secondLastPlayer = mainPlayer;
                mainPlayer = player;
                this.transform.position = mainPlayer.transform.position;


            }
            if (Vector3.Distance(player.transform.position, potato.transform.position) >= 240)
            {
                Destroy(player);
                if (secondLastPlayer != null)
                    mainPlayer = secondLastPlayer;
                else mainPlayer = GameObject.Find("secondMan");

            }


        }

    }
}
