using System;
using System.Collections.Generic;
using System.Linq;


namespace ControllerNamespace
{
    struct Element
    {
        private int key;
        private int mood;
        private string description;
        public Element(int key, int mood, int description)
        {
            this.key = key;
            this.mood = mood;
            this.description = description;
        }
        public int getKey()
        {
            return this.key;
        }
        public int getMood()
        {
            return this.mood;
        }
        public string getDescription()
        {
            return this.description;
        }
        public void setKey(int key)
        {
            this.key = key;
        }
        public void setMood(int mood)
        {
            this.mood = mood;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
    }
    public class Controller
    {
        public SortedList sortedElements = new SortedList<int, Element>();
        public void AddElement(Element element)
        {
            try
            {
                sortedElements.Add(element);
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
                sortedElements.Remove(element);
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception);
            }
        }

        public void editElement(Element element)
        {
            try
            {
                sortedElements.get
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}