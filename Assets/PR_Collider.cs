using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PR_Collider : MonoBehaviour
{
    public PR_Object pr_Object;
    //public string attachmentStatus;//none, preview, attached
    public Transform attachmentPoint;
    // public GameObject previewObj, attachedObj;

    // public TextMeshPro debugText;


    // Start is called before the first frame update
    public void Init(PR_Object pr_Obj)
    {
        //attachmentStatus = "none";
        pr_Object = pr_Obj;
        attachmentPoint = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Retire(){
        PR_Controller.i.prPreview.SetActive(false);
        gameObject.SetActive(false);
    }

}
