namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NetscapeDomainHandler : org.apache.http.impl.cookie.BasicDomainHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NetscapeDomainHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _match33307;
		public override bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.NetscapeDomainHandler.staticClass, global::org.apache.http.impl.cookie.NetscapeDomainHandler._match33307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate33308;
		public override void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.NetscapeDomainHandler.staticClass, global::org.apache.http.impl.cookie.NetscapeDomainHandler._validate33308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _NetscapeDomainHandler33309;
		public NetscapeDomainHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.NetscapeDomainHandler.staticClass, global::org.apache.http.impl.cookie.NetscapeDomainHandler._NetscapeDomainHandler33309);
			Init(@__env, handle);
		}
		static NetscapeDomainHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.NetscapeDomainHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/NetscapeDomainHandler"));
			global::org.apache.http.impl.cookie.NetscapeDomainHandler._match33307 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDomainHandler.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.impl.cookie.NetscapeDomainHandler._validate33308 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDomainHandler.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.impl.cookie.NetscapeDomainHandler._NetscapeDomainHandler33309 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDomainHandler.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
