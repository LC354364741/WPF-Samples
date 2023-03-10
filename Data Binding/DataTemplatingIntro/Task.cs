// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DataTemplatingIntro
{
    public class TaskBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        protected void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    

    }
    public class Task : TaskBase
    {
        private string _description;
        private string _name;
        private double _x =200;
        private double _y=300;

        private int _priority;
        private TaskType _type;
        
        public Task()
        {
            _type = TaskType.Node;
        }
        private ObservableCollection<TaskBase> items;

        public ObservableCollection<TaskBase> Items
        {
            get {
                if(items==null)
                    items = new ObservableCollection<TaskBase>();   
                return items; }
            set
            {
                items = value;
                OnPropertyChanged("Items");
            }
        }

        public Task(string name, string description, int priority, TaskType type)
        {
            _name = name;
            _description = description;
            _priority = priority;
            _type = type;
        }
        public string TaskName
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("TaskName");
            }
        }
        public double X
        {
            get { return _x; }
            set
            {
                _x = value;
                OnPropertyChanged("X");
            }
        }
        public double Y
        {
            get { return _y; }
            set
            {
                _y = value;
                OnPropertyChanged("Y");
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }

        public int Priority
        {
            get { return _priority; }
            set
            {
                _priority = value;
                OnPropertyChanged("Priority");
            }
        }

        public TaskType TaskType
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("TaskType");
            }
        }
        public override string ToString() => _name;


    }
    public class TaskLine : TaskBase
    {
        private string _description;
        private string _name;
        private double _x = 200;
        private double _y = 300;

        private int _priority;
        private TaskType _type;

        public TaskLine()
        {
            _type = TaskType.Line;
        }

        public TaskLine(string name, string description, int priority, TaskType type)
        {
            _name = name;
            _description = description;
            _priority = priority;
            _type = type;
        }
        public string TaskName
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("TaskName");
            }
        }
        public double X
        {
            get { return _x; }
            set
            {
                _x = value;
                OnPropertyChanged("X");
            }
        }
        public double Y
        {
            get { return _y; }
            set
            {
                _y = value;
                OnPropertyChanged("Y");
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }

        public int Priority
        {
            get { return _priority; }
            set
            {
                _priority = value;
                OnPropertyChanged("Priority");
            }
        }

        public TaskType TaskType
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("TaskType");
            }
        }

        public override string ToString() => _name;
    }
}