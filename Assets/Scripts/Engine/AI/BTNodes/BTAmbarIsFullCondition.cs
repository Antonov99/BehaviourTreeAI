using Atomic.AI;
using Blackboard = UnityEditor.Experimental.GraphView.Blackboard;

public class BTAmbarIsFullCondition : IBlackboardCondition
{
    public bool Invoke(IBlackboard blackboard)
    {
        blackboard.GetCharacter();
        return false;
    }
}
