using Atomic.AI;
using Game.Engine;
using Blackboard = UnityEditor.Experimental.GraphView.Blackboard;

public class BTAmbarIsFullCondition : IBlackboardCondition
{
    public bool Invoke(IBlackboard blackboard)
    {
        var barn = blackboard.GetBarn();
        return barn.Storage.IsFull();
    }
}
