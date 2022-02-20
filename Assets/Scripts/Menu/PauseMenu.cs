using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isPaused = GetComponent<OpenCloseUI> ().isUIOpen;
        
        if(isPaused){
            Pause();
        }   else{
            Resume();
        }
    }

    void Pause(){
        Time.timeScale = 0f;
    }

    void Resume(){
        Time.timeScale = 1f;
    }
}
