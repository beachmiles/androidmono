namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.parsers.DocumentBuilderFactory_))]
	public abstract partial class DocumentBuilderFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DocumentBuilderFactory()
		{
			InitJNI();
		}
		protected DocumentBuilderFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance30853;
		public static global::javax.xml.parsers.DocumentBuilderFactory newInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._newInstance30853)) as javax.xml.parsers.DocumentBuilderFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance30854;
		public static global::javax.xml.parsers.DocumentBuilderFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._newInstance30854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.parsers.DocumentBuilderFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute30855;
		public abstract global::java.lang.Object getAttribute(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setFeature30856;
		public abstract void setFeature(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _getFeature30857;
		public abstract bool getFeature(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setAttribute30858;
		public abstract void setAttribute(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware30859;
		public virtual bool isNamespaceAware()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isNamespaceAware30859);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isNamespaceAware30859);
		}
		internal static global::MonoJavaBridge.MethodId _isValidating30860;
		public virtual bool isValidating()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isValidating30860);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isValidating30860);
		}
		internal static global::MonoJavaBridge.MethodId _getSchema30861;
		public virtual global::javax.xml.validation.Schema getSchema()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._getSchema30861)) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._getSchema30861)) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _isXIncludeAware30862;
		public virtual bool isXIncludeAware()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isXIncludeAware30862);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isXIncludeAware30862);
		}
		internal static global::MonoJavaBridge.MethodId _newDocumentBuilder30863;
		public abstract global::javax.xml.parsers.DocumentBuilder newDocumentBuilder();
		internal static global::MonoJavaBridge.MethodId _setNamespaceAware30864;
		public virtual void setNamespaceAware(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setNamespaceAware30864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setNamespaceAware30864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setValidating30865;
		public virtual void setValidating(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setValidating30865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setValidating30865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIgnoringElementContentWhitespace30866;
		public virtual void setIgnoringElementContentWhitespace(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringElementContentWhitespace30866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringElementContentWhitespace30866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpandEntityReferences30867;
		public virtual void setExpandEntityReferences(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setExpandEntityReferences30867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setExpandEntityReferences30867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIgnoringComments30868;
		public virtual void setIgnoringComments(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringComments30868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringComments30868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCoalescing30869;
		public virtual void setCoalescing(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setCoalescing30869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setCoalescing30869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIgnoringElementContentWhitespace30870;
		public virtual bool isIgnoringElementContentWhitespace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringElementContentWhitespace30870);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringElementContentWhitespace30870);
		}
		internal static global::MonoJavaBridge.MethodId _isExpandEntityReferences30871;
		public virtual bool isExpandEntityReferences()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isExpandEntityReferences30871);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isExpandEntityReferences30871);
		}
		internal static global::MonoJavaBridge.MethodId _isIgnoringComments30872;
		public virtual bool isIgnoringComments()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringComments30872);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringComments30872);
		}
		internal static global::MonoJavaBridge.MethodId _isCoalescing30873;
		public virtual bool isCoalescing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isCoalescing30873);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isCoalescing30873);
		}
		internal static global::MonoJavaBridge.MethodId _setSchema30874;
		public virtual void setSchema(javax.xml.validation.Schema arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setSchema30874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setSchema30874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setXIncludeAware30875;
		public virtual void setXIncludeAware(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setXIncludeAware30875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setXIncludeAware30875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DocumentBuilderFactory30876;
		protected DocumentBuilderFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._DocumentBuilderFactory30876);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilderFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilderFactory"));
			global::javax.xml.parsers.DocumentBuilderFactory._newInstance30853 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "newInstance", "()Ljavax/xml/parsers/DocumentBuilderFactory;");
			global::javax.xml.parsers.DocumentBuilderFactory._newInstance30854 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/parsers/DocumentBuilderFactory;");
			global::javax.xml.parsers.DocumentBuilderFactory._getAttribute30855 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.parsers.DocumentBuilderFactory._setFeature30856 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._getFeature30857 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.parsers.DocumentBuilderFactory._setAttribute30858 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.parsers.DocumentBuilderFactory._isNamespaceAware30859 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._isValidating30860 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._getSchema30861 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;");
			global::javax.xml.parsers.DocumentBuilderFactory._isXIncludeAware30862 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isXIncludeAware", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._newDocumentBuilder30863 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "newDocumentBuilder", "()Ljavax/xml/parsers/DocumentBuilder;");
			global::javax.xml.parsers.DocumentBuilderFactory._setNamespaceAware30864 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setNamespaceAware", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._setValidating30865 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setValidating", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringElementContentWhitespace30866 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setIgnoringElementContentWhitespace", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._setExpandEntityReferences30867 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setExpandEntityReferences", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringComments30868 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setIgnoringComments", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._setCoalescing30869 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setCoalescing", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringElementContentWhitespace30870 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isIgnoringElementContentWhitespace", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._isExpandEntityReferences30871 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isExpandEntityReferences", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringComments30872 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isIgnoringComments", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._isCoalescing30873 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isCoalescing", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._setSchema30874 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setSchema", "(Ljavax/xml/validation/Schema;)V");
			global::javax.xml.parsers.DocumentBuilderFactory._setXIncludeAware30875 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setXIncludeAware", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._DocumentBuilderFactory30876 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.parsers.DocumentBuilderFactory))]
	internal sealed partial class DocumentBuilderFactory_ : javax.xml.parsers.DocumentBuilderFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DocumentBuilderFactory_()
		{
			InitJNI();
		}
		internal DocumentBuilderFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute30877;
		public override global::java.lang.Object getAttribute(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_._getAttribute30877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, global::javax.xml.parsers.DocumentBuilderFactory_._getAttribute30877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature30878;
		public override void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_._setFeature30878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, global::javax.xml.parsers.DocumentBuilderFactory_._setFeature30878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature30879;
		public override bool getFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_._getFeature30879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, global::javax.xml.parsers.DocumentBuilderFactory_._getFeature30879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute30880;
		public override void setAttribute(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_._setAttribute30880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, global::javax.xml.parsers.DocumentBuilderFactory_._setAttribute30880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newDocumentBuilder30881;
		public override global::javax.xml.parsers.DocumentBuilder newDocumentBuilder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_._newDocumentBuilder30881)) as javax.xml.parsers.DocumentBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, global::javax.xml.parsers.DocumentBuilderFactory_._newDocumentBuilder30881)) as javax.xml.parsers.DocumentBuilder;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilderFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilderFactory"));
			global::javax.xml.parsers.DocumentBuilderFactory_._getAttribute30877 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.parsers.DocumentBuilderFactory_._setFeature30878 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory_._getFeature30879 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.parsers.DocumentBuilderFactory_._setAttribute30880 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.parsers.DocumentBuilderFactory_._newDocumentBuilder30881 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "newDocumentBuilder", "()Ljavax/xml/parsers/DocumentBuilder;");
		}
	}
}
