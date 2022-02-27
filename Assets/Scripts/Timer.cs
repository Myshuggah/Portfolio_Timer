using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] int startingTime;
    [SerializeField] TextMeshProUGUI presentTimeText;

    float presentTime;
    bool timerisActive;
    
    

    // Start is called before the first frame update
    void Start()
    {
        presentTime = startingTime * 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerisActive == true)
        {
            presentTime = presentTime - Time.deltaTime;
            if(presentTime <= 0)
            {
                timerisActive = false;
                Start();
                Debug.Log("Timer is finished");
            }
        }
        TimeSpan time = TimeSpan.FromSeconds(presentTime);
        presentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString(); //used to be presentTime.ToString();
    }

    public void StartTimer()
    {
        timerisActive = true;
    }

    public void StopTimer()
    {
        timerisActive = false;
    }
}
