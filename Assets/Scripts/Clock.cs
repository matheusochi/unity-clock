using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    readonly float hoursToDegrees = -30;
    readonly float minutesToDegrees = -6;
    readonly float secondsToDegrees = -6;

    [SerializeField] Transform hoursPivot;
    [SerializeField] Transform minutesPivot;
    [SerializeField] Transform secondsPivot;
    
    
    void Update() {
        TimeSpan time = DateTime.Now.TimeOfDay;

        hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * (float) time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * (float) time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * (float) time.TotalSeconds);
    }
}

