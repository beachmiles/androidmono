namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HeaderElement_))]
	public partial interface HeaderElement  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getName();
		global::java.lang.String getValue();
		global::org.apache.http.NameValuePair[] getParameters();
		global::org.apache.http.NameValuePair getParameter(int arg0);
		int getParameterCount();
		global::org.apache.http.NameValuePair getParameterByName(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HeaderElement))]
	internal sealed partial class HeaderElement_ : java.lang.Object, HeaderElement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HeaderElement_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName31500;
		global::java.lang.String org.apache.http.HeaderElement.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_._getName31500)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue31501;
		global::java.lang.String org.apache.http.HeaderElement.getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_._getValue31501)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getParameters31502;
		global::org.apache.http.NameValuePair[] org.apache.http.HeaderElement.getParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_._getParameters31502)) as org.apache.http.NameValuePair[];
		}
		internal static global::MonoJavaBridge.MethodId _getParameter31503;
		global::org.apache.http.NameValuePair org.apache.http.HeaderElement.getParameter(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_._getParameter31503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _getParameterCount31504;
		int org.apache.http.HeaderElement.getParameterCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HeaderElement_._getParameterCount31504);
		}
		internal static global::MonoJavaBridge.MethodId _getParameterByName31505;
		global::org.apache.http.NameValuePair org.apache.http.HeaderElement.getParameterByName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElement_._getParameterByName31505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.NameValuePair;
		}
		static HeaderElement_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HeaderElement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HeaderElement"));
			global::org.apache.http.HeaderElement_._getName31500 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElement_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.HeaderElement_._getValue31501 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElement_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.HeaderElement_._getParameters31502 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElement_.staticClass, "getParameters", "()[Lorg/apache/http/NameValuePair;");
			global::org.apache.http.HeaderElement_._getParameter31503 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElement_.staticClass, "getParameter", "(I)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.HeaderElement_._getParameterCount31504 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElement_.staticClass, "getParameterCount", "()I");
			global::org.apache.http.HeaderElement_._getParameterByName31505 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElement_.staticClass, "getParameterByName", "(Ljava/lang/String;)Lorg/apache/http/NameValuePair;");
		}
		internal static void InitJNI()
		{
		}
	}
}
