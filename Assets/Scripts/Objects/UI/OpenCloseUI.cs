using UnityEngine;
using UnityEngine.UI;

public class OpenCloseUI : MonoBehaviour
{
    public GameObject UIObject;
    public bool isUIOpen;

    public bool isTriggered;
    public bool EnableAutoClosing;
    public GameObject ObjectToTest;

    // Update is called once per frame
    void Update()
    {    
        OpenClose();
        if(EnableAutoClosing){
            isTriggered = ObjectToTest.GetComponent<TriggerController> ().isTriggered;
            AutoClosing();
        }
    }

    void OpenClose(){

        if(isUIOpen){
            UIObject.SetActive(true);
        }   else{
            UIObject.SetActive(false);
        }
    }

    void AutoClosing(){

        if(!isTriggered && isUIOpen){
            isUIOpen = false;
        }
    }
}
