using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public Transform camTransform;

    public Vector3 offset;

    public float smoothTime = 0.3f;

    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        offset = camTransform.position - target.position;
    }

    void LateUpdate()
    {
        Vector3 targetPos = target.position + offset;
        camTransform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }
}
