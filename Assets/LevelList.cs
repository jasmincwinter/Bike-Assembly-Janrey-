using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
public class LevelList : MonoBehaviour
{
    public List<GameObject> Grababbles;
    public int CurrentState;
    private XRGrabInteractable Script_xRGrabInteractable;
<<<<<<< Updated upstream

    public Text stateCount; 

=======
    public Text stateCount;
>>>>>>> Stashed changes
    //public Text TextBoard;
    void Start()
    {
        //TextBoard.GetComponent<Text>();
<<<<<<< Updated upstream

        stateCount.enabled = true; 
=======
        stateCount.enabled = true;
>>>>>>> Stashed changes
    }
    void Update()
    {
        for (int i = 0; i < Grababbles.Count; i++)
        {
            Grababbles[CurrentState].GetComponent<XRGrabInteractable>().enabled = true;
        }
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
        stateCount.text = "Count: " + CurrentState;
    }
}