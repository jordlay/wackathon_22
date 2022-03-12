using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void HomeButtonClicked()
    {
        SceneManager.LoadScene("Homepage");
        Debug.Log("HOME");
    }

    public void CalendarButtonClicked()
    {
        SceneManager.LoadScene("Calendar");
        Debug.Log("CALENDAR");
    }

    public void NewsfeedButtonClicked()
    {
        SceneManager.LoadScene("Newsfeed");
        Debug.Log("NEWSFEED");
    }
    public void RecycleSearchButtonClicked()
    {
        SceneManager.LoadScene("RecycleSearch");
        Debug.Log("RECYABLE");
    }
    public void HelpButtonClicked()
    {
        SceneManager.LoadScene("Help");
        Debug.Log("HELP");
    }
}
