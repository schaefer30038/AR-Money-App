using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSize : MonoBehaviour
{

    public Text newText = null;

    public Transform needle;
    public int minAngle, maxAngle, angleDiff = 0;

    public void Awake()
    {
        minAngle = -141;
        maxAngle = 142;
        angleDiff = maxAngle - minAngle;
        needle.eulerAngles = new Vector3(0, 0, maxAngle);
    }



    public float newSize(float i)
    {
        return ((float)0.1) * i;
    }



    public void ModifySize(float value)
    {
        float size = newSize(value);
        transform.localScale = new Vector3(size, size, size);
    }


    public void ShowSize(float value)
    {
        newText.text = "Height: " + (10 * (transform.localScale.y)).ToString("F2") + "m";
    }


    public void AdjustSpeedometer(float scrollValue)
    {
        float addSpeed = scrollValue * angleDiff;
        needle.eulerAngles = new Vector3(0, 0, maxAngle - addSpeed);
    }


}
