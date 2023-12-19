using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PR_Collider : MonoBehaviour
{
    public string colliderDirection;
    public string colliderOppositeDirection;
    public PR_Object pr_Object;
    //public string attachmentStatus;//none, preview, attached
    public Transform attachmentPoint;

    private bool enableRenderer = false;
    private bool inited = false;

    // Start is called before the first frame update
    public void Init(PR_Object pr_Obj)
    {
        colliderDirection = GetDirection();
        colliderOppositeDirection = GetOppositeDirection();
        //attachmentStatus = "none";
        if(GetComponent<Renderer>())
            GetComponent<Renderer>().enabled = enableRenderer;
        pr_Object = pr_Obj;
        attachmentPoint = transform.parent;
        inited = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Retire(PR_Object _newObject){
        //retire new object's opposite collider
        foreach(PR_Collider pr_Collider in _newObject.pr_Colliders){
            if(!pr_Collider.inited)
                pr_Collider.Init(_newObject);
            if(pr_Collider.colliderDirection == colliderOppositeDirection){
                pr_Collider.gameObject.SetActive(false);
            }
        }

        //retire this collider
        PR_Controller.i.prPreview.SetActive(false);
        gameObject.SetActive(false);
    }

    public string GetOppositeDirection(){
        switch(colliderDirection){
            case "Front":
                return "Back";
            case "Back":
                return "Front";
            case "Left":
                return "Right";
            case "Right":
                return "Left";
            case "Top":
                return "Bottom";
            case "Bottom":
                return "Top";
            default:
                return "null";
        }
    }

    public string GetDirection(){
        if(name.Contains("Front")){
            return "Front";
        }else if(name.Contains("Back")){
            return "Back";
        }else if(name.Contains("Left")){
            return "Left";
        }else if(name.Contains("Right")){
            return "Right";
        }else if(name.Contains("Top")){
            return "Top";
        }else if(name.Contains("Bottom")){
            return "Bottom";
        }else{
            return "null";
        }

    }

}
