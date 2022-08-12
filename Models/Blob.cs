﻿using System.Text.Json.Serialization;

namespace GithubClient.Models
{
    /// <summary>
    /// A Git blob (binary large object) is the object type used to store the contents of each file in a repository.
    /// </summary>
    /// 
    /// <seealso href="https://docs.github.com/en/rest/git/blobs">Github Docs : Blobs</seealso>
    public class Blob
    {
        /// <summary>
        /// Github API Url
        /// </summary>
        private static readonly string Api = "https://api.github.com";
        /// <summary>
        /// The file's SHA-1 hash is computed and stored in the blob object
        /// </summary>
        [JsonPropertyName("sha")]
        public string? Sha { get; set; }
        /// <summary>
        /// Id of a Node (Node is a generic term for an object) used in GraphQL
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }
        /// <summary>
        /// File size in bytes
        /// </summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }
        /// <summary>
        /// Github API Url for this object
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        /// <summary>
        /// File Contents
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }
        /// <summary>
        /// The encoding used for content. Currently, "utf-8" and "base64" are supported.
        /// </summary>
        [JsonPropertyName("encoding")]
        public string? Encoding { get; set; }
        /// <summary>
        /// A method to return the default header
        /// </summary>
        /// <returns>The recommended header</returns>
        public static string GetHeader()
        {
            return "application/vnd.github+json";
        }
        /// <summary>
        /// A method to return the API Url
        /// </summary>
        /// <returns></returns>
        public static Uri GetApiUrl()
        {
            return new Uri(Api);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner">The account owner of the repository. This can also be the organization name. The name is not case sensitive.</param>
        /// <param name="Name">The name of the repository. The name is not case sensitive.</param>
        /// <param name="Sha">Secure hashing algorithm</param>
        /// <returns></returns>
        public static Uri GetApiUrl(string Owner, string Name, string Sha)
        {
            return new Uri(Api + "/repos/" + Owner + "/" + Name + "/git/blobs/" + Sha);
        }
    }
}