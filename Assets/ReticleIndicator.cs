using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReticleIndicator : MonoBehaviour
{
    public TextMeshPro hintText;
    //public GameObject currentlyHovering = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        hintText.text = "Enter" + other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        hintText.text = "Nope";
    }

    private void OnTriggerStay(Collider other){
        hintText.text = "Stay" + other.name;
        //currentlyHovering = other.gameObject;
        if(name.Contains("Left"))
            PalletRackController.i.rayObjL = other.gameObject;
        else if(name.Contains("Right"))
            PalletRackController.i.rayObjR = other.gameObject;
    }
}
