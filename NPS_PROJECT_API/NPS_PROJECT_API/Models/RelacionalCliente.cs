using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NPS_PROJECT_API.Models
{
    [Table(name:"TBL_NPS_PROJECT_RELACIONAL_CLIENTE")]
    public class RelacionalCliente
    {

        [Key]
        public int NUM_ID { get; set; }
        [Required]

        [Column(name: "CHR_DATA_RESPOSTA")]
        [JsonPropertyName("Data da Resposta")]
        public String col1 { get; set; }


        [Column(name: "CHR_PESQUISA")]
        [JsonPropertyName("Pesquisa")]
        public String col2 { get; set; }


        [Column(name: "CHR_SHOPPING")]
        [JsonPropertyName("Shopping")]
        public String col3 { get; set; }


        
        [Column(name: "CHR_NPS")]
        [JsonPropertyName("NPS")]
        public String col4 { get; set; }


        [Column(name: "CHR_NPS_MELHORAR")]
        [JsonPropertyName("Poxa! E o  que podemos melhorar em sua opinião?")]
        public String col5 { get; set; }


        [Column(name: "CHR_META10_MELHORAR")]
        [JsonPropertyName("Nossa meta é receber um 9 ou 10! O que podemos melhorar na sua opinião?")]
        public String col6 { get; set; }


        [Column(name: "CHR_INFLUENCIA_NOTA")]
        [JsonPropertyName("Legal! E o que mais influenciou a sua nota?")]
        public String col7 { get; set; }

        [Column(name: "CHR_FREQUENCIA_SHOPPING")]
        [JsonPropertyName("Com qual frequência você nos visita?")]
        public String col8 { get; set; }


        [Column(name: "CHR_COMENTARIO_SUGESTAO")]
        [JsonPropertyName("Gostaria de deixar um comentário, sugestão ou crítica? Queremos muito te ouvir.")]
        public String col9 { get; set; }


        public RelacionalCliente()
        {
        }
    }
}
