namespace java.math
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class MathContext : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MathContext()
		{
			InitJNI();
		}
		internal MathContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21305;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.math.MathContext._equals21305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.math.MathContext.staticClass, global::java.math.MathContext._equals21305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21306;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.MathContext._toString21306)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.MathContext.staticClass, global::java.math.MathContext._toString21306)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21307;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.MathContext._hashCode21307);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.MathContext.staticClass, global::java.math.MathContext._hashCode21307);
		}
		public new int Precision
		{
			get
			{
				return getPrecision();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrecision21308;
		public int getPrecision()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.MathContext._getPrecision21308);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.MathContext.staticClass, global::java.math.MathContext._getPrecision21308);
		}
		public new global::java.math.RoundingMode RoundingMode
		{
			get
			{
				return getRoundingMode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRoundingMode21309;
		public global::java.math.RoundingMode getRoundingMode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.MathContext._getRoundingMode21309)) as java.math.RoundingMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.MathContext.staticClass, global::java.math.MathContext._getRoundingMode21309)) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.MethodId _MathContext21310;
		public MathContext(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.MathContext.staticClass, global::java.math.MathContext._MathContext21310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MathContext21311;
		public MathContext(int arg0, java.math.RoundingMode arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.MathContext.staticClass, global::java.math.MathContext._MathContext21311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MathContext21312;
		public MathContext(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.MathContext.staticClass, global::java.math.MathContext._MathContext21312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _UNLIMITED21313;
		public static global::java.math.MathContext UNLIMITED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.MathContext>(@__env.GetStaticObjectField(global::java.math.MathContext.staticClass, _UNLIMITED21313)) as java.math.MathContext;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DECIMAL3221314;
		public static global::java.math.MathContext DECIMAL32
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.MathContext>(@__env.GetStaticObjectField(global::java.math.MathContext.staticClass, _DECIMAL3221314)) as java.math.MathContext;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DECIMAL6421315;
		public static global::java.math.MathContext DECIMAL64
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.MathContext>(@__env.GetStaticObjectField(global::java.math.MathContext.staticClass, _DECIMAL6421315)) as java.math.MathContext;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DECIMAL12821316;
		public static global::java.math.MathContext DECIMAL128
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.MathContext>(@__env.GetStaticObjectField(global::java.math.MathContext.staticClass, _DECIMAL12821316)) as java.math.MathContext;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.MathContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/MathContext"));
			global::java.math.MathContext._equals21305 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.math.MathContext._toString21306 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "toString", "()Ljava/lang/String;");
			global::java.math.MathContext._hashCode21307 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "hashCode", "()I");
			global::java.math.MathContext._getPrecision21308 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "getPrecision", "()I");
			global::java.math.MathContext._getRoundingMode21309 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;");
			global::java.math.MathContext._MathContext21310 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "<init>", "(I)V");
			global::java.math.MathContext._MathContext21311 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "<init>", "(ILjava/math/RoundingMode;)V");
			global::java.math.MathContext._MathContext21312 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.math.MathContext._UNLIMITED21313 = @__env.GetStaticFieldIDNoThrow(global::java.math.MathContext.staticClass, "UNLIMITED", "Ljava/math/MathContext;");
			global::java.math.MathContext._DECIMAL3221314 = @__env.GetStaticFieldIDNoThrow(global::java.math.MathContext.staticClass, "DECIMAL32", "Ljava/math/MathContext;");
			global::java.math.MathContext._DECIMAL6421315 = @__env.GetStaticFieldIDNoThrow(global::java.math.MathContext.staticClass, "DECIMAL64", "Ljava/math/MathContext;");
			global::java.math.MathContext._DECIMAL12821316 = @__env.GetStaticFieldIDNoThrow(global::java.math.MathContext.staticClass, "DECIMAL128", "Ljava/math/MathContext;");
		}
	}
}
