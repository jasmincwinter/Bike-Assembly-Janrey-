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
    public GameObject ghostMesh;

    //public GameObject asset; 



    void Start()
    {
        testScript = FindObjectOfType<LevelList>();
        Script_xRGrabInteractable = GetComponent<XRGrabInteractable>();
        //Script_xRSocketInteractor = GetComponent<XRSocketInteractor>();

        socketCollider = GetComponent<Collider>();

        ghostMesh.GetComponent<MeshRenderer>().enabled= false;
    }

    public void DisableSocket(Collider other)
    {
        testScript.CurrentState++;
        // Enable mesh renderer on ghost piece.


        other.gameObject.GetComponent<Collider>().enabled = false;

    }

    public void DisableXRGrab()
    {
            Script_xRGrabInteractable.enabled = false;
        //ghostMesh.GetComponent<MeshRenderer>().enabled = false;
    }

    public void MeshGhost(SelectEnterEventArgs MeshEnableArgs)
    {
        if (MeshEnableArgs.interactor.tag == "hand" )
        {
            ghostMesh.GetComponent<MeshRenderer>().enabled = true;
        }



    }

    public void MeshGhostDisable(SelectExitEventArgs MeshDisableArgs)
    {
        if (MeshDisableArgs.interactor.tag == "hand")
        {
            ghostMesh.GetComponent<MeshRenderer>().enabled = false;

        }


        //Script_xRGrabInteractable.enabled = false;
    }

    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject == socketCollider)
    //    {
    //        ghostMesh.GetComponent<MeshRenderer>().enabled = false;
    //    }
    //}
}

