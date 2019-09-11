using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClampName : MonoBehaviour
{

    public Image label;
    public float yValue;
    public float scrollValue;

    GameObject robot;

    public void GetValue(float value)
    {
        scrollValue = value;
    }

    public void GetHeight(float value)
    {
        robot = GameObject.FindGameObjectWithTag("RobotKyle");
        yValue = this.transform.position.y;
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position + new Vector3(1f, 1f, 0) );
        //namePos.y = yValue;
        //namePos.y = yValue * scrollValue;
        //this.transform.position = namePos;
        label.transform.position = namePos;

    }



}
