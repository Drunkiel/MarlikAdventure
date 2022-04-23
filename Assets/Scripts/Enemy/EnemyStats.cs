using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public float speed;
    public float damage;

    private SpriteRenderer EnemySprite;

    // Start is called before the first frame update
    void Start()
    {
        EnemySprite = GetComponent<SpriteRenderer> ();
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0){
            Die();
        }
    }

    void Die(){
        EnemySprite.color = Color.red;
        Destroy(this.gameObject, 1f);
    }

    public void TakeDamage(float amount){
        health -= amount;
    }
}
