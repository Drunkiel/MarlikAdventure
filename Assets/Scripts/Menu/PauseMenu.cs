using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused;

    OpenCloseUI UIObject;

    void Start()
    {
        UIObject = GetComponent<OpenCloseUI> ();
    }

    // Update is called once per frame
    void Update()
    {
        Controller();

        if(isPaused){
            Pause();
        }   else{
            Resume();
        }
    }

    void Controller(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            UIObject.isUIOpen = !UIObject.isUIOpen;
            isPaused = UIObject.isUIOpen;
        }
    }

    void Pause(){
        Time.timeScale = 0f;
    }

    public void Resume(){
        isPaused = false;
        UIObject.isUIOpen = false;
        Time.timeScale = 1f;
    }

    public void BackButton (){
        SceneManager.LoadScene(0);
    }
}
