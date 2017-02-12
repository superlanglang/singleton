using System;

//约束该类型必须是class，而且必须有一个不带参的构造函数。
public class Singleton<T> where T : class,new()
{
    private static T mInstance;
    public static T Instance
    {
        get
        {
            if (mInstance == null)
            {
                mInstance = Activator.CreateInstance<T>();
            }
            return mInstance;
        }
    }

    protected Singleton()
    {

    }
}
