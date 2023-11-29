using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalletRackController : MonoBehaviour
{
    public FadeMaterial fadeMaterialEnvironmentController;
    // Start is called before the first frame update
    void Start()
    {
        fadeMaterialEnvironmentController.FadeSkybox(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
