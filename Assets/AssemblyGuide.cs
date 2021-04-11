using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AssemblyGuide : MonoBehaviour
{
    public List<GameObject> Grabbables;
    public int currentState;

    private XRGrabInteractable XRGrabInteractableScript;

    private void Start()
    {
        currentState = 0;
    }

    private void Update()
    {
        foreach (GameObject step in Grabbables)
        {
            XRGrabInteractableScript = GetComponent<XRGrabInteractable>();

            XRGrabInteractableScript.enabled = true;
        }
        //for (int i = 0; i <= Grabbables.Count; i++)
        //{
        //    XRGrabInteractableScript = GetComponent<XRGrabInteractable>();

        //    XRGrabInteractableScript.enabled = true;
        //}
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("socket"))
        {
            currentState++;
        }
}


}
