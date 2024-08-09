using System;
using Atomic.AI;
using Atomic.Extensions;
using Atomic.Objects;
using Engine.Functions;
using Unity.Mathematics;
using UnityEngine;

namespace Game.Engine
{
    [Serializable]
    public sealed class BTNode_MoveToTarget : BTNode
    {
        public override string Name => "Move To Target";

        [SerializeField, BlackboardKey]
        private int character;

        [SerializeField, BlackboardKey]
        private int target;

        [SerializeField, BlackboardKey]
        private int stoppingDistance;

        protected override BTState OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            var m_character = blackboard.GetCharacter();
            var m_target = blackboard.GetObject<IAtomicObject>(target);
            var m_stoppingDistance = blackboard.GetFloat(stoppingDistance);

            Transform characterTransform = m_character.Transform;
            Transform targetTransform = m_target.Get<Transform>(ObjectAPI.Transform);

            if(TargetIsReached.IsReached(characterTransform,targetTransform,m_stoppingDistance, out Vector3 direction))
                return BTState.SUCCESS;
            
            m_character.InvokeAction(ObjectAPI.MoveStepRequest,direction);
            return BTState.RUNNING;
        }
    }
}