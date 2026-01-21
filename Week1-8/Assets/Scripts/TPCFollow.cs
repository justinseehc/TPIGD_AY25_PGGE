using UnityEngine;
using PGGE;

public abstract class TPCFollow : TPCBase
{
    public TPCFollow(Transform cameraTransform, Transform playerTransform) : base(cameraTransform, playerTransform)
    { }

    public override void Update()
    {
        // forward, up, right vectors for the camera
        Vector3 forward = mCameraTransform.rotation * Vector3.forward;
        Vector3 right = mCameraTransform.rotation * Vector3.right;
        Vector3 up = mCameraTransform.rotation * Vector3.up;

        // offset int the camera's coordinate
        // calculate targetPos
        Vector3 targetPos = mPlayerTransform.position;

        // add offset
        Vector3 desiredPosition = targetPos + forward * GameConstants.CameraPositionOffset.z
            + right * GameConstants.CameraPositionOffset.x + up * GameConstants.CameraPositionOffset.y;

        // change the position
        Vector3 position = Vector3.Lerp(mCameraTransform.position, desiredPosition, Time.deltaTime * GameConstants.Damping);
        mCameraTransform.position = position;
    }
}
