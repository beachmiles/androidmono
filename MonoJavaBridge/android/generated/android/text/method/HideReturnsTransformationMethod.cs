namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HideReturnsTransformationMethod : android.text.method.ReplacementTransformationMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HideReturnsTransformationMethod(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.text.method.HideReturnsTransformationMethod Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance13290;
		public static global::android.text.method.HideReturnsTransformationMethod getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.HideReturnsTransformationMethod.staticClass, global::android.text.method.HideReturnsTransformationMethod._getInstance13290)) as android.text.method.HideReturnsTransformationMethod;
		}
		protected new char[] Original
		{
			get
			{
				return getOriginal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginal13291;
		protected override char[] getOriginal()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.method.HideReturnsTransformationMethod.staticClass, global::android.text.method.HideReturnsTransformationMethod._getOriginal13291)) as char[];
		}
		protected new char[] Replacement
		{
			get
			{
				return getReplacement();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReplacement13292;
		protected override char[] getReplacement()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.method.HideReturnsTransformationMethod.staticClass, global::android.text.method.HideReturnsTransformationMethod._getReplacement13292)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _HideReturnsTransformationMethod13293;
		public HideReturnsTransformationMethod() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.HideReturnsTransformationMethod.staticClass, global::android.text.method.HideReturnsTransformationMethod._HideReturnsTransformationMethod13293);
			Init(@__env, handle);
		}
		static HideReturnsTransformationMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.HideReturnsTransformationMethod.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/HideReturnsTransformationMethod"));
			global::android.text.method.HideReturnsTransformationMethod._getInstance13290 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.HideReturnsTransformationMethod.staticClass, "getInstance", "()Landroid/text/method/HideReturnsTransformationMethod;");
			global::android.text.method.HideReturnsTransformationMethod._getOriginal13291 = @__env.GetMethodIDNoThrow(global::android.text.method.HideReturnsTransformationMethod.staticClass, "getOriginal", "()[C");
			global::android.text.method.HideReturnsTransformationMethod._getReplacement13292 = @__env.GetMethodIDNoThrow(global::android.text.method.HideReturnsTransformationMethod.staticClass, "getReplacement", "()[C");
			global::android.text.method.HideReturnsTransformationMethod._HideReturnsTransformationMethod13293 = @__env.GetMethodIDNoThrow(global::android.text.method.HideReturnsTransformationMethod.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
