namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringTokenizer : java.lang.Object, Enumeration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StringTokenizer()
		{
			InitJNI();
		}
		protected StringTokenizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasMoreElements26824;
		public virtual bool hasMoreElements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.StringTokenizer._hasMoreElements26824);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._hasMoreElements26824);
		}
		internal static global::MonoJavaBridge.MethodId _nextElement26825;
		public virtual global::java.lang.Object nextElement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.StringTokenizer._nextElement26825)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._nextElement26825)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _countTokens26826;
		public virtual int countTokens()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.StringTokenizer._countTokens26826);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._countTokens26826);
		}
		internal static global::MonoJavaBridge.MethodId _hasMoreTokens26827;
		public virtual bool hasMoreTokens()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.StringTokenizer._hasMoreTokens26827);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._hasMoreTokens26827);
		}
		internal static global::MonoJavaBridge.MethodId _nextToken26828;
		public virtual global::java.lang.String nextToken()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.StringTokenizer._nextToken26828)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._nextToken26828)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextToken26829;
		public virtual global::java.lang.String nextToken(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.StringTokenizer._nextToken26829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._nextToken26829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _StringTokenizer26830;
		public StringTokenizer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._StringTokenizer26830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringTokenizer26831;
		public StringTokenizer(java.lang.String arg0, java.lang.String arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._StringTokenizer26831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringTokenizer26832;
		public StringTokenizer(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._StringTokenizer26832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.StringTokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/StringTokenizer"));
			global::java.util.StringTokenizer._hasMoreElements26824 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "hasMoreElements", "()Z");
			global::java.util.StringTokenizer._nextElement26825 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "nextElement", "()Ljava/lang/Object;");
			global::java.util.StringTokenizer._countTokens26826 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "countTokens", "()I");
			global::java.util.StringTokenizer._hasMoreTokens26827 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "hasMoreTokens", "()Z");
			global::java.util.StringTokenizer._nextToken26828 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "nextToken", "()Ljava/lang/String;");
			global::java.util.StringTokenizer._nextToken26829 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "nextToken", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.StringTokenizer._StringTokenizer26830 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.StringTokenizer._StringTokenizer26831 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			global::java.util.StringTokenizer._StringTokenizer26832 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
