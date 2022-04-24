using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Slider HealthBar;
    public Image FillBar;

    public Color FullHp, HalfHp, QuartHp;
    
    public StatsController stats;
    public HealthUpdate updater;

    void FixedUpdate()
    {
        updater.HeartUpdate(HealthBar, FillBar, stats.maxHealth, stats.health, FullHp, HalfHp, QuartHp);
    }
}