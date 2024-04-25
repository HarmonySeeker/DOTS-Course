using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;

public partial struct HandleCubesSystem : ISystem
{
    public void OnUpdate (ref SystemState state)
    {
        foreach (RotatingMovingCubeAspect rotatingMovingCubeAspect in
            SystemAPI.Query<RotatingMovingCubeAspect>())
        {
            rotatingMovingCubeAspect.MoveAndRotate(SystemAPI.Time.DeltaTime);
        }
    }
}
