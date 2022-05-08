using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso06
{
    public class ExtratorValorDeArgumentoURL
    {
        private readonly string _argumento;
        public string URL { get; }

        public ExtratorValorDeArgumentoURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }

            int index = url.IndexOf("?");
            _argumento = url.Substring(index++);
            

            URL = url;
        }

        public string GetValorArgumento(string argumento)
        {
            int indexArgumento = _argumento.IndexOf(argumento);
            string valorArgumento = _argumento.Substring(indexArgumento + argumento.Length + 1);

            return valorArgumento;
        }

    }
}
