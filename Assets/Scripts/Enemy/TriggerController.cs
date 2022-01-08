using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public bool isTriggered;

    void OnTriggerEnter2D(Collider2D trig){
        if(trig.gameObject.CompareTag("Player")){
            isTriggered = true;
        }
    }

    void OnTriggerExit2D(Collider2D trig){
        if(trig.gameObject.CompareTag("Player")){
            isTriggered = false;
        }
    }
}
