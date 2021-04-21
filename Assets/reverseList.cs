using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class reverseList : MonoBehaviour
{
    public List<GameObject> ReverseGrababbles;
    public int RCurrentState;

    // Start is called before the first frame update

    //void Start()
    //{
    //    levelScript = FindObjectOfType<LevelList>();
    //}
    public void RL()
    {
        for (int i = 0; i < ReverseGrababbles.Count; i++)
        {
            ReverseGrababbles[RCurrentState].GetComponent<XRGrabInteractable>().enabled = true;
        }
    }
}
