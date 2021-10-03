using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour {
    public int power = 10;
    public GameObject playerSword;
    private bandits enemy;

    void Start() {
        playerSword = GetComponent<GameObject>();
        enemy = GetComponent<bandits>();
    }

    // Update is called once per frame
    void Update() {
        swordAtaque();

    }

    void swordAtaque() {

        if (Input.GetKeyDown(KeyCode.Mouse1)) {

            void OnTriggerEnter(Collider other) {
                if (other.gameObject.CompareTag("inimigo")) {

                    enemy.recebeDano = true;
                    enemy.life -= power;
                }


                void OnTriggerExit(Collider col) {
                    if (col.gameObject.CompareTag("inimigo")) {

                        enemy.recebeDano = false;


                    }

                }
            }
        }
    }
}



             
        
    




