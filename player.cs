using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;
    private bool jump = false;
    public Animator anim;
    private CharacterController cc;
    private Vector3 gravidade;
    public int life = 100;
    public int scrools = 0;
    public bool addScroll = false;

    private void Start() {
        cc = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    private void Update() {

        //Movimentação para frente e para trás
        Vector3 movement = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * moveSpeed;

        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)){
            anim.SetFloat("run", 0.02f);
        }
        else
            anim.SetFloat("run", 0.00f);



        //ataques

        if (Input.GetKey(KeyCode.Mouse0)) {
            anim.SetFloat("ataque1", 0.02f);
        }
        else
            anim.SetFloat("ataque1", 0.00f);

        if (Input.GetKey(KeyCode.Mouse1)) {
            anim.SetFloat("ataque2", 0.02f);
        }
        else
            anim.SetFloat("ataque2", 0.00f);

        //Rotação no PRÓPRIO eixo
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0));

        if (Input.GetKeyDown(KeyCode.Space)) {
            jump = true;
        }

        if (!cc.isGrounded) {
            gravidade += Physics.gravity * Time.deltaTime;
        }
        else {
            gravidade = Vector3.zero;
            if (jump) {
                gravidade.y = 10f;
                jump = false;
            }
        }

        movement += gravidade;

        //Método Move do próprio Character Controller
        cc.Move(movement * Time.deltaTime);


        

    }

}



