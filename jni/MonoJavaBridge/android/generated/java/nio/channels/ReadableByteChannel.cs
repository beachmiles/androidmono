namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.ReadableByteChannel_))]
	public partial interface ReadableByteChannel : Channel
	{
		int read(java.nio.ByteBuffer arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.ReadableByteChannel))]
	internal sealed partial class ReadableByteChannel_ : java.lang.Object, ReadableByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ReadableByteChannel_()
		{
			InitJNI();
		}
		internal ReadableByteChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read22545;
		int java.nio.channels.ReadableByteChannel.read(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_._read22545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_.staticClass, global::java.nio.channels.ReadableByteChannel_._read22545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close22546;
		void java.nio.channels.Channel.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_._close22546);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_.staticClass, global::java.nio.channels.ReadableByteChannel_._close22546);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22547;
		bool java.nio.channels.Channel.isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_._isOpen22547);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_.staticClass, global::java.nio.channels.ReadableByteChannel_._isOpen22547);
		}
		internal static global::MonoJavaBridge.MethodId _close22548;
		void java.io.Closeable.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_._close22548);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ReadableByteChannel_.staticClass, global::java.nio.channels.ReadableByteChannel_._close22548);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ReadableByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ReadableByteChannel"));
			global::java.nio.channels.ReadableByteChannel_._read22545 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ReadableByteChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.ReadableByteChannel_._close22546 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ReadableByteChannel_.staticClass, "close", "()V");
			global::java.nio.channels.ReadableByteChannel_._isOpen22547 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ReadableByteChannel_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.ReadableByteChannel_._close22548 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ReadableByteChannel_.staticClass, "close", "()V");
		}
	}
}
