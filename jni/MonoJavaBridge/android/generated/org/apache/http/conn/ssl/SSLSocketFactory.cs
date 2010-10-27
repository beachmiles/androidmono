namespace org.apache.http.conn.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLSocketFactory : java.lang.Object, org.apache.http.conn.scheme.LayeredSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLSocketFactory()
		{
			InitJNI();
		}
		protected SSLSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createSocket32338;
		public virtual global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ssl.SSLSocketFactory._createSocket32338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._createSocket32338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket32339;
		public virtual global::java.net.Socket createSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ssl.SSLSocketFactory._createSocket32339)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._createSocket32339)) as java.net.Socket;
		}
		public static global::org.apache.http.conn.ssl.SSLSocketFactory SocketFactory
		{
			get
			{
				return getSocketFactory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocketFactory32340;
		public static global::org.apache.http.conn.ssl.SSLSocketFactory getSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._getSocketFactory32340)) as org.apache.http.conn.ssl.SSLSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _connectSocket32341;
		public virtual global::java.net.Socket connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ssl.SSLSocketFactory._connectSocket32341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._connectSocket32341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32342;
		public virtual bool isSecure(java.net.Socket arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ssl.SSLSocketFactory._isSecure32342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._isSecure32342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHostnameVerifier32343;
		public virtual void setHostnameVerifier(org.apache.http.conn.ssl.X509HostnameVerifier arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.SSLSocketFactory._setHostnameVerifier32343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._setHostnameVerifier32343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.conn.ssl.X509HostnameVerifier HostnameVerifier
		{
			get
			{
				return getHostnameVerifier();
			}
			set
			{
				setHostnameVerifier(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHostnameVerifier32344;
		public virtual global::org.apache.http.conn.ssl.X509HostnameVerifier getHostnameVerifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ssl.X509HostnameVerifier>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ssl.SSLSocketFactory._getHostnameVerifier32344)) as org.apache.http.conn.ssl.X509HostnameVerifier;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ssl.X509HostnameVerifier>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._getHostnameVerifier32344)) as org.apache.http.conn.ssl.X509HostnameVerifier;
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocketFactory32345;
		public SSLSocketFactory(java.lang.String arg0, java.security.KeyStore arg1, java.lang.String arg2, java.security.KeyStore arg3, java.security.SecureRandom arg4, org.apache.http.conn.scheme.HostNameResolver arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory32345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocketFactory32346;
		public SSLSocketFactory(java.security.KeyStore arg0, java.lang.String arg1, java.security.KeyStore arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory32346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocketFactory32347;
		public SSLSocketFactory(java.security.KeyStore arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory32347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLSocketFactory32348;
		public SSLSocketFactory(java.security.KeyStore arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ssl.SSLSocketFactory.staticClass, global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory32348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String TLS
		{
			get
			{
				return "TLS";
			}
		}
		public static global::java.lang.String SSL
		{
			get
			{
				return "SSL";
			}
		}
		public static global::java.lang.String SSLV2
		{
			get
			{
				return "SSLv2";
			}
		}
		internal static global::MonoJavaBridge.FieldId _ALLOW_ALL_HOSTNAME_VERIFIER32352;
		public static global::org.apache.http.conn.ssl.X509HostnameVerifier ALLOW_ALL_HOSTNAME_VERIFIER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ssl.X509HostnameVerifier>(@__env.GetStaticObjectField(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, _ALLOW_ALL_HOSTNAME_VERIFIER32352)) as org.apache.http.conn.ssl.X509HostnameVerifier;
			}
		}
		internal static global::MonoJavaBridge.FieldId _BROWSER_COMPATIBLE_HOSTNAME_VERIFIER32353;
		public static global::org.apache.http.conn.ssl.X509HostnameVerifier BROWSER_COMPATIBLE_HOSTNAME_VERIFIER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ssl.X509HostnameVerifier>(@__env.GetStaticObjectField(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, _BROWSER_COMPATIBLE_HOSTNAME_VERIFIER32353)) as org.apache.http.conn.ssl.X509HostnameVerifier;
			}
		}
		internal static global::MonoJavaBridge.FieldId _STRICT_HOSTNAME_VERIFIER32354;
		public static global::org.apache.http.conn.ssl.X509HostnameVerifier STRICT_HOSTNAME_VERIFIER
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.ssl.X509HostnameVerifier>(@__env.GetStaticObjectField(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, _STRICT_HOSTNAME_VERIFIER32354)) as org.apache.http.conn.ssl.X509HostnameVerifier;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ssl/SSLSocketFactory"));
			global::org.apache.http.conn.ssl.SSLSocketFactory._createSocket32338 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._createSocket32339 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._getSocketFactory32340 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "getSocketFactory", "()Lorg/apache/http/conn/ssl/SSLSocketFactory;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._connectSocket32341 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/params/HttpParams;)Ljava/net/Socket;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._isSecure32342 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "isSecure", "(Ljava/net/Socket;)Z");
			global::org.apache.http.conn.ssl.SSLSocketFactory._setHostnameVerifier32343 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "setHostnameVerifier", "(Lorg/apache/http/conn/ssl/X509HostnameVerifier;)V");
			global::org.apache.http.conn.ssl.SSLSocketFactory._getHostnameVerifier32344 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "getHostnameVerifier", "()Lorg/apache/http/conn/ssl/X509HostnameVerifier;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory32345 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "<init>", "(Ljava/lang/String;Ljava/security/KeyStore;Ljava/lang/String;Ljava/security/KeyStore;Ljava/security/SecureRandom;Lorg/apache/http/conn/scheme/HostNameResolver;)V");
			global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory32346 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "<init>", "(Ljava/security/KeyStore;Ljava/lang/String;Ljava/security/KeyStore;)V");
			global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory32347 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "<init>", "(Ljava/security/KeyStore;Ljava/lang/String;)V");
			global::org.apache.http.conn.ssl.SSLSocketFactory._SSLSocketFactory32348 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "<init>", "(Ljava/security/KeyStore;)V");
			global::org.apache.http.conn.ssl.SSLSocketFactory._ALLOW_ALL_HOSTNAME_VERIFIER32352 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "ALLOW_ALL_HOSTNAME_VERIFIER", "Lorg/apache/http/conn/ssl/X509HostnameVerifier;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._BROWSER_COMPATIBLE_HOSTNAME_VERIFIER32353 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "BROWSER_COMPATIBLE_HOSTNAME_VERIFIER", "Lorg/apache/http/conn/ssl/X509HostnameVerifier;");
			global::org.apache.http.conn.ssl.SSLSocketFactory._STRICT_HOSTNAME_VERIFIER32354 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.conn.ssl.SSLSocketFactory.staticClass, "STRICT_HOSTNAME_VERIFIER", "Lorg/apache/http/conn/ssl/X509HostnameVerifier;");
		}
	}
}
