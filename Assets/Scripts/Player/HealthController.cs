using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public GameObject Player;
    public Slider HealthBar;
    public Image FillBar;

    StatsController stats;
    
    // Start is called before the first frame update
    void Start()
    {
        stats = Player.GetComponent<StatsController> ();
    }

    void Update()
    {
        HeartUpdate();
    }

    public void HeartUpdate(){
        HealthBar.maxValue = stats.MaxHealth;
        HealthBar.value = stats.Health;

        // FillBar.color = Color.white;
    }
}
