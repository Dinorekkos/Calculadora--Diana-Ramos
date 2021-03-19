using System.Collections;
using System.Collections.Generic;
public class TimeClass

{
    private float hour, minutes,seconds;

    public TimeClass (float aHour, float aMinutes, float aSeconds)
    {
        hour = aHour;
        minutes = aMinutes;
        seconds = aSeconds;
    }

public float GetTimeHour
{
    get{return hour;}
    set {hour = value;}
}

public float GetTimeMinutes
{
    get{return minutes;}
    set{minutes = value;}

}

public float GetTimeSeconds
{
    get{return seconds;}
    set {seconds = value;}
}



}
