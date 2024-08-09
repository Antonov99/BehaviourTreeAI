using System;
using Atomic.AI;
using Atomic.Extensions;
using Engine.Functions;
using Game.Engine;
using UnityEngine;

namespace Engine.AI.BTNodes
{
    [Serializable]
    public sealed class BTNode_ExtractResource : BTNode
    {
        public override string Name => "Extract Resource";

        [SerializeField, BlackboardKey]
        private int minDistance;

        protected override BTState OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            var character = blackboard.GetCharacter();
            var resource = blackboard.GetTargetResource();
            var distance = blackboard.GetFloat(minDistance);

            if (resource.Get<ResourceStorage>(ObjectAPI.ResourceStorage).IsEmpty())
            {
                Debug.Log("Extracted");
                return BTState.SUCCESS;
            }
            
            if (character.ResourceBag.IsFull())
            {
                Debug.Log("Backpack is full");
                return BTState.SUCCESS;
            }

            if (!TargetIsReached.IsReached(
                    character.Transform, 
                    resource.Get<Transform>(ObjectAPI.Transform),
                    distance,
                    out Vector3 direction))
            {
                Debug.Log("Not reached");
                return BTState.FAILURE;
            }

            Debug.Log("Invoking");
            character.InvokeAction(ObjectAPI.GatherRequest);
            
            return BTState.RUNNING;
        }
    }
}