using UnityEngine;

public class TagChecker : MonoBehaviour
{
    public bool isTriggered;
    public string[] Tag;

    void OnTriggerEnter2D(Collider2D trig){
        for (int i = 0; i < Tag.Length; i++)
        {
            if(trig.gameObject.CompareTag(Tag[i])){
                isTriggered = true;
            }   
        }
    }

    void OnTriggerExit2D(Collider2D trig){
        for (int i = 0; i < Tag.Length; i++)
        {
            if(trig.gameObject.CompareTag(Tag[i])){
                isTriggered = false;
            }   
        }
    }
}
