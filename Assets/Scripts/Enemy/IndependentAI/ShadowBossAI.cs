using UnityEngine;

public class ShadowBossAI : MonoBehaviour
{
    public GameObject Shadow;
    private float AmountOfMobs;

    public float Cooldown;
    public float ResCooldown;

    public GameObject[] Lamps;
    private bool isPlayer;

    EnemyStats Stats;

    void Start()
    {
        Lamps = GameObject.FindGameObjectsWithTag("LightSource");
        Stats = GetComponent<EnemyStats> ();
    }

    // Update is called once per frame
    void Update()
    {
        isPlayer = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MapLocalizationController> ().isPlayerThere[0];

        if(isPlayer){
            SpawnMobs();
            Lamp();
        } 
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

    void Lamp(){
        foreach (GameObject isLight in Lamps)
        {
            if(!isLight.GetComponent<LanternController> ().isTurnedOn){

                print("false");
                break;
            }   else{
                Stats.Health -= Lamps.Length;
                print("true");
            }
        }
    }
}
