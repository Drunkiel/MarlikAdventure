using UnityEngine;

public class OpeningUI : MonoBehaviour
{
    OpenCloseUI UIObject;

    // Start is called before the first frame update
    void Start()
    {
        UIObject = GetComponent<OpenCloseUI> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && UIObject.isTriggered){
            UIObject.isUIOpen = !UIObject.isUIOpen;
        }  
    }
}
