using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform PointToTeleport;

    public float Cooldown;
    public bool isTriggered;

    // Update is called once per frame
    void Update()
    {
        isTriggered = GetComponent<TriggerController> ().isTriggered;

        if(isTriggered){
            Teleportation();
        }   else{
            Cooldown = 5f;
        } 
    }

    void Teleportation(){
        if(Cooldown <= 0){      
            GameObject PlayerPos = GameObject.FindGameObjectWithTag("Player");
            PlayerPos.transform.position = PointToTeleport.position;

            Cooldown =  5;
        }   else{

            Cooldown -= Time.deltaTime;
        }
    }
}
