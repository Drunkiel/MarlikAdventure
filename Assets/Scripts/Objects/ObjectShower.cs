using UnityEngine;

public class ObjectShower : MonoBehaviour
{
    public GameObject objectToShow;
    public bool isTriggered;

    // Update is called once per frame
    void Update()
    {
        isTriggered = GetComponent<TagChecker> ().isTriggered;

        if(isTriggered){
            objectToShow.SetActive(true);
        }   else{
            objectToShow.SetActive(false);
        }
    }
}
