using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{

    public Text newText = null;

    public void SetText(string word) {

        newText.text = word;

    }
}
