using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getPostcode : MonoBehaviour
{
  public InputField PostcodeInput;
        public Text text;
        //public bool alreadyName;
 
        // void Start()
        // {
         
 
        //     text.text = PlayerPrefs.GetString ("username");
        //     // PlayerPrefs.SetString ("username", inputField.text); 
 
        // }
 
        // public void SaveUsername(string username)
        // {
         
        //     text.text = inputField.text;
        //         PlayerPrefs.SetString ("username", inputField.text);
 
        // }

    // public void SetString()
    // {
    //     text.text = inputField.text;
    //     string postcodeText = text.ToString();
    //     PlayerPrefs.SetString("postcode", postcodeText);
    //     Debug.Log("postcode2", postcodeText);
    //     PlayerPrefs.Save();
    // }
    // public void GetString()
    // {
    //     string loadedString = PlayerPrefs.GetString("postcode");
    // // }
    // public void SetString(string KeyName, string Value)
    // {
    //     PlayerPrefs.SetString(KeyName, Value);
    // }

    public string GetInputString(string KeyName)
    {
        InputField inputField = PostcodeInput.GetComponent<InputField>();
        string value = inputField.text;
        Debug.Log("test" + value);
        // return PlayerPrefs.GetString(KeyName);
        PlayerPrefs.SetString("Postcode", value);
        PlayerPrefs.Save();
        return value;
    }
}
