using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public bool isFailed;
    public bool isWin;

    // Update is called once per frame
    private void Start()
    {
        isFailed = false;
        isWin = false;
    }

    private void Update()
    {
        if (isFailed == true)
        {
            EndMenu.instance.failedUI.SetActive(true);           
            Time.timeScale = 0f;
        }
        if (isWin == true)
        {
            EndMenu.instance.winUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

     void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Trigger!");
        if (collider.gameObject.tag == "Obstacle")
        {
            isFailed = true;
        }
        if (collider.gameObject.tag == "Win")
        {
            isWin = true;
        }
        if (collider.gameObject.tag == "Walls")
        {
            isFailed = true;
        }
    } 
}