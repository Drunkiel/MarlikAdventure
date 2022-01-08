using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;

    Rigidbody2D rgBody;

    void Start(){

        rgBody = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    void Movement(){

        //Inicjalizing inputs
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        //Player movement
        rgBody.velocity = new Vector3(Horizontal* Time.deltaTime * Speed, Vertical * Time.deltaTime * Speed , 0);
    }
}
