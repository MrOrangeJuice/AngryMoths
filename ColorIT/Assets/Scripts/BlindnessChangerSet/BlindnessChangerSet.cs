using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindnessChangerSet : MonoBehaviour
{
    public bool showNormal = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform[] allChildren = GetComponentsInChildren<Transform>();
        foreach (Transform child in allChildren)
        {
            if (child.gameObject.name == "BlindnessChangerN")
            {
                child.gameObject.SetActive(showNormal);
            }

            // SetActive == false to remove the buttons on the side of the screen but without deleteing them
            child.gameObject.SetActive(false);
        }
    }
}
