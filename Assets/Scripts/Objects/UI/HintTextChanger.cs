using UnityEngine;
using TMPro;

public class HintTextChanger : MonoBehaviour
{
    public TMP_Text Hint;
    RandomTextPicker TextToPick;

    void Start()
    {
        TextToPick = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RandomTextPicker> ();
    }

    void OnTriggerEnter2D(Collider2D trig){
        if(trig.gameObject.CompareTag("Item")){
            Hint.text = TextToPick.PickupHint;
        }

        if(trig.gameObject.CompareTag("Talkative")){
            Hint.text = TextToPick.TalkHint;
        }
    }
}
