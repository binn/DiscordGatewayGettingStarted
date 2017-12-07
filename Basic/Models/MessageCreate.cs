using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace MyApp.Models
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class MessageObject
    {
        [J("attachments")] public object[] Attachments { get; set; }
        [J("author")] public Author Author { get; set; }
        [J("channel_id")] public string ChannelId { get; set; }
        [J("content")] public string Content { get; set; }
        [J("edited_timestamp")] public object EditedTimestamp { get; set; }
        [J("embeds")] public object[] Embeds { get; set; }
        [J("id")] public string Id { get; set; }
        [J("mention_everyone")] public bool MentionEveryone { get; set; }
        [J("mention_roles")] public object[] MentionRoles { get; set; }
        [J("mentions")] public object[] Mentions { get; set; }
        [J("pinned")] public bool Pinned { get; set; }
        [J("reactions")] public Reaction[] Reactions { get; set; }
        [J("timestamp")] public string Timestamp { get; set; }
        [J("tts")] public bool Tts { get; set; }
        [J("type")] public long Type { get; set; }
    }

    public class Reaction
    {
        [J("count")] public long Count { get; set; }
        [J("emoji")] public Emoji Emoji { get; set; }
        [J("me")] public bool Me { get; set; }
    }

    public class Emoji
    {
        [J("id")] public object Id { get; set; }
        [J("name")] public string Name { get; set; }
    }

    public class Author
    {
        [J("avatar")] public string Avatar { get; set; }
        [J("discriminator")] public string Discriminator { get; set; }
        [J("id")] public string Id { get; set; }
        [J("username")] public string Username { get; set; }
    }
}
