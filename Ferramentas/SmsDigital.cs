using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas
{
   

        #region envio
        public partial class SequenciaSMS
        {
            public long Celular;
            public int Sequencia;
        }

        public class Destinatario
        {
            public string Celular, Assunto, Mensagem;
            public DateTime? Data;
        }

        public partial class SMS
        {
            string Usuario, Senha;

            public SMS(string usuario, string senha)
            {
                Usuario = usuario;
                Senha = senha;
            }

            public async Task<SequenciaSMS[]> EnvieSms(string[] destinatarios, string mensagem, DateTime? data = null, string assunto = null, bool flash = false)
            {
                using (var ws = new HttpClient())
                {
                    ws.BaseAddress = new Uri("https://ws.smsdigital.com.br/");
                    ws.DefaultRequestHeaders.Accept.Clear();
                    ws.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    ws.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", Usuario, Senha))));

                    //objeto com os parâmetros de envio
                    var envio = new
                    {
                        Destinatarios = destinatarios,
                        Mensagem = mensagem,
                        Data = data,
                        Assunto = assunto,
                        Flash = flash
                    };

                    try
                    {
                        //fazendo a chamada                    
                        var post = await ws.PostAsync("sms/envio", new StringContent(JsonConvert.SerializeObject(envio), Encoding.UTF8, "application/json"));
                        var resposta = JsonConvert.DeserializeObject<RespostaSMS>(await post.Content.ReadAsStringAsync());

                        if (resposta.Status == StatusEnvio.Sucesso)
                        {
                            //resposta.Destinatarios e resposta.Lote podem ser usados para consultar status, resposta etc
                            return resposta.Destinatarios;
                        }
                        else
                        {
                            //resposta.StatusMensagem explica qual o motivo do não envio
                            throw new Exception(resposta.StatusMensagem);
                        }
                    }
                    catch (Exception ex)
                    {
                        //tratar exceção, conferir usuário/senha, url etc
                        throw ex;
                    }
                }
            }

            class RespostaSMS
            {
                public int Lote;
                public string StatusMensagem;
                public StatusEnvio Status;

                public SequenciaSMS[] Destinatarios;
            }

            enum StatusEnvio
            {
                Erro,
                Sucesso,
                SemCreditos,
                SemMensagem,
                SemAssunto,
                SemDestinatarios,
                MaximoDestinatarios,
                TamanhoExcedido,
                DestinatarioInvalido,
            }
        }

        public partial class SMS
        {
            public async Task<SequenciaSMS[]> EnvieSmsPersonalizado(Destinatario[] destinatarios)
            {
                using (var ws = new HttpClient())
                {
                    ws.BaseAddress = new Uri("https://ws.smsdigital.com.br/");
                    ws.DefaultRequestHeaders.Accept.Clear();
                    ws.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    ws.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", Usuario, Senha))));

                    //objeto com os parametros para envio
                    var envio = new
                    {
                        Destinatarios = destinatarios
                    };

                    try
                    {
                        //fazendo a chamada
                        var post = await ws.PostAsync("sms/envioPersonalizado", new StringContent(
       JsonConvert.SerializeObject(envio), Encoding.UTF8, "application/json"));
                        var resposta = JsonConvert.DeserializeObject<RespostaSMS>(await post.Content.ReadAsStringAsync());

                        if (resposta.Status == StatusEnvio.Sucesso)
                        {
                            //resposta.Destinatarios e resposta.Lote podem ser usados para consultar status, resposta etc
                            return resposta.Destinatarios;
                        }
                        else
                        {
                            //resposta.StatusMensagem explica qual o motivo do não envio
                            throw new Exception(resposta.StatusMensagem);
                        }
                    }
                    catch (Exception ex)
                    {
                        //tratamento exceção, conferir usuário/senha, url etc
                        throw ex;
                    }
                }
            }
        }
        #endregion

        #region cancelamento
        public partial class SMS
        {
            public async Task<SequenciaCancelamento[]> CanceleSms(int[] sequencias)
            {
                using (var ws = new HttpClient())
                {
                    ws.BaseAddress = new Uri("https://ws.smsdigital.com.br");
                    ws.DefaultRequestHeaders.Accept.Clear();
                    ws.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    ws.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", Usuario, Senha))));

                    //objeto envio
                    var sequenciaSMS = new
                    {
                        Sequencias = sequencias
                    };

                    try
                    {
                        var post = await ws.PostAsync("sms/cancelamento", new StringContent(JsonConvert.SerializeObject(sequenciaSMS), Encoding.UTF8, "application/json"));
                        var resposta = JsonConvert.DeserializeObject<RespostaCancelamento>(await post.Content.ReadAsStringAsync());

                        if (resposta.Status == StatusCancelamento.Sucesso)
                        {

                            return resposta.Cancelamentos;
                        }
                        else
                        {
                            //resposta.StatusMensagem explica por que não foi cancelado
                            throw new Exception(resposta.StatusMensagem);
                        }
                    }
                    catch (Exception ex)
                    {
                        //tratamento exceção, conferir usuário/senha, url etc
                        throw ex;
                    }
                }
            }
        }

        public class RespostaCancelamento
        {
            public StatusCancelamento Status;
            public int TotalMensagensCanceladas;
            public string StatusMensagem;
            public SequenciaCancelamento[] Cancelamentos;
        }

        public class SequenciaCancelamento
        {
            public int Sequencia;
            public bool Cancelado;
        }

        public enum StatusCancelamento { Erro, Sucesso, SemSequencias }
        #endregion

        #region status
        public enum StatusSMS
        {
            Enviar = 101,
            Erro = 104,
            Enviada = 105,
            NaoEntregue = 106,
            Entregue = 107,
            Blacklist = 108,
            Invalido = 109,
            CotaExcedida = 112
        }

        public class SequenciaStatus
        {
            public string StatusDescricao;
            public StatusSMS StatusCodigo;
            public int Sequencia;
        }

        public partial class SMS
        {
            public async Task<SequenciaStatus[]> ConsulteStatus(int[] sequencias)
            {
                using (var ws = new HttpClient())
                {
                    ws.BaseAddress = new Uri("https://ws.smsdigital.com.br/");
                    ws.DefaultRequestHeaders.Accept.Clear();
                    ws.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    ws.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", Usuario, Senha))));

                    //objeto envio
                    var sequenciaSMS = new
                    {
                        Sequencias = sequencias
                    };

                    try
                    {
                        var post = await ws.PostAsync("sms/status", new StringContent(
                           JsonConvert.SerializeObject(sequenciaSMS), Encoding.UTF8, "application/json"));
                        var resposta = JsonConvert.DeserializeObject<RespostaStatus>(await post.Content.ReadAsStringAsync());

                        if (resposta.Status == StatusResposta.Sucesso)
                        {
                            //StatusSequencias contem o status de cada sequencia
                            return resposta.StatusSequencias;
                        }
                        else
                        {
                            //resposta.StatusMensagem explica por que não voltaram os status
                            throw new Exception(resposta.StatusMensagem);
                        }
                    }
                    catch (Exception ex)
                    {
                        //tratamento exceção, conferir usuário/senha, url etc
                        throw ex;
                    }
                }
            }

            enum StatusResposta
            {
                Erro,
                Sucesso,
                MaximoConsultas
            }

            class RespostaStatus
            {
                public SequenciaStatus[] StatusSequencias;
                public StatusResposta Status;
                public string StatusMensagem;
            }
        }
        #endregion

        #region resposta
        public class Resposta
        {
            public int Sequencia;
            public string Mensagem;
            public DateTime Data;
        }

        public partial class SMS
        {
            public async Task<Resposta[]> ConsulteResposta(int[] sequencias)
            {
                using (var ws = new HttpClient())
                {
                    ws.BaseAddress = new Uri("https://ws.smsdigital.com.br/");
                    ws.DefaultRequestHeaders.Accept.Clear();
                    ws.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    ws.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", Usuario, Senha))));

                    //objeto envio
                    var sequenciasSMS = new
                    {
                        Sequencias = sequencias
                    };

                    try
                    {
                        var post = await ws.PostAsync("sms/resposta", new StringContent(
       JsonConvert.SerializeObject(sequenciasSMS), Encoding.UTF8, "application/json"));
                        var resposta = JsonConvert.DeserializeObject<RetornoSMS>(await post.Content.ReadAsStringAsync());

                        if (resposta.Status == StatusRespostaSMS.Sucesso)
                        {
                            //verificar status
                            return resposta.Respostas;
                        }
                        else
                        {
                            //resposta.StatusMensagem explica por que não voltaram os status
                            throw new Exception(resposta.StatusMensagem);
                        }
                    }
                    catch (Exception ex)
                    {
                        //tratamento exceção, conferir usuário/senha, url etc
                        throw ex;
                    }
                }
            }

            enum StatusRespostaSMS
            {
                Erro,
                Sucesso,
                MaximoConsultas
            }

            class RetornoSMS
            {
                public StatusRespostaSMS Status;
                public string StatusMensagem;
                public Resposta[] Respostas;
            }
        }
        #endregion

        #region saldo
        public partial class SMS
        {
            public async Task<int> ConsulteSaldo(string subusuario = null)
            {
                using (var ws = new HttpClient())
                {
                    ws.BaseAddress = new Uri("https://ws.smsdigital.com.br/");
                    ws.DefaultRequestHeaders.Accept.Clear();
                    ws.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    ws.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", Usuario, Senha))));

                    //objeto de envio
                    var parametro = new
                    {
                        Subusuario = subusuario
                    };

                    try
                    {
                        var post = await ws.PostAsync("sms/saldo", new StringContent(
    JsonConvert.SerializeObject(parametro), Encoding.UTF8, "application/json"));
                        var resposta = JsonConvert.DeserializeObject<RespostaSaldo>(await post.Content.ReadAsStringAsync());

                        if (resposta.Status == StatusSaldo.Sucesso)
                        {
                            //verificar status
                            return resposta.Saldo;
                        }
                        else
                        {
                            //resposta.StatusMensagem explica por que não voltaram os status
                            throw new Exception(resposta.StatusMensagem);
                        }
                    }
                    catch (Exception ex)
                    {
                        //tratamento exceção, conferir usuário/senha, url etc
                        throw ex;
                    }
                }
            }

            enum StatusSaldo
            {
                Erro,
                Sucesso,
                MaximoConsultas,
                UsuarioInvalido
            }

            class RespostaSaldo
            {
                public int Saldo;
                public StatusSaldo Status;
                public string StatusMensagem;
            }

        }
        #endregion

        #region mais cliente
        public class Mailing
        {
            public int ID;
            public string Celular, Campo1, Campo2, Campo3;
        }

        public partial class SMS
        {
            public async Task<Mailing[]> ConsulteMaisClientes(int evento, string senha, bool todosCelulares)
            {
                using (var ws = new HttpClient())
                {
                    ws.BaseAddress = new Uri("https://ws.smsdigital.com.br/");
                    ws.DefaultRequestHeaders.Accept.Clear();
                    ws.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    ws.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", Usuario, Senha))));

                    //objeto para envio
                    var maisClientes = new
                    {
                        Evento = evento,
                        Senha = senha,
                        TodosCelulares = todosCelulares
                    };

                    try
                    {
                        var post = await ws.PostAsync("sms/mailingMaisClientes", new StringContent(
    JsonConvert.SerializeObject(maisClientes), Encoding.UTF8, "application/json"));
                        var resposta = JsonConvert.DeserializeObject<RespostaMailingMaisCliente>(await post.Content.ReadAsStringAsync());

                        if (resposta.Status == StatusMailingMaisCliente.Sucesso)
                        {
                            //mailing deste Mais Clientes
                            return resposta.Mailing;
                        }
                        else
                        {
                            //resposta.StatusMensagem explica por que não voltaram os status
                            throw new Exception(resposta.StatusMensagem);
                        }
                    }
                    catch (Exception ex)
                    {
                        //tratamento exceção, conferir usuário/senha, url etc
                        throw ex;
                    }
                }
            }

            enum StatusMailingMaisCliente
            {
                Erro,
                Sucesso,
                EventoInvalido
            }

            class RespostaMailingMaisCliente
            {
                public Mailing[] Mailing;
                public StatusMailingMaisCliente Status;
                public string StatusMensagem;
            }
        }
        #endregion

        #region entrevistado radar
        public partial class SMS
        {
            public async Task<int> CadastreEntrevistado(int pesquisa, string celular, string nome = null, string apelido = null, string referencia = null)
            {
                using (var ws = new HttpClient())
                {
                    ws.BaseAddress = new Uri("https://ws.smsdigital.com.br/");
                    ws.DefaultRequestHeaders.Accept.Clear();
                    ws.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    ws.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", Usuario, Senha))));

                    //objeto com parametros
                    var entrevistado = new
                    {
                        Pesquisa = pesquisa,
                        Celular = celular,
                        Nome = nome,
                        Apelido = apelido,
                        Referencia = referencia
                    };

                    try
                    {
                        var post = await ws.PostAsync("sms/entrevistado", new StringContent(
    JsonConvert.SerializeObject(entrevistado), Encoding.UTF8, "application/json"));
                        var resposta = JsonConvert.DeserializeObject<RespostaEntrevistado>(await post.Content.ReadAsStringAsync());

                        if (resposta.Status == StatusEntrevistado.Sucesso)
                        {
                            //identificador do entrevistado
                            return resposta.Sequencia;
                        }
                        else
                        {
                            //resposta.StatusMensagem explica por que não foi cadastrado o entrevistado
                            throw new Exception(resposta.StatusMensagem);
                        }
                    }
                    catch (Exception ex)
                    {
                        //tratamento exceção, conferir usuário/senha, url etc
                        throw ex;
                    }
                }
            }

            enum StatusEntrevistado
            {
                Erro,
                Sucesso,
                CamposInvalidos,
                PesquisaInvalida
            }

            class RespostaEntrevistado
            {
                public int Sequencia;
                public StatusEntrevistado Status;
                public string StatusMensagem;
            }
        }
        #endregion

        #region usuário
        public enum ConfirmacaoRespostaPor
        {
            Nao,
            PorSMS,
            PorEmail,
            PorSMSEmail
        }

        public partial class SMS
        {
            public async Task CadastreUsuario(string login, string senha, string celular, string email, string nome, ConfirmacaoRespostaPor confirmacao, ConfirmacaoRespostaPor resposta, string assinatura = null, bool vendedor = false)
            {
                using (var ws = new HttpClient())
                {
                    ws.BaseAddress = new Uri("https://ws.smsdigital.com.br/");
                    ws.DefaultRequestHeaders.Accept.Clear();
                    ws.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    ws.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", Usuario, Senha))));

                    //objeto para envio
                    var novoUsuario = new
                    {
                        Login = login,
                        Senha = senha,
                        Celular = celular,
                        Email = email,
                        Nome = nome,
                        Confirmacao = confirmacao,
                        Resposta = resposta,
                        Assinatura = assinatura,
                        Vendedor = vendedor
                    };

                    try
                    {
                        //fazendo a chamada                    
                        var post = await ws.PostAsync("sms/usuario", new StringContent(
    JsonConvert.SerializeObject(novoUsuario), Encoding.UTF8, "application/json"));
                        var retorno = JsonConvert.DeserializeObject<RespostaUsuario>(await post.Content.ReadAsStringAsync());

                        if (retorno.Status == StatusUsuario.Sucesso)
                        {
                            //usuário cadastrado
                        }
                        else
                        {
                            //resposta.StatusMensagem explica por que não foi cadastrado o usuário
                            throw new Exception(retorno.StatusMensagem);
                        }
                    }
                    catch (Exception ex)
                    {
                        //tratamento exceção, conferir usuário/senha, url etc
                        throw ex;
                    }
                }
            }

            enum StatusUsuario
            {
                Erro,
                Sucesso,
                CotaExcedida,
                UsuarioExistente,
                CamposObrigatorios,
                CamposInvalidos
            }

            class RespostaUsuario
            {
                public StatusUsuario Status;
                public string StatusMensagem;
            }
        }
        #endregion

        #region transferência
        public partial class SMS
        {
            public async Task TransfiraCreditos(string Subusuario, uint Quantidade)
            {
                using (var ws = new HttpClient())
                {
                    ws.BaseAddress = new Uri("https://ws.smsdigital.com.br/");
                    ws.DefaultRequestHeaders.Accept.Clear();
                    ws.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    ws.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", Usuario, Senha))));

                    //objeto com os parâmetros de transferência
                    var transferencia = new
                    {
                        Quantidade = Quantidade,
                        Subusuario = Subusuario
                    };

                    try
                    {
                        //fazendo a chamada
                        var post = await ws.PostAsync("sms/transferencia", new StringContent(
    JsonConvert.SerializeObject(transferencia), Encoding.UTF8, "application/json"));
                        var resposta = JsonConvert.DeserializeObject<RespostaTransferencia>(await post.Content.ReadAsStringAsync());

                        if (resposta.Status == StatusTransferencia.Sucesso)
                        {
                            //créditos transferidos
                        }
                        else
                        {
                            //resposta.StatusMensagem explica qual o motivo do não envio
                            throw new Exception(resposta.StatusMensagem);
                        }
                    }
                    catch (Exception ex)
                    {
                        //tratar exceção, conferir usuário/senha, url etc
                        throw ex;
                    }
                }
            }
        }

        public enum StatusTransferencia
        {
            Erro,
            Sucesso,
            TransferenciaInvalida,
            CreditosInsuficientesExpirados
        }
        public class RespostaTransferencia
        {
            public StatusTransferencia Status;
            public string StatusMensagem;
        }
        #endregion
        public class EnviaSms : SMS
        {
            public EnviaSms(string usuario, string senha) : base(usuario, senha)
            {

            }

        }
    }
