﻿using BlazorState;
using LinkDotNet.KanbanBoard.Domain;
using LinkDotNet.KanbanBoard.Web;

namespace LinkDotNet.KanbanBoard.UI.Features
{
    public partial class GoalState
    {
        public class LoadGoalsAction : IAction
        {
        }

        public class AddGoalAction : IAction
        {
            public AddGoalAction(Goal goal)
            {
                Goal = goal;
            }

            public Goal Goal { get; }
        }

        public class ChangeGoalStatusAction : IAction
        {
            public string Id { get; }
            public GoalStatus NewStatus { get; }

            public ChangeGoalStatusAction(string id, GoalStatus newStatus)
            {
                Id = id;
                NewStatus = newStatus;
            }
        }
    }
}