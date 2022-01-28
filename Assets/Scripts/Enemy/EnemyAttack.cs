using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public bool isTriggered;
    public float Damage;

    public float Cooldown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isTriggered = transform.GetChild(0).GetComponent<TriggerController> ().isTriggered;
    }

    void Attack(){
        if(Cooldown <= 0){      

        }   else{

            Cooldown -= Time.deltaTime;
        }
    }
}
