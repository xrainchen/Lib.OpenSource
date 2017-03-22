﻿/*----------------------------------------------------------------
    Copyright (C) 2017 Senparc

    文件名：Enums.cs
    文件功能描述：枚举类型


    创建标识：Senparc - 20150211

    修改标识：Senparc - 20150303
    修改描述：整理接口

    修改标识：Senparc - 20150303
    修改描述：添加企业号返回码

    修改标识：Senparc - 20161112
    修改描述：v4.9.3 添加小程序返回码添加小程序返回码

    修改标识：Senparc - 20161215
    修改描述：v4.9.5 添加Sex枚举

    修改标识：Senparc - 20161215
    修改描述：v4.9.9 添加【ReturnCode.template_id】不正确枚举

    修改标识：Senparc - 20170302
    修改描述：v4.11.1 添加【ReturnCode.appsecret不正确】枚举类型（invalid appsecret，40125）
----------------------------------------------------------------*/

namespace Senparc.Weixin
{
    /// <summary>
    /// CommonJsonSend中的http提交类型
    /// </summary>
    public enum CommonJsonSendType
    {
        GET,
        POST
    }

    /// <summary>
    /// 公众号返回码（JSON）
    /// 应该更名为ReturnCode_MP，但为减少项目中的修改，此处依旧用ReturnCode命名
    /// </summary>
    public enum ReturnCode
    {
        系统繁忙此时请开发者稍候再试 = -1,
        请求成功 = 0,
        获取access_token时AppSecret错误或者access_token无效 = 40001,
        不合法的凭证类型 = 40002,
        不合法的OpenID = 40003,
        不合法的媒体文件类型 = 40004,
        不合法的文件类型 = 40005,
        不合法的文件大小 = 40006,
        不合法的媒体文件id = 40007,
        不合法的消息类型 = 40008,
        不合法的图片文件大小 = 40009,
        不合法的语音文件大小 = 40010,
        不合法的视频文件大小 = 40011,
        不合法的缩略图文件大小 = 40012,
        不合法的APPID = 40013,
        不合法的access_token = 40014,
        不合法的菜单类型 = 40015,
        不合法的按钮个数1 = 40016,
        不合法的按钮个数2 = 40017,
        不合法的按钮名字长度 = 40018,
        不合法的按钮KEY长度 = 40019,
        不合法的按钮URL长度 = 40020,
        不合法的菜单版本号 = 40021,
        不合法的子菜单级数 = 40022,
        不合法的子菜单按钮个数 = 40023,
        不合法的子菜单按钮类型 = 40024,
        不合法的子菜单按钮名字长度 = 40025,
        不合法的子菜单按钮KEY长度 = 40026,
        不合法的子菜单按钮URL长度 = 40027,
        不合法的自定义菜单使用用户 = 40028,
        不合法的oauth_code = 40029,
        不合法的refresh_token = 40030,
        不合法的openid列表 = 40031,
        不合法的openid列表长度 = 40032,
        不合法的请求字符不能包含uxxxx格式的字符 = 40033,
        不合法的参数 = 40035,

        //小程序、 公众号都有
        template_id不正确 = 40037,

        不合法的请求格式 = 40038,
        不合法的URL长度 = 40039,
        不合法的分组id = 40050,
        分组名字不合法 = 40051,
        appsecret不正确 = 40125,//invalid appsecret
        缺少access_token参数 = 41001,
        缺少appid参数 = 41002,
        缺少refresh_token参数 = 41003,
        缺少secret参数 = 41004,
        缺少多媒体文件数据 = 41005,
        缺少media_id参数 = 41006,
        缺少子菜单数据 = 41007,
        缺少oauth_code = 41008,
        缺少openid = 41009,

        //小程序
        form_id不正确_或者过期 = 41028,
        form_id已被使用 = 41029,
        page不正确 = 41030,

