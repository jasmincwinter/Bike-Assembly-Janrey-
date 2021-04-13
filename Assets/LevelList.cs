using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LevelList : MonoBehaviour
{
    public List<GameObject> Grababbles;
    public int CurrentState;

    private XRGrabInteractable Script_xRGrabInteractable;

    void Update()
    {
        for (int i = 0; i < Grababbles.Count; i++)
        {
            Grababbles[CurrentState].GetComponent<XRGrabInteractable>().enabled = true;
        }
    }
}
