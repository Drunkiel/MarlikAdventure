using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public bool isSceneLoaded;
    public string sceneNameToLoad;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.U)){
            StartCoroutine(Load_Start(sceneNameToLoad));
        }

        if(Input.GetKeyDown(KeyCode.I)){
            StartCoroutine(Load_End());
        }
    }

    public IEnumerator Load_Start(string sceneName){
        anim.Play("Load_Start");

        yield return new WaitForSeconds(1);

        anim.Play("Do_Nothing");

        SceneManager.LoadScene(sceneName);
    }

    public IEnumerator Load_End(){
        anim.Play("Load_End");

        yield return new WaitForSeconds(1);

        anim.Play("Do_Nothing");
    }
}
