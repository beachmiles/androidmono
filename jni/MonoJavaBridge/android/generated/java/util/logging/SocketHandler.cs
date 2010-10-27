namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SocketHandler : java.util.logging.StreamHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SocketHandler()
		{
			InitJNI();
		}
		protected SocketHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close28099;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.SocketHandler._close28099);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.SocketHandler.staticClass, global::java.util.logging.SocketHandler._close28099);
		}
		internal static global::MonoJavaBridge.MethodId _publish28100;
		public override void publish(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.SocketHandler._publish28100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.SocketHandler.staticClass, global::java.util.logging.SocketHandler._publish28100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SocketHandler28101;
		public SocketHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.SocketHandler.staticClass, global::java.util.logging.SocketHandler._SocketHandler28101);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SocketHandler28102;
		public SocketHandler(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.SocketHandler.staticClass, global::java.util.logging.SocketHandler._SocketHandler28102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.SocketHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/SocketHandler"));
			global::java.util.logging.SocketHandler._close28099 = @__env.GetMethodIDNoThrow(global::java.util.logging.SocketHandler.staticClass, "close", "()V");
			global::java.util.logging.SocketHandler._publish28100 = @__env.GetMethodIDNoThrow(global::java.util.logging.SocketHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V");
			global::java.util.logging.SocketHandler._SocketHandler28101 = @__env.GetMethodIDNoThrow(global::java.util.logging.SocketHandler.staticClass, "<init>", "()V");
			global::java.util.logging.SocketHandler._SocketHandler28102 = @__env.GetMethodIDNoThrow(global::java.util.logging.SocketHandler.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}
}
