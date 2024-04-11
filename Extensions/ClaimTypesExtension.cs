using System.Security.Claims;

namespace JwtAspNet.Extensions
{
    public static class ClaimTypesExtension
    {
        public static int Id(this ClaimsPrincipal user)
        {
            try
            {
                var id = user.Claims.FirstOrDefault(x => x.Type == "id")?.Value ?? "0";
                return int.Parse(id);
            }
            catch
            {
                return 0;
            }
        }
        public static string Name(this ClaimsPrincipal user)
        {
            try
            {
                var name = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value ?? string.Empty;
                return name;
            }
            catch
            {
                return string.Empty;
            }
        }
        public static string Email(this ClaimsPrincipal user)
        {
            try
            {
                var email = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value ?? string.Empty;
                return email;
            }
            catch
            {
                return string.Empty;
            }
        }
        public static string GivenName(this ClaimsPrincipal user)
        {
            try
            {
                var givenName = user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.GivenName)?.Value ?? string.Empty;
                return givenName;
            }
            catch
            {
                return string.Empty;
            }
        }
        public static string Image(this ClaimsPrincipal user)
        {
            try
            {
                var image = user.Claims.FirstOrDefault(x => x.Type == "image")?.Value ?? string.Empty;
                return image;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}

