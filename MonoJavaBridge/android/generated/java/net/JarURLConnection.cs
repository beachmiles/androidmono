namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.JarURLConnection_))]
	public abstract partial class JarURLConnection : java.net.URLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JarURLConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCertificates21597;
		public virtual global::java.security.cert.Certificate[] getCertificates()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getCertificates21597)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getManifest21598;
		public virtual global::java.util.jar.Manifest getManifest()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getManifest21598)) as java.util.jar.Manifest;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes21599;
		public virtual global::java.util.jar.Attributes getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getAttributes21599)) as java.util.jar.Attributes;
		}
		internal static global::MonoJavaBridge.MethodId _getMainAttributes21600;
		public virtual global::java.util.jar.Attributes getMainAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getMainAttributes21600)) as java.util.jar.Attributes;
		}
		internal static global::MonoJavaBridge.MethodId _getJarFileURL21601;
		public virtual global::java.net.URL getJarFileURL()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getJarFileURL21601)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getJarFile21602;
		public abstract global::java.util.jar.JarFile getJarFile();
		internal static global::MonoJavaBridge.MethodId _getJarEntry21603;
		public virtual global::java.util.jar.JarEntry getJarEntry()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getJarEntry21603)) as java.util.jar.JarEntry;
		}
		internal static global::MonoJavaBridge.MethodId _getEntryName21604;
		public virtual global::java.lang.String getEntryName()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._getEntryName21604)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _JarURLConnection21605;
		protected JarURLConnection(java.net.URL arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.JarURLConnection.staticClass, global::java.net.JarURLConnection._JarURLConnection21605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static JarURLConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.JarURLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/JarURLConnection"));
			global::java.net.JarURLConnection._getCertificates21597 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getCertificates", "()[Ljava/security/cert/Certificate;");
			global::java.net.JarURLConnection._getManifest21598 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getManifest", "()Ljava/util/jar/Manifest;");
			global::java.net.JarURLConnection._getAttributes21599 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getAttributes", "()Ljava/util/jar/Attributes;");
			global::java.net.JarURLConnection._getMainAttributes21600 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getMainAttributes", "()Ljava/util/jar/Attributes;");
			global::java.net.JarURLConnection._getJarFileURL21601 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getJarFileURL", "()Ljava/net/URL;");
			global::java.net.JarURLConnection._getJarFile21602 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getJarFile", "()Ljava/util/jar/JarFile;");
			global::java.net.JarURLConnection._getJarEntry21603 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getJarEntry", "()Ljava/util/jar/JarEntry;");
			global::java.net.JarURLConnection._getEntryName21604 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "getEntryName", "()Ljava/lang/String;");
			global::java.net.JarURLConnection._JarURLConnection21605 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.JarURLConnection))]
	internal sealed partial class JarURLConnection_ : java.net.JarURLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal JarURLConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getJarFile21606;
		public override global::java.util.jar.JarFile getJarFile()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.JarURLConnection_._getJarFile21606)) as java.util.jar.JarFile;
		}
		internal static global::MonoJavaBridge.MethodId _connect21607;
		public override void connect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.net.JarURLConnection_._connect21607);
		}
		static JarURLConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.JarURLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/JarURLConnection"));
			global::java.net.JarURLConnection_._getJarFile21606 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection_.staticClass, "getJarFile", "()Ljava/util/jar/JarFile;");
			global::java.net.JarURLConnection_._connect21607 = @__env.GetMethodIDNoThrow(global::java.net.JarURLConnection_.staticClass, "connect", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
