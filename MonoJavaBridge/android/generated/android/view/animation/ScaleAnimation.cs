namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScaleAnimation : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ScaleAnimation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _initialize15750;
		public override void initialize(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.ScaleAnimation.staticClass, global::android.view.animation.ScaleAnimation._initialize15750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _applyTransformation15751;
		protected override void applyTransformation(float arg0, android.view.animation.Transformation arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.ScaleAnimation.staticClass, global::android.view.animation.ScaleAnimation._applyTransformation15751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ScaleAnimation15752;
		public ScaleAnimation(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.ScaleAnimation.staticClass, global::android.view.animation.ScaleAnimation._ScaleAnimation15752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScaleAnimation15753;
		public ScaleAnimation(float arg0, float arg1, float arg2, float arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.ScaleAnimation.staticClass, global::android.view.animation.ScaleAnimation._ScaleAnimation15753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScaleAnimation15754;
		public ScaleAnimation(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.ScaleAnimation.staticClass, global::android.view.animation.ScaleAnimation._ScaleAnimation15754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScaleAnimation15755;
		public ScaleAnimation(float arg0, float arg1, float arg2, float arg3, int arg4, float arg5, int arg6, float arg7) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.ScaleAnimation.staticClass, global::android.view.animation.ScaleAnimation._ScaleAnimation15755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		static ScaleAnimation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.ScaleAnimation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/ScaleAnimation"));
			global::android.view.animation.ScaleAnimation._initialize15750 = @__env.GetMethodIDNoThrow(global::android.view.animation.ScaleAnimation.staticClass, "initialize", "(IIII)V");
			global::android.view.animation.ScaleAnimation._applyTransformation15751 = @__env.GetMethodIDNoThrow(global::android.view.animation.ScaleAnimation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V");
			global::android.view.animation.ScaleAnimation._ScaleAnimation15752 = @__env.GetMethodIDNoThrow(global::android.view.animation.ScaleAnimation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.ScaleAnimation._ScaleAnimation15753 = @__env.GetMethodIDNoThrow(global::android.view.animation.ScaleAnimation.staticClass, "<init>", "(FFFF)V");
			global::android.view.animation.ScaleAnimation._ScaleAnimation15754 = @__env.GetMethodIDNoThrow(global::android.view.animation.ScaleAnimation.staticClass, "<init>", "(FFFFFF)V");
			global::android.view.animation.ScaleAnimation._ScaleAnimation15755 = @__env.GetMethodIDNoThrow(global::android.view.animation.ScaleAnimation.staticClass, "<init>", "(FFFFIFIF)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
