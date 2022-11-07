using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject failedUI;
    public GameObject winUI;

    public static UI instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        failedUI.SetActive(false);
        winUI.SetActive(false);
    }
}