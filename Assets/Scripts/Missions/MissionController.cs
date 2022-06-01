using UnityEngine;
using UnityEngine.UI;

public class MissionController : MonoBehaviour
{
    public GameObject[] allMissions;
    public bool[] isMissionDone;

    public int idOfActiveMission;
    public Button btn;

    public MissionDesc misDesc;
    StatsController stats;

    void Start()
    {
        stats = GameObject.FindGameObjectWithTag("Player").GetComponent<StatsController> ();
    }

    public void AcceptMission(){
        if(idOfActiveMission != 0){
            print("Aktualnie posiadasz misję do wykonania");
        }   else{
            btn.interactable = false;
            idOfActiveMission = misDesc.id;
            misDesc.mission.isMissionActive = true;
        }
    }

    public void CompleteMission(){
        if(misDesc.mission.isMissionDone){
            stats.cash += misDesc.award;
            Destroy(gameObject.transform.GetChild(0).GetChild(0).gameObject);
            idOfActiveMission = 0;
            DrawMission();
        }
    }

    void DrawMission(){
        int ranNum = (int)Mathf.Round(Random.Range(0, allMissions.Length));

        if(!isMissionDone[ranNum]){
            Instantiate(allMissions[ranNum], gameObject.transform.GetChild(0), false);
        }
    }
}
