namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.reflect.InvocationHandler_))]
	public partial interface InvocationHandler  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object invoke(java.lang.Object arg0, java.lang.reflect.Method arg1, java.lang.Object[] arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.reflect.InvocationHandler))]
	internal sealed partial class InvocationHandler_ : java.lang.Object, InvocationHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InvocationHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _invoke21084;
		global::java.lang.Object java.lang.reflect.InvocationHandler.invoke(java.lang.Object arg0, java.lang.reflect.Method arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.InvocationHandler_._invoke21084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		static InvocationHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.InvocationHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/InvocationHandler"));
			global::java.lang.reflect.InvocationHandler_._invoke21084 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.InvocationHandler_.staticClass, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}
