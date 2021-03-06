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
    }

    public void GetCurrentSceneName(){
        currentScene = SceneManager.GetActiveScene().name;

        for (int i = 0; i < DataToSave.scenesNames.Length; i++)
        {
            if(currentScene == DataToSave.scenesNames[i]){
                sceneId = i;
                break;
            }
        }
    }
}
