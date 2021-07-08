using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateButtonReverse : MonoBehaviour
{
    public GameObject platform;
    public float speed = 50.0f;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("hand"))
        {
            GameObject.Find("Platform").GetComponent<RotatePlatformOpposite>().enabled = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("hand"))
        {
            GameObject.Find("Platform").GetComponent<RotatePlatformOpposite>().enabled = false;
        }
    }
}
