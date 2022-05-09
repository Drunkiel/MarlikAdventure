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

    public void FirstAutoSave(){
        gameData.playerSavedPosition[0] = new Vector2(0f, 0f);
        gameData.playerSavedPosition[1] = new Vector2(-6.53f, -6.6f);
        gameData.playerSavedPosition[2] = new Vector2(0f, -3.5f);
        gameData.playerSavedPosition[3] = new Vector2(-40.5f, -18.54f);
    }

    public void LoadGame(){
        scenesData.GetCurrentSceneName();
        GameObject.FindGameObjectWithTag("Player").GetComponent<Transform> ().position = gameData.playerSavedPosition[scenesData.sceneId];
        stats.cash = gameData.playerCash;
        stats.experience = gameData.experience;

        itemsData.LoadItems();
    }
}
