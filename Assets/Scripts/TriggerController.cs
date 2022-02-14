using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public bool isTriggered;
    public string Tag = "Player";

    void OnTriggerEnter2D(Collider2D trig){
        if(trig.gameObject.CompareTag(Tag)){
            isTriggered = true;
        }
    }

    void OnTriggerExit2D(Collider2D trig){
        if(trig.gameObject.CompareTag(Tag)){
            isTriggered = false;
        }
    }
}
