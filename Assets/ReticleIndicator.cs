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
        //this does not work because i think the ReticleIndicator object
        //gets deleted / disabled before this can be called
        hintText.text = "Nope";
        if(other.gameObject == PalletRackController.i.raycastingObjL)
            PalletRackController.i.raycastingObjL = null;
        if(other.gameObject == PalletRackController.i.raycastingObjR){
            PalletRackController.i.raycastingObjR = null;
        }
    }

    private void OnTriggerStay(Collider other){
        hintText.text = "Stay" + other.name;
        //currentlyHovering = other.gameObject;
        if(name.Contains("Left"))
            PalletRackController.i.raycastingObjL = other.gameObject;
        else if(name.Contains("Right"))
            PalletRackController.i.raycastingObjR = other.gameObject;
    }
}
