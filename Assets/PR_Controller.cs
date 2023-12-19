using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PR_Controller : MonoBehaviour
{
    //create a singleton of this script
    public static PR_Controller i;
    private void Awake()
    {
        if (i == null)
            i = this;
        else
            Destroy(this);
    }
    //public GameObject currentInteractingObject;
    public List<PR_Object> prKids = new List<PR_Object>();
    public GameObject prPreview, prPrefab, prOriginal;
    public GameObject reticleLeft, reticleRight;
    public PR_RayInteractor rayInteractorL, rayInteractorR;
    public GameObject raycastingObjL, raycastingObjR;
    public GameObject hoveringPRCollider;
    private GameObject previousPRCollider;
    public PR_Collider hoveringPRColliderScript;
    
    //public FadeMaterial fadeMaterialEnvironmentController;
    // Start is called before the first frame update
    void Start()
    {
        //fadeMaterialEnvironmentController.FadeSkybox(true);
        prPreview.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //hoveringPRCollider is the final collider that is detected via hover
        if(raycastingObjL != null){
            hoveringPRCollider = raycastingObjL;
        }else if(raycastingObjR != null){
            hoveringPRCollider = raycastingObjR;
        }else{
            previousPRCollider = hoveringPRCollider = null;
            prPreview.SetActive(false);
        }

        if(hoveringPRCollider != null && previousPRCollider != hoveringPRCollider){
            hoveringPRColliderScript = hoveringPRCollider.GetComponent<PR_Collider>();
            if(hoveringPRColliderScript){
                prPreview.SetActive(true);
                //move prPreview to the location of hoveringPRCollider's script's attachmentPoint
                prPreview.transform.position = hoveringPRColliderScript.attachmentPoint.position;
            }
            previousPRCollider = hoveringPRCollider;
        }
        
    }

    public void AddPR(){
        //check if currentPreviewPR is null
        if(prPreview.activeSelf){

            //add a new palletrack at the location of currentPreviewPR
            GameObject newPR = Instantiate(prPrefab, prPreview.transform.position, prPreview.transform.rotation, prOriginal.transform);
            prKids.Add(newPR.GetComponent<PR_Object>());

            // foreach(PR_Collider pr_Collider in newPR.GetComponent<PR_Object>().pr_Colliders){
            //     prOriginal.GetComponent<XRBaseInteractable>().colliders.Add(pr_Collider.gameObject.GetComponent<Collider>());
            // }
            //retire the collider of currentPreviewPRCollider
            if(hoveringPRCollider && hoveringPRColliderScript)
               hoveringPRColliderScript.Retire();
        }
    }

    //check the state of rayInteractorL and rayInteractorR

}
