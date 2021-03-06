﻿using UnityEngine;
using System.Collections;

//Script originally from thegamecontriver.com
//Modified by me though!

public class DogControl : MonoBehaviour
{
    //flag to check if the user has tapped / clicked.
    //Set to true on click. Reset to false on reaching destination
    private bool flag = false;
    //destination point
    private Vector3 endPoint;
    //alter this to change the speed of the movement of player / gameobject
    public float duration = 50.0f;
    //vertical position of the gameobject
    private float yAxis;

    //Used to say which dog is controlled with which button of the mouse. 0 = left click, 1 = right click.
    public int mouseButton;

    void Start()
    {
        //save the y axis value of gameobject
        yAxis = gameObject.transform.position.y;
    }
        
    void Update()
    {

        //check if the screen is touched / clicked  
        if (Input.GetMouseButtonDown(mouseButton))
        {
            //declare a variable of RaycastHit struct
            RaycastHit hit;
            //Create a Ray on the tapped / clicked position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //for touch device

            //Check if the ray hits any collider
            if (Physics.Raycast(ray, out hit))
            {
                //set a flag to indicate to move the gameobject
                flag = true;
                //save the click / tap position
                endPoint = hit.point;
                //as we do not want to change the y axis value based on touch position, reset it to original y axis value
                endPoint.y = yAxis;
                //Debug.Log(endPoint);
            }

        }
        //check if the flag for movement is true and the current gameobject position is not same as the clicked / tapped position
        if (flag && !Mathf.Approximately(gameObject.transform.position.magnitude, endPoint.magnitude))
        { 
            //move the gameobject to the desired position
            //gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, endPoint, 1 / (duration * (Vector3.Distance(gameObject.transform.position, endPoint) )));
            gameObject.transform.position = Vector3.MoveTowards(transform.position, endPoint, Time.deltaTime * duration);
        }
        //set the movement indicator flag to false if the endPoint and current gameobject position are equal
        else if (flag && Mathf.Approximately(gameObject.transform.position.magnitude, endPoint.magnitude))
        {
            flag = false;
            //Debug.Log("I am here");
        }

    }
}