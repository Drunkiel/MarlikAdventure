using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public GameObject Player;
    public Slider HealthBar;
    public Image FillBar;

    public Color FullHp, HalfHp, QuartHp;

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

        if(stats.Health <= stats.MaxHealth && stats.Health > stats.MaxHealth * 0.5f){
            FillBar.color = FullHp;
            print("a");

        } 
        if(stats.Health <= stats.MaxHealth * 0.5f && stats.Health > stats.MaxHealth * 0.25f){
            FillBar.color = HalfHp;
            print("b");

        }
        if(stats.Health <= stats.MaxHealth * 0.25f){
            FillBar.color = QuartHp;
            print("c");
        }
    }
}
