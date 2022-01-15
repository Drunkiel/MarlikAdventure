using UnityEngine;
using UnityEngine.UI;

public class StatsController : MonoBehaviour
{
    public float Health;
    private float MaxHealth;
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

    }

    public void TakeDamage(float amout){
        Health -= amout;
        SpriteRenderer Sprites = GetComponent<SpriteRenderer> ();
        Sprites.color = Color.Lerp(Color.white, Color.red, Mathf.PingPong(Time.time, 1));
    }
}
