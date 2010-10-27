namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.ActivityTestCase_))]
	public abstract partial class ActivityTestCase : android.test.InstrumentationTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ActivityTestCase()
		{
			InitJNI();
		}
		protected ActivityTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getActivity12124;
		protected virtual global::android.app.Activity getActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ActivityTestCase._getActivity12124)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ActivityTestCase.staticClass, global::android.test.ActivityTestCase._getActivity12124)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _setActivity12125;
		protected virtual void setActivity(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityTestCase._setActivity12125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityTestCase.staticClass, global::android.test.ActivityTestCase._setActivity12125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scrubClass12126;
		protected virtual void scrubClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityTestCase._scrubClass12126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityTestCase.staticClass, global::android.test.ActivityTestCase._scrubClass12126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ActivityTestCase12127;
		public ActivityTestCase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ActivityTestCase.staticClass, global::android.test.ActivityTestCase._ActivityTestCase12127);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ActivityTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ActivityTestCase"));
			global::android.test.ActivityTestCase._getActivity12124 = @__env.GetMethodIDNoThrow(global::android.test.ActivityTestCase.staticClass, "getActivity", "()Landroid/app/Activity;");
			global::android.test.ActivityTestCase._setActivity12125 = @__env.GetMethodIDNoThrow(global::android.test.ActivityTestCase.staticClass, "setActivity", "(Landroid/app/Activity;)V");
			global::android.test.ActivityTestCase._scrubClass12126 = @__env.GetMethodIDNoThrow(global::android.test.ActivityTestCase.staticClass, "scrubClass", "(Ljava/lang/Class;)V");
			global::android.test.ActivityTestCase._ActivityTestCase12127 = @__env.GetMethodIDNoThrow(global::android.test.ActivityTestCase.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ActivityTestCase))]
	internal sealed partial class ActivityTestCase_ : android.test.ActivityTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ActivityTestCase_()
		{
			InitJNI();
		}
		internal ActivityTestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ActivityTestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ActivityTestCase"));
		}
	}
}
