namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class UnresolvedPermission : java.security.Permission, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnresolvedPermission()
		{
			InitJNI();
		}
		internal UnresolvedPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23418;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.UnresolvedPermission._equals23418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._equals23418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23419;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._toString23419)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._toString23419)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23420;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.UnresolvedPermission._hashCode23420);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._hashCode23420);
		}
		internal static global::MonoJavaBridge.MethodId _implies23421;
		public sealed override bool implies(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.UnresolvedPermission._implies23421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._implies23421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActions23422;
		public sealed override global::java.lang.String getActions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._getActions23422)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._getActions23422)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection23423;
		public sealed override global::java.security.PermissionCollection newPermissionCollection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._newPermissionCollection23423)) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._newPermissionCollection23423)) as java.security.PermissionCollection;
		}
		public new global::java.lang.String UnresolvedType
		{
			get
			{
				return getUnresolvedType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUnresolvedType23424;
		public global::java.lang.String getUnresolvedType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._getUnresolvedType23424)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._getUnresolvedType23424)) as java.lang.String;
		}
		public new global::java.lang.String UnresolvedName
		{
			get
			{
				return getUnresolvedName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUnresolvedName23425;
		public global::java.lang.String getUnresolvedName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._getUnresolvedName23425)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._getUnresolvedName23425)) as java.lang.String;
		}
		public new global::java.lang.String UnresolvedActions
		{
			get
			{
				return getUnresolvedActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUnresolvedActions23426;
		public global::java.lang.String getUnresolvedActions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._getUnresolvedActions23426)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._getUnresolvedActions23426)) as java.lang.String;
		}
		public new global::java.security.cert.Certificate[] UnresolvedCerts
		{
			get
			{
				return getUnresolvedCerts();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUnresolvedCerts23427;
		public global::java.security.cert.Certificate[] getUnresolvedCerts()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._getUnresolvedCerts23427)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._getUnresolvedCerts23427)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _UnresolvedPermission23428;
		public UnresolvedPermission(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.security.cert.Certificate[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._UnresolvedPermission23428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.UnresolvedPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/UnresolvedPermission"));
			global::java.security.UnresolvedPermission._equals23418 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.UnresolvedPermission._toString23419 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.UnresolvedPermission._hashCode23420 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "hashCode", "()I");
			global::java.security.UnresolvedPermission._implies23421 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.UnresolvedPermission._getActions23422 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "getActions", "()Ljava/lang/String;");
			global::java.security.UnresolvedPermission._newPermissionCollection23423 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;");
			global::java.security.UnresolvedPermission._getUnresolvedType23424 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "getUnresolvedType", "()Ljava/lang/String;");
			global::java.security.UnresolvedPermission._getUnresolvedName23425 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "getUnresolvedName", "()Ljava/lang/String;");
			global::java.security.UnresolvedPermission._getUnresolvedActions23426 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "getUnresolvedActions", "()Ljava/lang/String;");
			global::java.security.UnresolvedPermission._getUnresolvedCerts23427 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "getUnresolvedCerts", "()[Ljava/security/cert/Certificate;");
			global::java.security.UnresolvedPermission._UnresolvedPermission23428 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/security/cert/Certificate;)V");
		}
	}
}
