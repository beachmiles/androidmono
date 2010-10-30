namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.locks.ReadWriteLock_))]
	public partial interface ReadWriteLock  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.util.concurrent.locks.Lock readLock();
		global::java.util.concurrent.locks.Lock writeLock();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.locks.ReadWriteLock))]
	internal sealed partial class ReadWriteLock_ : java.lang.Object, ReadWriteLock
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ReadWriteLock_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLock27753;
		global::java.util.concurrent.locks.Lock java.util.concurrent.locks.ReadWriteLock.readLock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReadWriteLock_._readLock27753)) as java.util.concurrent.locks.Lock;
		}
		internal static global::MonoJavaBridge.MethodId _writeLock27754;
		global::java.util.concurrent.locks.Lock java.util.concurrent.locks.ReadWriteLock.writeLock()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Lock>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.locks.ReadWriteLock_._writeLock27754)) as java.util.concurrent.locks.Lock;
		}
		static ReadWriteLock_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.ReadWriteLock_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/ReadWriteLock"));
			global::java.util.concurrent.locks.ReadWriteLock_._readLock27753 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReadWriteLock_.staticClass, "readLock", "()Ljava/util/concurrent/locks/Lock;");
			global::java.util.concurrent.locks.ReadWriteLock_._writeLock27754 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.ReadWriteLock_.staticClass, "writeLock", "()Ljava/util/concurrent/locks/Lock;");
		}
		internal static void InitJNI()
		{
		}
	}
}
