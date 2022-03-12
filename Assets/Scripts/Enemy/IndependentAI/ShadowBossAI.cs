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
                Instantiate(Shadow, transform.position, Quaternion.identity);
            }
        }   else{

            Cooldown -= Time.deltaTime;
        }
    }
}
