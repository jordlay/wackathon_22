using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayBinTime : MonoBehaviour
{
    // Start is called before the first frame update
    private DateTime currentDate;

    private int daysUntilTuesday;
    private int daysUntilThursday; 

    public GameObject greenBin;
    public GameObject blackBin;


    public Text counterText;

    public Text RecycleFact;

    void Start()
    {
        DateTime today = DateTime.Today;
        daysUntilTuesday = ((int) DayOfWeek.Tuesday - (int) today.DayOfWeek + 7) % 7;

        daysUntilThursday = ((int) DayOfWeek.Thursday - (int) today.DayOfWeek + 7) % 7;
   
        if (daysUntilThursday < daysUntilTuesday)
        {
            if (daysUntilThursday == 1)
                counterText.text = "tomorrow";
            else if (daysUntilThursday == 0)
                counterText.text = "today";
            else
                counterText.text = daysUntilThursday.ToString();
            blackBin.SetActive(true);
            greenBin.SetActive(false);
        }
        else
        {
            if (daysUntilTuesday == 1)
                counterText.text = "tomorrow";
            else if (daysUntilTuesday == 0)
                counterText.text = "today";
            else
                counterText.text = daysUntilTuesday.ToString();
            blackBin.SetActive(false);
            greenBin.SetActive(true);
        }

        RecycleFact.text = RecyclingFacts.RecyclingFact;

    }

    // Update is called once per frame
    void Update()
    {

    }



    
}
