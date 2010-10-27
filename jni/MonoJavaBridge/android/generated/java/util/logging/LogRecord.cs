namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LogRecord : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LogRecord()
		{
			InitJNI();
		}
		protected LogRecord(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
			set
			{
				setMessage(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage28010;
		public virtual global::java.lang.String getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord._getMessage28010)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._getMessage28010)) as java.lang.String;
		}
		public new global::java.lang.Object[] Parameters
		{
			get
			{
				return getParameters();
			}
			set
			{
				setParameters(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameters28011;
		public virtual global::java.lang.Object[] getParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord._getParameters28011)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._getParameters28011)) as java.lang.Object[];
		}
		public new long Millis
		{
			get
			{
				return getMillis();
			}
			set
			{
				setMillis(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMillis28012;
		public virtual long getMillis()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.logging.LogRecord._getMillis28012);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._getMillis28012);
		}
		internal static global::MonoJavaBridge.MethodId _setMillis28013;
		public virtual void setMillis(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord._setMillis28013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._setMillis28013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLevel28014;
		public virtual void setLevel(java.util.logging.Level arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord._setLevel28014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._setLevel28014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.logging.Level Level
		{
			get
			{
				return getLevel();
			}
			set
			{
				setLevel(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLevel28015;
		public virtual global::java.util.logging.Level getLevel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord._getLevel28015)) as java.util.logging.Level;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._getLevel28015)) as java.util.logging.Level;
		}
		internal static global::MonoJavaBridge.MethodId _setMessage28016;
		public virtual void setMessage(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord._setMessage28016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._setMessage28016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setParameters28017;
		public virtual void setParameters(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord._setParameters28017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._setParameters28017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.ResourceBundle ResourceBundle
		{
			get
			{
				return getResourceBundle();
			}
			set
			{
				setResourceBundle(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResourceBundle28018;
		public virtual global::java.util.ResourceBundle getResourceBundle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord._getResourceBundle28018)) as java.util.ResourceBundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._getResourceBundle28018)) as java.util.ResourceBundle;
		}
		public new global::java.lang.String ResourceBundleName
		{
			get
			{
				return getResourceBundleName();
			}
			set
			{
				setResourceBundleName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResourceBundleName28019;
		public virtual global::java.lang.String getResourceBundleName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord._getResourceBundleName28019)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._getResourceBundleName28019)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setLoggerName28020;
		public virtual void setLoggerName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord._setLoggerName28020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._setLoggerName28020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setResourceBundleName28021;
		public virtual void setResourceBundleName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord._setResourceBundleName28021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._setResourceBundleName28021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setResourceBundle28022;
		public virtual void setResourceBundle(java.util.ResourceBundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord._setResourceBundle28022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._setResourceBundle28022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setThrown28023;
		public virtual void setThrown(java.lang.Throwable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord._setThrown28023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._setThrown28023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSourceClassName28024;
		public virtual void setSourceClassName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord._setSourceClassName28024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._setSourceClassName28024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSourceMethodName28025;
		public virtual void setSourceMethodName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord._setSourceMethodName28025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._setSourceMethodName28025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String LoggerName
		{
			get
			{
				return getLoggerName();
			}
			set
			{
				setLoggerName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoggerName28026;
		public virtual global::java.lang.String getLoggerName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord._getLoggerName28026)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._getLoggerName28026)) as java.lang.String;
		}
		public new long SequenceNumber
		{
			get
			{
				return getSequenceNumber();
			}
			set
			{
				setSequenceNumber(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSequenceNumber28027;
		public virtual long getSequenceNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.logging.LogRecord._getSequenceNumber28027);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._getSequenceNumber28027);
		}
		internal static global::MonoJavaBridge.MethodId _setSequenceNumber28028;
		public virtual void setSequenceNumber(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord._setSequenceNumber28028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._setSequenceNumber28028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SourceClassName
		{
			get
			{
				return getSourceClassName();
			}
			set
			{
				setSourceClassName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSourceClassName28029;
		public virtual global::java.lang.String getSourceClassName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord._getSourceClassName28029)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._getSourceClassName28029)) as java.lang.String;
		}
		public new global::java.lang.String SourceMethodName
		{
			get
			{
				return getSourceMethodName();
			}
			set
			{
				setSourceMethodName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSourceMethodName28030;
		public virtual global::java.lang.String getSourceMethodName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord._getSourceMethodName28030)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._getSourceMethodName28030)) as java.lang.String;
		}
		public new int ThreadID
		{
			get
			{
				return getThreadID();
			}
			set
			{
				setThreadID(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadID28031;
		public virtual int getThreadID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.logging.LogRecord._getThreadID28031);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._getThreadID28031);
		}
		internal static global::MonoJavaBridge.MethodId _setThreadID28032;
		public virtual void setThreadID(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord._setThreadID28032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._setThreadID28032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.Throwable Thrown
		{
			get
			{
				return getThrown();
			}
			set
			{
				setThrown(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThrown28033;
		public virtual global::java.lang.Throwable getThrown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord._getThrown28033)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._getThrown28033)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _LogRecord28034;
		public LogRecord(java.util.logging.Level arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.LogRecord.staticClass, global::java.util.logging.LogRecord._LogRecord28034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.LogRecord.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/LogRecord"));
			global::java.util.logging.LogRecord._getMessage28010 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.logging.LogRecord._getParameters28011 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "getParameters", "()[Ljava/lang/Object;");
			global::java.util.logging.LogRecord._getMillis28012 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "getMillis", "()J");
			global::java.util.logging.LogRecord._setMillis28013 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "setMillis", "(J)V");
			global::java.util.logging.LogRecord._setLevel28014 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "setLevel", "(Ljava/util/logging/Level;)V");
			global::java.util.logging.LogRecord._getLevel28015 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "getLevel", "()Ljava/util/logging/Level;");
			global::java.util.logging.LogRecord._setMessage28016 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "setMessage", "(Ljava/lang/String;)V");
			global::java.util.logging.LogRecord._setParameters28017 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "setParameters", "([Ljava/lang/Object;)V");
			global::java.util.logging.LogRecord._getResourceBundle28018 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "getResourceBundle", "()Ljava/util/ResourceBundle;");
			global::java.util.logging.LogRecord._getResourceBundleName28019 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "getResourceBundleName", "()Ljava/lang/String;");
			global::java.util.logging.LogRecord._setLoggerName28020 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "setLoggerName", "(Ljava/lang/String;)V");
			global::java.util.logging.LogRecord._setResourceBundleName28021 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "setResourceBundleName", "(Ljava/lang/String;)V");
			global::java.util.logging.LogRecord._setResourceBundle28022 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "setResourceBundle", "(Ljava/util/ResourceBundle;)V");
			global::java.util.logging.LogRecord._setThrown28023 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "setThrown", "(Ljava/lang/Throwable;)V");
			global::java.util.logging.LogRecord._setSourceClassName28024 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "setSourceClassName", "(Ljava/lang/String;)V");
			global::java.util.logging.LogRecord._setSourceMethodName28025 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "setSourceMethodName", "(Ljava/lang/String;)V");
			global::java.util.logging.LogRecord._getLoggerName28026 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "getLoggerName", "()Ljava/lang/String;");
			global::java.util.logging.LogRecord._getSequenceNumber28027 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "getSequenceNumber", "()J");
			global::java.util.logging.LogRecord._setSequenceNumber28028 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "setSequenceNumber", "(J)V");
			global::java.util.logging.LogRecord._getSourceClassName28029 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "getSourceClassName", "()Ljava/lang/String;");
			global::java.util.logging.LogRecord._getSourceMethodName28030 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "getSourceMethodName", "()Ljava/lang/String;");
			global::java.util.logging.LogRecord._getThreadID28031 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "getThreadID", "()I");
			global::java.util.logging.LogRecord._setThreadID28032 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "setThreadID", "(I)V");
			global::java.util.logging.LogRecord._getThrown28033 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "getThrown", "()Ljava/lang/Throwable;");
			global::java.util.logging.LogRecord._LogRecord28034 = @__env.GetMethodIDNoThrow(global::java.util.logging.LogRecord.staticClass, "<init>", "(Ljava/util/logging/Level;Ljava/lang/String;)V");
		}
	}
}
