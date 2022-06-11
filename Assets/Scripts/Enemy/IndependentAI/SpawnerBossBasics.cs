using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class SpawnerBossBasics
{
    public GameObject mobToSpawn;
    public int amountOfMobs;

    public float cooldown;
    public float resCooldown;

    public float minTime;
    public float maxTime;

    public GameObject[] objectsToCheck;
    public bool isPlayer;

    public EnemyStats stats;
    public RandomTextPicker randomText;
    public Text bossDeathText;
    public GameObject main;

}
