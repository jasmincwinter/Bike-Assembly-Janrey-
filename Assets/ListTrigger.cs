using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ListTrigger : MonoBehaviour
{
    public GameObject socket;
    //private Level_script LevelScript;
    //private NewScript NewScript_;

    private LevelList testScript;
    //private XRGrabInteractable Script_xRGrabInteractable;

    void Start()
    {
        testScript = FindObjectOfType<LevelList>();

        //Script_xRGrabInteractable = FindObjectOfType<XRGrabInteractable>();
    }


    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == socket)
        {
            Debug.Log("collider collider with socket");
            testScript.CurrentState++;
            //Script_xRGrabInteractable.enabled = false;
        }
    }
}