        access_token超时 = 42001,
        refresh_token超时 = 42002,
        oauth_code超时 = 42003,
        需要GET请求 = 43001,
        需要POST请求 = 43002,
        需要HTTPS请求 = 43003,
        需要接收者关注 = 43004,
        需要好友关系 = 43005,
        多媒体文件为空 = 44001,
        POST的数据包为空 = 44002,
        图文消息内容为空 = 44003,
        文本消息内容为空 = 44004,
        多媒体文件大小超过限制 = 45001,
        消息内容超过限制 = 45002,
        标题字段超过限制 = 45003,
        描述字段超过限制 = 45004,
        链接字段超过限制 = 45005,
        图片链接字段超过限制 = 45006,
        语音播放时间超过限制 = 45007,
        图文消息超过限制 = 45008,
        接口调用超过限制 = 45009,
        创建菜单个数超过限制 = 45010,
        回复时间超过限制 = 45015,
        系统分组不允许修改 = 45016,
        分组名字过长 = 45017,
        分组数量超过上限 = 45018,
        不存在媒体数据 = 46001,
        不存在的菜单版本 = 46002,
        不存在的菜单数据 = 46003,
        解析JSON_XML内容错误 = 47001,
        api功能未授权 = 48001,
        用户未授权该api = 50001,
        参数错误invalid_parameter = 61451,
        无效客服账号invalid_kf_account = 61452,
        客服帐号已存在kf_account_exsited = 61453,
        /// <summary>
        /// 客服帐号名长度超过限制(仅允许10个英文字符，不包括@及@后的公众号的微信号)(invalid kf_acount length)
        /// </summary>
        客服帐号名长度超过限制 = 61454,
        /// <summary>
        /// 客服帐号名包含非法字符(仅允许英文+数字)(illegal character in kf_account)
        /// </summary>
        客服帐号名包含非法字符 = 61455,
        /// <summary>
        ///  	客服帐号个数超过限制(10个客服账号)(kf_account count exceeded)
        /// </summary>
        客服帐号个数超过限制 = 61456,
        无效头像文件类型invalid_file_type = 61457,
        系统错误system_error = 61450,
        日期格式错误 = 61500,
        日期范围错误 = 61501,

        //新加入的一些类型，以下文字根据P2P项目格式组织，非官方文字
        发送消息失败_48小时内用户未互动 = 10706,
        发送消息失败_该用户已被加入黑名单_无法向此发送消息 = 62751,
        发送消息失败_对方关闭了接收消息 = 10703,
        对方不是粉丝 = 10700
    }

    /// <summary>
    /// 企业号返回码
    /// </summary>
    public enum ReturnCode_QY
    {
        请求成功 = 0,
        获取access_token时Secret错误或者access_token无效 = 40001,
        不合法的凭证类型 = 40002,
        不合法的UserID = 40003,
        不合法的媒体文件类型 = 40004,
        不合法的文件类型 = 40005,
        不合法的文件大小 = 40006,
        不合法的媒体文件id = 40007,
        不合法的消息类型 = 40008,
        不合法的corpid = 40013,
        不合法的access_token = 40014,
        不合法的菜单类型 = 40015,
        不合法的按钮个数 = 40016,
        不合法的按钮类型 = 40017,
        不合法的按钮名字长度 = 40018,
        不合法的按钮KEY长度 = 40019,
        不合法的按钮URL长度 = 40020,
        不合法的菜单版本号 = 40021,
        不合法的子菜单级数 = 40022,
        不合法的子菜单按钮个数 = 40023,
        不合法的子菜单按钮类型 = 40024,
        不合法的子菜单按钮名字长度 = 40025,
        不合法的子菜单按钮KEY长度 = 40026,
        不合法的子菜单按钮URL长度 = 40027,
        不合法的自定义菜单使用成员 = 40028,
        不合法的oauth_code = 40029,
        不合法的UserID列表 = 40031,
        不合法的UserID列表长度 = 40032,
        不合法的请求字符_不能包含uxxxx格式的字符 = 40033,
        不合法的参数 = 40035,

