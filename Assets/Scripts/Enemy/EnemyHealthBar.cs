using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    private Slider healthBar;
    private Image fillBar;

    public Color FullHp, HalfHp, QuartHp;

    EnemyStats stats;
    HealthUpdate Updater;

    // Start is called before the first frame update
    void Start()
    {
        Updater = GameObject.FindGameObjectWithTag("MainCamera").transform.GetChild(0).GetComponent<HealthUpdate> ();
        stats = this.transform.parent.transform.GetChild(0).GetComponent<EnemyStats> ();
        healthBar = this.transform.GetChild(0).GetComponent<Slider> ();
        fillBar = this.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<Image> ();
    }

    void FixedUpdate()
    {
         Updater.HeartUpdate(healthBar, fillBar, stats.maxHealth, stats.health, FullHp, HalfHp, QuartHp);
    }
}
