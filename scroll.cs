using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scroll : MonoBehaviour
{
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("player");
    }

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.CompareTag("Player")) {
            player.GetComponent<player>().addScroll = true;
            player.GetComponent<player>().scrools++;
            Destroy(gameObject);
            player.GetComponent<player>().addScroll = false;
        }
    }
}
