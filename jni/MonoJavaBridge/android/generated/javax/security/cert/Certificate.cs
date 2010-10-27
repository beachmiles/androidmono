namespace javax.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.security.cert.Certificate_))]
	public abstract partial class Certificate : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Certificate()
		{
			InitJNI();
		}
		protected Certificate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals30223;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.security.cert.Certificate._equals30223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.cert.Certificate.staticClass, global::javax.security.cert.Certificate._equals30223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString30224;
		public abstract global::java.lang.String toString();
		internal static global::MonoJavaBridge.MethodId _hashCode30225;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.security.cert.Certificate._hashCode30225);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.security.cert.Certificate.staticClass, global::javax.security.cert.Certificate._hashCode30225);
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded30226;
		public abstract byte[] getEncoded();
		internal static global::MonoJavaBridge.MethodId _verify30227;
		public abstract void verify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _verify30228;
		public abstract void verify(java.security.PublicKey arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _getPublicKey30229;
		public abstract global::java.security.PublicKey getPublicKey();
		internal static global::MonoJavaBridge.MethodId _Certificate30230;
		public Certificate() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.cert.Certificate.staticClass, global::javax.security.cert.Certificate._Certificate30230);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.Certificate.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/Certificate"));
			global::javax.security.cert.Certificate._equals30223 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.security.cert.Certificate._toString30224 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.cert.Certificate._hashCode30225 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "hashCode", "()I");
			global::javax.security.cert.Certificate._getEncoded30226 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "getEncoded", "()[B");
			global::javax.security.cert.Certificate._verify30227 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::javax.security.cert.Certificate._verify30228 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::javax.security.cert.Certificate._getPublicKey30229 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
			global::javax.security.cert.Certificate._Certificate30230 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.security.cert.Certificate))]
	internal sealed partial class Certificate_ : javax.security.cert.Certificate
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Certificate_()
		{
			InitJNI();
		}
		internal Certificate_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString30231;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_._toString30231)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._toString30231)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded30232;
		public override byte[] getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_._getEncoded30232)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._getEncoded30232)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _verify30233;
		public override void verify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.Certificate_._verify30233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._verify30233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verify30234;
		public override void verify(java.security.PublicKey arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.cert.Certificate_._verify30234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._verify30234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicKey30235;
		public override global::java.security.PublicKey getPublicKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_._getPublicKey30235)) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.cert.Certificate_.staticClass, global::javax.security.cert.Certificate_._getPublicKey30235)) as java.security.PublicKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.cert.Certificate_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/cert/Certificate"));
			global::javax.security.cert.Certificate_._toString30231 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.cert.Certificate_._getEncoded30232 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "getEncoded", "()[B");
			global::javax.security.cert.Certificate_._verify30233 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;)V");
			global::javax.security.cert.Certificate_._verify30234 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			global::javax.security.cert.Certificate_._getPublicKey30235 = @__env.GetMethodIDNoThrow(global::javax.security.cert.Certificate_.staticClass, "getPublicKey", "()Ljava/security/PublicKey;");
		}
	}
}
