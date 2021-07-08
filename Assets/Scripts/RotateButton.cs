using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateButton : MonoBehaviour
{
    public GameObject platform;

    //public float speed = 50.0f; 


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("hand"))
        {
            Debug.Log("Collided!");
            //platform.gameObject.transform.Rotate(Vector3.up * Time.deltaTime * 50);
            GameObject.Find("Platform").GetComponent<RotatePlatform>().enabled = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("hand"))
        {
            Debug.Log("Collided!");
            //platform.gameObject.transform.Rotate(Vector3.up * Time.deltaTime * 50);
            GameObject.Find("Platform").GetComponent<RotatePlatform>().enabled = false;
        }
    }
}
