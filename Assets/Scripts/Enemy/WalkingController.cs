using UnityEngine;

public class WalkingController : MonoBehaviour
{
    public bool isTriggered;
    private float speed;

    public float randomNum;
    public float xmov;
    public float ymov;
    public float cooldown;

    void Start()
    {
        speed = GetComponent<EnemyStats> ().speed;
    }

    // Update is called once per frame
    void Update()
    {
        isTriggered = transform.GetChild(0).GetComponent<TriggerController> ().isTriggered;

        if(isTriggered){
            FollowPlayer();
        }   else{
            RandomMovement();
        } 
    }

    void RandomMovement(){
        if(cooldown <= 0){      

            cooldown = Mathf.Round(Random.Range(3, 8));
            xmov = Mathf.Round(Random.Range(-1, 1));
            ymov = Mathf.Round(Random.Range(-1, 1));
        }   else{
            
            transform.Translate(xmov * speed * Time.deltaTime, ymov * speed * Time.deltaTime, 0);

            cooldown -= Time.deltaTime;
        }
    }

    void FollowPlayer(){
        GameObject PlayerPos = GameObject.FindGameObjectWithTag("Player");
        Vector3 directionShouldGo = (PlayerPos.transform.position - transform.position).normalized;

        transform.Translate(directionShouldGo * speed * Time.deltaTime);
    }
}
