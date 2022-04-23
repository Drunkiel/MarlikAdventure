using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public bool isTriggered;
    private float damage;
    public float attackRange;

    public float cooldown;
    private float resCooldown;

    public Transform attackPoint;
    public LayerMask playerLayer;

    // Start is called before the first frame update
    void Start()
    {
        resCooldown = cooldown;
        damage = GetComponent<EnemyStats> ().damage;
    }

    // Update is called once per frame
    void Update()
    {
        isTriggered = transform.GetChild(0).GetComponent<TriggerController> ().isTriggered;

        if(isTriggered){
            Attack();
        }   else{
            cooldown = resCooldown;
        }
    }

    void Attack(){
        //Detecting player
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayer);
        
        //Do damage to player
        foreach(Collider2D player in hitPlayer){
            if(cooldown <= 0){      
                player.GetComponent<StatsController>().TakeDamage(damage);               
                cooldown = resCooldown;

            }   else{

                cooldown -= Time.deltaTime;
            }
        }
    }
}
