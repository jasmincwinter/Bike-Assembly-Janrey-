using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Handpresence : MonoBehaviour
{
    public bool showcontroller = false;
    public InputDeviceCharacteristics controllercharacteristics;
    public List<GameObject> controllerPrefabs;
    public GameObject handmodelprefab;

    private InputDevice targetdevice;
    private GameObject spawnedcontroller;
    private GameObject spawnedhandmodel;
    private Animator handanimator;

    // Start is called before the first frame update
    private void Start()
    {
        tryinitialize();
    }

    private void tryinitialize()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllercharacteristics, devices);

        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        if (devices.Count > 0)
        {
            targetdevice = devices[0];
            GameObject prefab = controllerPrefabs.Find(controller => controller.name == targetdevice.name);
            if (prefab)
            {
                spawnedcontroller = Instantiate(prefab, transform);
            }
            else
            {
                Debug.Log("did not find the correct controller");
                spawnedcontroller = Instantiate(controllerPrefabs[0], transform);
            }

            spawnedhandmodel = Instantiate(handmodelprefab, transform);
            handanimator = spawnedhandmodel.GetComponent<Animator>();
        }
    }

    private void UpdateHandAnimator()
    {
        if (targetdevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            handanimator.SetFloat("trigger", triggerValue);
        }
        else
        {
            handanimator.SetFloat("trigger", 0);
        }

        if (targetdevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            handanimator.SetFloat("grip", gripValue);
        }
        else
        {
            handanimator.SetFloat("grip", 0);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (!targetdevice.isValid)
        {
            tryinitialize();
        }
        else
        {
            if (showcontroller)
            {
                spawnedhandmodel.SetActive(false);
                spawnedcontroller.SetActive(true);
            }
            else
            {
                spawnedhandmodel.SetActive(true);
                spawnedcontroller.SetActive(false);
                UpdateHandAnimator();
            }
        }
    }
}