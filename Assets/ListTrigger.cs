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
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
    public GameObject boardCollider;
    public Text TextBoard;
    public GameObject InfoObject;
    public string textin;
<<<<<<< Updated upstream


=======
>>>>>>> Stashed changes
    void Start()
    {
        testScript = FindObjectOfType<LevelList>();
        ghostMesh.GetComponent<MeshRenderer>().enabled = false;
        Script_xRGrabInteractable = GetComponent<XRGrabInteractable>();
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
        InfoObject.SetActive(false);
        TextBoard.GetComponent<Text>();
        InfoObject.GetComponent<Text>();
    }
    public void IncreaseCount(Collider other)
<<<<<<< Updated upstream
    { 
        testScript.CurrentState++;
    }

=======
    {
        testScript.CurrentState++;
    }
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
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

=======
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
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream


    public void DisableXRGrab()
    {
         Script_xRGrabInteractable.enabled = false;

        InfoObject.SetActive(false);

        TextBoard.color = Color.red;
    }

    // Just for last item. 
=======
    public void DisableXRGrab()
    {
        Script_xRGrabInteractable.enabled = false;
        InfoObject.SetActive(false);
        TextBoard.color = Color.red;
    }
    // Just for last item.
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream

        InfoObject.GetComponent<Text>().text = textin; 
=======
        InfoObject.GetComponent<Text>().text = textin;
>>>>>>> Stashed changes
        InfoObject.SetActive(true);
    }
    public void MeshGhostDisable(SelectExitEventArgs MeshDisableArgs)
    {
        if (MeshDisableArgs.interactor.tag == "hand")
        {
            ghostMesh.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
