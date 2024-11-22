using System;
using System.Security.Cryptography;
using System.Text;

namespace HousingAPITestApp
{
    class APISignature
    {
        private const char SEPARATOR = '|';     // Request separator

        public string Key { get; private set; }
        public string Secret { get; private set; }
        public string HttpMethod { get; private set; }
        public string AbsoluteURI { get; private set; }
        public long ContentLength { get; private set; }
        public string Component { get; private set; }

        public string Timestamp { get; private set; }

        public APISignature(string key, string secret, string method, string uri, string component) 
            : this(key, secret, method, uri, component, DateTime.UtcNow.ToString("yyyyMMddTHHmmss"), 0)
        {
        }

        public APISignature(string key, string secret, string method, string uri, string component, string timestamp, long contentlength)
        {
            Key = key;
            Secret = secret;
            HttpMethod = method;
            AbsoluteURI = uri;
            Component = component;
            ContentLength = contentlength;
            Timestamp = timestamp; //DateTime.UtcNow.ToString("yyyyMMddTHHmmss");
        }

        /// <summary>
        /// Calculates a signature for this specific request
        /// </summary>
        public String ToSignature()
        {
            // The Request to sign is comprised of key parts of the request to be sent.
            string requestToSign = GetRequestToSign();

            // The Sign Key is a key derived from your private API secret that will be used to produce the final HMAC
            byte[] key = GetSignKey();

            // Produce signature
            byte[] signature = HMAC(key, requestToSign);

            return Convert.ToBase64String(signature);
        }

        private byte[] GetSignKey()
        {
            // Step 1: Produce a HMAC of the current request timestamp using private secret
            var step1Key = HMAC(Secret, this.Timestamp);

            // Step 2: Produce a HMAC of the current request details using previous result as the key
            var step2Key = HMAC(step1Key, String.Format("{0}{1}", Component.ToLower(), Key.ToLower()));

            Console.WriteLine("DBG: " + String.Format("{0}{1}", Component.ToLower(), Key.ToLower()));

            return step2Key;
        }

        private string GetRequestToSign()
        {
            StringBuilder toSign = new StringBuilder();

            // Lower-case HTTP Method
            toSign.Append(HttpMethod.ToLower());

            // Separator
            toSign.Append(SEPARATOR);

            // Lower-case Absolute URI
            toSign.Append(AbsoluteURI.ToLower());

            // Separator
            toSign.Append(SEPARATOR);

            // Content Length
            toSign.Append(ContentLength);

            Console.WriteLine("DBG: " + toSign.ToString());

            return toSign.ToString();
        }

        #region Utility
        private byte[] HMAC(string key, string toSign)
        {
            // Convert key to UTF8 byte array
            var keyBytes = Encoding.UTF8.GetBytes(key);

            return HMAC(keyBytes, toSign);
        }

        private byte[] HMAC(byte[] key, string toSign)
        {
            // Convert string to UTF8 byte array
            var bytesToSign = ToByteArray(toSign);

            // Create HMAC algorithm
            HMACSHA256 hmac = new HMACSHA256(key);

            return hmac.ComputeHash(bytesToSign);
        }

        private byte[] ToByteArray(string input)
        {
            return Encoding.UTF8.GetBytes(input);
        }
        #endregion
    }
}
