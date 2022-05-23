using UnityEngine;

public class TestMission : MonoBehaviour
{
    public int award;
    public bool isMissionActive;
    public bool isMissionDone;

    public int clicks;

    void Update()
    {
        Mission();
    }

    void Mission(){
        if(isMissionActive && Input.GetMouseButtonDown(0)){
            clicks++;
            if(clicks >= 5){
                isMissionDone = true;
            }
        }

        if(isMissionDone){
            isMissionActive = false;
            clicks = 0;
        }
    }
}
