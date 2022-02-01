using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float Health;
    public float MaxHealth;
    public float Speed;
    public float Damage;

    private SpriteRenderer EnemySprite;

    // Start is called before the first frame update
    void Start()
    {
        EnemySprite = GetComponent<SpriteRenderer> ();
        MaxHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0){
            Die();
        }
    }

    void Die(){
        EnemySprite.color = Color.red;
        Destroy(this.gameObject, 1f);
    }

    public void TakeDamage(float amount){
        Health -= amount;
    }
}
