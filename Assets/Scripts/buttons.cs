using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void HomeButtonClicked()
    {
        SceneManager.LoadScene("Homepage");
    }

    public void CalendarButtonClicked()
    {
        SceneManager.LoadScene("Calendar");
    }

    public void NewsfeedButtonClicked()
    {
        SceneManager.LoadScene("Newsfeed");
    }
    public void RecycleSearchButtonClicked()
    {
        SceneManager.LoadScene("RecycleSearch");
    }
    public void HelpButtonClicked()
    {
        SceneManager.LoadScene("Help");
    }
}
