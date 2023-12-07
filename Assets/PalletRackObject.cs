using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PalletRackObject : MonoBehaviour
{
    private float snapRotationInterval = 15f;
    private float snapScaleInterval = 0.2f;
    public GameObject currentlyHovering = null;//object currently hovered by ray selectors
    public TextMeshPro currentlyHoveringText;
    bool hoveringL, hoveringR;
    public GameObject previewObj;
    public List<PR_Collider> pr_Colliders = new List<PR_Collider>();

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //the rayObjR and rayObjL are always on since they're picked in OnTriggerStay
        //but currentlyHovering are nullified when hoveringL or hoveringR is false
        if(hoveringR && PalletRackController.i.rayObjR != null){
            currentlyHovering = PalletRackController.i.rayObjR;
        }else if(hoveringL && PalletRackController.i.rayObjL != null){
            currentlyHovering = PalletRackController.i.rayObjL;
        }else{
            currentlyHovering = null;
        }

        currentlyHoveringText.text = currentlyHovering == null ? "null" : currentlyHovering.name;

        //SET PREVIEW
        previewObj.SetActive(currentlyHovering != null);
        if(currentlyHovering){
            foreach(PR_Collider pr_Collider in pr_Colliders){
                if(pr_Collider.gameObject == currentlyHovering){
                    previewObj.transform.position = pr_Collider.attachmentPoint.position;
                }
            }
        }

        //transform.rotation = Quaternion.Euler(SnapToIntervalVec3(transform.rotation.eulerAngles, snapRotationInterval));
        //snap rotation only on y axis, keep x and z 0
        transform.rotation = Quaternion.Euler(0, SnapToInterval(transform.rotation.eulerAngles.y, snapRotationInterval), 0);
        //snap scale by 0.2
        transform.localScale = SnapToIntervalVec3(transform.localScale, snapScaleInterval);
    }

    Vector3 SnapToIntervalVec3(Vector3 value, float interval)
    {
        return new Vector3(SnapToInterval(value.x, interval), SnapToInterval(value.y, interval), SnapToInterval(value.z, interval));
    }

    float SnapToInterval(float value, float interval)
    {
        return Mathf.Round(value / interval) * interval;
    }

    public void LeftRayEnter(){
        //Debug.Log("LeftRayEnter");
        hoveringL = true;
    }

    public void LeftRayExit(){
        //Debug.Log("LeftRayExit");
        hoveringL = false;
    }

    public void RightRayEnter(){
        //Debug.Log("RightRayEnter");
        hoveringR = true;
    }

    public void RightRayExit(){
        //Debug.Log("RightRayExit");
        hoveringR = false;
    }
}
