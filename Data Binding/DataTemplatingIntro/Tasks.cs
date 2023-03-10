// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.ObjectModel;

namespace DataTemplatingIntro
{
    public class Tasks : ObservableCollection<TaskBase>
    {
        public Tasks()
        {
            Task ss = new Task("Node1", "Node1", 2, TaskType.Node) { X = 5,Y = 300 };
            ss.Items.Add(new Task("Node34", "Node34", 2, TaskType.Node) { X = 20, Y = 300 });
            ss.Items.Add(new TaskLine("Line", "Line", 2, TaskType.Line) { X = 10, Y = 200 });
            Add(ss);
            //Add(new TaskLine("Line", "Line", 2, TaskType.Line) { X =100,Y=200});
            //Add(new TaskLine("Line", "Line", 2, TaskType.Line));
            //Add(new Task("Laundry", "Do my Laundry", 2, TaskType.Home));
            //Add(new Task("Email", "Email clients", 1, TaskType.Work));
            //Add(new Task("Clean", "Clean my office", 3, TaskType.Work));
            //Add(new Task("Dinner", "Get ready for family reunion", 1, TaskType.Home));
            //Add(new Task("Proposals", "Review new budget proposals", 2, TaskType.Work));
        }
    }
}