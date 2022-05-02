using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    #nullable enable
    public bool sceneTeleport;
    public string? sceneName;
    public Transform? pointToTeleport;

    public float cooldown;
    public bool isTriggered;
    
    #nullable disable
    public SaveLoad saveLoad;

    // Update is called once per frame
    void Update()
    {
        isTriggered = GetComponent<TriggerController> ().isTriggered;

        if(isTriggered){
            Teleportation();
        }   else{
            cooldown = 5f;
        } 
    }

    void Teleportation(){
        if(cooldown <= 0){    
            if(!sceneTeleport && pointToTeleport != null){
                GameObject PlayerPos = GameObject.FindGameObjectWithTag("Player");
                PlayerPos.transform.position = pointToTeleport.position;
            }   else{
                saveLoad.Save();
                SceneManager.LoadScene(sceneName);
            }

            cooldown =  5;
        }   else{

            cooldown -= Time.deltaTime;
        }
    }
}