        //小程序、 公众号都有
        template_id不正确 = 40037,

        不合法的请求格式 = 40038,
        不合法的URL长度 = 40039,
        不合法的插件token = 40040,
        不合法的插件id = 40041,
        不合法的插件会话 = 40042,
        url中包含不合法domain = 40048,
        不合法的子菜单url域名 = 40054,
        不合法的按钮url域名 = 40055,
        不合法的agentid = 40056,
        不合法的callbackurl = 40057,
        不合法的红包参数 = 40058,
        不合法的上报地理位置标志位 = 40059,
        设置上报地理位置标志位时没有设置callbackurl = 40060,
        设置应用头像失败 = 40061,
        不合法的应用模式 = 40062,
        红包参数为空 = 40063,
        管理组名字已存在 = 40064,
        不合法的管理组名字长度 = 40065,
        不合法的部门列表 = 40066,
        标题长度不合法 = 40067,
        不合法的标签ID = 40068,
        不合法的标签ID列表 = 40069,
        列表中所有标签_成员_ID都不合法 = 40070,
        不合法的标签名字_标签名字已经存在 = 40071,
        不合法的标签名字长度 = 40072,
        不合法的openid = 40073,
        news消息不支持指定为高保密消息 = 40074,
        不合法的预授权码 = 40077,
        不合法的临时授权码 = 40078,
        不合法的授权信息 = 40079,
        不合法的suitesecret = 40080,
        不合法的suitetoken = 40082,
        不合法的suiteid = 40083,
        不合法的永久授权码 = 40084,
        不合法的suiteticket = 40085,
        不合法的第三方应用appid = 40086,
        缺少access_token参数 = 41001,
        缺少corpid参数 = 41002,
        缺少refresh_token参数 = 41003,
        缺少secret参数 = 41004,
        缺少多媒体文件数据 = 41005,
        缺少media_id参数 = 41006,
        缺少子菜单数据 = 41007,
        缺少oauthcode = 41008,
        缺少UserID = 41009,
        缺少url = 41010,
        缺少agentid = 41011,
        缺少应用头像mediaid = 41012,
        缺少应用名字 = 41013,
        缺少应用描述 = 41014,
        缺少Content = 41015,
        缺少标题 = 41016,
        缺少标签ID = 41017,
        缺少标签名字 = 41018,
        缺少suiteid = 41021,
        缺少suitetoken = 41022,
        缺少suiteticket = 41023,
        缺少suitesecret = 41024,
        缺少永久授权码 = 41025,

        //小程序
        form_id不正确_或者过期 = 41028,
        form_id已被使用 = 41029,
        page不正确 = 41030,


