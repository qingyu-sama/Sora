using Newtonsoft.Json;
using Sora.Converter;
using Sora.Enumeration.ApiEnum;

namespace Sora.EventArgs.OnebotEvent.RequestEvent
{
    /// <summary>
    /// 群聊邀请/入群请求事件
    /// </summary>
    internal sealed class ServerGroupRequestEventArgs : BaseRequestEvent
    {
        /// <summary>
        /// 请求子类型
        /// </summary>
        [JsonConverter(typeof(EnumDescriptionConverter))]
        [JsonProperty(PropertyName = "sub_type")]
        internal GroupRequestType GroupRequestType { get; set; }

        /// <summary>
        /// 群号
        /// </summary>
        [JsonProperty(PropertyName = "group_id")]
        internal long GroupId { get; set; }
    }
}