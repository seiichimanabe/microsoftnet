namespace Common.ClassLibrary.Validation
{

	/// <summary>
	/// 数値の入力判定を行うValidation
	/// </summary>
	/// <remarks>1文字単位の検証を行う</remarks>
	public class NumericCharValidation : AbstructRegexCharValidation
	{

		/// ------------------------------------------------------------------------------------------
		/// <summary>
		/// 小数点を有効とするかどうかを設定する
		/// </summary>
		/// <remarks></remarks>
		/// ------------------------------------------------------------------------------------------

		private bool _PeriodEnabled;
		/// ------------------------------------------------------------------------------------------
		/// <summary>
		/// マイナスを有効とするかどうかを設定する
		/// </summary>
		/// <remarks></remarks>
		/// ------------------------------------------------------------------------------------------

		private bool _MinusEnabled;
		#region "Constructor (+3)"

		/// ------------------------------------------------------------------------------------------
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="validationValue">検証対象の値</param>
		/// <remarks></remarks>
		/// ------------------------------------------------------------------------------------------

		public NumericCharValidation(string validationValue) : this(validationValue, false, false)
		{

		}


		/// ------------------------------------------------------------------------------------------
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="validationValue">検証対象の値</param>
		/// <remarks></remarks>
		/// ------------------------------------------------------------------------------------------

		public NumericCharValidation(string validationValue, bool periodEnabled) : this(validationValue, periodEnabled, false)
		{

		}

		/// ------------------------------------------------------------------------------------------
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="validationValue">検証対象の値</param>
		/// <param name="periodEnabled">小数点以下を有効にする場合=True</param>
		/// <param name="minusEnabled">マイナスを有効にする場合=True</param>
		/// <remarks></remarks>
		/// ------------------------------------------------------------------------------------------

		public NumericCharValidation(string validationValue, bool periodEnabled, bool minusEnabled) : base(validationValue)
		{
			this._PeriodEnabled = periodEnabled;
			this._MinusEnabled = minusEnabled;

		}

		#endregion

		/// ------------------------------------------------------------------------------------------
		/// <summary>
		/// 入力可能な文字列の正規表現値を返却する
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		/// <remarks></remarks>
		/// ------------------------------------------------------------------------------------------
		protected override string RegexString {
			get {
				if (this._PeriodEnabled == true) {
					if (this._MinusEnabled == true) {
						return ValidationConstants.NumericCharRegexStringIncPeriodMinus;
					} else {
						return ValidationConstants.NumericCharRegexStringIncPeriod;
					}
				} else {
					if (this._MinusEnabled == true) {
						return ValidationConstants.NumericCharRegexStringIncMinus;
					} else {
						return ValidationConstants.NumericCharNoPeriodRegexString;
					}
				}
			}
		}

	}

}

