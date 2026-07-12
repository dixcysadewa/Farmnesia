using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 pos = target.position;
        pos.z = -10f;

        transform.position = pos;
    }
}