using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public bool isTriggered;
    public float Damage;
    public float AttackRange;

    public float Cooldown;
    private float ResCooldown;

    public Transform AttackPoint;
    public LayerMask PlayerLayer;

    // Start is called before the first frame update
    void Start()
    {
        ResCooldown = Cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        isTriggered = transform.GetChild(0).GetComponent<TriggerController> ().isTriggered;

        if(isTriggered){
            Attack();
        }   else{
            Cooldown = ResCooldown;
        }
    }

    void Attack(){
        //Detecting player
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(AttackPoint.position, AttackRange, PlayerLayer);
        
        //Do damage to player
        foreach(Collider2D player in hitPlayer){
            if(Cooldown <= 0){      
                player.GetComponent<StatsController>().TakeDamage(Damage);               
                Cooldown = ResCooldown;

            }   else{

                Cooldown -= Time.deltaTime;
            }
        }
    }
}
