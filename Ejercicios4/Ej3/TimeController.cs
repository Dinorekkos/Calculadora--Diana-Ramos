using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    
    TimeClass timeController = new TimeClass (0,0,0);
    
    //public float newSeconds, newMinutes, newhours;
    public  float newTime = 60f;
    
    private float day;
    private GameObject clockHandHourMovement;
    private GameObject clockHandMinMovement;
    public Text newTXTtime;
    

     private void Awake() 
     {
        clockHandHourMovement = GameObject.FindGameObjectWithTag("HanHour");
        clockHandMinMovement = GameObject.FindGameObjectWithTag("HandMin");
        if (newTXTtime == null) newTXTtime = GetComponent<Text>(); 
    }

    void Update()
    {
        CountTime();
    }
    
    public void CountTime()
    {
        day += Time.deltaTime / newTime;

        float dayNormalized = day % 1f;
        float rotationsDay = 360f;

        clockHandHourMovement.gameObject.transform.eulerAngles = new Vector3(0,0, - dayNormalized * rotationsDay * 2f );

        float hoursInDay = 24f;
        clockHandMinMovement.gameObject.transform.eulerAngles = new Vector3(0,0, - dayNormalized * rotationsDay * hoursInDay);


        timeController.GetTimeHour = Mathf.Floor(dayNormalized * hoursInDay);

        float minutesInHour = 60f;
        timeController.GetTimeMinutes = Mathf.Floor(((dayNormalized * hoursInDay) % 1f) * minutesInHour);

        float secondsInMinutes = 60f;
        timeController.GetTimeSeconds = Mathf.Floor(((((dayNormalized * hoursInDay) % 1f) * minutesInHour) % 1f) * secondsInMinutes);

       newTXTtime.text = timeController.GetTimeHour + ":" + timeController.GetTimeMinutes + ":" +  timeController.GetTimeSeconds;
    }

    public void ShowTime()
    {
      Debug.Log(timeController.GetTimeHour + ":" + timeController.GetTimeMinutes + ":" +  timeController.GetTimeSeconds);
    }

    



}
