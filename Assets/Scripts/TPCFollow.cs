using UnityEngine;

public abstract class TPCFollow : TPCBase
{
    public TPCFollow(Transform cameraTransform, Transform playerTransform)
        : base(cameraTransform, playerTransform);
    { }

    public override void Update()
    {
        
    }
}
