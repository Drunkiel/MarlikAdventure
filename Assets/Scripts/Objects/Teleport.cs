using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform pointToTeleport;

    public float cooldown;
    public bool isTriggered;

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
            GameObject PlayerPos = GameObject.FindGameObjectWithTag("Player");
            PlayerPos.transform.position = pointToTeleport.position;

            cooldown =  5;
        }   else{

            cooldown -= Time.deltaTime;
        }
    }
}
