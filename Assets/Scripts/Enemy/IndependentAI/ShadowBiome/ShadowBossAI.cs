using UnityEngine;

public class ShadowBossAI : MonoBehaviour
{
    public SpawnerBossBasics bossBasics;
    public SpawnerBossVoids bossVoids;

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
            bossVoids.SpawnMobs(bossBasics.resCooldown, bossBasics.minTime, bossBasics.maxTime, bossBasics.main, bossBasics.mobToSpawn);
            Lamp();
        } 

        if(bossBasics.stats.health <= 0){
            Death();
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
