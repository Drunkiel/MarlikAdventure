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

    void FixedUpdate()
    {
        HeartUpdate();
    }

    public void HeartUpdate(){
        HealthBar.maxValue = stats.MaxHealth;
        HealthBar.value = stats.Health;

        if(stats.Health <= stats.MaxHealth * 1f){
            // FillBar.color = new Color(150f, 0.1f, 0f);
            FillBar.color = Color.red;

        }   else if(stats.Health <= stats.MaxHealth * 0.5f){
            // FillBar.color = new Color(216f, 123f, 0f);
            FillBar.color = Color.red * Color.yellow;

        }   else if(stats.Health <= stats.MaxHealth * 0.25f){
            FillBar.color = Color.yellow;
        }
    }
}
