namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SuperscriptSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SuperscriptSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13589;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._writeToParcel13589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13590;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._describeContents13590);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13591;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._getSpanTypeId13591);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13592;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._updateDrawState13592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState13593;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._updateMeasureState13593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SuperscriptSpan13594;
		public SuperscriptSpan() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._SuperscriptSpan13594);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SuperscriptSpan13595;
		public SuperscriptSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._SuperscriptSpan13595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SuperscriptSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.SuperscriptSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/SuperscriptSpan"));
			global::android.text.style.SuperscriptSpan._writeToParcel13589 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.SuperscriptSpan._describeContents13590 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "describeContents", "()I");
			global::android.text.style.SuperscriptSpan._getSpanTypeId13591 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.SuperscriptSpan._updateDrawState13592 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.SuperscriptSpan._updateMeasureState13593 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.SuperscriptSpan._SuperscriptSpan13594 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "<init>", "()V");
			global::android.text.style.SuperscriptSpan._SuperscriptSpan13595 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
