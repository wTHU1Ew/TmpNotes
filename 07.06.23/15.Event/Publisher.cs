using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event15
{
    /*
     *             1st: 声明一个委托类型
     *                  该委托类型的名字是Handler，该委托类型的返回类型是void，该委托类型的访问修饰符是public,
     *                  同时，由于Handler是一个委托类型,签名为void Handler(int argv1, int argv2)，
     *                  所以该委托类型的实例化对象也是一个委托类型，该委托类型的实例化对象的签名也必须是void (int argv1, int argv2)
     *                  ！！！注意，我这里的签名定义省略掉了方法名，因为我认为《图解C#》笼统定义了整个签名要保持一致是错误的！！！
     */
    public delegate void Handler(int argv1, int argv2);
    class CustomPublisher //  C#中class的默认访问修饰符是internal，该发布者类是用的自定义委托类型而不是系统给的EventHandler
    {
        private static int i = 0;
        /*
         *            three ways to create an event statement
         *            2nd: 声明一个事件，事件的名字是OnChange，事件的类型是Handler，事件的访问修饰符是public
         *                 其中，该事件OnChange1的类型是Handler，而Handler是一个委托类型，所以该事件的实际返回类型是void
         *                 该事件OnChange1的签名为void (int argv1, int argv2)
        */
        public event Handler OnChange1;
        public event Handler OnChange2, OnChange3;
        public static event Handler StaticOnChange4;

        public void TryEvent()
        {
            do
            {
                i++;
                OnChange1(i, ++i);
            } while (i < 5);
        }
        
    }

    class ExtentionEventArgs : EventArgs
    {
        public string? Info
        {
            set; get;
        }
    }

    class StandardPublisher
    {
        private static int i = 0;
        public string str = $"StandardPublisher i: {i}";

        public event EventHandler OnChange = delegate { };
        public event EventHandler<ExtentionEventArgs> OnChange2 = delegate { };

        public void TryEvent()
        {
            do
            {
                str = $"StandardPublisher i: {i}";
                i++;
                ExtentionEventArgs extentionEventArgs = new ExtentionEventArgs();
                extentionEventArgs.Info = str;
                OnChange(this, EventArgs.Empty);
                OnChange2(this, extentionEventArgs);
                
            } while (i < 5);
        }
        
    }


}
