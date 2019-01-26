using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SpotTracker : MonoBehaviour
{
    [SerializeField]private Camera cameraTracker;

    void Update()
    {
        Vector3 trackerPosition = cameraTracker.transform.position;
        trackerPosition.z = 0;
        transform.position = trackerPosition;
    }
}
