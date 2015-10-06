﻿// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

using System.Security.Cryptography;

namespace NWebsec.SessionSecurity.SessionState
{
    internal class HmacSha256Helper : IHmacHelper
    {
        public byte[] CalculateMac(byte[] key, byte[] input)
        {
            using (var hmac = new HMACSHA256(key))
            {
                return hmac.ComputeHash(input);
            }
        }
    }
}