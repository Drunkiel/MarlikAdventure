using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public GameObject Player;
    public Slider HealthBar;
    public Image FillBar;

    public Color FullHp, HalfHp, QuartHp;
    
    StatsController stats;
    public HealthUpdate Updater;
    
    // Start is called before the first frame update
    void Start()
    {
        stats = Player.GetComponent<StatsController> ();
    }

    void FixedUpdate()
    {
        Updater.HeartUpdate(HealthBar, FillBar, stats.maxHealth, stats.health, FullHp, HalfHp, QuartHp);
    }
}
