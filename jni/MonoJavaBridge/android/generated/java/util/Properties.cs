namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Properties : java.util.Hashtable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Properties()
		{
			InitJNI();
		}
		protected Properties(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty26555;
		public virtual global::java.lang.Object setProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Properties._setProperty26555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._setProperty26555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty26556;
		public virtual global::java.lang.String getProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Properties._getProperty26556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._getProperty26556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty26557;
		public virtual global::java.lang.String getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Properties._getProperty26557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._getProperty26557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _load26558;
		public virtual void load(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._load26558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._load26558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _load26559;
		public virtual void load(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._load26559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._load26559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _list26560;
		public virtual void list(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._list26560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._list26560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _list26561;
		public virtual void list(java.io.PrintWriter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._list26561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._list26561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _save26562;
		public virtual void save(java.io.OutputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._save26562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._save26562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _store26563;
		public virtual void store(java.io.Writer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._store26563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._store26563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _store26564;
		public virtual void store(java.io.OutputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._store26564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._store26564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadFromXML26565;
		public virtual void loadFromXML(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._loadFromXML26565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._loadFromXML26565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _storeToXML26566;
		public virtual void storeToXML(java.io.OutputStream arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._storeToXML26566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._storeToXML26566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _storeToXML26567;
		public virtual void storeToXML(java.io.OutputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Properties._storeToXML26567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._storeToXML26567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _propertyNames26568;
		public virtual global::java.util.Enumeration propertyNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Properties._propertyNames26568)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._propertyNames26568)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _stringPropertyNames26569;
		public virtual global::java.util.Set stringPropertyNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Properties._stringPropertyNames26569)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Properties.staticClass, global::java.util.Properties._stringPropertyNames26569)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _Properties26570;
		public Properties() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Properties.staticClass, global::java.util.Properties._Properties26570);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Properties26571;
		public Properties(java.util.Properties arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Properties.staticClass, global::java.util.Properties._Properties26571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Properties.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Properties"));
			global::java.util.Properties._setProperty26555 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			global::java.util.Properties._getProperty26556 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.Properties._getProperty26557 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.Properties._load26558 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "load", "(Ljava/io/Reader;)V");
			global::java.util.Properties._load26559 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "load", "(Ljava/io/InputStream;)V");
			global::java.util.Properties._list26560 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "list", "(Ljava/io/PrintStream;)V");
			global::java.util.Properties._list26561 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "list", "(Ljava/io/PrintWriter;)V");
			global::java.util.Properties._save26562 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "save", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::java.util.Properties._store26563 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "store", "(Ljava/io/Writer;Ljava/lang/String;)V");
			global::java.util.Properties._store26564 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "store", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::java.util.Properties._loadFromXML26565 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "loadFromXML", "(Ljava/io/InputStream;)V");
			global::java.util.Properties._storeToXML26566 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Properties._storeToXML26567 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::java.util.Properties._propertyNames26568 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "propertyNames", "()Ljava/util/Enumeration;");
			global::java.util.Properties._stringPropertyNames26569 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "stringPropertyNames", "()Ljava/util/Set;");
			global::java.util.Properties._Properties26570 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "<init>", "()V");
			global::java.util.Properties._Properties26571 = @__env.GetMethodIDNoThrow(global::java.util.Properties.staticClass, "<init>", "(Ljava/util/Properties;)V");
		}
	}
}
