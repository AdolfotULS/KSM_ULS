using System.ComponentModel;

namespace KSM_ULS.Models
{
    public class Client : INotifyPropertyChanged
    {
        private string _id = string.Empty;
        private string _name = string.Empty;
        private string _contactName = string.Empty;
        private string _email = string.Empty;
        private string _phone = string.Empty;
        private string _address = string.Empty;
        private string _type = string.Empty;
        private string _notificationPreference = string.Empty;
        private DateTime _registerDate;
        private int _activeTickets;

        public string Id
        {
            get => _id;
            set { _id = value; OnPropertyChanged(nameof(Id)); }
        }

        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }

        public string ContactName
        {
            get => _contactName;
            set { _contactName = value; OnPropertyChanged(nameof(ContactName)); }
        }

        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(nameof(Email)); }
        }

        public string Phone
        {
            get => _phone;
            set { _phone = value; OnPropertyChanged(nameof(Phone)); }
        }

        public string Address
        {
            get => _address;
            set { _address = value; OnPropertyChanged(nameof(Address)); }
        }

        public string Type
        {
            get => _type;
            set { _type = value; OnPropertyChanged(nameof(Type)); OnPropertyChanged(nameof(IconText)); OnPropertyChanged(nameof(TypeBadgeColor)); }
        }

        public string NotificationPreference
        {
            get => _notificationPreference;
            set { _notificationPreference = value; OnPropertyChanged(nameof(NotificationPreference)); OnPropertyChanged(nameof(NotificationBadgeColor)); }
        }

        public DateTime RegisterDate
        {
            get => _registerDate;
            set { _registerDate = value; OnPropertyChanged(nameof(RegisterDate)); OnPropertyChanged(nameof(RegisterDateFormatted)); }
        }

        public int ActiveTickets
        {
            get => _activeTickets;
            set { _activeTickets = value; OnPropertyChanged(nameof(ActiveTickets)); OnPropertyChanged(nameof(TicketsText)); OnPropertyChanged(nameof(TicketsBadgeColor)); }
        }

        public string IconText => Type == "Empresa" ? "🏢" : "👤";

        public string TypeBadgeColor => Type == "Empresa" ? "#B3E5FC" : "#B2DFDB";

        public string NotificationBadgeColor => NotificationPreference == "Email" ? "#C8E6C9" : "#C5E1A5";

        public string RegisterDateFormatted => $"Registrado: {RegisterDate:yyyy-MM-dd}";

        public string TicketsText => $"Tickets activos: {ActiveTickets}";

        public string TicketsBadgeColor => ActiveTickets > 0 ? "#EF5350" : "#BDBDBD";

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
