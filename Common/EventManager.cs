using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace ColorBall.Mod.Common
{
	public class EventManager
	{
        private Dictionary<string, List<Action<DataArgs>>> eventsDict = new Dictionary<string, List<Action<DataArgs>>>();
        private static EventManager instance = null;
        public static EventManager Instance
        {
            get
            {
                if(instance == null) 
                {
                    instance = new EventManager();
                }
                return instance;
            }
        }


        public void AddEventListener(string eventName, Action<DataArgs> func)
        {
            if (eventsDict.ContainsKey(eventName) && eventsDict[eventName].Contains(func))
            {
                Debug.WriteLine("event aready exist eventName=" + eventName + ", func=" + func.Method.Name);
                return;
            }
            if (!eventsDict.ContainsKey(eventName))
            { 
                eventsDict.Add(eventName, new List<Action<DataArgs>>());
            }
            List<Action<DataArgs>> list = eventsDict[eventName];
            list.Add(func);
        }


        public void RemoveEventListenter(string eventName, Action<DataArgs> func)
        {
            if (!eventsDict.ContainsKey(eventName)) { return; }
            eventsDict[eventName].Remove(func);
        }


        public void EventFire(string eventName, DataArgs arg)
        {
            if (!eventsDict.ContainsKey(eventName))
            {
                Debug.WriteLine("event doesn't add yet! eventName=" + eventName);
                return;
            }
            List<Action<DataArgs>> list = eventsDict[eventName];
			for (int i = 0; i < list.Count; i++)
			{
                list[i](arg);
			}
        }


	}
}
