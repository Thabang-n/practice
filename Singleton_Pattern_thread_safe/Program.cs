

using Singleton_Pattern_thread_safe;

var s1 = MySingletonClass.instance;
s1.Message();

var s2 = MySingletonClass.instance;
s2.Message();