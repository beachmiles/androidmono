namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DecimalFormatSymbols : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DecimalFormatSymbols()
		{
			InitJNI();
		}
		protected DecimalFormatSymbols(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25468;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._equals25468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._equals25468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25469;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._hashCode25469);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._hashCode25469);
		}
		internal static global::MonoJavaBridge.MethodId _clone25470;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._clone25470)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._clone25470)) as java.lang.Object;
		}
		public static global::java.text.DecimalFormatSymbols Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25471;
		public static global::java.text.DecimalFormatSymbols getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getInstance25471)) as java.text.DecimalFormatSymbols;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25472;
		public static global::java.text.DecimalFormatSymbols getInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getInstance25472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DecimalFormatSymbols;
		}
		public static global::java.util.Locale[] AvailableLocales
		{
			get
			{
				return getAvailableLocales();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales25473;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getAvailableLocales25473)) as java.util.Locale[];
		}
		public new char ZeroDigit
		{
			get
			{
				return getZeroDigit();
			}
			set
			{
				setZeroDigit(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZeroDigit25474;
		public virtual char getZeroDigit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getZeroDigit25474);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getZeroDigit25474);
		}
		public new global::java.util.Currency Currency
		{
			get
			{
				return getCurrency();
			}
			set
			{
				setCurrency(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrency25475;
		public virtual global::java.util.Currency getCurrency()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getCurrency25475)) as java.util.Currency;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getCurrency25475)) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency25476;
		public virtual void setCurrency(java.util.Currency arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setCurrency25476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setCurrency25476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String NaN
		{
			get
			{
				return getNaN();
			}
			set
			{
				setNaN(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNaN25477;
		public virtual global::java.lang.String getNaN()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getNaN25477)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getNaN25477)) as java.lang.String;
		}
		public new global::java.lang.String Infinity
		{
			get
			{
				return getInfinity();
			}
			set
			{
				setInfinity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInfinity25478;
		public virtual global::java.lang.String getInfinity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getInfinity25478)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getInfinity25478)) as java.lang.String;
		}
		public new char GroupingSeparator
		{
			get
			{
				return getGroupingSeparator();
			}
			set
			{
				setGroupingSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGroupingSeparator25479;
		public virtual char getGroupingSeparator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getGroupingSeparator25479);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getGroupingSeparator25479);
		}
		public new char MonetaryDecimalSeparator
		{
			get
			{
				return getMonetaryDecimalSeparator();
			}
			set
			{
				setMonetaryDecimalSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMonetaryDecimalSeparator25480;
		public virtual char getMonetaryDecimalSeparator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getMonetaryDecimalSeparator25480);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getMonetaryDecimalSeparator25480);
		}
		public new char DecimalSeparator
		{
			get
			{
				return getDecimalSeparator();
			}
			set
			{
				setDecimalSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDecimalSeparator25481;
		public virtual char getDecimalSeparator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getDecimalSeparator25481);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getDecimalSeparator25481);
		}
		public new global::java.lang.String ExponentSeparator
		{
			get
			{
				return getExponentSeparator();
			}
			set
			{
				setExponentSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExponentSeparator25482;
		public virtual global::java.lang.String getExponentSeparator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getExponentSeparator25482)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getExponentSeparator25482)) as java.lang.String;
		}
		public new char MinusSign
		{
			get
			{
				return getMinusSign();
			}
			set
			{
				setMinusSign(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinusSign25483;
		public virtual char getMinusSign()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getMinusSign25483);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getMinusSign25483);
		}
		public new global::java.lang.String InternationalCurrencySymbol
		{
			get
			{
				return getInternationalCurrencySymbol();
			}
			set
			{
				setInternationalCurrencySymbol(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInternationalCurrencySymbol25484;
		public virtual global::java.lang.String getInternationalCurrencySymbol()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getInternationalCurrencySymbol25484)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getInternationalCurrencySymbol25484)) as java.lang.String;
		}
		public new global::java.lang.String CurrencySymbol
		{
			get
			{
				return getCurrencySymbol();
			}
			set
			{
				setCurrencySymbol(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrencySymbol25485;
		public virtual global::java.lang.String getCurrencySymbol()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getCurrencySymbol25485)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getCurrencySymbol25485)) as java.lang.String;
		}
		public new char Percent
		{
			get
			{
				return getPercent();
			}
			set
			{
				setPercent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPercent25486;
		public virtual char getPercent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getPercent25486);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getPercent25486);
		}
		public new char PerMill
		{
			get
			{
				return getPerMill();
			}
			set
			{
				setPerMill(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPerMill25487;
		public virtual char getPerMill()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getPerMill25487);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getPerMill25487);
		}
		public new char Digit
		{
			get
			{
				return getDigit();
			}
			set
			{
				setDigit(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDigit25488;
		public virtual char getDigit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getDigit25488);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getDigit25488);
		}
		public new char PatternSeparator
		{
			get
			{
				return getPatternSeparator();
			}
			set
			{
				setPatternSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPatternSeparator25489;
		public virtual char getPatternSeparator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getPatternSeparator25489);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getPatternSeparator25489);
		}
		internal static global::MonoJavaBridge.MethodId _setZeroDigit25490;
		public virtual void setZeroDigit(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setZeroDigit25490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setZeroDigit25490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupingSeparator25491;
		public virtual void setGroupingSeparator(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setGroupingSeparator25491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setGroupingSeparator25491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDecimalSeparator25492;
		public virtual void setDecimalSeparator(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setDecimalSeparator25492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setDecimalSeparator25492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPerMill25493;
		public virtual void setPerMill(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setPerMill25493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setPerMill25493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPercent25494;
		public virtual void setPercent(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setPercent25494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setPercent25494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDigit25495;
		public virtual void setDigit(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setDigit25495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setDigit25495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPatternSeparator25496;
		public virtual void setPatternSeparator(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setPatternSeparator25496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setPatternSeparator25496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInfinity25497;
		public virtual void setInfinity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setInfinity25497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setInfinity25497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNaN25498;
		public virtual void setNaN(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setNaN25498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setNaN25498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinusSign25499;
		public virtual void setMinusSign(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setMinusSign25499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setMinusSign25499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCurrencySymbol25500;
		public virtual void setCurrencySymbol(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setCurrencySymbol25500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setCurrencySymbol25500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInternationalCurrencySymbol25501;
		public virtual void setInternationalCurrencySymbol(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setInternationalCurrencySymbol25501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setInternationalCurrencySymbol25501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMonetaryDecimalSeparator25502;
		public virtual void setMonetaryDecimalSeparator(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setMonetaryDecimalSeparator25502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setMonetaryDecimalSeparator25502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExponentSeparator25503;
		public virtual void setExponentSeparator(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setExponentSeparator25503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setExponentSeparator25503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormatSymbols25504;
		public DecimalFormatSymbols() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._DecimalFormatSymbols25504);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormatSymbols25505;
		public DecimalFormatSymbols(java.util.Locale arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._DecimalFormatSymbols25505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DecimalFormatSymbols.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DecimalFormatSymbols"));
			global::java.text.DecimalFormatSymbols._equals25468 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.DecimalFormatSymbols._hashCode25469 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "hashCode", "()I");
			global::java.text.DecimalFormatSymbols._clone25470 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.DecimalFormatSymbols._getInstance25471 = @__env.GetStaticMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInstance", "()Ljava/text/DecimalFormatSymbols;");
			global::java.text.DecimalFormatSymbols._getInstance25472 = @__env.GetStaticMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/DecimalFormatSymbols;");
			global::java.text.DecimalFormatSymbols._getAvailableLocales25473 = @__env.GetStaticMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.DecimalFormatSymbols._getZeroDigit25474 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getZeroDigit", "()C");
			global::java.text.DecimalFormatSymbols._getCurrency25475 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getCurrency", "()Ljava/util/Currency;");
			global::java.text.DecimalFormatSymbols._setCurrency25476 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setCurrency", "(Ljava/util/Currency;)V");
			global::java.text.DecimalFormatSymbols._getNaN25477 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getNaN", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getInfinity25478 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInfinity", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getGroupingSeparator25479 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getGroupingSeparator", "()C");
			global::java.text.DecimalFormatSymbols._getMonetaryDecimalSeparator25480 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getMonetaryDecimalSeparator", "()C");
			global::java.text.DecimalFormatSymbols._getDecimalSeparator25481 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getDecimalSeparator", "()C");
			global::java.text.DecimalFormatSymbols._getExponentSeparator25482 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getExponentSeparator", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getMinusSign25483 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getMinusSign", "()C");
			global::java.text.DecimalFormatSymbols._getInternationalCurrencySymbol25484 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInternationalCurrencySymbol", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getCurrencySymbol25485 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getCurrencySymbol", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getPercent25486 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getPercent", "()C");
			global::java.text.DecimalFormatSymbols._getPerMill25487 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getPerMill", "()C");
			global::java.text.DecimalFormatSymbols._getDigit25488 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getDigit", "()C");
			global::java.text.DecimalFormatSymbols._getPatternSeparator25489 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getPatternSeparator", "()C");
			global::java.text.DecimalFormatSymbols._setZeroDigit25490 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setZeroDigit", "(C)V");
			global::java.text.DecimalFormatSymbols._setGroupingSeparator25491 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setGroupingSeparator", "(C)V");
			global::java.text.DecimalFormatSymbols._setDecimalSeparator25492 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setDecimalSeparator", "(C)V");
			global::java.text.DecimalFormatSymbols._setPerMill25493 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setPerMill", "(C)V");
			global::java.text.DecimalFormatSymbols._setPercent25494 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setPercent", "(C)V");
			global::java.text.DecimalFormatSymbols._setDigit25495 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setDigit", "(C)V");
			global::java.text.DecimalFormatSymbols._setPatternSeparator25496 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setPatternSeparator", "(C)V");
			global::java.text.DecimalFormatSymbols._setInfinity25497 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setInfinity", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._setNaN25498 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setNaN", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._setMinusSign25499 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setMinusSign", "(C)V");
			global::java.text.DecimalFormatSymbols._setCurrencySymbol25500 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setCurrencySymbol", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._setInternationalCurrencySymbol25501 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setInternationalCurrencySymbol", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._setMonetaryDecimalSeparator25502 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setMonetaryDecimalSeparator", "(C)V");
			global::java.text.DecimalFormatSymbols._setExponentSeparator25503 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setExponentSeparator", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._DecimalFormatSymbols25504 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "<init>", "()V");
			global::java.text.DecimalFormatSymbols._DecimalFormatSymbols25505 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "<init>", "(Ljava/util/Locale;)V");
		}
	}
}
