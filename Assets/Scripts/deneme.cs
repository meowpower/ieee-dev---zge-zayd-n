using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class deneme : MonoBehaviour
{
    private TMP_Text xpText;
    private int xp ;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("sepet"))
        {
            xp++;
            xpText.SetText("XP : " + xp);
        }
        ChangXpText();
    }
    private void ChangXpText()
    {
        xpText.text = "XP : "+xp;
    }
}
