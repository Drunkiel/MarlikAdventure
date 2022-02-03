using UnityEngine;
using UnityEngine.UI;

public class HealthUpdate : MonoBehaviour, HealthInterface
{
    public void HeartUpdate(Slider HealthBar, Image FillBar, float MaxHealth, float Health, Color FullHp, Color HalfHp, Color QuartHp){
        HealthBar.maxValue = MaxHealth;
        HealthBar.value = Health;

        if(Health <= MaxHealth && Health > MaxHealth * 0.5f){
            FillBar.color = FullHp;
        } 
        
        if(Health <= MaxHealth * 0.5f && Health > MaxHealth * 0.25f){
            FillBar.color = HalfHp;
        }

        if(Health <= MaxHealth * 0.25f){
            FillBar.color = QuartHp;
        }
    }
}
