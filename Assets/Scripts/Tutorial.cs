using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Tutorial : MonoBehaviour
{
    public GameObject InfoObject;


    private void Awake()
    {
        foreach (var part in FindObjectsOfType<ListTrigger>())
        {
            part.OnSelect += Part_OnSelect; 
        }    
    }

    private void Part_OnSelect(string description)
    {
        InfoObject.SetActive(true);
        InfoObject.GetComponent<Text>().text = description;
    }
}
