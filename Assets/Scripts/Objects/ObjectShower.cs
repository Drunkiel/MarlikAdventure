using UnityEngine;

public class ObjectShower : MonoBehaviour
{
    public GameObject ObjectToShow;
    public bool isTriggered;

    // Update is called once per frame
    void Update()
    {
        isTriggered = GetComponent<TagChecker> ().isTriggered;

        if(isTriggered){
            ObjectToShow.SetActive(true);
        }   else{
            ObjectToShow.SetActive(false);
        }
    }
}
