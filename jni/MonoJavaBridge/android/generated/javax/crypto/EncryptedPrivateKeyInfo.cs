namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EncryptedPrivateKeyInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EncryptedPrivateKeyInfo()
		{
			InitJNI();
		}
		protected EncryptedPrivateKeyInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new byte[] Encoded
		{
			get
			{
				return getEncoded();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded28580;
		public virtual byte[] getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo._getEncoded28580)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._getEncoded28580)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getKeySpec28581;
		public virtual global::java.security.spec.PKCS8EncodedKeySpec getKeySpec(java.security.Key arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo._getKeySpec28581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.PKCS8EncodedKeySpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._getKeySpec28581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.PKCS8EncodedKeySpec;
		}
		internal static global::MonoJavaBridge.MethodId _getKeySpec28582;
		public virtual global::java.security.spec.PKCS8EncodedKeySpec getKeySpec(java.security.Key arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo._getKeySpec28582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.PKCS8EncodedKeySpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._getKeySpec28582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.PKCS8EncodedKeySpec;
		}
		internal static global::MonoJavaBridge.MethodId _getKeySpec28583;
		public virtual global::java.security.spec.PKCS8EncodedKeySpec getKeySpec(javax.crypto.Cipher arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo._getKeySpec28583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.PKCS8EncodedKeySpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._getKeySpec28583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.spec.PKCS8EncodedKeySpec;
		}
		internal static global::MonoJavaBridge.MethodId _getKeySpec28584;
		public virtual global::java.security.spec.PKCS8EncodedKeySpec getKeySpec(java.security.Key arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo._getKeySpec28584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.PKCS8EncodedKeySpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._getKeySpec28584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.PKCS8EncodedKeySpec;
		}
		public new global::java.lang.String AlgName
		{
			get
			{
				return getAlgName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgName28585;
		public virtual global::java.lang.String getAlgName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo._getAlgName28585)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._getAlgName28585)) as java.lang.String;
		}
		public new global::java.security.AlgorithmParameters AlgParameters
		{
			get
			{
				return getAlgParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgParameters28586;
		public virtual global::java.security.AlgorithmParameters getAlgParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo._getAlgParameters28586)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._getAlgParameters28586)) as java.security.AlgorithmParameters;
		}
		public new byte[] EncryptedData
		{
			get
			{
				return getEncryptedData();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncryptedData28587;
		public virtual byte[] getEncryptedData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo._getEncryptedData28587)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._getEncryptedData28587)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _EncryptedPrivateKeyInfo28588;
		public EncryptedPrivateKeyInfo(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._EncryptedPrivateKeyInfo28588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EncryptedPrivateKeyInfo28589;
		public EncryptedPrivateKeyInfo(java.lang.String arg0, byte[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._EncryptedPrivateKeyInfo28589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EncryptedPrivateKeyInfo28590;
		public EncryptedPrivateKeyInfo(java.security.AlgorithmParameters arg0, byte[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.EncryptedPrivateKeyInfo.staticClass, global::javax.crypto.EncryptedPrivateKeyInfo._EncryptedPrivateKeyInfo28590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.EncryptedPrivateKeyInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/EncryptedPrivateKeyInfo"));
			global::javax.crypto.EncryptedPrivateKeyInfo._getEncoded28580 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getEncoded", "()[B");
			global::javax.crypto.EncryptedPrivateKeyInfo._getKeySpec28581 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getKeySpec", "(Ljava/security/Key;)Ljava/security/spec/PKCS8EncodedKeySpec;");
			global::javax.crypto.EncryptedPrivateKeyInfo._getKeySpec28582 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getKeySpec", "(Ljava/security/Key;Ljava/security/Provider;)Ljava/security/spec/PKCS8EncodedKeySpec;");
			global::javax.crypto.EncryptedPrivateKeyInfo._getKeySpec28583 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getKeySpec", "(Ljavax/crypto/Cipher;)Ljava/security/spec/PKCS8EncodedKeySpec;");
			global::javax.crypto.EncryptedPrivateKeyInfo._getKeySpec28584 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getKeySpec", "(Ljava/security/Key;Ljava/lang/String;)Ljava/security/spec/PKCS8EncodedKeySpec;");
			global::javax.crypto.EncryptedPrivateKeyInfo._getAlgName28585 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getAlgName", "()Ljava/lang/String;");
			global::javax.crypto.EncryptedPrivateKeyInfo._getAlgParameters28586 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getAlgParameters", "()Ljava/security/AlgorithmParameters;");
			global::javax.crypto.EncryptedPrivateKeyInfo._getEncryptedData28587 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "getEncryptedData", "()[B");
			global::javax.crypto.EncryptedPrivateKeyInfo._EncryptedPrivateKeyInfo28588 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "<init>", "([B)V");
			global::javax.crypto.EncryptedPrivateKeyInfo._EncryptedPrivateKeyInfo28589 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "<init>", "(Ljava/lang/String;[B)V");
			global::javax.crypto.EncryptedPrivateKeyInfo._EncryptedPrivateKeyInfo28590 = @__env.GetMethodIDNoThrow(global::javax.crypto.EncryptedPrivateKeyInfo.staticClass, "<init>", "(Ljava/security/AlgorithmParameters;[B)V");
		}
	}
}
