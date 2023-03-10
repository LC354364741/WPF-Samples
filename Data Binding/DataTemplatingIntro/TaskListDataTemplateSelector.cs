// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Reflection;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;
using System.Windows.Data;

namespace DataTemplatingIntro
{
    public class DragItemConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            TaskBase val = value as TaskBase;
            if (val != null)
            {
                string sName = val.GetType().Name;

                Type t = Assembly.GetExecutingAssembly().GetType("DataTemplatingIntro." + sName);
                if (t != null)
                {
                    return Activator.CreateInstance(t);
                }
            }
            return value;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
    public class TaskListDataTemplateSelector : DataTemplateSelector
    {

        public DataTemplate NodeTemplate { get; set; }
        public DataTemplate ConnectorTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            TaskBase drag = (TaskBase)item;
            if (drag != null)
            {
                Type type = drag.GetType();
                PropertyInfo? info = type.GetProperty("TaskType");
                if (info != null && drag != null)
                {
                    if (info.GetValue(drag, null).ToString() == "Node")
                    {
                        return NodeTemplate;
                    }
                    else if (info.GetValue(drag, null).ToString() == "Line")
                    {
                        return ConnectorTemplate;
                    }
                }

            }
            return null;
        }
    }
}