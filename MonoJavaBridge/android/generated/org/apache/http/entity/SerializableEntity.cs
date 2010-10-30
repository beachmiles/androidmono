namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SerializableEntity : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SerializableEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32564;
		public override global::java.io.InputStream getContent()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.SerializableEntity.staticClass, global::org.apache.http.entity.SerializableEntity._getContent32564)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32565;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.SerializableEntity.staticClass, global::org.apache.http.entity.SerializableEntity._writeTo32565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32566;
		public override long getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.SerializableEntity.staticClass, global::org.apache.http.entity.SerializableEntity._getContentLength32566);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32567;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.SerializableEntity.staticClass, global::org.apache.http.entity.SerializableEntity._isRepeatable32567);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32568;
		public override bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.SerializableEntity.staticClass, global::org.apache.http.entity.SerializableEntity._isStreaming32568);
		}
		internal static global::MonoJavaBridge.MethodId _SerializableEntity32569;
		public SerializableEntity(java.io.Serializable arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.SerializableEntity.staticClass, global::org.apache.http.entity.SerializableEntity._SerializableEntity32569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SerializableEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.SerializableEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/SerializableEntity"));
			global::org.apache.http.entity.SerializableEntity._getContent32564 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.SerializableEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.SerializableEntity._writeTo32565 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.SerializableEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.SerializableEntity._getContentLength32566 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.SerializableEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.SerializableEntity._isRepeatable32567 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.SerializableEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.SerializableEntity._isStreaming32568 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.SerializableEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.SerializableEntity._SerializableEntity32569 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.SerializableEntity.staticClass, "<init>", "(Ljava/io/Serializable;Z)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
