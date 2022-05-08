using UnityEngine;

public class DataManager : MonoBehaviour
{
    private Vector2 playerPos;

    DataToSave gameData;
    ItemsToSave itemsData;
    FromScenesToSave scenesData;
    StatsController stats;

    void Start()
    {
        gameData = GetComponent<DataToSave> ();
        itemsData = GetComponent<ItemsToSave> ();
        scenesData = GetComponent<FromScenesToSave> ();
        stats = GameObject.FindGameObjectWithTag("Player").GetComponent<StatsController> ();
    }

    public void SaveGame(){
        gameData.playerSavedPosition[scenesData.sceneId] = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform> ().position;
        gameData.playerCash = stats.cash;
        gameData.experience = stats.experience;

        itemsData.SaveItems();
    }

    public void LoadGame(){
        GameObject.FindGameObjectWithTag("Player").GetComponent<Transform> ().position = gameData.playerSavedPosition[scenesData.sceneId];
        stats.cash = gameData.playerCash;
        stats.experience = gameData.experience;

        itemsData.LoadItems();
    }
}
