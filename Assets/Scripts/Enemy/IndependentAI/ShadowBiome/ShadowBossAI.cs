using UnityEngine;
using UnityEngine.UI;

public class ShadowBossAI : MonoBehaviour
{
    public SpawnerBossBasics bossBasics;

    void Start()
    {
        bossBasics.objectsToCheck = GameObject.FindGameObjectsWithTag("LightSource");
        bossBasics.randomText = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RandomTextPicker> ();
        bossBasics.stats = GetComponent<EnemyStats> ();
    }

    // Update is called once per frame
    void Update()
    {
        bossBasics.isPlayer = GameObject.FindGameObjectWithTag("MapLocalization").GetComponent<MapLocalizationController> ().isPlayerThere[0];

        if(bossBasics.isPlayer){
            SpawnMobs();
            Lamp();
        } 

        if(bossBasics.stats.health <= 0){
            Death();
        }
    }

    void SpawnMobs(){
        if(bossBasics.cooldown <= 0){

            bossBasics.cooldown = bossBasics.resCooldown;
            bossBasics.amountOfMobs = Mathf.Round(Random.Range(1, 4));

            for (int i = 0; i < bossBasics.amountOfMobs; i++)
            {
                float XPos = Mathf.Round(Random.Range(-2, 2));
                float YPos = Mathf.Round(Random.Range(-2, 2));
                Vector2 RandomPos = new Vector2(transform.position.x + XPos, transform.position.y + YPos); 

                Instantiate(bossBasics.mobToSpawn, RandomPos, Quaternion.identity);
            }
        }   else{

            bossBasics.cooldown -= Time.deltaTime;
        }
    }

    void Death(){
        bossBasics.bossDeathText.enabled = true;

        if(bossBasics.cooldown <= 0){
            bossBasics.bossDeathText.enabled = false;
            
        }   else{
            bossBasics.randomText.RandomPick(bossBasics.bossDeathText, false);
            bossBasics.cooldown -= Time.deltaTime;
        }
    }

    void Lamp(){
        foreach (GameObject isLight in bossBasics.objectsToCheck)
        {
            if(!isLight.GetComponent<LanternController> ().isTurnedOn){
                break;
            }   else{
                bossBasics.stats.health -= bossBasics.objectsToCheck.Length;
            }
        }
    }
}
