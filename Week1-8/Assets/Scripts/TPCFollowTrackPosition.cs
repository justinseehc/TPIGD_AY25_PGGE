using UnityEngine;
using PGGE;

public class TPCFollowTrackPosition : TPCFollow
{
    public TPCFollowTrackPosition(Transform cameraTransform, Transform playerTransform) : base(cameraTransform, playerTransform) { }
    public override void Update()
    {
        // create initial rotation quaternion based on camera angle offset
        // !! Quaternion is used for rotation related
        Quaternion initialRotation = Quaternion.Euler(GameConstants.CameraAngleOffset);

        // rotate camera to above initial rotation offset - damping/lerp
        mCameraTransform.rotation = Quaternion.RotateTowards(mCameraTransform.rotation, initialRotation, Time.deltaTime * GameConstants.Damping);

        // position tracking
        // !! base is used to call the direct parent script of this script so for this is the TPCFollow Update()
        base.Update();
    }
}
