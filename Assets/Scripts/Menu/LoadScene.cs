using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Animator anim;

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
