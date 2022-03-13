using UnityEngine;

public class ShadowBossAI : MonoBehaviour
{
    public GameObject Shadow;
    private float AmountOfMobs;

    public float Cooldown;
    public float ResCooldown;

    // Update is called once per frame
    void Update()
    {
        SpawnMobs();
    }

    void SpawnMobs(){
        if(Cooldown <= 0){      

            Cooldown = ResCooldown;
            AmountOfMobs = Mathf.Round(Random.Range(1, 4));

            for (int i = 0; i < AmountOfMobs; i++)
            {
                float XPos = Mathf.Round(Random.Range(-2, 2));
                float YPos = Mathf.Round(Random.Range(-2, 2));
                Vector2 RandomPos = new Vector2(transform.position.x + XPos, transform.position.y + YPos); 

                Instantiate(Shadow, RandomPos, Quaternion.identity);
            }
        }   else{

            Cooldown -= Time.deltaTime;
        }
    }
}
