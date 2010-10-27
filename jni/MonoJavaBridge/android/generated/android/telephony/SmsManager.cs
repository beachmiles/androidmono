namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SmsManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SmsManager()
		{
			InitJNI();
		}
		internal SmsManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.telephony.SmsManager Default
		{
			get
			{
				return getDefault();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefault11896;
		public static global::android.telephony.SmsManager getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.SmsManager>(@__env.CallStaticObjectMethod(android.telephony.SmsManager.staticClass, global::android.telephony.SmsManager._getDefault11896)) as android.telephony.SmsManager;
		}
		internal static global::MonoJavaBridge.MethodId _sendTextMessage11897;
		public void sendTextMessage(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, android.app.PendingIntent arg3, android.app.PendingIntent arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.SmsManager._sendTextMessage11897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.SmsManager.staticClass, global::android.telephony.SmsManager._sendTextMessage11897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _divideMessage11898;
		public global::java.util.ArrayList divideMessage(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsManager._divideMessage11898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsManager.staticClass, global::android.telephony.SmsManager._divideMessage11898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _sendMultipartTextMessage11899;
		public void sendMultipartTextMessage(java.lang.String arg0, java.lang.String arg1, java.util.ArrayList arg2, java.util.ArrayList arg3, java.util.ArrayList arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.SmsManager._sendMultipartTextMessage11899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.SmsManager.staticClass, global::android.telephony.SmsManager._sendMultipartTextMessage11899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _sendDataMessage11900;
		public void sendDataMessage(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, android.app.PendingIntent arg4, android.app.PendingIntent arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.SmsManager._sendDataMessage11900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.SmsManager.staticClass, global::android.telephony.SmsManager._sendDataMessage11900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public static int STATUS_ON_ICC_FREE
		{
			get
			{
				return 0;
			}
		}
		public static int STATUS_ON_ICC_READ
		{
			get
			{
				return 1;
			}
		}
		public static int STATUS_ON_ICC_UNREAD
		{
			get
			{
				return 3;
			}
		}
		public static int STATUS_ON_ICC_SENT
		{
			get
			{
				return 5;
			}
		}
		public static int STATUS_ON_ICC_UNSENT
		{
			get
			{
				return 7;
			}
		}
		public static int RESULT_ERROR_GENERIC_FAILURE
		{
			get
			{
				return 1;
			}
		}
		public static int RESULT_ERROR_RADIO_OFF
		{
			get
			{
				return 2;
			}
		}
		public static int RESULT_ERROR_NULL_PDU
		{
			get
			{
				return 3;
			}
		}
		public static int RESULT_ERROR_NO_SERVICE
		{
			get
			{
				return 4;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.SmsManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/SmsManager"));
			global::android.telephony.SmsManager._getDefault11896 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsManager.staticClass, "getDefault", "()Landroid/telephony/SmsManager;");
			global::android.telephony.SmsManager._sendTextMessage11897 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsManager.staticClass, "sendTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/app/PendingIntent;Landroid/app/PendingIntent;)V");
			global::android.telephony.SmsManager._divideMessage11898 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsManager.staticClass, "divideMessage", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.telephony.SmsManager._sendMultipartTextMessage11899 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsManager.staticClass, "sendMultipartTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)V");
			global::android.telephony.SmsManager._sendDataMessage11900 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsManager.staticClass, "sendDataMessage", "(Ljava/lang/String;Ljava/lang/String;S[BLandroid/app/PendingIntent;Landroid/app/PendingIntent;)V");
		}
	}
}
