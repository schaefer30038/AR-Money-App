using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedText : MonoBehaviour
{

    public Text newText = null;
    GameObject fan;
    float spd;


    private void Awake()
    {
        fan = GameObject.FindGameObjectWithTag("Fan");
    }


    public void Start()
    {
        spd = fan.GetComponent<Fan_Rotation>().speedConstant;
        newText.text = "Rotational speed: " + Mathf.RoundToInt(spd);
    }
   


    public void TextChange(float value)
    {
        newText.text = "Rotational speed: " + Mathf.RoundToInt(spd*value);
    }

}
