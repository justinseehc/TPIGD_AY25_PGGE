using UnityEngine;

public abstract class TPCBase : MonoBehaviour // abstract is a special class used as a blueprint for other class
{
    protected Transform mCameraTransform;
    protected Transform mPlayerTransform;

    public Transform CameraTransform
    {
        get 
        { 
            return mCameraTransform; 
        }
    }

    public Transform PlayerTransform
    {
        get
        {
            return mPlayerTransform;
        }
    }

    public TPCBase(Transform cameraTransform, Transform playerTransform)
    {
        mCameraTransform = cameraTransform;
        mPlayerTransform = playerTransform;
    }

    public abstract void Update();
}
