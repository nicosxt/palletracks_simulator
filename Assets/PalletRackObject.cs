using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalletRackObject : MonoBehaviour
{
    private float snapRotationInterval = 15f;
    private float snapScaleInterval = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
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
}
