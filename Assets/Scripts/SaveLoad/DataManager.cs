using UnityEngine;

public class DataManager : MonoBehaviour
{
    private Vector2 PlayerPos;

    DataToSave gameData;
    ItemsToSave itemsData;
    StatsController Stats;

    void Start()
    {
        gameData= GetComponent<DataToSave> ();
        itemsData = GetComponent<ItemsToSave> ();
        Stats = GameObject.FindGameObjectWithTag("Player").GetComponent<StatsController> ();
    }

    public void SaveGame(){
        gameData.PlayerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform> ().position;
        gameData.PlayerCash = Stats.Cash;
        gameData.Experience = Stats.Experience;

        itemsData.SaveItems();
    }

    public void LoadGame(){
        
    }
}
