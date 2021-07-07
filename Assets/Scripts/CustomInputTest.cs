using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CustomInputTest : XRGrabInteractable
{

    Vector3 mPrevPos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero;

    public GameObject cube; 

    private CustomActionBasedController controller;

    private void Update()
    {
        if(/*controller*/  controller.primaryButtonAction.action.triggered)
        {
            Debug.Log("A button pressed"); 
            //mPosDelta = selectingInteractor.transform.position - mPrevPos;
            //transform.Rotate(transform.up, -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);

            cube.transform.Rotate(Vector3.up * 50.0f * Time.deltaTime);
        }

        //mPrevPos = selectingInteractor.transform.position;
    }

    protected override void Grab()
    {
        controller = selectingInteractor.GetComponent<CustomActionBasedController>();
        if (controller)
        {
            Debug.Log("Controller!!!!!! : " + controller.name);
        }

        base.Grab();
    }

    protected override void Drop()
    {
        controller = null;
        base.Drop();
    }
}
