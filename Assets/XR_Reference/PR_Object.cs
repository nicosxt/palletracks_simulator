using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PR_Object : MonoBehaviour
{
    public bool isOriginal = false;
    public Transform followTransform;
    private float snapRotationInterval = 15f;
    private float snapScaleInterval = 0.2f;
    public TextMeshPro currentlyHoveringText;
    public List<PR_Collider> pr_Colliders = new List<PR_Collider>();

    void Start(){
        foreach(PR_Collider pr_Collider in pr_Colliders){
            pr_Collider.Init(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentlyHoveringText.text = PR_Controller.i.hoveringPRCollider == null ? "null" : PR_Controller.i.hoveringPRCollider.name;

        if(isOriginal){
            //transform.rotation = Quaternion.Euler(SnapToIntervalVec3(transform.rotation.eulerAngles, snapRotationInterval));
            //snap rotation only on y axis, keep x and z 0
            transform.rotation = Quaternion.Euler(0, SnapToInterval(transform.rotation.eulerAngles.y, snapRotationInterval), 0);
            //snap scale by 0.2
            transform.localScale = SnapToIntervalVec3(transform.localScale, snapScaleInterval);
        }

        if(followTransform != null && isOriginal){
            transform.position = followTransform.position;
            transform.rotation = followTransform.rotation;
            //set the transform's scale offset to followTransform's scale offset
            transform.localScale = followTransform.localScale;
        }

    }

    //if SelectionEnd is called within 0.5s of SelectionStart, then trigger OnSelect
    bool selectionStart = false;
    // public void OnSelect(){
    //     //remove attaching colliders
    //     //disable prPreview in PR_Controller
    //     PR_Controller.i.AddPR();
    // }

    public void SelectionStart(){
        selectionStart = true;
        StartCoroutine(SelectionStartCoroutine());
    }

    public void SelectionEnd(){
        selectionStart = false;
    }

    IEnumerator SelectionStartCoroutine(){

        //log that coroutine is called
        //PR_Controller.i.debugText.text += "selection coroutine\n" + gameObject.name;

        yield return new WaitForSeconds(0.5f);
        if(!selectionStart){
            PR_Controller.i.AddPR();
        }
    }

    Vector3 SnapToIntervalVec3(Vector3 value, float interval)
    {
        return new Vector3(SnapToInterval(value.x, interval), SnapToInterval(value.y, interval), SnapToInterval(value.z, interval));
    }

    float SnapToInterval(float value, float interval)
    {
        return Mathf.Round(value / interval) * interval;
    }
}
