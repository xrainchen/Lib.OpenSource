/*----------------------------------------------------------------
    Copyright (C) 2017 Senparc
    
    �ļ�����MD5UtilHelper.cs
    �ļ�������������ȡ��д��MD5ǩ�����
    
    
    ������ʶ��Senparc - 20150211
    
    �޸ı�ʶ��Senparc - 20150303
    �޸�����������ӿ�

    �޸ı�ʶ��Senparc - 20170203
    �޸�������v14.3.123  �ϳ�MD5UtilHelper�������ϲ���
       Senparc.Weixin.Helpers.EncryptHelper�£�Senparc.Weixin.dll�У�

----------------------------------------------------------------*/

using System;
using System.Security.Cryptography;
using System.Text;

namespace Senparc.Weixin.MP.Helpers
{
	/// <summary>
    /// MD5UtilHelper ��ժҪ˵����
	/// </summary>
	public class MD5UtilHelper
	{
        /// <summary>
        /// ��ȡ��д��MD5ǩ�����
        /// </summary>
        /// <param name="encypStr"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        [Obsolete("�˷����ѹ��ڣ���ʹ��Senparc.Weixin.Helpers.EncryptHelper.GetMD5(encypStr,charset)")]
        public static string GetMD5(string encypStr, string charset)
        {
            return Senparc.Weixin.Helpers.EncryptHelper.GetMD5(encypStr, charset);
        }
	}
}
