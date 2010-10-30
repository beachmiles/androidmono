namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.ResponseCache_))]
	public abstract partial class ResponseCache : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResponseCache(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21678;
		public abstract global::java.net.CacheResponse get(java.net.URI arg0, java.lang.String arg1, java.util.Map arg2);
		internal static global::MonoJavaBridge.MethodId _put21679;
		public abstract global::java.net.CacheRequest put(java.net.URI arg0, java.net.URLConnection arg1);
		internal static global::MonoJavaBridge.MethodId _getDefault21680;
		public static global::java.net.ResponseCache getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.ResponseCache.staticClass, global::java.net.ResponseCache._getDefault21680)) as java.net.ResponseCache;
		}
		internal static global::MonoJavaBridge.MethodId _setDefault21681;
		public static void setDefault(java.net.ResponseCache arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.ResponseCache.staticClass, global::java.net.ResponseCache._setDefault21681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ResponseCache21682;
		public ResponseCache() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ResponseCache.staticClass, global::java.net.ResponseCache._ResponseCache21682);
			Init(@__env, handle);
		}
		static ResponseCache()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ResponseCache.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ResponseCache"));
			global::java.net.ResponseCache._get21678 = @__env.GetMethodIDNoThrow(global::java.net.ResponseCache.staticClass, "get", "(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map;)Ljava/net/CacheResponse;");
			global::java.net.ResponseCache._put21679 = @__env.GetMethodIDNoThrow(global::java.net.ResponseCache.staticClass, "put", "(Ljava/net/URI;Ljava/net/URLConnection;)Ljava/net/CacheRequest;");
			global::java.net.ResponseCache._getDefault21680 = @__env.GetStaticMethodIDNoThrow(global::java.net.ResponseCache.staticClass, "getDefault", "()Ljava/net/ResponseCache;");
			global::java.net.ResponseCache._setDefault21681 = @__env.GetStaticMethodIDNoThrow(global::java.net.ResponseCache.staticClass, "setDefault", "(Ljava/net/ResponseCache;)V");
			global::java.net.ResponseCache._ResponseCache21682 = @__env.GetMethodIDNoThrow(global::java.net.ResponseCache.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.ResponseCache))]
	internal sealed partial class ResponseCache_ : java.net.ResponseCache
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ResponseCache_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21683;
		public override global::java.net.CacheResponse get(java.net.URI arg0, java.lang.String arg1, java.util.Map arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ResponseCache_._get21683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.CacheResponse;
		}
		internal static global::MonoJavaBridge.MethodId _put21684;
		public override global::java.net.CacheRequest put(java.net.URI arg0, java.net.URLConnection arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ResponseCache_._put21684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.CacheRequest;
		}
		static ResponseCache_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ResponseCache_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ResponseCache"));
			global::java.net.ResponseCache_._get21683 = @__env.GetMethodIDNoThrow(global::java.net.ResponseCache_.staticClass, "get", "(Ljava/net/URI;Ljava/lang/String;Ljava/util/Map;)Ljava/net/CacheResponse;");
			global::java.net.ResponseCache_._put21684 = @__env.GetMethodIDNoThrow(global::java.net.ResponseCache_.staticClass, "put", "(Ljava/net/URI;Ljava/net/URLConnection;)Ljava/net/CacheRequest;");
		}
		internal static void InitJNI()
		{
		}
	}
}
