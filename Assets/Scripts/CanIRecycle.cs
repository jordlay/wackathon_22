using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanIRecycle : MonoBehaviour
{
    public GameObject yesrecycle;
    public GameObject norecycle;

    public GameObject happyBarry;
    public GameObject sadBarry;

    public GameObject speechBubble;

    public InputField RecycleSearch;

    // Start is called before the first frame update
    void Start()
    {
        happyBarry.SetActive(false);
        sadBarry.SetActive(false);
        yesrecycle.SetActive(false);
        norecycle.SetActive(false);
        speechBubble.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetItemString()
    {
        InputField inputField = RecycleSearch.GetComponent<InputField>();
        string value = inputField.text;
        
        int pos = Array.IndexOf(RecycleDatabase.YesRecycle, value);
        if (pos > -1)
        {
            // the array contains the string and the pos variable
            happyBarry.SetActive(true);
            sadBarry.SetActive(false);
            yesrecycle.SetActive(true);
            norecycle.SetActive(false);
            speechBubble.SetActive(true);
        }
        else
        {
            happyBarry.SetActive(false);
            sadBarry.SetActive(true);
            yesrecycle.SetActive(false);
            norecycle.SetActive(true);
            speechBubble.SetActive(true);
            
        }
                
     

    }

}
