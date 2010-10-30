namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EofSensorInputStream : java.io.InputStream, ConnectionReleaseTrigger
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EofSensorInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close32095;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._close32095);
		}
		internal static global::MonoJavaBridge.MethodId _read32096;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._read32096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read32097;
		public override int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._read32097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read32098;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._read32098);
		}
		internal static global::MonoJavaBridge.MethodId _available32099;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._available32099);
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection32100;
		public virtual void releaseConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._releaseConnection32100);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection32101;
		public virtual void abortConnection()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._abortConnection32101);
		}
		internal static global::MonoJavaBridge.MethodId _isReadAllowed32102;
		protected virtual bool isReadAllowed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._isReadAllowed32102);
		}
		internal static global::MonoJavaBridge.MethodId _checkEOF32103;
		protected virtual void checkEOF(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._checkEOF32103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkClose32104;
		protected virtual void checkClose()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._checkClose32104);
		}
		internal static global::MonoJavaBridge.MethodId _checkAbort32105;
		protected virtual void checkAbort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._checkAbort32105);
		}
		internal static global::MonoJavaBridge.MethodId _EofSensorInputStream32106;
		public EofSensorInputStream(java.io.InputStream arg0, org.apache.http.conn.EofSensorWatcher arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.EofSensorInputStream.staticClass, global::org.apache.http.conn.EofSensorInputStream._EofSensorInputStream32106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static EofSensorInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.EofSensorInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/EofSensorInputStream"));
			global::org.apache.http.conn.EofSensorInputStream._close32095 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "close", "()V");
			global::org.apache.http.conn.EofSensorInputStream._read32096 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "read", "([BII)I");
			global::org.apache.http.conn.EofSensorInputStream._read32097 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "read", "([B)I");
			global::org.apache.http.conn.EofSensorInputStream._read32098 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "read", "()I");
			global::org.apache.http.conn.EofSensorInputStream._available32099 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "available", "()I");
			global::org.apache.http.conn.EofSensorInputStream._releaseConnection32100 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "releaseConnection", "()V");
			global::org.apache.http.conn.EofSensorInputStream._abortConnection32101 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "abortConnection", "()V");
			global::org.apache.http.conn.EofSensorInputStream._isReadAllowed32102 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "isReadAllowed", "()Z");
			global::org.apache.http.conn.EofSensorInputStream._checkEOF32103 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "checkEOF", "(I)V");
			global::org.apache.http.conn.EofSensorInputStream._checkClose32104 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "checkClose", "()V");
			global::org.apache.http.conn.EofSensorInputStream._checkAbort32105 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "checkAbort", "()V");
			global::org.apache.http.conn.EofSensorInputStream._EofSensorInputStream32106 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Lorg/apache/http/conn/EofSensorWatcher;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
