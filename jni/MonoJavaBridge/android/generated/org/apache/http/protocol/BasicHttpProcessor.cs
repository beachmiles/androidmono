namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BasicHttpProcessor : java.lang.Object, HttpProcessor, HttpRequestInterceptorList, HttpResponseInterceptorList, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHttpProcessor()
		{
			InitJNI();
		}
		internal BasicHttpProcessor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone33819;
		public global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._clone33819)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._clone33819)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _copy33820;
		public global::org.apache.http.protocol.BasicHttpProcessor copy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.protocol.BasicHttpProcessor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._copy33820)) as org.apache.http.protocol.BasicHttpProcessor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.protocol.BasicHttpProcessor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._copy33820)) as org.apache.http.protocol.BasicHttpProcessor;
		}
		internal static global::MonoJavaBridge.MethodId _process33821;
		public void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._process33821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._process33821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _process33822;
		public void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._process33822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._process33822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor33823;
		public void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor33823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor33823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor33824;
		public void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor33824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor33824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptor33825;
		public global::org.apache.http.HttpResponseInterceptor getResponseInterceptor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseInterceptor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptor33825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponseInterceptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseInterceptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptor33825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponseInterceptor;
		}
		public new int ResponseInterceptorCount
		{
			get
			{
				return getResponseInterceptorCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptorCount33826;
		public int getResponseInterceptorCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptorCount33826);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptorCount33826);
		}
		internal static global::MonoJavaBridge.MethodId _clearResponseInterceptors33827;
		public void clearResponseInterceptors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._clearResponseInterceptors33827);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._clearResponseInterceptors33827);
		}
		internal static global::MonoJavaBridge.MethodId _removeResponseInterceptorByClass33828;
		public void removeResponseInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._removeResponseInterceptorByClass33828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._removeResponseInterceptorByClass33828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor33829;
		public void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor33829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor33829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor33830;
		public void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor33830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor33830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptor33831;
		public global::org.apache.http.HttpRequestInterceptor getRequestInterceptor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestInterceptor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptor33831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequestInterceptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestInterceptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptor33831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequestInterceptor;
		}
		public new int RequestInterceptorCount
		{
			get
			{
				return getRequestInterceptorCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptorCount33832;
		public int getRequestInterceptorCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptorCount33832);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptorCount33832);
		}
		internal static global::MonoJavaBridge.MethodId _clearRequestInterceptors33833;
		public void clearRequestInterceptors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._clearRequestInterceptors33833);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._clearRequestInterceptors33833);
		}
		internal static global::MonoJavaBridge.MethodId _removeRequestInterceptorByClass33834;
		public void removeRequestInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._removeRequestInterceptorByClass33834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._removeRequestInterceptorByClass33834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addInterceptor33835;
		public void addInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addInterceptor33836;
		public void addInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addInterceptor33837;
		public void addInterceptor(org.apache.http.HttpRequestInterceptor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addInterceptor33838;
		public void addInterceptor(org.apache.http.HttpResponseInterceptor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List Interceptors
		{
			set
			{
				setInterceptors(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setInterceptors33839;
		public void setInterceptors(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._setInterceptors33839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._setInterceptors33839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearInterceptors33840;
		public void clearInterceptors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._clearInterceptors33840);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._clearInterceptors33840);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpProcessor33841;
		public BasicHttpProcessor() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._BasicHttpProcessor33841);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.BasicHttpProcessor.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/BasicHttpProcessor"));
			global::org.apache.http.protocol.BasicHttpProcessor._clone33819 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.protocol.BasicHttpProcessor._copy33820 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "copy", "()Lorg/apache/http/protocol/BasicHttpProcessor;");
			global::org.apache.http.protocol.BasicHttpProcessor._process33821 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._process33822 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor33823 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor33824 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V");
			global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptor33825 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;");
			global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptorCount33826 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getResponseInterceptorCount", "()I");
			global::org.apache.http.protocol.BasicHttpProcessor._clearResponseInterceptors33827 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clearResponseInterceptors", "()V");
			global::org.apache.http.protocol.BasicHttpProcessor._removeResponseInterceptorByClass33828 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "removeResponseInterceptorByClass", "(Ljava/lang/Class;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor33829 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor33830 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptor33831 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;");
			global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptorCount33832 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getRequestInterceptorCount", "()I");
			global::org.apache.http.protocol.BasicHttpProcessor._clearRequestInterceptors33833 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clearRequestInterceptors", "()V");
			global::org.apache.http.protocol.BasicHttpProcessor._removeRequestInterceptorByClass33834 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "removeRequestInterceptorByClass", "(Ljava/lang/Class;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33835 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33836 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33837 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor33838 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._setInterceptors33839 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "setInterceptors", "(Ljava/util/List;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._clearInterceptors33840 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clearInterceptors", "()V");
			global::org.apache.http.protocol.BasicHttpProcessor._BasicHttpProcessor33841 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "<init>", "()V");
		}
	}
}
