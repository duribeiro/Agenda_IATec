using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_IATec.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
        public int Tipo { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("IdentityUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual IdentityUser IdentityUser { get; set; }
    }
}
