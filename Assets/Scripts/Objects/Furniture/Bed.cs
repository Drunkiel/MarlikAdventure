using UnityEngine;

public class Bed : MonoBehaviour
{
    public bool isTriggered;
    public TimeController timeSys;

    // Update is called once per frame
    void Update()
    {
        BedSystem();
    }

    void BedSystem(){
        isTriggered = GetComponent<TriggerController> ().isTriggered;

        if(isTriggered && Input.GetKeyDown(KeyCode.F)){
            timeSys.SkipDay();
        }
    }
}
