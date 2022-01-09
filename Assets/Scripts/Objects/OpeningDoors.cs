using UnityEngine;

public class OpeningDoors : MonoBehaviour
{
    private Transform Doors;
    public GameObject Trigger;
    public float Speed;
    public bool isTriggered;

    private float StartPlace;

    void Start(){
        Doors = this.transform;
        StartPlace = Doors.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        isTriggered = Trigger.GetComponent<TriggerController> ().isTriggered;
        if(isTriggered){
            OpenDoor();
        }   else{
            CloseDoor();
        }
    }

    void OpenDoor(){
        if(Doors.position.x <= StartPlace + 2){
             
            Doors.Translate(new Vector2(1 * Speed * Time.deltaTime, 0));
        }
    }

    void CloseDoor(){
        if(Doors.position.x >= StartPlace){
            Doors.Translate(new Vector2(-1 * Speed * Time.deltaTime, 0));
        }
    }
}
