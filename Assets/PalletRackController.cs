using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalletRackController : MonoBehaviour
{
    //create a singleton of this script
    public static PalletRackController i;
    private void Awake()
    {
        if (i == null)
            i = this;
        else
            Destroy(this);
    }
    //public GameObject currentInteractingObject;
    public GameObject ogPalletRack;
    public GameObject reticleLeft, reticleRight;
    public GameObject rayObjL, rayObjR;//currently hovering object
    
    //public FadeMaterial fadeMaterialEnvironmentController;
    // Start is called before the first frame update
    void Start()
    {
        //fadeMaterialEnvironmentController.FadeSkybox(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
