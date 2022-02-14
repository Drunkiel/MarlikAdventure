using UnityEngine;
using UnityEngine.UI;

public class OpenCloseUI : MonoBehaviour
{
    public GameObject UIObject;
    public bool isUIOpen;

    private bool isTriggered;
    public GameObject ObjectToTest;

    // Update is called once per frame
    void Update()
    {
        isTriggered = ObjectToTest.GetComponent<TriggerController> ().isTriggered;

        if(Input.GetKeyDown(KeyCode.F) && isTriggered){
            isUIOpen = !isUIOpen;
        }

        OpenClose();
        AutoClosing();
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
