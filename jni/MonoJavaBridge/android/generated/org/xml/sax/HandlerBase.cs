namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HandlerBase : java.lang.Object, EntityResolver, DTDHandler, DocumentHandler, ErrorHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HandlerBase()
		{
			InitJNI();
		}
		protected HandlerBase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _fatalError34986;
		public virtual void fatalError(org.xml.sax.SAXParseException arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._fatalError34986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._fatalError34986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _error34987;
		public virtual void error(org.xml.sax.SAXParseException arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._error34987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._error34987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _warning34988;
		public virtual void warning(org.xml.sax.SAXParseException arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._warning34988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._warning34988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startElement34989;
		public virtual void startElement(java.lang.String arg0, org.xml.sax.AttributeList arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._startElement34989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._startElement34989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _characters34990;
		public virtual void characters(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._characters34990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._characters34990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement34991;
		public virtual void endElement(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._endElement34991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._endElement34991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument34992;
		public virtual void startDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._startDocument34992);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._startDocument34992);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument34993;
		public virtual void endDocument()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._endDocument34993);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._endDocument34993);
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace34994;
		public virtual void ignorableWhitespace(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._ignorableWhitespace34994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._ignorableWhitespace34994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction34995;
		public virtual void processingInstruction(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._processingInstruction34995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._processingInstruction34995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.xml.sax.Locator DocumentLocator
		{
			set
			{
				setDocumentLocator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator34996;
		public virtual void setDocumentLocator(org.xml.sax.Locator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._setDocumentLocator34996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._setDocumentLocator34996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unparsedEntityDecl34997;
		public virtual void unparsedEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._unparsedEntityDecl34997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._unparsedEntityDecl34997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _notationDecl34998;
		public virtual void notationDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._notationDecl34998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._notationDecl34998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _resolveEntity34999;
		public virtual global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.HandlerBase._resolveEntity34999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._resolveEntity34999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _HandlerBase35000;
		public HandlerBase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.HandlerBase.staticClass, global::org.xml.sax.HandlerBase._HandlerBase35000);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.HandlerBase.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/HandlerBase"));
			global::org.xml.sax.HandlerBase._fatalError34986 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "fatalError", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.HandlerBase._error34987 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "error", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.HandlerBase._warning34988 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "warning", "(Lorg/xml/sax/SAXParseException;)V");
			global::org.xml.sax.HandlerBase._startElement34989 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V");
			global::org.xml.sax.HandlerBase._characters34990 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "characters", "([CII)V");
			global::org.xml.sax.HandlerBase._endElement34991 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "endElement", "(Ljava/lang/String;)V");
			global::org.xml.sax.HandlerBase._startDocument34992 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "startDocument", "()V");
			global::org.xml.sax.HandlerBase._endDocument34993 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "endDocument", "()V");
			global::org.xml.sax.HandlerBase._ignorableWhitespace34994 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "ignorableWhitespace", "([CII)V");
			global::org.xml.sax.HandlerBase._processingInstruction34995 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.HandlerBase._setDocumentLocator34996 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::org.xml.sax.HandlerBase._unparsedEntityDecl34997 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.HandlerBase._notationDecl34998 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.HandlerBase._resolveEntity34999 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
			global::org.xml.sax.HandlerBase._HandlerBase35000 = @__env.GetMethodIDNoThrow(global::org.xml.sax.HandlerBase.staticClass, "<init>", "()V");
		}
	}
}
