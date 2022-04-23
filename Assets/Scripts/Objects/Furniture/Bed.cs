using UnityEngine;

public class Bed : MonoBehaviour
{
    public bool isTriggered;
    TimeController timeSys;
    
    // Start is called before the first frame update
    void Start()
    {
        timeSys = GetComponent<TimeController> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(isTriggered && Input.GetKeyDown(KeyCode.F)){
            timeSys.SkipDay();
        }
    }
}
