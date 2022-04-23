using UnityEngine;
using UnityEngine.UI;

public class OpenCloseUI : MonoBehaviour
{
    public GameObject UIObject;
    public bool isUIOpen;

    public bool isTriggered;
    public bool enableAutoClosing;
    public GameObject objectToTest;

    // Update is called once per frame
    void Update()
    {    
        OpenClose();
        if(enableAutoClosing){
            isTriggered = objectToTest.GetComponent<TriggerController> ().isTriggered;
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
