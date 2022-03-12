using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator Anim;
    Vector2 Move;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        Animating();
    }

    void Animating(){
        //Initializing inputs
        Move.x = Input.GetAxis("Horizontal"); 
        Move.y = Input.GetAxis("Vertical");

        Anim.SetFloat("Horizontal", Move.x);
        Anim.SetFloat("Vertical", Move.y);
        Anim.SetFloat("Speed", Move.sqrMagnitude);
    }
}
