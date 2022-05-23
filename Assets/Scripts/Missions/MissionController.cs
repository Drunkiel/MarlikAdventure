using UnityEngine;
using UnityEngine.UI;

public class MissionController : MonoBehaviour
{
    public GameObject[] allMissions;
    public bool[] isMissionDone;

    public int idOfActiveMission;
    public Button btn;

    public MissionDesc misDesc;

    public void AcceptMission(){
        if(idOfActiveMission != 0){
            print("Aktualnie posiadasz misję do wykonania");
        }   else{
            btn.interactable = false;
            idOfActiveMission = misDesc.id;
        }
    }
}
