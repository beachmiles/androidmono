namespace java.math
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BigDecimal : java.lang.Number, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BigDecimal()
		{
			InitJNI();
		}
		protected BigDecimal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add21163;
		public virtual global::java.math.BigDecimal add(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._add21163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._add21163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _add21164;
		public virtual global::java.math.BigDecimal add(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._add21164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._add21164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _equals21165;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.math.BigDecimal._equals21165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._equals21165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21166;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toString21166)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toString21166)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21167;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._hashCode21167);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._hashCode21167);
		}
		internal static global::MonoJavaBridge.MethodId _abs21168;
		public virtual global::java.math.BigDecimal abs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._abs21168)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._abs21168)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _abs21169;
		public virtual global::java.math.BigDecimal abs(java.math.MathContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._abs21169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._abs21169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _pow21170;
		public virtual global::java.math.BigDecimal pow(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._pow21170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._pow21170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _pow21171;
		public virtual global::java.math.BigDecimal pow(int arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._pow21171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._pow21171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _min21172;
		public virtual global::java.math.BigDecimal min(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._min21172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._min21172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _max21173;
		public virtual global::java.math.BigDecimal max(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._max21173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._max21173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21174;
		public virtual int compareTo(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._compareTo21174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._compareTo21174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21175;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._compareTo21175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._compareTo21175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21176;
		public static global::java.math.BigDecimal valueOf(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._valueOf21176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21177;
		public static global::java.math.BigDecimal valueOf(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._valueOf21177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21178;
		public static global::java.math.BigDecimal valueOf(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._valueOf21178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _intValue21179;
		public override int intValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._intValue21179);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._intValue21179);
		}
		internal static global::MonoJavaBridge.MethodId _longValue21180;
		public override long longValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.math.BigDecimal._longValue21180);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._longValue21180);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue21181;
		public override float floatValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.math.BigDecimal._floatValue21181);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._floatValue21181);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue21182;
		public override double doubleValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.math.BigDecimal._doubleValue21182);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._doubleValue21182);
		}
		internal static global::MonoJavaBridge.MethodId _signum21183;
		public virtual int signum()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._signum21183);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._signum21183);
		}
		internal static global::MonoJavaBridge.MethodId _round21184;
		public virtual global::java.math.BigDecimal round(java.math.MathContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._round21184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._round21184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _ulp21185;
		public virtual global::java.math.BigDecimal ulp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._ulp21185)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._ulp21185)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _scale21186;
		public virtual int scale()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._scale21186);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._scale21186);
		}
		internal static global::MonoJavaBridge.MethodId _subtract21187;
		public virtual global::java.math.BigDecimal subtract(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._subtract21187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._subtract21187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _subtract21188;
		public virtual global::java.math.BigDecimal subtract(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._subtract21188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._subtract21188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _multiply21189;
		public virtual global::java.math.BigDecimal multiply(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._multiply21189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._multiply21189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _multiply21190;
		public virtual global::java.math.BigDecimal multiply(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._multiply21190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._multiply21190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21191;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide21191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21192;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1, java.math.RoundingMode arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide21192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21193;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide21193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21194;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, java.math.RoundingMode arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide21194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21195;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide21195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21196;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide21196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divideAndRemainder21197;
		public virtual global::java.math.BigDecimal[] divideAndRemainder(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigDecimal>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divideAndRemainder21197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigDecimal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideAndRemainder21197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal[];
		}
		internal static global::MonoJavaBridge.MethodId _divideAndRemainder21198;
		public virtual global::java.math.BigDecimal[] divideAndRemainder(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigDecimal>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divideAndRemainder21198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigDecimal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideAndRemainder21198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal[];
		}
		internal static global::MonoJavaBridge.MethodId _remainder21199;
		public virtual global::java.math.BigDecimal remainder(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._remainder21199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._remainder21199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _remainder21200;
		public virtual global::java.math.BigDecimal remainder(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._remainder21200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._remainder21200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _negate21201;
		public virtual global::java.math.BigDecimal negate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._negate21201)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._negate21201)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _negate21202;
		public virtual global::java.math.BigDecimal negate(java.math.MathContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._negate21202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._negate21202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _toBigInteger21203;
		public virtual global::java.math.BigInteger toBigInteger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toBigInteger21203)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toBigInteger21203)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _setScale21204;
		public virtual global::java.math.BigDecimal setScale(int arg0, java.math.RoundingMode arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._setScale21204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._setScale21204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _setScale21205;
		public virtual global::java.math.BigDecimal setScale(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._setScale21205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._setScale21205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _setScale21206;
		public virtual global::java.math.BigDecimal setScale(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._setScale21206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._setScale21206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _precision21207;
		public virtual int precision()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._precision21207);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._precision21207);
		}
		internal static global::MonoJavaBridge.MethodId _divideToIntegralValue21208;
		public virtual global::java.math.BigDecimal divideToIntegralValue(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divideToIntegralValue21208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideToIntegralValue21208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divideToIntegralValue21209;
		public virtual global::java.math.BigDecimal divideToIntegralValue(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divideToIntegralValue21209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideToIntegralValue21209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _plus21210;
		public virtual global::java.math.BigDecimal plus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._plus21210)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._plus21210)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _plus21211;
		public virtual global::java.math.BigDecimal plus(java.math.MathContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._plus21211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._plus21211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _unscaledValue21212;
		public virtual global::java.math.BigInteger unscaledValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._unscaledValue21212)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._unscaledValue21212)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _movePointLeft21213;
		public virtual global::java.math.BigDecimal movePointLeft(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._movePointLeft21213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._movePointLeft21213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _movePointRight21214;
		public virtual global::java.math.BigDecimal movePointRight(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._movePointRight21214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._movePointRight21214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _scaleByPowerOfTen21215;
		public virtual global::java.math.BigDecimal scaleByPowerOfTen(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._scaleByPowerOfTen21215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._scaleByPowerOfTen21215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _stripTrailingZeros21216;
		public virtual global::java.math.BigDecimal stripTrailingZeros()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._stripTrailingZeros21216)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._stripTrailingZeros21216)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _toEngineeringString21217;
		public virtual global::java.lang.String toEngineeringString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toEngineeringString21217)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toEngineeringString21217)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toPlainString21218;
		public virtual global::java.lang.String toPlainString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toPlainString21218)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toPlainString21218)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toBigIntegerExact21219;
		public virtual global::java.math.BigInteger toBigIntegerExact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toBigIntegerExact21219)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toBigIntegerExact21219)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _longValueExact21220;
		public virtual long longValueExact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.math.BigDecimal._longValueExact21220);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._longValueExact21220);
		}
		internal static global::MonoJavaBridge.MethodId _intValueExact21221;
		public virtual int intValueExact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._intValueExact21221);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._intValueExact21221);
		}
		internal static global::MonoJavaBridge.MethodId _shortValueExact21222;
		public virtual short shortValueExact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.math.BigDecimal._shortValueExact21222);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._shortValueExact21222);
		}
		internal static global::MonoJavaBridge.MethodId _byteValueExact21223;
		public virtual byte byteValueExact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.math.BigDecimal._byteValueExact21223);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._byteValueExact21223);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21224;
		public BigDecimal(char[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21225;
		public BigDecimal(char[] arg0, int arg1, int arg2, java.math.MathContext arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21226;
		public BigDecimal(char[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21227;
		public BigDecimal(char[] arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21228;
		public BigDecimal(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21229;
		public BigDecimal(java.lang.String arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21230;
		public BigDecimal(double arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21231;
		public BigDecimal(double arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21232;
		public BigDecimal(java.math.BigInteger arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21233;
		public BigDecimal(java.math.BigInteger arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21234;
		public BigDecimal(java.math.BigInteger arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21235;
		public BigDecimal(java.math.BigInteger arg0, int arg1, java.math.MathContext arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21236;
		public BigDecimal(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21237;
		public BigDecimal(int arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21238;
		public BigDecimal(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21239;
		public BigDecimal(long arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ZERO21240;
		public static global::java.math.BigDecimal ZERO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigDecimal.staticClass, _ZERO21240)) as java.math.BigDecimal;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ONE21241;
		public static global::java.math.BigDecimal ONE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigDecimal.staticClass, _ONE21241)) as java.math.BigDecimal;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TEN21242;
		public static global::java.math.BigDecimal TEN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigDecimal.staticClass, _TEN21242)) as java.math.BigDecimal;
			}
		}
		public static int ROUND_UP
		{
			get
			{
				return 0;
			}
		}
		public static int ROUND_DOWN
		{
			get
			{
				return 1;
			}
		}
		public static int ROUND_CEILING
		{
			get
			{
				return 2;
			}
		}
		public static int ROUND_FLOOR
		{
			get
			{
				return 3;
			}
		}
		public static int ROUND_HALF_UP
		{
			get
			{
				return 4;
			}
		}
		public static int ROUND_HALF_DOWN
		{
			get
			{
				return 5;
			}
		}
		public static int ROUND_HALF_EVEN
		{
			get
			{
				return 6;
			}
		}
		public static int ROUND_UNNECESSARY
		{
			get
			{
				return 7;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.BigDecimal.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/BigDecimal"));
			global::java.math.BigDecimal._add21163 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "add", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._add21164 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "add", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._equals21165 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.math.BigDecimal._toString21166 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toString", "()Ljava/lang/String;");
			global::java.math.BigDecimal._hashCode21167 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "hashCode", "()I");
			global::java.math.BigDecimal._abs21168 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "abs", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._abs21169 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "abs", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._pow21170 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "pow", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._pow21171 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "pow", "(ILjava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._min21172 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "min", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._max21173 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "max", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._compareTo21174 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "compareTo", "(Ljava/math/BigDecimal;)I");
			global::java.math.BigDecimal._compareTo21175 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.math.BigDecimal._valueOf21176 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(JI)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._valueOf21177 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(D)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._valueOf21178 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(J)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._intValue21179 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "intValue", "()I");
			global::java.math.BigDecimal._longValue21180 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "longValue", "()J");
			global::java.math.BigDecimal._floatValue21181 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "floatValue", "()F");
			global::java.math.BigDecimal._doubleValue21182 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "doubleValue", "()D");
			global::java.math.BigDecimal._signum21183 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "signum", "()I");
			global::java.math.BigDecimal._round21184 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "round", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._ulp21185 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "ulp", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._scale21186 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "scale", "()I");
			global::java.math.BigDecimal._subtract21187 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "subtract", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._subtract21188 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "subtract", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._multiply21189 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "multiply", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._multiply21190 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "multiply", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide21191 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide21192 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide21193 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide21194 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;Ljava/math/RoundingMode;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide21195 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide21196 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;II)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divideAndRemainder21197 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideAndRemainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)[Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divideAndRemainder21198 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideAndRemainder", "(Ljava/math/BigDecimal;)[Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._remainder21199 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "remainder", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._remainder21200 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "remainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._negate21201 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "negate", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._negate21202 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "negate", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._toBigInteger21203 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toBigInteger", "()Ljava/math/BigInteger;");
			global::java.math.BigDecimal._setScale21204 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "setScale", "(ILjava/math/RoundingMode;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._setScale21205 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "setScale", "(II)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._setScale21206 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "setScale", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._precision21207 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "precision", "()I");
			global::java.math.BigDecimal._divideToIntegralValue21208 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideToIntegralValue", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divideToIntegralValue21209 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideToIntegralValue", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._plus21210 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "plus", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._plus21211 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "plus", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._unscaledValue21212 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "unscaledValue", "()Ljava/math/BigInteger;");
			global::java.math.BigDecimal._movePointLeft21213 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "movePointLeft", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._movePointRight21214 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "movePointRight", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._scaleByPowerOfTen21215 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "scaleByPowerOfTen", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._stripTrailingZeros21216 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "stripTrailingZeros", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._toEngineeringString21217 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toEngineeringString", "()Ljava/lang/String;");
			global::java.math.BigDecimal._toPlainString21218 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toPlainString", "()Ljava/lang/String;");
			global::java.math.BigDecimal._toBigIntegerExact21219 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toBigIntegerExact", "()Ljava/math/BigInteger;");
			global::java.math.BigDecimal._longValueExact21220 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "longValueExact", "()J");
			global::java.math.BigDecimal._intValueExact21221 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "intValueExact", "()I");
			global::java.math.BigDecimal._shortValueExact21222 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "shortValueExact", "()S");
			global::java.math.BigDecimal._byteValueExact21223 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "byteValueExact", "()B");
			global::java.math.BigDecimal._BigDecimal21224 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CII)V");
			global::java.math.BigDecimal._BigDecimal21225 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CIILjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21226 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([C)V");
			global::java.math.BigDecimal._BigDecimal21227 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CLjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21228 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.math.BigDecimal._BigDecimal21229 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/lang/String;Ljava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21230 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(D)V");
			global::java.math.BigDecimal._BigDecimal21231 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(DLjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21232 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;)V");
			global::java.math.BigDecimal._BigDecimal21233 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21234 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;I)V");
			global::java.math.BigDecimal._BigDecimal21235 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;ILjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21236 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(I)V");
			global::java.math.BigDecimal._BigDecimal21237 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(ILjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21238 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(J)V");
			global::java.math.BigDecimal._BigDecimal21239 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(JLjava/math/MathContext;)V");
			global::java.math.BigDecimal._ZERO21240 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigDecimal.staticClass, "ZERO", "Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._ONE21241 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigDecimal.staticClass, "ONE", "Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._TEN21242 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigDecimal.staticClass, "TEN", "Ljava/math/BigDecimal;");
		}
	}
}
