using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using System;

public class ListTrigger : MonoBehaviour
{
    // Building the bike. 
    public GameObject socket;
    public GameObject ghostMesh;
    public XRGrabInteractable Script_xRGrabInteractable;
    public XRSocketInteractor Script_xRSocketInteractor;
    public GameObject boardCollider;

    // Events referenced in Tutorial script. 
    public event Action<string> OnSelect;
    public event Action OnDeselect; 

    // Tutorial. 
    private LevelList LevelListScript;
    public string textin;

    // Events referenced in BoardDisplay script.



    // Board display. 
    public Text TextBoard;
    public GameObject InfoObject;

    // Make child a ghost bike.
    public GameObject bikeParent;

    void Start()
    {
        LevelListScript = FindObjectOfType<LevelList>();
        ghostMesh.GetComponent<MeshRenderer>().enabled = false;
        Script_xRGrabInteractable = GetComponent<XRGrabInteractable>();
        InfoObject.SetActive(true);
        TextBoard.GetComponent<Text>();
        InfoObject.GetComponent<Text>();
    }

    public void IncreaseCount(Collider other)
    {
        LevelListScript.CurrentState++;
    }

    IEnumerator coroutineDelay()
    {
        yield return new WaitForSeconds(4);
        Script_xRGrabInteractable.enabled = false;
        socket.gameObject.GetComponent<Collider>().enabled = false; // Prevents from counting more than once.

        // Make red bike part a child of ghost bike so that they rotate together. 
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == socket)
        {
            StartCoroutine(coroutineDelay());
        }
        else if (other.gameObject == boardCollider)
        {
            StartCoroutine(coroutineDelay());
            TextBoard.color = Color.black;
            InfoObject.SetActive(false);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        StopCoroutine(coroutineDelay()); // Trying to prevent collider from being disabled. 
    }



    public void TextHover(HoverEnterEventArgs TextHoverArgs) // Talks only to hand, because socket is also similar interactor.
    {
        if (TextHoverArgs.interactor.tag == "hand")
        {
            TextBoard.color = Color.blue;
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
    public void TextHoverExit(HoverExitEventArgs TextHoverExitArgs)
    {
        if (TextHoverExitArgs.interactor.tag == "hand")
        {
            TextBoard.color = Color.black;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
;
    }
    public void DisableWallSocket(Collider other)
    {
        TextBoard.color = Color.black;
        LevelListScript.CurrentState--;
    }

    public void LastTextColour()
    {
        TextBoard.color = Color.black;
    }

    public void DisableXRGrab()
    {
        Script_xRGrabInteractable.enabled = false;
        InfoObject.SetActive(false);

        TextBoard.color = Color.red;
        transform.parent = bikeParent.transform;
    }
    // Just for last item.

    public void TextColour()
    {
        TextBoard.color = Color.red;
    }

    public void MeshGhost(SelectEnterEventArgs MeshEnableArgs)
    {
        if (MeshEnableArgs.interactor.tag == "hand")
        {
            ghostMesh.GetComponent<MeshRenderer>().enabled = true;
        }

        OnSelect?.Invoke(textin); 
    }

    public void MeshGhostDisable(SelectExitEventArgs MeshDisableArgs)
    {
        OnDeselect?.Invoke();


        if (MeshDisableArgs.interactor.tag == "hand")
        {
            ghostMesh.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}