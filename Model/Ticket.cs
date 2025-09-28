
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
        public string clientName { get; set; } //TODO transform this in a tecnitian class
        public string[] tecnitianNames { get; set; } //TODO transform this in a tecnitian class
        public string limitDate { get; set; }
        public string creationDate { get; set; }
        public int expectedRemuneration = 0;
        protected int ticketState = 0; //0 inactivo, 1 en proceso, 2 finalizado TODO checkear esta logica

        public progressNotes[] tecnitianNotes { get; set; }//notas del ticket que tenga registradas, puedes verlo en detalles


        //optional
        private bool isCopyTicket = false; //TODO save data of original version of ticket to recuparate if any case
        private Ticket copyTicket;          // + could be a list of versions in DB instead of local machine 

        public Ticket(int idIn, string clientData, string[] tecnitianInCharge, string limitDate = "0/0/0")
        {
            this.Id = idIn;
            this.clientName = clientData;
            this.tecnitianNames = tecnitianInCharge;
            this.limitDate = limitDate;
            this.creationDate = "0/0/0"; //TODO , take date automaticamente
        }
        



        /// <summary>
        /// This function changes the state of the ticket object by a given paramenter , cases:
        /// <param name="setState"> |"inactive" --> ticket.ticketState = 0 </param>
        /// <param name="setState"> | "in progress" --> ticket.ticketState = 1 </param>
        /// <param name="setState"> | "finalized"--> ticket.ticketState = 2 </param>
        /// default --> ticket.ticketState = 0 
        /// </summary>        
        public void changeStateTicket(string setState) 
        {
            

            switch (setState)
            {
                case "incative":
                    this.ticketState = 0;
                    break;
                case "in progress":
                    this.ticketState = 1;
                    break;
                case "finalized":
                    this.ticketState = 2;
                    break;
                default: this.ticketState = 0; break;
            }
            
        }
        public int getState() { return this.ticketState; }
        public void changeTecnitianInCharge(string[] tecnitianNames) //TODO adapt to class Tecnitian
        {
            //sets the 1 or multiple tecnitian in charge of this ticket
        }
        public void changeLimitDate(string newLimitDate) { 
            //call to set new limit date of ticket, in case somethign happens like client giving more time
            this.limitDate = newLimitDate;
        }

        public void addNote (string noteText, string author)//author seria el tecnico que lo escribio, puede rescatar datos de la cuenta actual
        {
            //adds note of case to ticket + optional
        }

    }
}
