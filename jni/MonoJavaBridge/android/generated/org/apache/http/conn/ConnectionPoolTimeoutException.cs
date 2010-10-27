namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnectionPoolTimeoutException : org.apache.http.conn.ConnectTimeoutException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnectionPoolTimeoutException()
		{
			InitJNI();
		}
		protected ConnectionPoolTimeoutException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ConnectionPoolTimeoutException32090;
		public ConnectionPoolTimeoutException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ConnectionPoolTimeoutException.staticClass, global::org.apache.http.conn.ConnectionPoolTimeoutException._ConnectionPoolTimeoutException32090);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConnectionPoolTimeoutException32091;
		public ConnectionPoolTimeoutException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ConnectionPoolTimeoutException.staticClass, global::org.apache.http.conn.ConnectionPoolTimeoutException._ConnectionPoolTimeoutException32091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ConnectionPoolTimeoutException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ConnectionPoolTimeoutException"));
			global::org.apache.http.conn.ConnectionPoolTimeoutException._ConnectionPoolTimeoutException32090 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ConnectionPoolTimeoutException.staticClass, "<init>", "()V");
			global::org.apache.http.conn.ConnectionPoolTimeoutException._ConnectionPoolTimeoutException32091 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ConnectionPoolTimeoutException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
