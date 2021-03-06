using UnityEngine;

public class MapLocalizationController : MonoBehaviour
{
    public GameObject[] Maps;
    public bool[] isPlayerThere;

    void FixedUpdate()
    {
        Checker();
    }

    void Checker(){
        for (int i = 0; i < isPlayerThere.Length; i++)
        {
            isPlayerThere[i] = Maps[i].GetComponent<TriggerController> ().isTriggered;
        }
    }
}
