using UnityEngine;
using UnityEngine.SceneManagement;

public class FromScenesToSave : MonoBehaviour
{
    public string currentScene;
    public int sceneId;

    DataToSave gameData;

    // Start is called before the first frame update
    void Start()
    {
        gameData = GetComponent<DataToSave> ();
        GetCurrentSceneName();
    }

    void GetCurrentSceneName(){
        currentScene = SceneManager.GetActiveScene().name;

        for (int i = 0; i < gameData.scenesNames.Length; i++)
        {
            if(currentScene == gameData.scenesNames[i]){
                sceneId = i;
                break;
            }
        }
    }
}
