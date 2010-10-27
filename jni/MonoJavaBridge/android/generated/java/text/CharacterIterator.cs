namespace java.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.text.CharacterIterator_))]
	public partial interface CharacterIterator : java.lang.Cloneable
	{
		global::java.lang.Object clone();
		char next();
		char previous();
		int getIndex();
		char current();
		char setIndex(int arg0);
		int getBeginIndex();
		int getEndIndex();
		char last();
		char first();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.CharacterIterator))]
	internal sealed partial class CharacterIterator_ : java.lang.Object, CharacterIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharacterIterator_()
		{
			InitJNI();
		}
		internal CharacterIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone25253;
		global::java.lang.Object java.text.CharacterIterator.clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.CharacterIterator_._clone25253)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._clone25253)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _next25254;
		char java.text.CharacterIterator.next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._next25254);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._next25254);
		}
		internal static global::MonoJavaBridge.MethodId _previous25255;
		char java.text.CharacterIterator.previous()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._previous25255);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._previous25255);
		}
		internal static global::MonoJavaBridge.MethodId _getIndex25256;
		int java.text.CharacterIterator.getIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CharacterIterator_._getIndex25256);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._getIndex25256);
		}
		internal static global::MonoJavaBridge.MethodId _current25257;
		char java.text.CharacterIterator.current()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._current25257);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._current25257);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex25258;
		char java.text.CharacterIterator.setIndex(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._setIndex25258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._setIndex25258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBeginIndex25259;
		int java.text.CharacterIterator.getBeginIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CharacterIterator_._getBeginIndex25259);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._getBeginIndex25259);
		}
		internal static global::MonoJavaBridge.MethodId _getEndIndex25260;
		int java.text.CharacterIterator.getEndIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.CharacterIterator_._getEndIndex25260);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._getEndIndex25260);
		}
		internal static global::MonoJavaBridge.MethodId _last25261;
		char java.text.CharacterIterator.last()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._last25261);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._last25261);
		}
		internal static global::MonoJavaBridge.MethodId _first25262;
		char java.text.CharacterIterator.first()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.CharacterIterator_._first25262);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.CharacterIterator_.staticClass, global::java.text.CharacterIterator_._first25262);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.CharacterIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/CharacterIterator"));
			global::java.text.CharacterIterator_._clone25253 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.CharacterIterator_._next25254 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "next", "()C");
			global::java.text.CharacterIterator_._previous25255 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "previous", "()C");
			global::java.text.CharacterIterator_._getIndex25256 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "getIndex", "()I");
			global::java.text.CharacterIterator_._current25257 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "current", "()C");
			global::java.text.CharacterIterator_._setIndex25258 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "setIndex", "(I)C");
			global::java.text.CharacterIterator_._getBeginIndex25259 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "getBeginIndex", "()I");
			global::java.text.CharacterIterator_._getEndIndex25260 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "getEndIndex", "()I");
			global::java.text.CharacterIterator_._last25261 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "last", "()C");
			global::java.text.CharacterIterator_._first25262 = @__env.GetMethodIDNoThrow(global::java.text.CharacterIterator_.staticClass, "first", "()C");
		}
	}
}
