using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PR_RayInteractor : MonoBehaviour
{
    public TextMeshPro debugText;
    public string direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnHoverEnter(){
        debugText.text = "ENTER";
        // if(PalletRackController.i.rayObjL != null)
        //     debugText.text = "ENTER " + PalletRackController.i.rayObjL.name;
        //     else
        //     debugText.text = "null";
    }
    public void OnHoverExit(){
        debugText.text = "EXIT " + PalletRackController.i.rayObjL.name;
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
