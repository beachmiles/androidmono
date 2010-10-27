namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DatatypeConstants : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatatypeConstants()
		{
			InitJNI();
		}
		internal DatatypeConstants(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Field : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Field()
			{
				InitJNI();
			}
			internal Field(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString30638;
			public sealed override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeConstants.Field._toString30638)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeConstants.Field.staticClass, global::javax.xml.datatype.DatatypeConstants.Field._toString30638)) as java.lang.String;
			}
			public new int Id
			{
				get
				{
					return getId();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getId30639;
			public int getId()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeConstants.Field._getId30639);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeConstants.Field.staticClass, global::javax.xml.datatype.DatatypeConstants.Field._getId30639);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.xml.datatype.DatatypeConstants.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeConstants$Field"));
				global::javax.xml.datatype.DatatypeConstants.Field._toString30638 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConstants.Field.staticClass, "toString", "()Ljava/lang/String;");
				global::javax.xml.datatype.DatatypeConstants.Field._getId30639 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConstants.Field.staticClass, "getId", "()I");
			}
		}
		public static int JANUARY
		{
			get
			{
				return 1;
			}
		}
		public static int FEBRUARY
		{
			get
			{
				return 2;
			}
		}
		public static int MARCH
		{
			get
			{
				return 3;
			}
		}
		public static int APRIL
		{
			get
			{
				return 4;
			}
		}
		public static int MAY
		{
			get
			{
				return 5;
			}
		}
		public static int JUNE
		{
			get
			{
				return 6;
			}
		}
		public static int JULY
		{
			get
			{
				return 7;
			}
		}
		public static int AUGUST
		{
			get
			{
				return 8;
			}
		}
		public static int SEPTEMBER
		{
			get
			{
				return 9;
			}
		}
		public static int OCTOBER
		{
			get
			{
				return 10;
			}
		}
		public static int NOVEMBER
		{
			get
			{
				return 11;
			}
		}
		public static int DECEMBER
		{
			get
			{
				return 12;
			}
		}
		public static int LESSER
		{
			get
			{
				return -1;
			}
		}
		public static int EQUAL
		{
			get
			{
				return 0;
			}
		}
		public static int GREATER
		{
			get
			{
				return 1;
			}
		}
		public static int INDETERMINATE
		{
			get
			{
				return 2;
			}
		}
		public static int FIELD_UNDEFINED
		{
			get
			{
				return -2147483648;
			}
		}
		internal static global::MonoJavaBridge.FieldId _YEARS30657;
		public static global::javax.xml.datatype.DatatypeConstants.Field YEARS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.xml.datatype.DatatypeConstants.Field>(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _YEARS30657)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MONTHS30658;
		public static global::javax.xml.datatype.DatatypeConstants.Field MONTHS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.xml.datatype.DatatypeConstants.Field>(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _MONTHS30658)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DAYS30659;
		public static global::javax.xml.datatype.DatatypeConstants.Field DAYS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.xml.datatype.DatatypeConstants.Field>(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DAYS30659)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HOURS30660;
		public static global::javax.xml.datatype.DatatypeConstants.Field HOURS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.xml.datatype.DatatypeConstants.Field>(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _HOURS30660)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MINUTES30661;
		public static global::javax.xml.datatype.DatatypeConstants.Field MINUTES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.xml.datatype.DatatypeConstants.Field>(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _MINUTES30661)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SECONDS30662;
		public static global::javax.xml.datatype.DatatypeConstants.Field SECONDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.xml.datatype.DatatypeConstants.Field>(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _SECONDS30662)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DATETIME30663;
		public static global::javax.xml.@namespace.QName DATETIME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DATETIME30663)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TIME30664;
		public static global::javax.xml.@namespace.QName TIME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _TIME30664)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DATE30665;
		public static global::javax.xml.@namespace.QName DATE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DATE30665)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GYEARMONTH30666;
		public static global::javax.xml.@namespace.QName GYEARMONTH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GYEARMONTH30666)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GMONTHDAY30667;
		public static global::javax.xml.@namespace.QName GMONTHDAY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GMONTHDAY30667)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GYEAR30668;
		public static global::javax.xml.@namespace.QName GYEAR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GYEAR30668)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GMONTH30669;
		public static global::javax.xml.@namespace.QName GMONTH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GMONTH30669)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GDAY30670;
		public static global::javax.xml.@namespace.QName GDAY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GDAY30670)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DURATION30671;
		public static global::javax.xml.@namespace.QName DURATION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DURATION30671)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DURATION_DAYTIME30672;
		public static global::javax.xml.@namespace.QName DURATION_DAYTIME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DURATION_DAYTIME30672)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DURATION_YEARMONTH30673;
		public static global::javax.xml.@namespace.QName DURATION_YEARMONTH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DURATION_YEARMONTH30673)) as javax.xml.@namespace.QName;
			}
		}
		public static int MAX_TIMEZONE_OFFSET
		{
			get
			{
				return -840;
			}
		}
		public static int MIN_TIMEZONE_OFFSET
		{
			get
			{
				return 840;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeConstants.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeConstants"));
			global::javax.xml.datatype.DatatypeConstants._YEARS30657 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "YEARS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._MONTHS30658 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "MONTHS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._DAYS30659 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DAYS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._HOURS30660 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "HOURS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._MINUTES30661 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "MINUTES", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._SECONDS30662 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "SECONDS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._DATETIME30663 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DATETIME", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._TIME30664 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "TIME", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._DATE30665 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DATE", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GYEARMONTH30666 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GYEARMONTH", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GMONTHDAY30667 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GMONTHDAY", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GYEAR30668 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GYEAR", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GMONTH30669 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GMONTH", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GDAY30670 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GDAY", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._DURATION30671 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DURATION", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._DURATION_DAYTIME30672 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DURATION_DAYTIME", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._DURATION_YEARMONTH30673 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DURATION_YEARMONTH", "Ljavax/xml/namespace/QName;");
		}
	}
}
