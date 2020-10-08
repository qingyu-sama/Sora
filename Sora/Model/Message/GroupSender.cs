using Newtonsoft.Json;

namespace Sora.Model.Message
{
    /// <summary>
    /// 群组消息发送者
    /// </summary>
    internal sealed class GroupSender
    {
        /// <summary>
        /// 发送者 QQ 号
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        internal long UserId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty(PropertyName = "nickname")]
        internal string Nick { get; set; }

        /// <summary>
        /// 群名片／备注
        /// </summary>
        [JsonProperty(PropertyName = "card")]
        internal string Card { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty(PropertyName = "sex")]
        internal string Sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [JsonProperty(PropertyName = "age")]
        internal int Age { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [JsonProperty(PropertyName = "area")]
        internal string Area { get; set; }

        /// <summary>
        /// 成员等级
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        internal string Level { get; set; }

        /// <summary>
        /// 角色(权限等级)
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        internal string Role { get; set; }

        /// <summary>
        /// 专属头衔
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        internal string Title { get; set; }
    }
}
