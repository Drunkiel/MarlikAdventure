using UnityEngine;
using UnityEngine.UI;

public class StatsController : MonoBehaviour
{
    public float Health;
    public float MaxHealth;
    public int Level;
    public float Experience;
    public float ExpToNextLvl;
    public int Cash;

    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        if(Health < 0){
            PlayerDeath();
        }
    }

    void PlayerDeath(){
        //for now
        Health = MaxHealth;
    }

    public void TakeDamage(float amout){
        Health -= amout;
        SpriteRenderer Sprites = GetComponent<SpriteRenderer> ();
        Sprites.color = Color.Lerp(Color.white, Color.red, Mathf.PingPong(Time.time, 0.4f));
    }
}
