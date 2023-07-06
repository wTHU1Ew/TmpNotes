using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event15
{
    internal class Subscriber
    {
        /*
         *          3rd: 订阅事件
         */
        public void D(CustomPublisher customPublisher)
        {
            customPublisher.OnChange1 += HandlerMethod1;
            customPublisher.OnChange1 += HandlerMethod1;
            customPublisher.OnChange1 += HandlerMethod2;
            customPublisher.OnChange1 -= HandlerMethod1;
        }
        /*
         *           4th: 声明几个方法，方法的名字是HandlerMethod1，HandlerMethod2，方法的返回类型是void，方法的访问修饰符是public
         *                该方法是用来订阅事件的
         */
        public void HandlerMethod1(int argv1, int argv2)
        {
            Console.WriteLine("Subscriber.HandlerMethod1: {0} + {1} = {2}", argv1, argv2, argv1 + argv2);
        }
        public void HandlerMethod2(int argv1, int argv2)
        {
            Console.WriteLine("Subscriber.HandlerMethod: {0} * {1} = {2}", argv1, argv2, argv1 * argv2);
        }
    }

    internal class StandardSubscriber
    {
        private string s = "";
        public StandardSubscriber(StandardPublisher standardPublisher)
        {
            s = standardPublisher.str;
            standardPublisher.OnChange += HandlerMethod1;
        }

        public void UseExtention(StandardPublisher standardPublisher)
        {
            s = standardPublisher.str;
            standardPublisher.OnChange2 += HandlerMethod2;
        }

        void HandlerMethod1(object? sender, EventArgs e)
        {
            Console.WriteLine(s);
        }
        void HandlerMethod2(object? sender, ExtentionEventArgs e)
        {
            Console.WriteLine(e.Info);
        }
    }
}
