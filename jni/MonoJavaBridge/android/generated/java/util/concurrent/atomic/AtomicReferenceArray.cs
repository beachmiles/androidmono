namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicReferenceArray : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicReferenceArray()
		{
			InitJNI();
		}
		protected AtomicReferenceArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27656;
		public virtual global::java.lang.Object get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray._get27656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._get27656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _toString27657;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray._toString27657)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._toString27657)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length27658;
		public virtual int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray._length27658);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._length27658);
		}
		internal static global::MonoJavaBridge.MethodId _set27659;
		public virtual void set(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray._set27659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._set27659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27660;
		public virtual void lazySet(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray._lazySet27660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._lazySet27660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27661;
		public virtual global::java.lang.Object getAndSet(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray._getAndSet27661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._getAndSet27661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27662;
		public virtual bool compareAndSet(int arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray._compareAndSet27662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._compareAndSet27662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27663;
		public virtual bool weakCompareAndSet(int arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray._weakCompareAndSet27663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._weakCompareAndSet27663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicReferenceArray27664;
		public AtomicReferenceArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._AtomicReferenceArray27664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicReferenceArray27665;
		public AtomicReferenceArray(java.lang.Object[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReferenceArray.staticClass, global::java.util.concurrent.atomic.AtomicReferenceArray._AtomicReferenceArray27665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicReferenceArray"));
			global::java.util.concurrent.atomic.AtomicReferenceArray._get27656 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.concurrent.atomic.AtomicReferenceArray._toString27657 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicReferenceArray._length27658 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "length", "()I");
			global::java.util.concurrent.atomic.AtomicReferenceArray._set27659 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "set", "(ILjava/lang/Object;)V");
			global::java.util.concurrent.atomic.AtomicReferenceArray._lazySet27660 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "lazySet", "(ILjava/lang/Object;)V");
			global::java.util.concurrent.atomic.AtomicReferenceArray._getAndSet27661 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "getAndSet", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.atomic.AtomicReferenceArray._compareAndSet27662 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "compareAndSet", "(ILjava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.atomic.AtomicReferenceArray._weakCompareAndSet27663 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "weakCompareAndSet", "(ILjava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.atomic.AtomicReferenceArray._AtomicReferenceArray27664 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.atomic.AtomicReferenceArray._AtomicReferenceArray27665 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReferenceArray.staticClass, "<init>", "([Ljava/lang/Object;)V");
		}
	}
}
