using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Calendar : MonoBehaviour
{
    public Text[] days;

    public Text monthText;

    private DateTime currDate;


    // Start is called before the first frame update
    void Start()
    {
        UpdateCalendar(DateTime.Now.Year, DateTime.Now.Month);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateCalendar(int year, int month)
    {
        DateTime temp = new DateTime(year, month, 1);
        
        currDate = temp;
        string monthDate = temp.ToString("MMMM") + " " + temp.Year.ToString();
        monthText.text = monthDate;
        int startDay = GetMonthStartDay(year,month)-2;
        int endDay = GetTotalNumberOfDays(year, month)+1;
        

        for(int i = 0; i < 42; i++)
        {
            if(i < startDay || i - startDay >= endDay)
            {
                days[i].text = "";
            }
            else
            {
                if (i - startDay <= 0)
                    days[i].text = "";
                else
                    days[i].text = (i - startDay).ToString();
            }
        }
        

        ///This just checks if today is on our calendar. If so, we highlight it in green
        if(DateTime.Now.Year == year && DateTime.Now.Month == month)
        {
            days[(DateTime.Now.Day - 1) + startDay].text = "T";
        }

    }

    int GetMonthStartDay(int year, int month)
    {
        DateTime temp = new DateTime(year, month, 1);

        //DayOfWeek Sunday == 0, Saturday == 6 etc.
        return (int)temp.DayOfWeek;
    }

    int GetTotalNumberOfDays(int year, int month)
    {
        return DateTime.DaysInMonth(year, month);
    }

    public void NextMonth()
    {
        currDate = currDate.AddMonths(1);
        UpdateCalendar(currDate.Year, currDate.Month);
    }

    public void PreviousMonth()
    {        
        currDate = currDate.AddMonths(-1);
        UpdateCalendar(currDate.Year, currDate.Month);

    }
}
