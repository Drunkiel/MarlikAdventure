using UnityEngine;

public class StatsController : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public int energy;
    public int maxEnergy;
    public float speed;
    public int level;
    public float experience;
    public float expToNextLvl;
    public int cash;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
        energy = maxEnergy;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0 && energy <= 0){
            PlayerDeath();
        }
    }

    void PlayerDeath(){
        //for now
        health = maxHealth;
    }

    public void TakeDamage(float amount){
        health -= amount;
        SpriteRenderer Sprites = GetComponent<SpriteRenderer> ();
        Sprites.color = Color.Lerp(Color.white, Color.red, Mathf.PingPong(Time.time, 0.4f));
    }
}
