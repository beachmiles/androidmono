namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.message.LineParser_))]
	public partial interface LineParser  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.Header parseHeader(org.apache.http.util.CharArrayBuffer arg0);
		global::org.apache.http.ProtocolVersion parseProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1);
		bool hasProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1);
		global::org.apache.http.RequestLine parseRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1);
		global::org.apache.http.StatusLine parseStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.message.LineParser))]
	internal sealed partial class LineParser_ : java.lang.Object, LineParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LineParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parseHeader33702;
		global::org.apache.http.Header org.apache.http.message.LineParser.parseHeader(org.apache.http.util.CharArrayBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.LineParser_._parseHeader33702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _parseProtocolVersion33703;
		global::org.apache.http.ProtocolVersion org.apache.http.message.LineParser.parseProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.LineParser_._parseProtocolVersion33703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _hasProtocolVersion33704;
		bool org.apache.http.message.LineParser.hasProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.LineParser_._hasProtocolVersion33704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseRequestLine33705;
		global::org.apache.http.RequestLine org.apache.http.message.LineParser.parseRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.LineParser_._parseRequestLine33705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.RequestLine;
		}
		internal static global::MonoJavaBridge.MethodId _parseStatusLine33706;
		global::org.apache.http.StatusLine org.apache.http.message.LineParser.parseStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.StatusLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.LineParser_._parseStatusLine33706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.StatusLine;
		}
		static LineParser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.LineParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/LineParser"));
			global::org.apache.http.message.LineParser_._parseHeader33702 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.LineParser_.staticClass, "parseHeader", "(Lorg/apache/http/util/CharArrayBuffer;)Lorg/apache/http/Header;");
			global::org.apache.http.message.LineParser_._parseProtocolVersion33703 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.LineParser_.staticClass, "parseProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.message.LineParser_._hasProtocolVersion33704 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.LineParser_.staticClass, "hasProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Z");
			global::org.apache.http.message.LineParser_._parseRequestLine33705 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.LineParser_.staticClass, "parseRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/RequestLine;");
			global::org.apache.http.message.LineParser_._parseStatusLine33706 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.LineParser_.staticClass, "parseStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/StatusLine;");
		}
		internal static void InitJNI()
		{
		}
	}
}
