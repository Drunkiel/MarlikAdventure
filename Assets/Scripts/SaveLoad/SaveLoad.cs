using UnityEngine;
using System.IO;

public class SaveLoad : MonoBehaviour
{
    private string jsonSavePath;
    DataToSave gameData;
    DataManager moreGameData;

    void Start(){
        jsonSavePath = Application.persistentDataPath + "/Settings.json";
        moreGameData = GetComponent<DataManager> ();
        gameData = GetComponent<DataToSave> ();
    }
    
    public void Save(){
        //Creating file or opening file
        FileStream File1 = new FileStream(jsonSavePath, FileMode.OpenOrCreate);

        //Data to save    
        moreGameData.SaveGame();

        //!Saving data
        string jsonData = JsonUtility.ToJson(gameData, true); 

        File1.Close();
        File.WriteAllText(jsonSavePath, jsonData);
    }

    public void Load(){
        string json = ReadFromFile("Settings.json");
        JsonUtility.FromJsonOverwrite(json, gameData);
        moreGameData.LoadGame();
    }

    private string ReadFromFile(string FileName){
        using(StreamReader Reader = new StreamReader(jsonSavePath)){
            string json = Reader.ReadToEnd();
            return json;
        }
    }
}
