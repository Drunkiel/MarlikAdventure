using UnityEngine;
using UnityEngine.UI;

public class ShadowBossAI : MonoBehaviour
{
    public GameObject shadow;
    private float amountOfMobs;

    public float cooldown;
    public float resCooldown;

    public GameObject[] lamps;
    private bool isPlayer;

    EnemyStats stats;
    RandomTextPicker randomText;
    public Text bossDeathText;

    void Start()
    {
        lamps = GameObject.FindGameObjectsWithTag("LightSource");
        randomText = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RandomTextPicker> ();
        stats = GetComponent<EnemyStats> ();
    }

    // Update is called once per frame
    void Update()
    {
        isPlayer = GameObject.FindGameObjectWithTag("MapLocalization").GetComponent<MapLocalizationController> ().isPlayerThere[0];

        if(isPlayer){
            SpawnMobs();
            Lamp();
        } 

        if(stats.health <= 0){
            Death();
        }
    }

    void SpawnMobs(){
        if(cooldown <= 0){      

            cooldown = resCooldown;
            amountOfMobs = Mathf.Round(Random.Range(1, 4));

            for (int i = 0; i < amountOfMobs; i++)
            {
                float XPos = Mathf.Round(Random.Range(-2, 2));
                float YPos = Mathf.Round(Random.Range(-2, 2));
                Vector2 RandomPos = new Vector2(transform.position.x + XPos, transform.position.y + YPos); 

                Instantiate(shadow, RandomPos, Quaternion.identity);
            }
        }   else{

            cooldown -= Time.deltaTime;
        }
    }

    void Death(){
        bossDeathText.enabled = true;

        if(cooldown <= 0){      
            bossDeathText.enabled = false;
            
        }   else{
            randomText.RandomPick(bossDeathText, false);
            cooldown -= Time.deltaTime;
        }
    }

    void Lamp(){
        foreach (GameObject isLight in lamps)
        {
            if(!isLight.GetComponent<LanternController> ().isTurnedOn){
                break;
            }   else{
                stats.health -= lamps.Length;
            }
        }
    }
}
