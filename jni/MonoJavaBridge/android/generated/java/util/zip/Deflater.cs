namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Deflater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Deflater()
		{
			InitJNI();
		}
		protected Deflater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize28353;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._finalize28353);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._finalize28353);
		}
		internal static global::MonoJavaBridge.MethodId _reset28354;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._reset28354);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._reset28354);
		}
		internal static global::MonoJavaBridge.MethodId _finished28355;
		public virtual bool finished()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Deflater._finished28355);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._finished28355);
		}
		internal static global::MonoJavaBridge.MethodId _end28356;
		public virtual void end()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._end28356);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._end28356);
		}
		public new byte[] Input
		{
			set
			{
				setInput(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setInput28357;
		public virtual void setInput(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setInput28357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setInput28357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInput28358;
		public virtual void setInput(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setInput28358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setInput28358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new long BytesWritten
		{
			get
			{
				return getBytesWritten();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesWritten28359;
		public virtual long getBytesWritten()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Deflater._getBytesWritten28359);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getBytesWritten28359);
		}
		internal static global::MonoJavaBridge.MethodId _needsInput28360;
		public virtual bool needsInput()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.Deflater._needsInput28360);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._needsInput28360);
		}
		public new byte[] Dictionary
		{
			set
			{
				setDictionary(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary28361;
		public virtual void setDictionary(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setDictionary28361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setDictionary28361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDictionary28362;
		public virtual void setDictionary(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setDictionary28362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setDictionary28362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int Adler
		{
			get
			{
				return getAdler();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAdler28363;
		public virtual int getAdler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._getAdler28363);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getAdler28363);
		}
		public new int TotalIn
		{
			get
			{
				return getTotalIn();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalIn28364;
		public virtual int getTotalIn()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._getTotalIn28364);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getTotalIn28364);
		}
		public new long BytesRead
		{
			get
			{
				return getBytesRead();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBytesRead28365;
		public virtual long getBytesRead()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Deflater._getBytesRead28365);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getBytesRead28365);
		}
		public new int TotalOut
		{
			get
			{
				return getTotalOut();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalOut28366;
		public virtual int getTotalOut()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._getTotalOut28366);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._getTotalOut28366);
		}
		public new int Level
		{
			set
			{
				setLevel(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLevel28367;
		public virtual void setLevel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setLevel28367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setLevel28367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finish28368;
		public virtual void finish()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._finish28368);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._finish28368);
		}
		internal static global::MonoJavaBridge.MethodId _deflate28369;
		public virtual int deflate(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._deflate28369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._deflate28369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _deflate28370;
		public virtual int deflate(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.Deflater._deflate28370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._deflate28370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Strategy
		{
			set
			{
				setStrategy(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setStrategy28371;
		public virtual void setStrategy(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Deflater._setStrategy28371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._setStrategy28371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Deflater28372;
		public Deflater(int arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._Deflater28372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Deflater28373;
		public Deflater(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._Deflater28373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Deflater28374;
		public Deflater() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Deflater.staticClass, global::java.util.zip.Deflater._Deflater28374);
			Init(@__env, handle);
		}
		public static int DEFLATED
		{
			get
			{
				return 8;
			}
		}
		public static int NO_COMPRESSION
		{
			get
			{
				return 0;
			}
		}
		public static int BEST_SPEED
		{
			get
			{
				return 1;
			}
		}
		public static int BEST_COMPRESSION
		{
			get
			{
				return 9;
			}
		}
		public static int DEFAULT_COMPRESSION
		{
			get
			{
				return -1;
			}
		}
		public static int FILTERED
		{
			get
			{
				return 1;
			}
		}
		public static int HUFFMAN_ONLY
		{
			get
			{
				return 2;
			}
		}
		public static int DEFAULT_STRATEGY
		{
			get
			{
				return 0;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Deflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Deflater"));
			global::java.util.zip.Deflater._finalize28353 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "finalize", "()V");
			global::java.util.zip.Deflater._reset28354 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "reset", "()V");
			global::java.util.zip.Deflater._finished28355 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "finished", "()Z");
			global::java.util.zip.Deflater._end28356 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "end", "()V");
			global::java.util.zip.Deflater._setInput28357 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setInput", "([B)V");
			global::java.util.zip.Deflater._setInput28358 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setInput", "([BII)V");
			global::java.util.zip.Deflater._getBytesWritten28359 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getBytesWritten", "()J");
			global::java.util.zip.Deflater._needsInput28360 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "needsInput", "()Z");
			global::java.util.zip.Deflater._setDictionary28361 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setDictionary", "([B)V");
			global::java.util.zip.Deflater._setDictionary28362 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setDictionary", "([BII)V");
			global::java.util.zip.Deflater._getAdler28363 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getAdler", "()I");
			global::java.util.zip.Deflater._getTotalIn28364 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getTotalIn", "()I");
			global::java.util.zip.Deflater._getBytesRead28365 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getBytesRead", "()J");
			global::java.util.zip.Deflater._getTotalOut28366 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "getTotalOut", "()I");
			global::java.util.zip.Deflater._setLevel28367 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setLevel", "(I)V");
			global::java.util.zip.Deflater._finish28368 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "finish", "()V");
			global::java.util.zip.Deflater._deflate28369 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "deflate", "([BII)I");
			global::java.util.zip.Deflater._deflate28370 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "deflate", "([B)I");
			global::java.util.zip.Deflater._setStrategy28371 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "setStrategy", "(I)V");
			global::java.util.zip.Deflater._Deflater28372 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "(IZ)V");
			global::java.util.zip.Deflater._Deflater28373 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "(I)V");
			global::java.util.zip.Deflater._Deflater28374 = @__env.GetMethodIDNoThrow(global::java.util.zip.Deflater.staticClass, "<init>", "()V");
		}
	}
}