        access_token超时 = 42001,
        refresh_token超时 = 42002,
        oauth_code超时 = 42003,
        插件token超时 = 42004,
        预授权码失效 = 42007,
        临时授权码失效 = 42008,
        suitetoken失效 = 42009,
        需要GET请求 = 43001,
        需要POST请求 = 43002,
        需要HTTPS = 43003,
        需要成员已关注 = 43004,
        需要好友关系 = 43005,
        需要订阅 = 43006,
        需要授权 = 43007,
        需要支付授权 = 43008,
        需要处于回调模式 = 43010,
        需要企业授权 = 43011,
        多媒体文件为空 = 44001,
        POST的数据包为空 = 44002,
        图文消息内容为空 = 44003,
        文本消息内容为空 = 44004,
        多媒体文件大小超过限制 = 45001,
        消息内容超过限制 = 45002,
        标题字段超过限制 = 45003,
        描述字段超过限制 = 45004,
        链接字段超过限制 = 45005,
        图片链接字段超过限制 = 45006,
        语音播放时间超过限制 = 45007,
        图文消息超过限制 = 45008,
        接口调用超过限制 = 45009,
        创建菜单个数超过限制 = 45010,
        回复时间超过限制 = 45015,
        系统分组不允许修改 = 45016,
        分组名字过长 = 45017,
        分组数量超过上限 = 45018,
        账号数量超过上限 = 45024,
        mpnews消息每天只能发送100次 = 45027,
        不存在媒体数据 = 46001,
        不存在的菜单版本 = 46002,
        不存在的菜单数据 = 46003,
        不存在的成员 = 46004,
        解析JSONXML内容错误 = 47001,
        Api未授权 = 48001,
        Api禁用 = 48002,
        suitetoken无效 = 48003,
        授权关系无效 = 48004,
        redirect_uri未授权 = 50001,
        成员不在权限范围 = 50002,
        应用已停用 = 50003,
        成员状态不正确需要成员为企业验证中状态 = 50004,
        企业已禁用 = 50005,
        部门长度不符合限制 = 60001,
        部门层级深度超过限制 = 60002,
        部门不存在 = 60003,
        父亲部门不存在 = 60004,
        不允许删除有成员的部门 = 60005,
        不允许删除有子部门的部门 = 60006,
        不允许删除根部门 = 60007,
        部门名称已存在 = 60008,
        部门名称含有非法字符 = 60009,
        部门存在循环关系 = 60010,
        管理员权限不足_user_department_agent_无权限 = 60011,
        不允许删除默认应用 = 60012,
        不允许关闭应用 = 60013,
        不允许开启应用 = 60014,
        不允许修改默认应用可见范围 = 60015,
        不允许删除存在成员的标签 = 60016,
        不允许设置企业 = 60017,
        不允许设置应用地理位置上报开关 = 60019,
        访问ip不在白名单之中 = 60020,
        应用已授权予第三方不允许通过分级管理员修改菜单 = 60023,
        UserID已存在 = 60102,
        手机号码不合法 = 60103,
        手机号码已存在 = 60104,
        邮箱不合法 = 60105,
        邮箱已存在 = 60106,
        微信号不合法 = 60107,
        微信号已存在 = 60108,
        QQ号已存在 = 60109,
        部门个数超出限制 = 60110,
        UserID不存在 = 60111,
        成员姓名不合法 = 60112,
        身份认证信息_微信号_手机_邮箱_不能同时为空 = 60113,
        性别不合法 = 60114,
        已关注成员微信不能修改 = 60115,
        扩展属性已存在 = 60116,
        成员无有效邀请字段_微信_邮箱_手机号 = 60118,
        成员已关注 = 60119,
        成员已禁用 = 60120,
        找不到该成员 = 60121,
        邮箱已被外部管理员使用 = 60122,
        无效的部门id = 60123,
        无效的父部门id = 60124,
        部门名字长度超过限制 = 60125,
        创建部门失败 = 60126,
        缺少部门id = 60127,
        字段不合法可能存在主键冲突或者格式错误 = 60128,
        可信域名没有IPC备案后续将不能在该域名下正常使用jssdk = 80001,
        发送消息或者邀请的参数全部为空或者全部不合法 = 82001,
        不合法的PartyID列表长度 = 82002,
        不合法的TagID列表长度 = 82003,
    }



    /// <summary>
    /// 语言
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// 中文简体
        /// </summary>
        zh_CN,
        /// <summary>
        /// 中文繁体
        /// </summary>
        zh_TW,
        /// <summary>
        /// 英文
        /// </summary>
        en
    }

    /// <summary>
    /// AppStore状态
    /// </summary>
    public enum AppStoreState
    {
        /// <summary>
        /// 无状态
        /// </summary>
        None = 1,
        /// <summary>
        /// 已进入应用状态
        /// </summary>
        Enter = 2,
        /// <summary>
        /// 退出App状态（临时传输状态，退出后即为None）
        /// </summary>
        Exit = 4
    }

    /// <summary>
    /// 用户信息中的性别（sex）
    /// </summary>
    public enum Sex
    {
        未知=0,
        男=1,
        女=2
    }
}
