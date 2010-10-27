namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LineNumberReader : java.io.BufferedReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LineNumberReader()
		{
			InitJNI();
		}
		protected LineNumberReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _readLine19131;
		public override global::java.lang.String readLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.LineNumberReader._readLine19131)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._readLine19131)) as java.lang.String;
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
			set
			{
				setLineNumber(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber19132;
		public virtual int getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberReader._getLineNumber19132);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._getLineNumber19132);
		}
		internal static global::MonoJavaBridge.MethodId _mark19133;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.LineNumberReader._mark19133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._mark19133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19134;
		public override void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.LineNumberReader._reset19134);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._reset19134);
		}
		internal static global::MonoJavaBridge.MethodId _read19135;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberReader._read19135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._read19135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19136;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberReader._read19136);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._read19136);
		}
		internal static global::MonoJavaBridge.MethodId _skip19137;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.LineNumberReader._skip19137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._skip19137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLineNumber19138;
		public virtual void setLineNumber(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.LineNumberReader._setLineNumber19138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._setLineNumber19138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LineNumberReader19139;
		public LineNumberReader(java.io.Reader arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._LineNumberReader19139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LineNumberReader19140;
		public LineNumberReader(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.LineNumberReader.staticClass, global::java.io.LineNumberReader._LineNumberReader19140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.LineNumberReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/LineNumberReader"));
			global::java.io.LineNumberReader._readLine19131 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.LineNumberReader._getLineNumber19132 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "getLineNumber", "()I");
			global::java.io.LineNumberReader._mark19133 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "mark", "(I)V");
			global::java.io.LineNumberReader._reset19134 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "reset", "()V");
			global::java.io.LineNumberReader._read19135 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "read", "([CII)I");
			global::java.io.LineNumberReader._read19136 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "read", "()I");
			global::java.io.LineNumberReader._skip19137 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "skip", "(J)J");
			global::java.io.LineNumberReader._setLineNumber19138 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "setLineNumber", "(I)V");
			global::java.io.LineNumberReader._LineNumberReader19139 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "<init>", "(Ljava/io/Reader;I)V");
			global::java.io.LineNumberReader._LineNumberReader19140 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
		}
	}
}
