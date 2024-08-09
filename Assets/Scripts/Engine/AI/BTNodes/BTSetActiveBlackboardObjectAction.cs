using System;
using Atomic.AI;
using UnityEngine;

namespace Game.Engine
{
    [Serializable]
    public class BTSetActiveBlackboardObjectAction:IBlackboardAction
    {
        [BlackboardKey]
        [SerializeField] private int dialogKey;
        [SerializeField] private bool isActive;
        public void Invoke(IBlackboard blackboard)
        {
            blackboard.GetObject<GameObject>(dialogKey).SetActive(isActive);
        }
    }
}