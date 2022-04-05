using System;
using System.Collections.Generic;
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
        public List<UserEvent> UsersEvents { get; set; }
    }
}
