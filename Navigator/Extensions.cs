using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using EVEStandard.Models.API;
using EVEStandard.Models.SSO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Navigator.Consts;

namespace Navigator
{
    public static class Extensions
    {
        public static AuthDTO GetAuth(this ClaimsPrincipal principal)
        {
            if (string.IsNullOrEmpty(principal.FindFirstValue(AppClaimTypes.AccessToken)))
            {
                throw new UnauthorizedAccessException("You need to login via ESI.");
            }

            return new AuthDTO
            {
                CharacterId = int.Parse(principal.FindFirstValue(ClaimTypes.NameIdentifier)),
                AccessToken = new AccessTokenDetails
                {
                    AccessToken = principal.FindFirstValue(AppClaimTypes.AccessToken),
                    ExpiresUtc = DateTime.Parse(principal.FindFirstValue(AppClaimTypes.AccessTokenExpiry)),
                    RefreshToken = principal.FindFirstValue(AppClaimTypes.RefreshToken)
                },
                Scopes = principal.FindFirstValue(AppClaimTypes.Scopes)
            };
        }

        public static async Task SignInAsync(this HttpContext context, AccessTokenDetails accessToken, CharacterDetails character)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, character.CharacterId.ToString()),
                new Claim(ClaimTypes.Name, character.CharacterName),
                new Claim(AppClaimTypes.AccessToken, accessToken.AccessToken),
                new Claim(AppClaimTypes.RefreshToken, accessToken.RefreshToken ?? ""),
                new Claim(AppClaimTypes.AccessTokenExpiry, accessToken.ExpiresUtc.ToString()),
                new Claim(AppClaimTypes.Scopes, character.Scopes)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), new AuthenticationProperties
            {
                IsPersistent = true,
                ExpiresUtc = DateTime.UtcNow.AddHours(24)
            });
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