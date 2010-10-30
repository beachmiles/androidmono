namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UsernamePasswordCredentials : java.lang.Object, Credentials
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UsernamePasswordCredentials(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals31851;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._equals31851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31852;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._toString31852)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode31853;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._hashCode31853);
		}
		public new global::java.lang.String Password
		{
			get
			{
				return getPassword();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPassword31854;
		public virtual global::java.lang.String getPassword()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._getPassword31854)) as java.lang.String;
		}
		public new global::java.lang.String UserName
		{
			get
			{
				return getUserName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserName31855;
		public virtual global::java.lang.String getUserName()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._getUserName31855)) as java.lang.String;
		}
		public new global::java.security.Principal UserPrincipal
		{
			get
			{
				return getUserPrincipal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserPrincipal31856;
		public virtual global::java.security.Principal getUserPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._getUserPrincipal31856)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _UsernamePasswordCredentials31857;
		public UsernamePasswordCredentials(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._UsernamePasswordCredentials31857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UsernamePasswordCredentials31858;
		public UsernamePasswordCredentials(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._UsernamePasswordCredentials31858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UsernamePasswordCredentials()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.UsernamePasswordCredentials.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/UsernamePasswordCredentials"));
			global::org.apache.http.auth.UsernamePasswordCredentials._equals31851 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.auth.UsernamePasswordCredentials._toString31852 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.auth.UsernamePasswordCredentials._hashCode31853 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "hashCode", "()I");
			global::org.apache.http.auth.UsernamePasswordCredentials._getPassword31854 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "getPassword", "()Ljava/lang/String;");
			global::org.apache.http.auth.UsernamePasswordCredentials._getUserName31855 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "getUserName", "()Ljava/lang/String;");
			global::org.apache.http.auth.UsernamePasswordCredentials._getUserPrincipal31856 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "getUserPrincipal", "()Ljava/security/Principal;");
			global::org.apache.http.auth.UsernamePasswordCredentials._UsernamePasswordCredentials31857 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.auth.UsernamePasswordCredentials._UsernamePasswordCredentials31858 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
