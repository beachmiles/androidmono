namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class File : java.lang.Object, Serializable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected File(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals18952;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._equals18952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString18953;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._toString18953)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode18954;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.File.staticClass, global::java.io.File._hashCode18954);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo18955;
		public virtual int compareTo(java.io.File arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.File.staticClass, global::java.io.File._compareTo18955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo18956;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.File.staticClass, global::java.io.File._compareTo18956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName18957;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._getName18957)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length18958;
		public virtual long length()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.File.staticClass, global::java.io.File._length18958);
		}
		public new global::java.lang.String Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent18959;
		public virtual global::java.lang.String getParent()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._getParent18959)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAbsolute18960;
		public virtual bool isAbsolute()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._isAbsolute18960);
		}
		public new global::java.lang.String CanonicalPath
		{
			get
			{
				return getCanonicalPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalPath18961;
		public virtual global::java.lang.String getCanonicalPath()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._getCanonicalPath18961)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setReadOnly18962;
		public virtual bool setReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._setReadOnly18962);
		}
		internal static global::MonoJavaBridge.MethodId _list18963;
		public virtual global::java.lang.String[] list(java.io.FilenameFilter arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._list18963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _list18964;
		public virtual global::java.lang.String[] list()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._list18964)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _delete18965;
		public virtual bool delete()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._delete18965);
		}
		public new global::java.io.File ParentFile
		{
			get
			{
				return getParentFile();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParentFile18966;
		public virtual global::java.io.File getParentFile()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._getParentFile18966)) as java.io.File;
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath18967;
		public virtual global::java.lang.String getPath()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._getPath18967)) as java.lang.String;
		}
		public new global::java.lang.String AbsolutePath
		{
			get
			{
				return getAbsolutePath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAbsolutePath18968;
		public virtual global::java.lang.String getAbsolutePath()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._getAbsolutePath18968)) as java.lang.String;
		}
		public new global::java.io.File AbsoluteFile
		{
			get
			{
				return getAbsoluteFile();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAbsoluteFile18969;
		public virtual global::java.io.File getAbsoluteFile()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._getAbsoluteFile18969)) as java.io.File;
		}
		public new global::java.io.File CanonicalFile
		{
			get
			{
				return getCanonicalFile();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalFile18970;
		public virtual global::java.io.File getCanonicalFile()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._getCanonicalFile18970)) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _toURL18971;
		public virtual global::java.net.URL toURL()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._toURL18971)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _toURI18972;
		public virtual global::java.net.URI toURI()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._toURI18972)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _canRead18973;
		public virtual bool canRead()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._canRead18973);
		}
		internal static global::MonoJavaBridge.MethodId _canWrite18974;
		public virtual bool canWrite()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._canWrite18974);
		}
		internal static global::MonoJavaBridge.MethodId _exists18975;
		public virtual bool exists()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._exists18975);
		}
		internal static global::MonoJavaBridge.MethodId _isDirectory18976;
		public virtual bool isDirectory()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._isDirectory18976);
		}
		internal static global::MonoJavaBridge.MethodId _isFile18977;
		public virtual bool isFile()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._isFile18977);
		}
		internal static global::MonoJavaBridge.MethodId _isHidden18978;
		public virtual bool isHidden()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._isHidden18978);
		}
		internal static global::MonoJavaBridge.MethodId _lastModified18979;
		public virtual long lastModified()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.File.staticClass, global::java.io.File._lastModified18979);
		}
		internal static global::MonoJavaBridge.MethodId _createNewFile18980;
		public virtual bool createNewFile()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._createNewFile18980);
		}
		internal static global::MonoJavaBridge.MethodId _deleteOnExit18981;
		public virtual void deleteOnExit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.File.staticClass, global::java.io.File._deleteOnExit18981);
		}
		internal static global::MonoJavaBridge.MethodId _listFiles18982;
		public virtual global::java.io.File[] listFiles(java.io.FileFilter arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._listFiles18982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
		}
		internal static global::MonoJavaBridge.MethodId _listFiles18983;
		public virtual global::java.io.File[] listFiles()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._listFiles18983)) as java.io.File[];
		}
		internal static global::MonoJavaBridge.MethodId _listFiles18984;
		public virtual global::java.io.File[] listFiles(java.io.FilenameFilter arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.File.staticClass, global::java.io.File._listFiles18984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.File[];
		}
		internal static global::MonoJavaBridge.MethodId _mkdir18985;
		public virtual bool mkdir()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._mkdir18985);
		}
		internal static global::MonoJavaBridge.MethodId _mkdirs18986;
		public virtual bool mkdirs()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._mkdirs18986);
		}
		internal static global::MonoJavaBridge.MethodId _renameTo18987;
		public virtual bool renameTo(java.io.File arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._renameTo18987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLastModified18988;
		public virtual bool setLastModified(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._setLastModified18988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWritable18989;
		public virtual bool setWritable(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._setWritable18989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool Writable
		{
			set
			{
				setWritable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setWritable18990;
		public virtual bool setWritable(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._setWritable18990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setReadable18991;
		public virtual bool setReadable(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._setReadable18991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool Readable
		{
			set
			{
				setReadable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setReadable18992;
		public virtual bool setReadable(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._setReadable18992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExecutable18993;
		public virtual bool setExecutable(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._setExecutable18993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool Executable
		{
			set
			{
				setExecutable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setExecutable18994;
		public virtual bool setExecutable(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._setExecutable18994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _canExecute18995;
		public virtual bool canExecute()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.File.staticClass, global::java.io.File._canExecute18995);
		}
		internal static global::MonoJavaBridge.MethodId _listRoots18996;
		public static global::java.io.File[] listRoots()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.File>(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._listRoots18996)) as java.io.File[];
		}
		public new long TotalSpace
		{
			get
			{
				return getTotalSpace();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalSpace18997;
		public virtual long getTotalSpace()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.File.staticClass, global::java.io.File._getTotalSpace18997);
		}
		public new long FreeSpace
		{
			get
			{
				return getFreeSpace();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFreeSpace18998;
		public virtual long getFreeSpace()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.File.staticClass, global::java.io.File._getFreeSpace18998);
		}
		public new long UsableSpace
		{
			get
			{
				return getUsableSpace();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUsableSpace18999;
		public virtual long getUsableSpace()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.File.staticClass, global::java.io.File._getUsableSpace18999);
		}
		internal static global::MonoJavaBridge.MethodId _createTempFile19000;
		public static global::java.io.File createTempFile(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._createTempFile19000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _createTempFile19001;
		public static global::java.io.File createTempFile(java.lang.String arg0, java.lang.String arg1, java.io.File arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.io.File.staticClass, global::java.io.File._createTempFile19001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.File;
		}
		internal static global::MonoJavaBridge.MethodId _File19002;
		public File(java.net.URI arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File19002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _File19003;
		public File(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File19003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _File19004;
		public File(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File19004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _File19005;
		public File(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.File.staticClass, global::java.io.File._File19005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static char separatorChar
		{
			get
			{
				return '/';
			}
		}
		public static global::java.lang.String separator
		{
			get
			{
				return "/";
			}
		}
		public static char pathSeparatorChar
		{
			get
			{
				return ':';
			}
		}
		public static global::java.lang.String pathSeparator
		{
			get
			{
				return ":";
			}
		}
		static File()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.File.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/File"));
			global::java.io.File._equals18952 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.io.File._toString18953 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.File._hashCode18954 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "hashCode", "()I");
			global::java.io.File._compareTo18955 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "compareTo", "(Ljava/io/File;)I");
			global::java.io.File._compareTo18956 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.io.File._getName18957 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getName", "()Ljava/lang/String;");
			global::java.io.File._length18958 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "length", "()J");
			global::java.io.File._getParent18959 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getParent", "()Ljava/lang/String;");
			global::java.io.File._isAbsolute18960 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isAbsolute", "()Z");
			global::java.io.File._getCanonicalPath18961 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getCanonicalPath", "()Ljava/lang/String;");
			global::java.io.File._setReadOnly18962 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setReadOnly", "()Z");
			global::java.io.File._list18963 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "list", "(Ljava/io/FilenameFilter;)[Ljava/lang/String;");
			global::java.io.File._list18964 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "list", "()[Ljava/lang/String;");
			global::java.io.File._delete18965 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "delete", "()Z");
			global::java.io.File._getParentFile18966 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getParentFile", "()Ljava/io/File;");
			global::java.io.File._getPath18967 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getPath", "()Ljava/lang/String;");
			global::java.io.File._getAbsolutePath18968 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getAbsolutePath", "()Ljava/lang/String;");
			global::java.io.File._getAbsoluteFile18969 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getAbsoluteFile", "()Ljava/io/File;");
			global::java.io.File._getCanonicalFile18970 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getCanonicalFile", "()Ljava/io/File;");
			global::java.io.File._toURL18971 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "toURL", "()Ljava/net/URL;");
			global::java.io.File._toURI18972 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "toURI", "()Ljava/net/URI;");
			global::java.io.File._canRead18973 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "canRead", "()Z");
			global::java.io.File._canWrite18974 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "canWrite", "()Z");
			global::java.io.File._exists18975 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "exists", "()Z");
			global::java.io.File._isDirectory18976 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isDirectory", "()Z");
			global::java.io.File._isFile18977 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isFile", "()Z");
			global::java.io.File._isHidden18978 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "isHidden", "()Z");
			global::java.io.File._lastModified18979 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "lastModified", "()J");
			global::java.io.File._createNewFile18980 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "createNewFile", "()Z");
			global::java.io.File._deleteOnExit18981 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "deleteOnExit", "()V");
			global::java.io.File._listFiles18982 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "listFiles", "(Ljava/io/FileFilter;)[Ljava/io/File;");
			global::java.io.File._listFiles18983 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "listFiles", "()[Ljava/io/File;");
			global::java.io.File._listFiles18984 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "listFiles", "(Ljava/io/FilenameFilter;)[Ljava/io/File;");
			global::java.io.File._mkdir18985 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "mkdir", "()Z");
			global::java.io.File._mkdirs18986 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "mkdirs", "()Z");
			global::java.io.File._renameTo18987 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "renameTo", "(Ljava/io/File;)Z");
			global::java.io.File._setLastModified18988 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setLastModified", "(J)Z");
			global::java.io.File._setWritable18989 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setWritable", "(ZZ)Z");
			global::java.io.File._setWritable18990 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setWritable", "(Z)Z");
			global::java.io.File._setReadable18991 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setReadable", "(ZZ)Z");
			global::java.io.File._setReadable18992 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setReadable", "(Z)Z");
			global::java.io.File._setExecutable18993 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setExecutable", "(ZZ)Z");
			global::java.io.File._setExecutable18994 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "setExecutable", "(Z)Z");
			global::java.io.File._canExecute18995 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "canExecute", "()Z");
			global::java.io.File._listRoots18996 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "listRoots", "()[Ljava/io/File;");
			global::java.io.File._getTotalSpace18997 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getTotalSpace", "()J");
			global::java.io.File._getFreeSpace18998 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getFreeSpace", "()J");
			global::java.io.File._getUsableSpace18999 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "getUsableSpace", "()J");
			global::java.io.File._createTempFile19000 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;");
			global::java.io.File._createTempFile19001 = @__env.GetStaticMethodIDNoThrow(global::java.io.File.staticClass, "createTempFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;");
			global::java.io.File._File19002 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::java.io.File._File19003 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.File._File19004 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.File._File19005 = @__env.GetMethodIDNoThrow(global::java.io.File.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
