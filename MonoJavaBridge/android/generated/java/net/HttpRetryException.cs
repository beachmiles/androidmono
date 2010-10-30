namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpRetryException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpRetryException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Location
		{
			get
			{
				return getLocation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocation21467;
		public virtual global::java.lang.String getLocation()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.HttpRetryException.staticClass, global::java.net.HttpRetryException._getLocation21467)) as java.lang.String;
		}
		public new global::java.lang.String Reason
		{
			get
			{
				return getReason();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReason21468;
		public virtual global::java.lang.String getReason()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.HttpRetryException.staticClass, global::java.net.HttpRetryException._getReason21468)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _responseCode21469;
		public virtual int responseCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.HttpRetryException.staticClass, global::java.net.HttpRetryException._responseCode21469);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRetryException21470;
		public HttpRetryException(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.HttpRetryException.staticClass, global::java.net.HttpRetryException._HttpRetryException21470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRetryException21471;
		public HttpRetryException(java.lang.String arg0, int arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.HttpRetryException.staticClass, global::java.net.HttpRetryException._HttpRetryException21471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static HttpRetryException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.HttpRetryException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/HttpRetryException"));
			global::java.net.HttpRetryException._getLocation21467 = @__env.GetMethodIDNoThrow(global::java.net.HttpRetryException.staticClass, "getLocation", "()Ljava/lang/String;");
			global::java.net.HttpRetryException._getReason21468 = @__env.GetMethodIDNoThrow(global::java.net.HttpRetryException.staticClass, "getReason", "()Ljava/lang/String;");
			global::java.net.HttpRetryException._responseCode21469 = @__env.GetMethodIDNoThrow(global::java.net.HttpRetryException.staticClass, "responseCode", "()I");
			global::java.net.HttpRetryException._HttpRetryException21470 = @__env.GetMethodIDNoThrow(global::java.net.HttpRetryException.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.net.HttpRetryException._HttpRetryException21471 = @__env.GetMethodIDNoThrow(global::java.net.HttpRetryException.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
