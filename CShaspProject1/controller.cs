using System;
using System.Collections.Generic;
using System.Linq;


namespace ControllerNamespace
{
    struct Element
    {
        public int key;
        public int mood;
        public string description;
    }
    public class Controller
    {
        public SortedList sortedElements = new SortedList<int, Element>();
        public void AddElement(Element element)
        {
            try
            {
                sortedElements.Add(element.key, element);
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception);
            }
        }

        public void RemoveElement(Element element)
        {
            try
            {
                sortedElements.Remove(element.key, element);
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception);
            }
        }
    }

}