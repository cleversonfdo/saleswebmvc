//classe criada automaticamente pelo aplicativo
using System;

namespace SalesWebMvc.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //inser��o de propriedade para ser possivel a utiliza��o de mensagens
        public string Message { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}