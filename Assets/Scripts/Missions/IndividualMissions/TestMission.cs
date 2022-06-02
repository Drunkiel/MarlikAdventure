using UnityEngine;

public class TestMission : MonoBehaviour
{
    public bool isMissionActive;
    public bool isMissionDone;

    MissionController misController;
    MissionDesc misDesc;

    public int clicks;

    void Start()
    {
        misController = transform.parent.parent.GetComponent<MissionController> ();
        misDesc = GetComponent<MissionDesc> ();
    }

    void Update()
    {
        isMissionActive = misDesc.isMissionActive;
        isMissionDone = misDesc.isMissionDone;

        Mission();
    }

    void Mission(){
        //Checker
        if(isMissionActive && Input.GetMouseButtonDown(0)){
            clicks++;
        }

        //Mission ending condition
        if(clicks >= 5){
            misDesc.isMissionDone = true;
            misDesc.isMissionActive = false;
        }

        //Ending mission
        if(isMissionDone){
            misController.CompleteMission();
        }
    }
}
