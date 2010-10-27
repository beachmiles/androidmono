namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLSessionBindingEvent : java.util.EventObject
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLSessionBindingEvent()
		{
			InitJNI();
		}
		protected SSLSessionBindingEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName30057;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingEvent._getName30057)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingEvent.staticClass, global::javax.net.ssl.SSLSessionBindingEvent._getName30057)) as java.lang.String;
		}
		public new global::javax.net.ssl.SSLSession Session
		{
			get
			{
				return getSession();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSession30058;
		public virtual global::javax.net.ssl.SSLSession getSession()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingEvent._getSession30058)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingEvent.staticClass, global::javax.net.ssl.SSLSessionBindingEvent._getSession30058)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _SSLSessionBindingEvent30059;
		public SSLSessionBindingEvent(javax.net.ssl.SSLSession arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSessionBindingEvent.staticClass, global::javax.net.ssl.SSLSessionBindingEvent._SSLSessionBindingEvent30059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSessionBindingEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSessionBindingEvent"));
			global::javax.net.ssl.SSLSessionBindingEvent._getName30057 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionBindingEvent.staticClass, "getName", "()Ljava/lang/String;");
			global::javax.net.ssl.SSLSessionBindingEvent._getSession30058 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionBindingEvent.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLSessionBindingEvent._SSLSessionBindingEvent30059 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionBindingEvent.staticClass, "<init>", "(Ljavax/net/ssl/SSLSession;Ljava/lang/String;)V");
		}
	}
}
