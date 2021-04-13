using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ListTrigger : MonoBehaviour
{
    public GameObject socket;
    private LevelList testScript;

    public XRGrabInteractable Script_xRGrabInteractable;
    public XRSocketInteractor Script_xRSocketInteractor;

    public Collider socketCollider; 



    void Start()
    {
        testScript = FindObjectOfType<LevelList>();
        Script_xRGrabInteractable = GetComponent<XRGrabInteractable>();
        //Script_xRSocketInteractor = GetComponent<XRSocketInteractor>();

        socketCollider = GetComponent<Collider>(); 
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == socket)
        {
            //testScript.CurrentState++;

            //if(Script_xRSocketInteractor.finalPosition)
            //{

            //}

            //other.gameObject.GetComponent<Collider>().isTrigger = false;

            // Disable collider from socket.  

            //socketCollider.enabled = false;


            //Script_xRSocketInteractor.enabled = false; 

            //Script_xRGrabInteractable.enabled = false;
        }
    }

    public void DisableSocket(Collider other)
    {
        testScript.CurrentState++;
        other.gameObject.GetComponent<Collider>().enabled = false;

    }

    public void DisableXRGrab()
    {
        Script_xRGrabInteractable.enabled = false;
    }
}

