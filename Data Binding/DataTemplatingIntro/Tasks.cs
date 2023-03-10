// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.ObjectModel;

namespace DataTemplatingIntro
{
    public class Tasks : ObservableCollection<TaskBase>
    {
        public Tasks()
        {
            Add(new Task("Node", "Node", 2, TaskType.Node) { X = 200, Y = 300 });
            Add(new TaskLine("Line", "Line", 2, TaskType.Line) { X =100,Y=200});
            //Add(new TaskLine("Line", "Line", 2, TaskType.Line));
            //Add(new Task("Laundry", "Do my Laundry", 2, TaskType.Home));
            //Add(new Task("Email", "Email clients", 1, TaskType.Work));
            //Add(new Task("Clean", "Clean my office", 3, TaskType.Work));
            //Add(new Task("Dinner", "Get ready for family reunion", 1, TaskType.Home));
            //Add(new Task("Proposals", "Review new budget proposals", 2, TaskType.Work));
        }
    }
}