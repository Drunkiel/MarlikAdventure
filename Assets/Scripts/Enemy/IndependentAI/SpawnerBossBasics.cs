using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class SpawnerBossBasics
{
    public GameObject mobToSpawn;
    public float amountOfMobs;

    public float cooldown;
    public float resCooldown;

    public GameObject[] objectsToCheck;
    public bool isPlayer;

    public EnemyStats stats;
    public RandomTextPicker randomText;
    public Text bossDeathText;
}
