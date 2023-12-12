using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PR_RayInteractor : MonoBehaviour
{
    public TextMeshPro debugText;
    public string direction;
    public bool isStayingInObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnHoverEnter(){
        //this does not work for some reason
        debugText.text = "ENTER " + PalletRackController.i.raycastingObjL.name;
        //isStayingInObject = true;
    }
    public void OnHoverExit(){
        debugText.text = "EXIT " + PalletRackController.i.raycastingObjR.name;
        //isStayingInObject = false;
        if(direction == "L" && PalletRackController.i.raycastingObjL != null)
            PalletRackController.i.raycastingObjL = null;
        else if(direction == "R" && PalletRackController.i.raycastingObjR != null)
            PalletRackController.i.raycastingObjR = null;
    }

    public void OnSelectEntering(){
        debugText.text = "SelectEntering";
    }
    public void OnSelectExiting(){
        debugText.text = "SelectExiting";
    }
    public void OnUISelectEntering(){
        debugText.text = "UISelectEntering";
    }
    public void OnUISelectExiting(){
        debugText.text = "UISelectExiting";
    }
}
