namespace android.location
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.location.LocationListener_))]
	public partial interface LocationListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onStatusChanged(java.lang.String arg0, int arg1, android.os.Bundle arg2);
		void onLocationChanged(android.location.Location arg0);
		void onProviderEnabled(java.lang.String arg0);
		void onProviderDisabled(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.location.LocationListener))]
	internal sealed partial class LocationListener_ : java.lang.Object, LocationListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LocationListener_()
		{
			InitJNI();
		}
		internal LocationListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onStatusChanged6929;
		void android.location.LocationListener.onStatusChanged(java.lang.String arg0, int arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationListener_._onStatusChanged6929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationListener_.staticClass, global::android.location.LocationListener_._onStatusChanged6929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onLocationChanged6930;
		void android.location.LocationListener.onLocationChanged(android.location.Location arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationListener_._onLocationChanged6930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationListener_.staticClass, global::android.location.LocationListener_._onLocationChanged6930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onProviderEnabled6931;
		void android.location.LocationListener.onProviderEnabled(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationListener_._onProviderEnabled6931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationListener_.staticClass, global::android.location.LocationListener_._onProviderEnabled6931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onProviderDisabled6932;
		void android.location.LocationListener.onProviderDisabled(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.LocationListener_._onProviderDisabled6932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.LocationListener_.staticClass, global::android.location.LocationListener_._onProviderDisabled6932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.LocationListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/LocationListener"));
			global::android.location.LocationListener_._onStatusChanged6929 = @__env.GetMethodIDNoThrow(global::android.location.LocationListener_.staticClass, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V");
			global::android.location.LocationListener_._onLocationChanged6930 = @__env.GetMethodIDNoThrow(global::android.location.LocationListener_.staticClass, "onLocationChanged", "(Landroid/location/Location;)V");
			global::android.location.LocationListener_._onProviderEnabled6931 = @__env.GetMethodIDNoThrow(global::android.location.LocationListener_.staticClass, "onProviderEnabled", "(Ljava/lang/String;)V");
			global::android.location.LocationListener_._onProviderDisabled6932 = @__env.GetMethodIDNoThrow(global::android.location.LocationListener_.staticClass, "onProviderDisabled", "(Ljava/lang/String;)V");
		}
	}
}
