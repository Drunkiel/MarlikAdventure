using UnityEngine;

public class LanternController : MonoBehaviour
{
    public GameObject Light;

    public bool isTurnedOn;
    public bool isTriggered;

    private float Cooldown = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Light = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        isTriggered = GetComponent<TriggerController> ().isTriggered;

        if(isTriggered){

            TimerToTurnOn();
        }   else{

            Cooldown = 5f;
        }
    }

    void TimerToTurnOn(){
        if(Cooldown <= 0){      

            Light.SetActive(true);
            isTurnedOn = true;
        }   else{

            Cooldown -= Time.deltaTime;
        }
    }
}
