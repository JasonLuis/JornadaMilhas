using Azure.Core;
using Microsoft.IdentityModel.Tokens;

namespace JornadaMilhas.API.Helpers;

public class UploadFile
{

    public static async Task<string> Upload(string? fileBase64, IHostEnvironment env)
    {
        if (!fileBase64.IsNullOrEmpty())
        {
            var nome = fileBase64.Trim();
            var foto = DateTime.Now.ToString("ddMMyyyyhhss") + "." + nome + ".jpeg";

            var path = Path.Combine(env.ContentRootPath, "wwwroot", "Fotos", foto);

            using MemoryStream ms = new MemoryStream(Convert.FromBase64String(fileBase64));
            using FileStream fs = new(path, FileMode.Create);
            await ms.CopyToAsync(fs);

            return foto;
        }

        return "";
    }
}
