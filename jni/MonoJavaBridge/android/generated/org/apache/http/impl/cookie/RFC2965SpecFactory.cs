namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RFC2965SpecFactory : java.lang.Object, org.apache.http.cookie.CookieSpecFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RFC2965SpecFactory()
		{
			InitJNI();
		}
		protected RFC2965SpecFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance33363;
		public virtual global::org.apache.http.cookie.CookieSpec newInstance(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieSpec>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965SpecFactory._newInstance33363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.cookie.CookieSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieSpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965SpecFactory.staticClass, global::org.apache.http.impl.cookie.RFC2965SpecFactory._newInstance33363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.cookie.CookieSpec;
		}
		internal static global::MonoJavaBridge.MethodId _RFC2965SpecFactory33364;
		public RFC2965SpecFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2965SpecFactory.staticClass, global::org.apache.http.impl.cookie.RFC2965SpecFactory._RFC2965SpecFactory33364);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.RFC2965SpecFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/RFC2965SpecFactory"));
			global::org.apache.http.impl.cookie.RFC2965SpecFactory._newInstance33363 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965SpecFactory.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;");
			global::org.apache.http.impl.cookie.RFC2965SpecFactory._RFC2965SpecFactory33364 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965SpecFactory.staticClass, "<init>", "()V");
		}
	}
}
