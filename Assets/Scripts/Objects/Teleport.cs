using UnityEngine;

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
    public LoadScene loadScene;

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
                StartCoroutine(loadScene.Load_Start(sceneName));
            }

            cooldown =  5;
        }   else{

            cooldown -= Time.deltaTime;
        }
    }
}
