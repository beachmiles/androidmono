namespace junit.framework
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::junit.framework.Protectable_))]
	public partial interface Protectable  : global::MonoJavaBridge.IJavaObject 
	{
		void protect();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.framework.Protectable))]
	internal sealed partial class Protectable_ : java.lang.Object, Protectable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Protectable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _protect31374;
		void junit.framework.Protectable.protect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.Protectable_._protect31374);
		}
		static Protectable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.Protectable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/Protectable"));
			global::junit.framework.Protectable_._protect31374 = @__env.GetMethodIDNoThrow(global::junit.framework.Protectable_.staticClass, "protect", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
