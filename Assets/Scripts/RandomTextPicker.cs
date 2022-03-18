using UnityEngine;
using UnityEngine.UI;

public class RandomTextPicker : MonoBehaviour
{   
    public string[] PlayerDeathTexts;
    public string[] BossDeathTexts;

    public void RandomPick(Text UIText, bool Player){

        if(Player){

            float RanNum = Mathf.Round(Random.Range(0, PlayerDeathTexts.Length));
            UIText.text = PlayerDeathTexts[(int)RanNum];
        }   else{

            float RanNum = Mathf.Round(Random.Range(0, BossDeathTexts.Length));
            UIText.text = BossDeathTexts[(int)RanNum];
        }
    }
}
