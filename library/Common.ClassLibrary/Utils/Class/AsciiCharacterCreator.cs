using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Common.ClassLibrary.Utils
{

    /// ------------------------------------------------------------------------------------------
    /// <summary>
    /// ASCII文字列の束を返却するUtilityクラス
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <history>
    /// 2012/12 Rebuild
    /// </history>
    /// ------------------------------------------------------------------------------------------
    public class AsciiCharacterCreator
    {

        #region Public Method

        #region getAllAsciiCharacterStringArray (全てのASCII英数字記号を返す)

        /// ------------------------------------------------------------------------------------------
        /// <summary>
        /// 全てのASCII英数字記号を返す
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        /// ------------------------------------------------------------------------------------------
        public List<string> getAllAsciiCharacterStringArray()
        {

            List<string> lst = null;
            lst = new List<string>();

            for (int i = 33; i <= 126; i++)
            {
                lst.Add(Convert.ToChar(i).ToString());
            }
            return lst;

        }

        #endregion

        #region getNumberStringArray (全ての数値を返す)

        /// ------------------------------------------------------------------------------------------
        /// <summary>
        /// 全ての数値を返す
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        /// ------------------------------------------------------------------------------------------
        public List<string> getNumberStringArray()
        {

            List<string> lst = null;
            lst = new List<string>();

            //0123456789
            for (int i = 48; i <= 57; i++)
            {
                lst.Add(Convert.ToChar(i).ToString());
            }
            return lst;

        }

        #endregion

        #region getAllSymbolStringArray (全ての記号を返す)

        /// ------------------------------------------------------------------------------------------
        /// <summary>
        /// 全ての記号を返す
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        /// ------------------------------------------------------------------------------------------
        public List<string> getAllSymbolStringArray()
        {

            List<string> lst = null;
            lst = new List<string>();

            //!"#$%&'()*+,-./
            for (int i = 33; i <= 47; i++)
            {
                lst.Add(Convert.ToChar(i).ToString());
            }

            //:;<=>?@
            for (int i = 58; i <= 64; i++)
            {
                lst.Add(Convert.ToChar(i).ToString());
            }

            //[\]^_`
            for (int i = 91; i <= 96; i++)
            {
                lst.Add(Convert.ToChar(i).ToString());
            }

            //{|}~
            for (int i = 123; i <= 126; i++)
            {
                lst.Add(Convert.ToChar(i).ToString());
            }

            return lst;

        }

        #endregion

        #region getBritishLowerStringArray (英数字小文字を返す)

        /// ------------------------------------------------------------------------------------------
        /// <summary>
        /// 英数字小文字を返す
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        /// ------------------------------------------------------------------------------------------
        public List<string> getBritishLowerStringArray()
        {

            List<string> lst = null;
            lst = new List<string>();

            //abcdefghijklmnopqrstuvwxyz
            for (int i = 97; i <= 122; i++)
            {
                lst.Add(Convert.ToChar(i).ToString());
            }
            return lst;


        }

        #endregion

        #region getBritishUpperStringArray (英数字大文字を返す)

        /// ------------------------------------------------------------------------------------------
        /// <summary>
        /// 英数字大文字を返す
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        /// ------------------------------------------------------------------------------------------
        public List<string> getBritishUpperStringArray()
        {

            List<string> lst = null;
            lst = new List<string>();

            //ABCDEFGHIJKLMNOPQRSTUVWXYZ
            for (int i = 65; i <= 90; i++)
            {
                lst.Add(Convert.ToChar(i).ToString());
            }
            return lst;

        }

        #endregion

        #region getBritishStringArray (英数字を返す)

        /// ------------------------------------------------------------------------------------------
        /// <summary>
        /// 英数字を返す
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        /// ------------------------------------------------------------------------------------------
        public List<string> getBritishStringArray()
        {

            List<string> lst = null;

            lst = getBritishUpperStringArray();
            lst.AddRange(this.getBritishLowerStringArray());
            return lst;

        }

        #endregion

        #endregion

        #region All Ascii Charactor List (memo)

        //ASCII		HEX		Char
        //0		0x00		NUL（null文字)
        //1		0x01		SOH（ヘッダ開始）
        //2		0x02		STX（テキスト開始）
        //3		0x03		ETX（テキスト終了）
        //4		0x04		EOT（転送終了）
        //5		0x05		ENQ（照会）
        //6		0x06		ACK（受信ＯＫ）
        //7		0x07		BEL（警告）
        //8		0x08		BS（後退）
        //9		0x09		HT（水平タブ）
        //10		0x0a		LF（改行）
        //11		0x0b		VT（垂直タブ）
        //12		0x0c		FF（改頁）
        //13		0x0d		CR（復帰）
        //14		0x0e		SO（シフトアウト）
        //15		0x0f		SI（シフトイン）
        //16		0x10		DLE（データリンクエスケープ）
        //17		0x11		DC1（装置制御１）
        //18		0x12		DC2（装置制御２）
        //19		0x13		DC3（装置制御３）
        //20		0x14		DC4（装置制御４）
        //21		0x15		NAK（受信失敗）
        //22		0x16		SYN（同期）
        //23		0x17		ETB（転送ブロック終了）
        //24		0x18		CAN（とりけし）
        //25		0x19		EM（メディア終了）
        //26		0x1a		SUB（置換）
        //27		0x1b		ESC（エスケープ）
        //28		0x1c		FS（フォーム区切り）
        //29		0x1d		GS（グループ区切り）
        //30		0x1e		RS（レコード区切り）
        //31		0x1f		US（ユニット区切り）
        //32		0x20		（スペース）
        //33		0x21		!
        //34		0x22		
        //35		0x23		#
        //36		0x24		$
        //37		0x25		%
        //38		0x26		&
        //39		0x27		'
        //40		0x28		(
        //41		0x29		)
        //42		0x2a		*
        //43		0x2b		+
        //44		0x2c		,
        //45		0x2d		-
        //46		0x2e		.
        //47		0x2f		/
        //48		0x30		0
        //49		0x31		1
        //50		0x32		2
        //51		0x33		3
        //52		0x34		4
        //53		0x35		5
        //54		0x36		6
        //55		0x37		7
        //56		0x38		8
        //57		0x39		9
        //58		0x3a		:
        //59		0x3b		;
        //60		0x3c		<
        //61		0x3d		=
        //62		0x3e		>
        //63		0x3f		?
        //64		0x40		@
        //65		0x41		A
        //66		0x42		B
        //67		0x43		C
        //68		0x44		D
        //69		0x45		E
        //70		0x46		F
        //71		0x47		G
        //72		0x48		H
        //73		0x49		I
        //74		0x4a		J
        //75		0x4b		K
        //76		0x4c		L
        //77		0x4d		M
        //78		0x4e		N
        //79		0x4f		O
        //80		0x50		P
        //81		0x51		Q
        //82		0x52		R
        //83		0x53		S
        //84		0x54		T
        //85		0x55		U
        //86		0x56		V
        //87		0x57		W
        //88		0x58		X
        //89		0x59		Y
        //90		0x5a		Z
        //91		0x5b		[
        //92		0x5c		\
        //93		0x5d		]
        //94		0x5e		^
        //95		0x5f		_
        //96		0x60		`
        //97		0x61		a
        //98		0x62		b
        //99		0x63		c
        //100	0x64		d
        //101	0x65		e
        //102	0x66		f
        //103	0x67		g
        //104	0x68		h
        //105	0x69		i
        //106	0x6a		j
        //107	0x6b		k
        //108	0x6c		l
        //109	0x6d		m
        //110	0x6e		n
        //111	0x6f		o
        //112	0x70		p
        //113	0x71		q
        //114	0x72		r
        //115	0x73		s
        //116	0x74		t
        //117	0x75		u
        //118	0x76		v
        //119	0x77		w
        //120	0x78		x
        //121	0x79		y
        //122	0x7a		z
        //123	0x7b		{
        //124	0x7c		|
        //125	0x7d		}
        //126	0x7e		~
        //127	0x7f		DEL（削除）

        #endregion

    }

}
