//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using OVRTouchSample;


//public class VRRotateObject : MonoBehaviour
//{
//    [Header("Controller")]

//    if (controller && controller.activateAction.action.triggered)
//    })

//    public  grabButton;
//    public OVRInput.Button resetRotationButton;

//    [Header("Robot")]
//    public GameObject robot;

//    [Header("Activation Settings")]
//    public float activationDistance;

//    private Quaternion currentRot;
//    private Vector3 startPos;
//    private bool offsetSet;

//    private void Start()
//    {
//        offsetSet = false;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (OVRInput.Get(grabButton) && IsCloseEnough())
//            Rotate();
//        else
//            offsetSet = false;

//        if (OVRInput.GetDown(resetRotationButton))
//            robot.transform.eulerAngles = Vector3.zero;
//    }

//    void SetOffsets()
//    {
//        if (offsetSet)
//            return;

//        startPos = Vector3.Normalize(transform.position - robot.transform.position);
//        currentRot = robot.transform.rotation;

//        offsetSet = true;
//    }

//    void Rotate()
//    {
//        SetOffsets();

//        Vector3 closestPoint = Vector3.Normalize(transform.position - robot.transform.position);
//        robot.transform.rotation = Quaternion.FromToRotation(startPos, closestPoint) * currentRot;
//    }

//    bool IsCloseEnough()
//    {
//        if (Mathf.Abs(Vector3.Distance(transform.position, robot.transform.position)) < activationDistance)
//            return true;

//        return false;
//    }
//}
