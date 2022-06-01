using UnityEngine;

public class TestMission : MonoBehaviour
{
    public int award;
    public bool isMissionActive;
    public bool isMissionDone;

    MissionController misController;

    public int clicks;

    void Start()
    {
        misController = transform.parent.parent.GetComponent<MissionController> ();
    }

    void Update()
    {
        Mission();
    }

    void Mission(){
        if(isMissionActive && Input.GetMouseButtonDown(0)){
            clicks++;
            if(clicks >= 5){
                isMissionDone = true;
                isMissionActive = false;
            }
        }

        if(isMissionDone){
            misController.CompleteMission();
        }
    }
}
