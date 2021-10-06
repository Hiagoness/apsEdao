using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apsEdao.Models
{
    public class ApiResponse<T> where T : class
    {
        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("erro")]
        public object Erro { get; set; }

        [JsonProperty("mensagem")]
        public string Mensagem { get; set; }

        [JsonProperty("observacaoTecnica")]
        public string ObservacaoTecnica { get; set; }

        public static ApiResponse<T> NotFoundResponse(string entidade, int idEntidade, string controller, string genero)
        {
            switch (genero)
            {
                case "M":
                    return RepostaDeErro($"O {entidade} {idEntidade} não foi encontrado.",
                        $"seminovos-api-{controller}_404_{entidade}-nao-encontrado",
                        new { });

                case "F":
                    return RepostaDeErro($"A {entidade} {idEntidade} não foi encontrada.",
                        $"seminovos-api-{controller}_404_{entidade}-nao-encontrada",
                        new { });
            };

            return null;
        }

        public static ApiResponse<T> RepostaDeErro(string mensagem, string observacaoTecnica, object erro)
        {
            return new ApiResponse<T>
            {
                Mensagem = mensagem,
                ObservacaoTecnica = observacaoTecnica,
                Erro = erro,
                Data = null
            };
        }

        public static ApiResponse<T> RespostaDeSucesso(string mensagem, T data)
        {
            return new ApiResponse<T>
            {
                Mensagem = mensagem,
                Data = data,
                Erro = null,
                ObservacaoTecnica = null
            };
        }

        public ApiResponse() { }
    }
}
