using System;
using Atomic.AI;
using Atomic.Extensions;
using Atomic.Objects;
using UnityEngine;

namespace Game.Engine
{
    [Serializable]
    public sealed class BTNode_UnloadResources : BTNode
    {
        public override string Name => "Unload Resources";
        
        protected override BTState OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            var targetStorage = blackboard.GetBarn().Storage;
            var character = blackboard.GetCharacter();
            var characterStorage = character.ResourceBag;

            var amount = characterStorage.ExtractAllResources();
            targetStorage.PutResources(amount);

            return BTState.SUCCESS;
        }
    }
}