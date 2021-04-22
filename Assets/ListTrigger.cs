using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
public class ListTrigger : MonoBehaviour
{
    public GameObject socket;
    public GameObject ghostMesh;
    private LevelList testScript;
    public XRGrabInteractable Script_xRGrabInteractable;
    public XRSocketInteractor Script_xRSocketInteractor;
    public GameObject boardCollider;
    public Text TextBoard;
    public GameObject InfoObject;
    public string textin;
    public GameObject congratsText;

    void Start()
    {
        testScript = FindObjectOfType<LevelList>();
        ghostMesh.GetComponent<MeshRenderer>().enabled = false;
        Script_xRGrabInteractable = GetComponent<XRGrabInteractable>();
        InfoObject.SetActive(true);
        TextBoard.GetComponent<Text>();
        InfoObject.GetComponent<Text>();
        congratsText.SetActive(false);
    }

    public void IncreaseCount(Collider other)
    {
        testScript.CurrentState++;
    }
    IEnumerator coroutineDelay()
    {
        yield return new WaitForSeconds(3);
        Script_xRGrabInteractable.enabled = false;
        socket.gameObject.GetComponent<Collider>().enabled = false; // Prevents from counting more than once.
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
        testScript.CurrentState--;
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
        InfoObject.GetComponent<Text>().text = textin;
        InfoObject.SetActive(true);
    }
    public void MeshGhostDisable(SelectExitEventArgs MeshDisableArgs)
    {
        if (MeshDisableArgs.interactor.tag == "hand")
        {
            ghostMesh.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    public void Congratulations()
    {
            congratsText.SetActive(true);
    }

}