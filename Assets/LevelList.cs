using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
public class LevelList : MonoBehaviour
{
    public List<GameObject> Grababbles;
    public int CurrentState;
    private XRGrabInteractable Script_xRGrabInteractable;
    public Text stateCount;

    //public Text TextBoard;
    void Start()
    {
        //TextBoard.GetComponent<Text>();
        stateCount.enabled = true;
    }
    void Update()
    {
        for (int i = 0; i < Grababbles.Count; i++)
        {
            Grababbles[CurrentState].GetComponent<XRGrabInteractable>().enabled = true;
        }
        stateCount.text = "Count: " + CurrentState;
    }
}