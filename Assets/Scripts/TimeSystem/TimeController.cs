using UnityEngine;
using TMPro;

public class TimeController : MonoBehaviour
{
    public int countOfDays;
    public int countOfHours;
    public int gameTime;
    public float actualTime;

    public TMP_Text clockHour;

    StatsController stats;
    public LuckController luckController;

    void Start()
    {
        stats = GameObject.FindGameObjectWithTag("Player").GetComponent<StatsController> ();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
        UpdateClock();
    }

    void Timer(){
        actualTime += Time.deltaTime;

        //Minutes
        if(actualTime >= 10){
            gameTime += 10;
            actualTime = 0;
            stats.energy -= 10;
        }

        //Hours
        if(gameTime >= 60){
            gameTime -= 60;
            countOfHours++;
        }

        //Days
        if(countOfHours >= 24){
            countOfHours = 0;
            luckController.DrawLuck();
            countOfDays += 1;
        }
    }

    void UpdateClock(){
        string NewTime;

        if(gameTime == 0){
            NewTime = countOfHours.ToString() + "," + "00"; 
        }   else{
            NewTime = countOfHours.ToString() + "," + gameTime.ToString();
        }

        clockHour.text = NewTime;
    }

    public void SkipDay(){
        countOfHours += 9;
        stats.energy = stats.maxEnergy;
    }
}