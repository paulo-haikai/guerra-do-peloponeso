using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canva : MonoBehaviour
{
    public Text scroll;
    private player player;

    
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<player>();
        scroll.text = " ";
    }

    private void FixedUpdate() {
        
        if (player.addScroll == true) {

            scroll.text = player.scrools.ToString();


        }
    }



}

