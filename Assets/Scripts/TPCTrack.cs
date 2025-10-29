using UnityEngine;
using UnityEngine.Rendering;

public class TPCTrack : TPCBase // we reference TPCBase as the base script to use
{
    public TPCTrack(Transform cameraTransform, Transform playerTransform) 
        : base(cameraTransform, playerTransform)
    { }


    // Update is called once per frame
    public override void Update() // to inherit the Update from TPCBase 
    {
        //const float playerHeight = 2.0f;
        Vector3 targetPos = mPlayerTransform.position;
        targetPos.y += GameConstants.CameraPositionOffset.y;

        //targetPos.y += playerHeight;
        mCameraTransform.LookAt(targetPos);
    }
}
