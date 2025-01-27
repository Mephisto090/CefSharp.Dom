using Newtonsoft.Json;

namespace CefSharp.Dom
{
    /// <summary>
    /// Cookie data.
    /// </summary>
    /// <seealso cref="IDevToolsContext.SetContentAsync(string, NavigationOptions)"/>
    /// <seealso cref="IDevToolsContext.DeleteCookieAsync(CookieParam[])"/>
    /// <seealso cref="IDevToolsContext.GetCookiesAsync(string[])"/>
    public class CookieParam
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; set; }
        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>The domain.</value>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }
        /// <summary>
        /// Gets or sets the expiration. Unix time in seconds.
        /// </summary>
        /// <value>Expiration.</value>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double? Expires { get; set; }
        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }
        /// <summary>
        /// Gets or sets if it's HTTP only.
        /// </summary>
        /// <value>Whether it's http only or not.</value>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? HttpOnly { get; set; }
        /// <summary>
        /// Gets or sets if it's secure.
        /// </summary>
        /// <value>Whether it's secure or not.</value>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Secure { get; set; }
        /// <summary>
        /// Gets or sets if it's session only.
        /// </summary>
        /// <value>Whether it's session only or not.</value>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? Session { get; set; }
        /// <summary>
        /// Gets or sets the cookies SameSite value.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SameSite? SameSite { get; set; }
    }
}
