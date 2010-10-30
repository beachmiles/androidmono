namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.protocol.HttpContext_))]
	public partial interface HttpContext  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object getAttribute(java.lang.String arg0);
		global::java.lang.Object removeAttribute(java.lang.String arg0);
		void setAttribute(java.lang.String arg0, java.lang.Object arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.protocol.HttpContext))]
	internal sealed partial class HttpContext_ : java.lang.Object, HttpContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpContext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute33885;
		global::java.lang.Object org.apache.http.protocol.HttpContext.getAttribute(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpContext_._getAttribute33885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute33886;
		global::java.lang.Object org.apache.http.protocol.HttpContext.removeAttribute(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpContext_._removeAttribute33886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute33887;
		void org.apache.http.protocol.HttpContext.setAttribute(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpContext_._setAttribute33887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static HttpContext_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpContext"));
			global::org.apache.http.protocol.HttpContext_._getAttribute33885 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpContext_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.HttpContext_._removeAttribute33886 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpContext_.staticClass, "removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.HttpContext_._setAttribute33887 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpContext_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
