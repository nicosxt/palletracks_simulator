using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PR_Collider : MonoBehaviour
{
    //public PalletRackObject palletRackObject;
    //public string attachmentStatus;//none, preview, attached
    public Transform attachmentPoint;
    // public GameObject previewObj, attachedObj;

    // public TextMeshPro debugText;


    // Start is called before the first frame update
    void Start()
    {
        //attachmentStatus = "none";
        attachmentPoint = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
