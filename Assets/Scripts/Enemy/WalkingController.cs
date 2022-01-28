using UnityEngine;

public class WalkingController : MonoBehaviour
{
    public bool isTriggered;
    public float Speed;

    public float RandomNum;
    public float xmov;
    public float ymov;
    public float Cooldown;

    // Update is called once per frame
    void Update()
    {
        isTriggered = transform.GetChild(0).GetComponent<TriggerController> ().isTriggered;

        if(isTriggered){
            FollowPlayer();
        }   else{
            RandomMovemnt();
        } 
    }

    void RandomMovemnt(){
        if(Cooldown <= 0){      

            Cooldown = Mathf.Round(Random.Range(3, 8));
            xmov = Mathf.Round(Random.Range(-1, 1));
            ymov = Mathf.Round(Random.Range(-1, 1));
        }   else{
            
            transform.Translate(xmov * Speed * Time.deltaTime, ymov * Speed * Time.deltaTime, 0);

            Cooldown -= Time.deltaTime;
        }
    }

    void FollowPlayer(){
        GameObject PlayerPos = GameObject.FindGameObjectWithTag("Player");
        Vector3 directionShouldGo = (PlayerPos.transform.position - transform.position).normalized;

        transform.Translate(directionShouldGo * Speed * Time.deltaTime);
    }
}
