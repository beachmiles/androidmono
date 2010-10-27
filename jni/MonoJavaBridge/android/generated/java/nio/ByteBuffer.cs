namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.ByteBuffer_))]
	public abstract partial class ByteBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ByteBuffer()
		{
			InitJNI();
		}
		protected ByteBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22016;
		public abstract byte get();
		internal static global::MonoJavaBridge.MethodId _get22017;
		public virtual global::java.nio.ByteBuffer get(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._get22017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._get22017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22018;
		public virtual global::java.nio.ByteBuffer get(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._get22018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._get22018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22019;
		public abstract byte get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22020;
		public virtual global::java.nio.ByteBuffer put(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put22020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put22020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22021;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put22021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put22021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22022;
		public abstract global::java.nio.ByteBuffer put(byte arg0);
		internal static global::MonoJavaBridge.MethodId _put22023;
		public abstract global::java.nio.ByteBuffer put(int arg0, byte arg1);
		internal static global::MonoJavaBridge.MethodId _put22024;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._put22024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._put22024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22025;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer._equals22025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._equals22025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22026;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._toString22026)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._toString22026)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22027;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._hashCode22027);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._hashCode22027);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22028;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._compareTo22028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._compareTo22028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22029;
		public virtual int compareTo(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._compareTo22029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._compareTo22029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort22030;
		public abstract short getShort(int arg0);
		internal static global::MonoJavaBridge.MethodId _getShort22031;
		public abstract short getShort();
		internal static global::MonoJavaBridge.MethodId _putShort22032;
		public abstract global::java.nio.ByteBuffer putShort(int arg0, short arg1);
		internal static global::MonoJavaBridge.MethodId _putShort22033;
		public abstract global::java.nio.ByteBuffer putShort(short arg0);
		internal static global::MonoJavaBridge.MethodId _getChar22034;
		public abstract char getChar();
		internal static global::MonoJavaBridge.MethodId _getChar22035;
		public abstract char getChar(int arg0);
		internal static global::MonoJavaBridge.MethodId _putChar22036;
		public abstract global::java.nio.ByteBuffer putChar(int arg0, char arg1);
		internal static global::MonoJavaBridge.MethodId _putChar22037;
		public abstract global::java.nio.ByteBuffer putChar(char arg0);
		internal static global::MonoJavaBridge.MethodId _getInt22038;
		public abstract int getInt();
		internal static global::MonoJavaBridge.MethodId _getInt22039;
		public abstract int getInt(int arg0);
		internal static global::MonoJavaBridge.MethodId _putInt22040;
		public abstract global::java.nio.ByteBuffer putInt(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _putInt22041;
		public abstract global::java.nio.ByteBuffer putInt(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLong22042;
		public abstract long getLong(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLong22043;
		public abstract long getLong();
		internal static global::MonoJavaBridge.MethodId _putLong22044;
		public abstract global::java.nio.ByteBuffer putLong(long arg0);
		internal static global::MonoJavaBridge.MethodId _putLong22045;
		public abstract global::java.nio.ByteBuffer putLong(int arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _getFloat22046;
		public abstract float getFloat();
		internal static global::MonoJavaBridge.MethodId _getFloat22047;
		public abstract float getFloat(int arg0);
		internal static global::MonoJavaBridge.MethodId _putFloat22048;
		public abstract global::java.nio.ByteBuffer putFloat(float arg0);
		internal static global::MonoJavaBridge.MethodId _putFloat22049;
		public abstract global::java.nio.ByteBuffer putFloat(int arg0, float arg1);
		internal static global::MonoJavaBridge.MethodId _getDouble22050;
		public abstract double getDouble();
		internal static global::MonoJavaBridge.MethodId _getDouble22051;
		public abstract double getDouble(int arg0);
		internal static global::MonoJavaBridge.MethodId _putDouble22052;
		public abstract global::java.nio.ByteBuffer putDouble(int arg0, double arg1);
		internal static global::MonoJavaBridge.MethodId _putDouble22053;
		public abstract global::java.nio.ByteBuffer putDouble(double arg0);
		internal static global::MonoJavaBridge.MethodId _isDirect22054;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22055;
		public sealed override bool hasArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer._hasArray22055);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._hasArray22055);
		}
		internal static global::MonoJavaBridge.MethodId _array22056;
		public override global::java.lang.Object array()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._array22056)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._array22056)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22057;
		public sealed override int arrayOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer._arrayOffset22057);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._arrayOffset22057);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22058;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap22058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22059;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._wrap22059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22060;
		public static global::java.nio.ByteBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocate22060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22061;
		public abstract global::java.nio.ByteBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _allocateDirect22062;
		public static global::java.nio.ByteBuffer allocateDirect(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._allocateDirect22062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22063;
		public abstract global::java.nio.ByteBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22064;
		public abstract global::java.nio.ByteBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22065;
		public abstract global::java.nio.ByteBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22066;
		public virtual global::java.nio.ByteBuffer order(java.nio.ByteOrder arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._order22066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._order22066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22067;
		public virtual global::java.nio.ByteOrder order()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer._order22067)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._order22067)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer22068;
		public abstract global::java.nio.CharBuffer asCharBuffer();
		internal static global::MonoJavaBridge.MethodId _asShortBuffer22069;
		public abstract global::java.nio.ShortBuffer asShortBuffer();
		internal static global::MonoJavaBridge.MethodId _asIntBuffer22070;
		public abstract global::java.nio.IntBuffer asIntBuffer();
		internal static global::MonoJavaBridge.MethodId _asLongBuffer22071;
		public abstract global::java.nio.LongBuffer asLongBuffer();
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer22072;
		public abstract global::java.nio.FloatBuffer asFloatBuffer();
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer22073;
		public abstract global::java.nio.DoubleBuffer asDoubleBuffer();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteBuffer"));
			global::java.nio.ByteBuffer._get22016 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "()B");
			global::java.nio.ByteBuffer._get22017 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._get22018 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._get22019 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "get", "(I)B");
			global::java.nio.ByteBuffer._put22020 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put22021 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put22022 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put22023 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._put22024 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "put", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._equals22025 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.ByteBuffer._toString22026 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.ByteBuffer._hashCode22027 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "hashCode", "()I");
			global::java.nio.ByteBuffer._compareTo22028 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.ByteBuffer._compareTo22029 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.ByteBuffer._getShort22030 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getShort", "(I)S");
			global::java.nio.ByteBuffer._getShort22031 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getShort", "()S");
			global::java.nio.ByteBuffer._putShort22032 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putShort22033 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getChar22034 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getChar", "()C");
			global::java.nio.ByteBuffer._getChar22035 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getChar", "(I)C");
			global::java.nio.ByteBuffer._putChar22036 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putChar22037 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getInt22038 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getInt", "()I");
			global::java.nio.ByteBuffer._getInt22039 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getInt", "(I)I");
			global::java.nio.ByteBuffer._putInt22040 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putInt22041 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getLong22042 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getLong", "(I)J");
			global::java.nio.ByteBuffer._getLong22043 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getLong", "()J");
			global::java.nio.ByteBuffer._putLong22044 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putLong22045 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getFloat22046 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getFloat", "()F");
			global::java.nio.ByteBuffer._getFloat22047 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getFloat", "(I)F");
			global::java.nio.ByteBuffer._putFloat22048 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putFloat22049 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._getDouble22050 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getDouble", "()D");
			global::java.nio.ByteBuffer._getDouble22051 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "getDouble", "(I)D");
			global::java.nio.ByteBuffer._putDouble22052 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._putDouble22053 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._isDirect22054 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.ByteBuffer._hasArray22055 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.ByteBuffer._array22056 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.ByteBuffer._arrayOffset22057 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.ByteBuffer._wrap22058 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._wrap22059 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([BII)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._allocate22060 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocate", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._duplicate22061 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._allocateDirect22062 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocateDirect", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._slice22063 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._asReadOnlyBuffer22064 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._compact22065 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._order22066 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "order", "(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer._order22067 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.ByteBuffer._asCharBuffer22068 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.ByteBuffer._asShortBuffer22069 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ByteBuffer._asIntBuffer22070 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.ByteBuffer._asLongBuffer22071 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.ByteBuffer._asFloatBuffer22072 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.ByteBuffer._asDoubleBuffer22073 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.ByteBuffer))]
	internal sealed partial class ByteBuffer_ : java.nio.ByteBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ByteBuffer_()
		{
			InitJNI();
		}
		internal ByteBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22074;
		public override byte get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_._get22074);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._get22074);
		}
		internal static global::MonoJavaBridge.MethodId _get22075;
		public override byte get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_._get22075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._get22075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22076;
		public override global::java.nio.ByteBuffer put(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._put22076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._put22076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22077;
		public override global::java.nio.ByteBuffer put(int arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._put22077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._put22077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getShort22078;
		public override short getShort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getShort22078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getShort22078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort22079;
		public override short getShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getShort22079);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getShort22079);
		}
		internal static global::MonoJavaBridge.MethodId _putShort22080;
		public override global::java.nio.ByteBuffer putShort(int arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putShort22080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putShort22080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putShort22081;
		public override global::java.nio.ByteBuffer putShort(short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putShort22081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putShort22081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getChar22082;
		public override char getChar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getChar22082);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getChar22082);
		}
		internal static global::MonoJavaBridge.MethodId _getChar22083;
		public override char getChar(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getChar22083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getChar22083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putChar22084;
		public override global::java.nio.ByteBuffer putChar(int arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putChar22084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putChar22084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putChar22085;
		public override global::java.nio.ByteBuffer putChar(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putChar22085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putChar22085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getInt22086;
		public override int getInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getInt22086);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getInt22086);
		}
		internal static global::MonoJavaBridge.MethodId _getInt22087;
		public override int getInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getInt22087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getInt22087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putInt22088;
		public override global::java.nio.ByteBuffer putInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putInt22088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putInt22088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putInt22089;
		public override global::java.nio.ByteBuffer putInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putInt22089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putInt22089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getLong22090;
		public override long getLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getLong22090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getLong22090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong22091;
		public override long getLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getLong22091);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getLong22091);
		}
		internal static global::MonoJavaBridge.MethodId _putLong22092;
		public override global::java.nio.ByteBuffer putLong(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putLong22092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putLong22092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putLong22093;
		public override global::java.nio.ByteBuffer putLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putLong22093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putLong22093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22094;
		public override float getFloat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getFloat22094);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getFloat22094);
		}
		internal static global::MonoJavaBridge.MethodId _getFloat22095;
		public override float getFloat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getFloat22095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getFloat22095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22096;
		public override global::java.nio.ByteBuffer putFloat(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putFloat22096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putFloat22096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putFloat22097;
		public override global::java.nio.ByteBuffer putFloat(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putFloat22097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putFloat22097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22098;
		public override double getDouble()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getDouble22098);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getDouble22098);
		}
		internal static global::MonoJavaBridge.MethodId _getDouble22099;
		public override double getDouble(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_._getDouble22099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._getDouble22099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22100;
		public override global::java.nio.ByteBuffer putDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putDouble22100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putDouble22100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _putDouble22101;
		public override global::java.nio.ByteBuffer putDouble(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._putDouble22101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._putDouble22101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22102;
		public override bool isDirect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_._isDirect22102);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._isDirect22102);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22103;
		public override global::java.nio.ByteBuffer duplicate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._duplicate22103)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._duplicate22103)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22104;
		public override global::java.nio.ByteBuffer slice()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._slice22104)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._slice22104)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22105;
		public override global::java.nio.ByteBuffer asReadOnlyBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asReadOnlyBuffer22105)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asReadOnlyBuffer22105)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22106;
		public override global::java.nio.ByteBuffer compact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._compact22106)) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._compact22106)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asCharBuffer22107;
		public override global::java.nio.CharBuffer asCharBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asCharBuffer22107)) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asCharBuffer22107)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asShortBuffer22108;
		public override global::java.nio.ShortBuffer asShortBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asShortBuffer22108)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asShortBuffer22108)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asIntBuffer22109;
		public override global::java.nio.IntBuffer asIntBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asIntBuffer22109)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asIntBuffer22109)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asLongBuffer22110;
		public override global::java.nio.LongBuffer asLongBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asLongBuffer22110)) as java.nio.LongBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asLongBuffer22110)) as java.nio.LongBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asFloatBuffer22111;
		public override global::java.nio.FloatBuffer asFloatBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asFloatBuffer22111)) as java.nio.FloatBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asFloatBuffer22111)) as java.nio.FloatBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asDoubleBuffer22112;
		public override global::java.nio.DoubleBuffer asDoubleBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_._asDoubleBuffer22112)) as java.nio.DoubleBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._asDoubleBuffer22112)) as java.nio.DoubleBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22113;
		public override bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_._isReadOnly22113);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ByteBuffer_.staticClass, global::java.nio.ByteBuffer_._isReadOnly22113);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteBuffer"));
			global::java.nio.ByteBuffer_._get22074 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "get", "()B");
			global::java.nio.ByteBuffer_._get22075 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "get", "(I)B");
			global::java.nio.ByteBuffer_._put22076 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "put", "(B)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._put22077 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getShort22078 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getShort", "(I)S");
			global::java.nio.ByteBuffer_._getShort22079 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getShort", "()S");
			global::java.nio.ByteBuffer_._putShort22080 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putShort22081 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getChar22082 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getChar", "()C");
			global::java.nio.ByteBuffer_._getChar22083 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getChar", "(I)C");
			global::java.nio.ByteBuffer_._putChar22084 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putChar22085 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getInt22086 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getInt", "()I");
			global::java.nio.ByteBuffer_._getInt22087 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getInt", "(I)I");
			global::java.nio.ByteBuffer_._putInt22088 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putInt22089 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getLong22090 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getLong", "(I)J");
			global::java.nio.ByteBuffer_._getLong22091 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getLong", "()J");
			global::java.nio.ByteBuffer_._putLong22092 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putLong22093 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getFloat22094 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getFloat", "()F");
			global::java.nio.ByteBuffer_._getFloat22095 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getFloat", "(I)F");
			global::java.nio.ByteBuffer_._putFloat22096 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putFloat22097 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._getDouble22098 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getDouble", "()D");
			global::java.nio.ByteBuffer_._getDouble22099 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "getDouble", "(I)D");
			global::java.nio.ByteBuffer_._putDouble22100 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._putDouble22101 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._isDirect22102 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.ByteBuffer_._duplicate22103 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._slice22104 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "slice", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._asReadOnlyBuffer22105 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._compact22106 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "compact", "()Ljava/nio/ByteBuffer;");
			global::java.nio.ByteBuffer_._asCharBuffer22107 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;");
			global::java.nio.ByteBuffer_._asShortBuffer22108 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ByteBuffer_._asIntBuffer22109 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.ByteBuffer_._asLongBuffer22110 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;");
			global::java.nio.ByteBuffer_._asFloatBuffer22111 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;");
			global::java.nio.ByteBuffer_._asDoubleBuffer22112 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;");
			global::java.nio.ByteBuffer_._isReadOnly22113 = @__env.GetMethodIDNoThrow(global::java.nio.ByteBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
