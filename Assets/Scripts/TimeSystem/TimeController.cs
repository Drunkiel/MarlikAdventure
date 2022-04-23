using UnityEngine;

public class TimeController : MonoBehaviour
{
    public int countOfDays;
    public int gameTime;
    public float actualTime;

    StatsController stats;

    // Update is called once per frame
    void Update()
    {
        Timer();
        stats = GameObject.FindGameObjectWithTag("Player").GetComponent<StatsController> ();
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
            gameTime += 100;
        }

        //Days
        if(gameTime >= 2400){
            countOfDays += 1;
            gameTime = 0;
        }
    }

    public void SkipDay(){
        gameTime += 900;
        stats.energy = stats.maxEnergy;
    }
}
