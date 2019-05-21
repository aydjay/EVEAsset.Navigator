using System;
using System.Collections.Generic;
using System.Security.Claims;
using EVEStandard.Models.API;
using EVEStandard.Models.SSO;

namespace Navigator
{
    public static class Extensions
    {
        public static AuthDTO EsiAuth(this ClaimsPrincipal user)
        {
            if (string.IsNullOrEmpty(user.FindFirstValue("AccessToken")))
            {
                throw new UnauthorizedAccessException("You need to login via ESI.");
            }

            return new AuthDTO
            {
                AccessToken = new AccessTokenDetails
                {
                    AccessToken = user.FindFirstValue("AccessToken"),
                    ExpiresUtc = DateTime.Parse(user.FindFirstValue("AccessTokenExpiry")),
                    RefreshToken = user.FindFirstValue("RefreshToken")
                },
                CharacterId = Convert.ToInt32(user.FindFirstValue(ClaimTypes.NameIdentifier)),
                Scopes = user.FindFirstValue("Scopes")
            };
        }

        /// <summary>
        /// Taken from: https://stackoverflow.com/questions/489258/linqs-distinct-on-a-particular-property
        /// Author (Jon Skeet)
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}