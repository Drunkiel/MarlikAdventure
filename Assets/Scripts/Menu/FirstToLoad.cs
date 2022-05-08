using UnityEngine;

public class FirstToLoad : MonoBehaviour
{
    public SaveLoad saveLoad;
    public LoadScene loadScene;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadScene.Load_End());
        saveLoad.Load();
    }
}
