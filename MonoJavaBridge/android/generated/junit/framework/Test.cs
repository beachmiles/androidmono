namespace junit.framework
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::junit.framework.Test_))]
	public partial interface Test  : global::MonoJavaBridge.IJavaObject 
	{
		void run(junit.framework.TestResult arg0);
		int countTestCases();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.framework.Test))]
	internal sealed partial class Test_ : java.lang.Object, Test
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Test_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run31375;
		void junit.framework.Test.run(junit.framework.TestResult arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.Test_._run31375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countTestCases31376;
		int junit.framework.Test.countTestCases()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.Test_._countTestCases31376);
		}
		static Test_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.Test_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/Test"));
			global::junit.framework.Test_._run31375 = @__env.GetMethodIDNoThrow(global::junit.framework.Test_.staticClass, "run", "(Ljunit/framework/TestResult;)V");
			global::junit.framework.Test_._countTestCases31376 = @__env.GetMethodIDNoThrow(global::junit.framework.Test_.staticClass, "countTestCases", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}
