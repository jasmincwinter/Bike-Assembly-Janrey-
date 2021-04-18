using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class ListTrigger : MonoBehaviour
{
    public GameObject socket;
    private LevelList testScript;

    public XRGrabInteractable Script_xRGrabInteractable;
    public XRSocketInteractor Script_xRSocketInteractor;

    public GameObject ghostMesh;

    public GameObject boardCollider;

    public Text TextBoard;
    public GameObject InfoObject;
    public string textin;

    void Start()
    {
        testScript = FindObjectOfType<LevelList>();
        Script_xRGrabInteractable = GetComponent<XRGrabInteractable>();

        ghostMesh.GetComponent<MeshRenderer>().enabled= false;

        InfoObject.SetActive(false);

        TextBoard.GetComponent<Text>();
        InfoObject.GetComponent<Text>();
    }

    public void DisableSocket(Collider other)
    {
        testScript.CurrentState++;
    }

    IEnumerator coroutineD()
    {
        yield return new WaitForSeconds(1);
        Script_xRGrabInteractable.enabled = false;
        socket.gameObject.GetComponent<Collider>().enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == socket)
        {
            StartCoroutine(coroutineD());
        }

    }

    public void DisableWallSocket(Collider other)
    {
        testScript.CurrentState--;

        other.gameObject.GetComponent<Collider>().enabled = false;

    }

    public void DisableXRGrab()
    {
         Script_xRGrabInteractable.enabled = false;

        // infor object UI text = false
        InfoObject.SetActive(false);
        // change color of the name of the asset to gray
        TextBoard.color = Color.gray;
    }

    public void MeshGhost(SelectEnterEventArgs MeshEnableArgs)
    {
        if (MeshEnableArgs.interactor.tag == "hand" )
        {
            ghostMesh.GetComponent<MeshRenderer>().enabled = true;
        }

        //TextinfoDesciption.text = textin;
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

}

