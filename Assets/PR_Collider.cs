using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PR_Collider : MonoBehaviour
{
    public PalletRackObject palletRackObject;
    public string attachmentStatus;//none, preview, attached
    public Transform attachmentPoint;
    public GameObject previewObj, attachedObj;

    public TextMeshPro debugText;


    // Start is called before the first frame update
    void Start()
    {
        attachmentStatus = "none";
        attachmentPoint = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HoveringSelf(){
        //set MeshRenderer's material color to red
        GetComponent<MeshRenderer>().material.color = Color.red;
        debugText.text = "hovering" + gameObject.name;
    }

    public void LeavingSelf(){
        //set MeshRenderer's material color to yellow
        GetComponent<MeshRenderer>().material.color = Color.yellow;
        debugText.text = "leaving" + gameObject.name;
    }

    public void SetAttachedObject(string _attachmentStatus){
        // if(attachmentStatus == _attachmentStatus)
        //     return;

        // if(attachmentStatus == "preview"){
        //     if(previewObj == null)
        //         previewObj = Instantiate(PalletRackController.i.palletrackPreviewObj, attachmentPoint.position, PalletRackController.i.ogPalletRack.transform.rotation);
        // }else if(attachmentStatus == "none"){
        //     if(previewObj != null){
        //         Destroy(previewObj);
        //     }
        //     if(attachedObj != null){
        //         Destroy(attachedObj);
        //     }
        // }

        // attachmentStatus = _attachmentStatus;
    }

}
