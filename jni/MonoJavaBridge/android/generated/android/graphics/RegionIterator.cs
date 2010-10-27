namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RegionIterator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RegionIterator()
		{
			InitJNI();
		}
		protected RegionIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize5791;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RegionIterator._finalize5791);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RegionIterator.staticClass, global::android.graphics.RegionIterator._finalize5791);
		}
		internal static global::MonoJavaBridge.MethodId _next5792;
		public virtual bool next(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RegionIterator._next5792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RegionIterator.staticClass, global::android.graphics.RegionIterator._next5792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RegionIterator5793;
		public RegionIterator(android.graphics.Region arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RegionIterator.staticClass, global::android.graphics.RegionIterator._RegionIterator5793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.RegionIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/RegionIterator"));
			global::android.graphics.RegionIterator._finalize5791 = @__env.GetMethodIDNoThrow(global::android.graphics.RegionIterator.staticClass, "finalize", "()V");
			global::android.graphics.RegionIterator._next5792 = @__env.GetMethodIDNoThrow(global::android.graphics.RegionIterator.staticClass, "next", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.RegionIterator._RegionIterator5793 = @__env.GetMethodIDNoThrow(global::android.graphics.RegionIterator.staticClass, "<init>", "(Landroid/graphics/Region;)V");
		}
	}
}
