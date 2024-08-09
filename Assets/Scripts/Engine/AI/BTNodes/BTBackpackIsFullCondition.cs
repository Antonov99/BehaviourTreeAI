using Atomic.AI;
using Game.Engine;

namespace Engine.AI.BTNodes
{
    public class BTBackpackIsFullCondition: IBlackboardCondition
    {
        public bool Invoke(IBlackboard blackboard)
        {
            var character = blackboard.GetCharacter();
            return character.ResourceBag.IsFull();
        }
    }
}