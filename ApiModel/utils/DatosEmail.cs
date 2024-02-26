using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace ApiModel.utils
{
    public class DatosEmail
    {
        public MailAddress De { get; set; }
        public List<string> Para { get; set; }
        public List<string> ConCopia { get; set; }
        public List<string> ConCopiaOculta { get; set; }
        public string Titulo { get; set; }
        public string Mensaje { get; set; }
        public List<string> Adjuntos { get; set; }

        public DatosEmail()
        {
            De = new MailAddress("walter150976@gmail.com");
            Para = new List<string>();
            ConCopia = new List<string>();
            ConCopiaOculta = new List<string>();
            Titulo = "";
            Mensaje = "";
            Adjuntos = new List<string>();
        }
    }
}
