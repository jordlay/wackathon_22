using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelOpener : MonoBehaviour
{
    public GameObject Panel;
    public void OpenPanel() {
       StartCoroutine(TimerCoroutine());
    }

    IEnumerator TimerCoroutine() {
         if (Panel != null) {
            // bool isActive = Panel.activeSelf;
            Panel.SetActive(true);
            yield return new WaitForSeconds(3.0f);
            // StartCoroutine(TimerCoroutine());
            Panel.SetActive(false);
        }
        // yield return new WaitForSeconds(5);
    }
}
