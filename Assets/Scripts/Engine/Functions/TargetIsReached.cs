using Unity.Mathematics;
using UnityEngine;

namespace Engine.Functions
{
    public static class TargetIsReached
    {
        public static bool IsReached(Transform characterTransform, Transform targetTransform, float stoppingDistance,out Vector3 direction)
        {
            float3 distance = characterTransform.position - targetTransform.position;
            
            direction = -math.normalize(distance);
            
            return math.lengthsq(distance) <= stoppingDistance * stoppingDistance;
        }
    }
}