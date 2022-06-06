using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NPS_PROJECT_API.Models
{
    [Table(name:"TBL_NPS_PROJECT_PESQUISA_GERAL")]
    public class PesquisaGeral
    {
            [Key]
            public int NUM_ID { get; set; }
            [Required]

            [Column(name: "CHR_DATA_RESPOSTA")]
            [JsonPropertyName("Data da Resposta")]
            public String CHR_DATA_RESPOSTA { get; set; }


            [Column(name: "CHR_PESQUISA")]
            [JsonPropertyName("Pesquisa")]
            public String CHR_PESQUISA { get; set; }



            [Column(name: "CHR_SHOPPING")]
            [JsonPropertyName("Shopping")]
            public String CHR_SHOPPING { get; set; }



            [Column(name: "CHR_ORIGEM")]
            [JsonPropertyName("Origem")]
            public String CHR_ORIGEM { get; set; }



            [Column(name: "CHR_NPS")]
            [JsonPropertyName("NPS")]
            public String CHR_NPS { get; set; }


            [Column(name: "CHR_NPS_COMENTARIO")]
            [JsonPropertyName("Gostaria de fazer algum comentário sobre a sua nota?")]
            public String CHR_NPS_COMENTARIO { get; set; }


            [Column(name: "CHR_UTILIZA_TECNOLOGIA")]
            [JsonPropertyName("Você considera que esse shopping utiliza a tecnologia (aplicativo, assistente virtual ou outras ferramentas digitais) para facilitar a vida e melhorar a experiência no shopping?")]
            public String CHR_UTILIZA_TECNOLOGIA { get; set; }


            [Column(name: "CHR_APP_MELHORAR")]
            [JsonPropertyName("O que podemos melhorar em nosso Aplicativo / Assistente Virtual?")]
            public String CHR_APP_MELHORAR { get; set; }


            [Column(name: "CHR_APP_OUTROS")]
            [JsonPropertyName("Outros (Aplicativo / Assistente Virtual)")]
            public String CHR_APP_OUTROS { get; set; }


            [Column(name: "CHR_TECNOLOGIA_MELHORAR")]
            [JsonPropertyName("E falando sobre a Tecnologia no shopping, o que podemos melhorar?")]
            public String CHR_TECNOLOGIA_MELHORAR { get; set; }


            [Column(name: "CHR_TECNOLOGIA_OUTROS")]
            [JsonPropertyName("Outros (Tecnologia no shopping)")]
            public String CHR_TECNOLOGIA_OUTROS { get; set; }


            [Column(name: "CHR_PRACA_ALIMENTACAO")]
            [JsonPropertyName("Praça de alimentação")]
            public String CHR_PRACA_ALIMENTACAO { get; set; }


            [Column(name: "CHR_PRACA_ALIMENTACAO_MELHORAR")]
            [JsonPropertyName("O que podemos melhorar (Praça de alimentação)")]
            public String CHR_PRACA_ALIMENTACAO_MELHORAR { get; set; }


            [Column(name: "CHR_BANHEIRO")]
            [JsonPropertyName("Banheiro")]
            public String CHR_BANHEIRO { get; set; }


            [Column(name: "CHR_BANHEIRO_MELHORAR")]
            [JsonPropertyName("O que podemos melhorar (Banheiro)")]
            public String CHR_BANHEIRO_MELHORAR { get; set; }


            [Column(name: "CHR_ESTACIONAMENTO")]
            [JsonPropertyName("Estacionamento")]
            public String CHR_ESTACIONAMENTO { get; set; }


            [Column(name: "CHR_ESTACIONAMENTO_MELHORAR")]
            [JsonPropertyName("O que podemos melhorar (Estacionamento)")]
            public String CHR_ESTACIONAMENTO_MELHORAR { get; set; }



            [Column(name: "CHR_SEGURANCA")]
            [JsonPropertyName("Percepção de segurança")]
            public String CHR_SEGURANCA { get; set; }


            [Column(name: "CHR_SEGURANCA_MELHORAR")]
            [JsonPropertyName("O que podemos melhorar (Percepção de segurança)")]
            public String CHR_SEGURANCA_MELHORAR { get; set; }


            [Column(name: "CHR_CORREDORES")]
            [JsonPropertyName("Corredores / Áreas comuns")]
            public String CHR_CORREDORES { get; set; }


            [Column(name: "CHR_CORREDORES_MELHORAR")]
            [JsonPropertyName("O que podemos melhorar (Corredores / Áreas comuns)")]
            public String CHR_CORREDORES_MELHORAR { get; set; }


            [Column(name: "CHR_LOJAS")]
            [JsonPropertyName("Lojas e serviços")]
            public String CHR_LOJAS { get; set; }


            [Column(name: "CHR_LOJAS_MELHORAR")]
            [JsonPropertyName("O que podemos melhorar (Lojas e serviços)")]
            public String CHR_LOJAS_MELHORAR { get; set; }


            [Column(name: "CHR_ATENDIMENTO")]
            [JsonPropertyName("Atendimento")]
            public String CHR_ATENDIMENTO { get; set; }


            [Column(name: "CHR_ATENDIMENTO_MELHORAR")]
            [JsonPropertyName("O que podemos melhorar (Atendimento)")]
            public String CHR_ATENDIMENTO_MELHORAR { get; set; }


            [Column(name: "CHR_CINEMA")]
            [JsonPropertyName("Cinema")]
            public String CHR_CINEMA { get; set; }


            [Column(name: "CHR_CINEMA_MELHORAR")]
            [JsonPropertyName("O que podemos melhorar (Cinema)")]
            public String CHR_CINEMA_MELHORAR { get; set; }



            [Column(name: "CHR_LAZER")]
            [JsonPropertyName("Lazer e eventos")]
            public String CHR_LAZER { get; set; }



            [Column(name: "CHR_LAZER_MELHORAR")]
            [JsonPropertyName("O que podemos melhorar (Lazer e eventos)")]
            public String CHR_LAZER_MELHORAR { get; set; }


            [Column(name: "CHR_ACESSIBILIDADE")]
            [JsonPropertyName("Acessibilidade")]
            public String CHR_ACESSIBILIDADE { get; set; }


            [Column(name: "CHR_ACESSIBILIDADE_MELHORAR")]
            [JsonPropertyName("O que podemos melhorar (Acessibilidade)")]
            public String CHR_ACESSIBILIDADE_MELHORAR { get; set; }


            [Column(name: "CHR_FREQUENCIA")]
            [JsonPropertyName("Com qual frequência você nos visita?")]
            public String CHR_FREQUENCIA { get; set; }


            [Column(name: "CHR_PERFIL_PESQUISA")]
            [JsonPropertyName("Em qual dessas opções você se encaixa?")]
            public String CHR_PERFIL_PESQUISA { get; set; }


            [Column(name: "CHR_COMENTARIO_SUGESTAO")]
            [JsonPropertyName("Gostaria de deixar um comentário adicional, reclamação, sugestão? Sinta-se à vontade, para nós é muito importante ouvir você!")]
            public String CHR_COMENTARIO_SUGESTAO { get; set; }

          public PesquisaGeral()
        {
        }
    }
    }
