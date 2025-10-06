
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KSM_ULS.Model;
namespace KSM_ULS.Model
{
    public class Ticket //TODO revisar permisos de sistemas
    {
        public int Id { get; set; }
        public string ClientName { get; set; } //TODO transform this in a tecnitian class
        public string TecnitianNames { get; set; } //TODO transform this in a tecnitian class + deberia ser una lista, varios tecnicos mismo ticket
        public string LimitDate { get; set; }
        public string Description { get; set; }

        public string CreationDate { get; set; }
        public int ExpectedRemuneration = 0;
        protected int TicketState = 0; //0 inactivo, 1 en proceso, 2 finalizado TODO checkear esta logica

        public ProgressNotes[] TecnitianNotes { get; set; }//notas del ticket que tenga registradas, puedes verlo en detalles


        //optional
        private bool IsCopyTicket = false; //TODO save data of original version of ticket to recuparate if any case
        private Ticket CopyTicket;          // + could be a list of versions in DB instead of local machine 

        public Ticket(int idIn, string clientData, string tecnitianInCharge, string limitDate = "0/0/0",string descripcionIn="filler")
        {
            this.Id = idIn;
            this.ClientName = clientData;
            this.TecnitianNames = tecnitianInCharge;
            this.LimitDate = limitDate;
            this.CreationDate = "0/0/0"; //TODO , take date automaticamente
            this.Description = descripcionIn;
        }
        



        /// <summary>
        /// This function changes the state of the ticket object by a given paramenter , cases:
        /// <param name="setState"> |"inactive" --> ticket.ticketState = 0 </param>
        /// <param name="setState"> | "in progress" --> ticket.ticketState = 1 </param>
        /// <param name="setState"> | "finalized"--> ticket.ticketState = 2 </param>
        /// default --> ticket.ticketState = 0 
        /// </summary>        
        public void ChangeStateTicket(string setState) 
        {
            

            switch (setState)
            {
                case "incative":
                    this.TicketState = 0;
                    break;
                case "in progress":
                    this.TicketState = 1;
                    break;
                case "finalized":
                    this.TicketState = 2;
                    break;
                default: this.TicketState = 0; break;
            }
            
        }
        public int GetState() { return this.TicketState; }
        public void ChangeTecnitianInCharge(string[] tecnitianNames) //TODO adapt to class Tecnitian
        {
            //sets the 1 or multiple tecnitian in charge of this ticket
        }
        public void ChangeLimitDate(string newLimitDate) { 
            //call to set new limit date of ticket, in case somethign happens like client giving more time
            this.LimitDate = newLimitDate;
        }

        public void AddNote (string noteText, string author)//author seria el tecnico que lo escribio, puede rescatar datos de la cuenta actual
        {
            //adds note of case to ticket + optional
        }

    }
}
