namespace org.apache.http.conn.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.conn.ssl.AbstractVerifier_))]
	public abstract partial class AbstractVerifier : java.lang.Object, X509HostnameVerifier
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractVerifier()
		{
			InitJNI();
		}
		protected AbstractVerifier(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _verify32321;
		public abstract void verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2);
		internal static global::MonoJavaBridge.MethodId _verify32322;
		public virtual void verify(java.lang.String arg0, javax.net.ssl.SSLSocket arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.AbstractVerifier._verify32322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._verify32322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _verify32323;
		public virtual bool verify(java.lang.String arg0, javax.net.ssl.SSLSession arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ssl.AbstractVerifier._verify32323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._verify32323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _verify32324;
		public virtual void verify(java.lang.String arg0, java.security.cert.X509Certificate arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.AbstractVerifier._verify32324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._verify32324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _verify32325;
		public virtual void verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.AbstractVerifier._verify32325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._verify32325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _acceptableCountryWildcard32326;
		public static bool acceptableCountryWildcard(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._acceptableCountryWildcard32326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCNs32327;
		public static global::java.lang.String[] getCNs(java.security.cert.X509Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._getCNs32327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getDNSSubjectAlts32328;
		public static global::java.lang.String[] getDNSSubjectAlts(java.security.cert.X509Certificate arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._getDNSSubjectAlts32328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _countDots32329;
		public static int countDots(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._countDots32329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractVerifier32330;
		public AbstractVerifier() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ssl.AbstractVerifier.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier._AbstractVerifier32330);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ssl.AbstractVerifier.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ssl/AbstractVerifier"));
			global::org.apache.http.conn.ssl.AbstractVerifier._verify32321 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V");
			global::org.apache.http.conn.ssl.AbstractVerifier._verify32322 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSocket;)V");
			global::org.apache.http.conn.ssl.AbstractVerifier._verify32323 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "verify", "(Ljava/lang/String;Ljavax/net/ssl/SSLSession;)Z");
			global::org.apache.http.conn.ssl.AbstractVerifier._verify32324 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "verify", "(Ljava/lang/String;Ljava/security/cert/X509Certificate;)V");
			global::org.apache.http.conn.ssl.AbstractVerifier._verify32325 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Z)V");
			global::org.apache.http.conn.ssl.AbstractVerifier._acceptableCountryWildcard32326 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "acceptableCountryWildcard", "(Ljava/lang/String;)Z");
			global::org.apache.http.conn.ssl.AbstractVerifier._getCNs32327 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "getCNs", "(Ljava/security/cert/X509Certificate;)[Ljava/lang/String;");
			global::org.apache.http.conn.ssl.AbstractVerifier._getDNSSubjectAlts32328 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "getDNSSubjectAlts", "(Ljava/security/cert/X509Certificate;)[Ljava/lang/String;");
			global::org.apache.http.conn.ssl.AbstractVerifier._countDots32329 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "countDots", "(Ljava/lang/String;)I");
			global::org.apache.http.conn.ssl.AbstractVerifier._AbstractVerifier32330 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.ssl.AbstractVerifier))]
	internal sealed partial class AbstractVerifier_ : org.apache.http.conn.ssl.AbstractVerifier
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractVerifier_()
		{
			InitJNI();
		}
		internal AbstractVerifier_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _verify32331;
		public override void verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.AbstractVerifier_._verify32331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.AbstractVerifier_.staticClass, global::org.apache.http.conn.ssl.AbstractVerifier_._verify32331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ssl.AbstractVerifier_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ssl/AbstractVerifier"));
			global::org.apache.http.conn.ssl.AbstractVerifier_._verify32331 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.AbstractVerifier_.staticClass, "verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V");
		}
	}
}
