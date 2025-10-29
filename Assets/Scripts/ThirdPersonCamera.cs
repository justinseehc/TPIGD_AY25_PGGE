using UnityEngine;

public static class GameConstants
{
    public static Vector3 CameraAngleOffset { get; set; }
    public static Vector3 CameraPositionOffset { get; set; }
    public static float Damping { get; set; }
}

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform mPlayer;
    TPCBase mThirdPersonCamera;

    // Get from Unity Editor
    public Vector3 mPositionOffset = new Vector3(0.0f, 2.0f, -2.5f);
    public Vector3 mAngleOffset = new Vector3(0.0f, 0.0f, 0.0f);
    
    [Tooltip("The damping factor to smooth the changes in position and rotation of the camera.")]
    public float mDamping = 1.0f;

    private void Start()
    {
        // Set the game constant parameters to the GameConstant
        GameConstants.Damping = mDamping;
        GameConstants.CameraPositionOffset = mPositionOffset;
        GameConstants.CameraAngleOffset = mAngleOffset;
        mThirdPersonCamera = new TPCTrack(transform, mPlayer);
    }

    private void LateUpdate()
    {
        mThirdPersonCamera.Update();
    }
}
