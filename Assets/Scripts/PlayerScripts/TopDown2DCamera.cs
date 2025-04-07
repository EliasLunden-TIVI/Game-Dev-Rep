using UnityEngine;

public class TopDown2DCamera : MonoBehaviour
{
    [Header("Target Settings")]
    public Transform target;               // The object the camera follows

    [Header("Smoothing")]
    public float smoothSpeed = 0.1f;       // How smooth the camera follows

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
    }
}
