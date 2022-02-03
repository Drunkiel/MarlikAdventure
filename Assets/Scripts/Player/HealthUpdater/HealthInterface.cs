using UnityEngine;
using UnityEngine.UI;
public interface HealthInterface {
    void HeartUpdate(Slider HealthBar, Image FillBar, float MaxHealth, float Health, Color FullHp, Color HalfHp, Color QuartHp);
}