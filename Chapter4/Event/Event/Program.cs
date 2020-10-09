using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public delegate void MyEventHandler();
    class Button
    {
        public event MyEventHandler Push;

        public void OnPush()
        {
            if(Push != null)
            {
                Push();
            }
        }
    }

    class EventHandlerClass
    {
        public void MyMethod()
        {
            Console.WriteLine("EventHandlerClass.MyMethod() 호출");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Button btn = new Button();
            EventHandlerClass obj = new EventHandlerClass();
            btn.Push += new MyEventHandler(obj.MyMethod);
            btn.OnPush();
        }
    }
}
