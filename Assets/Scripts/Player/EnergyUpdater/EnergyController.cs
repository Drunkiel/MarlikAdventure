using UnityEngine;
using UnityEngine.UI;

public class EnergyController : MonoBehaviour
{
    public Slider healthBar;
    public StatsController stats;

    // Update is called once per frame
    void Update()
    {
        EnergyControl();
    }

    void EnergyControl(){
        healthBar.maxValue = stats.maxEnergy;
        healthBar.value = stats.energy;
    }
}