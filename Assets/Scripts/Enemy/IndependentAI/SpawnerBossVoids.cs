using UnityEngine;

public class SpawnerBossVoids : MonoBehaviour
{
    public float cooldown;

    public void SpawnMobs(float resCooldown, float minTime, float maxTime, GameObject main, GameObject mobToSpawn)
    {
        if (cooldown <= 0)
        {
            cooldown = resCooldown;

            int amountOfMobs = (int)Mathf.Round(Random.Range(minTime, maxTime));

            for (int i = 0; i < amountOfMobs; i++)
            {
                float XPos = Mathf.Round(Random.Range(-2, 2));
                float YPos = Mathf.Round(Random.Range(-2, 2));
                Vector2 RandomPos = new Vector2(main.transform.position.x + XPos, main.transform.position.y + YPos);

                Instantiate(mobToSpawn, RandomPos, Quaternion.identity);
            }
        }
        else
        {
            cooldown -= Time.deltaTime;
        }
    }
}
