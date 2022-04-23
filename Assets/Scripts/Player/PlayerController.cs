using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Speed;

    Rigidbody2D rgBody;

    void Start(){

        rgBody = GetComponent<Rigidbody2D> ();
        Speed = GetComponent<StatsController> ().speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    void Movement(){

        //Initializing inputs
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        //Player movement
        rgBody.velocity = new Vector3(Horizontal* Time.deltaTime * Speed, Vertical * Time.deltaTime * Speed , 0);
    }
}
