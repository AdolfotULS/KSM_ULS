using KSM_ULS.Models;
using System.Text.RegularExpressions;

namespace KSM_ULS.Views;

public partial class RegisterClientModal : ContentPage
{
    public event EventHandler<Client>? ClientSaved;

    private Client? _existingClient;
    private bool _isEditMode;

    public RegisterClientModal()
    {
        InitializeComponent();
        _isEditMode = false;
        NotificationPicker.SelectedIndex = 0;
    }

    public RegisterClientModal(Client existingClient) : this()
    {
        _existingClient = existingClient;
        _isEditMode = true;

        TitleLabel.Text = "Editar Cliente";
        SaveButton.Text = "Guardar Cambios";

        LoadClientData();
    }

    private void LoadClientData()
    {
        if (_existingClient == null) return;

        if (_existingClient.Type == "Empresa")
        {
            EmpresaTab.TextColor = Color.FromArgb("#0066FF");
            EmpresaUnderline.IsVisible = true;
            EmpresaUnderline.BackgroundColor = Color.FromArgb("#0066FF");

            PersonaTab.TextColor = Color.FromArgb("#666666");
            PersonaUnderline.IsVisible = false;

            EmpresaForm.IsVisible = true;
            PersonaForm.IsVisible = false;

            EmpresaNameEntry.Text = _existingClient.Name;
            EmpresaContactEntry.Text = _existingClient.ContactName;
            EmpresaEmailEntry.Text = _existingClient.Email;
            EmpresaPhoneEntry.Text = _existingClient.Phone;
            EmpresaAddressEntry.Text = _existingClient.Address;
        }
        else
        {
            PersonaTab.TextColor = Color.FromArgb("#0066FF");
            PersonaUnderline.IsVisible = true;
            PersonaUnderline.BackgroundColor = Color.FromArgb("#0066FF");

            EmpresaTab.TextColor = Color.FromArgb("#666666");
            EmpresaUnderline.IsVisible = false;

            PersonaForm.IsVisible = true;
            EmpresaForm.IsVisible = false;

            PersonaNameEntry.Text = _existingClient.Name;
            PersonaEmailEntry.Text = _existingClient.Email;
            PersonaPhoneEntry.Text = _existingClient.Phone;
            PersonaAddressEntry.Text = _existingClient.Address;
        }

        NotificationPicker.SelectedItem = _existingClient.NotificationPreference;
    }

    private void OnEmpresaTabClicked(object? sender, EventArgs e)
    {
        EmpresaTab.TextColor = Color.FromArgb("#0066FF");
        EmpresaUnderline.IsVisible = true;
        EmpresaUnderline.BackgroundColor = Color.FromArgb("#0066FF");

        PersonaTab.TextColor = Color.FromArgb("#666666");
        PersonaUnderline.IsVisible = false;

        EmpresaForm.IsVisible = true;
        PersonaForm.IsVisible = false;
    }

    private void OnPersonaTabClicked(object? sender, EventArgs e)
    {
        PersonaTab.TextColor = Color.FromArgb("#0066FF");
        PersonaUnderline.IsVisible = true;
        PersonaUnderline.BackgroundColor = Color.FromArgb("#0066FF");

        EmpresaTab.TextColor = Color.FromArgb("#666666");
        EmpresaUnderline.IsVisible = false;

        PersonaForm.IsVisible = true;
        EmpresaForm.IsVisible = false;
    }

    private async void OnSaveClicked(object? sender, EventArgs e)
    {
        Client client;

        if (EmpresaForm.IsVisible)
        {
            if (string.IsNullOrWhiteSpace(EmpresaNameEntry.Text) ||
                string.IsNullOrWhiteSpace(EmpresaEmailEntry.Text) ||
                string.IsNullOrWhiteSpace(EmpresaContactEntry.Text))
            {
                await DisplayAlert("Error", "Por favor complete todos los campos requeridos", "OK");
                return;
            }

            if (!IsValidEmail(EmpresaEmailEntry.Text))
            {
                await DisplayAlert("Error", "Por favor ingrese un email válido", "OK");
                return;
            }

            client = new Client
            {
                Name = EmpresaNameEntry.Text,
                ContactName = EmpresaContactEntry.Text,
                Email = EmpresaEmailEntry.Text,
                Phone = EmpresaPhoneEntry.Text ?? string.Empty,
                Address = EmpresaAddressEntry.Text ?? string.Empty,
                Type = "Empresa",
                NotificationPreference = NotificationPicker.SelectedItem?.ToString() ?? "Email"
            };
        }
        else
        {
            if (string.IsNullOrWhiteSpace(PersonaNameEntry.Text) ||
                string.IsNullOrWhiteSpace(PersonaEmailEntry.Text))
            {
                await DisplayAlert("Error", "Por favor complete todos los campos requeridos", "OK");
                return;
            }

            if (!IsValidEmail(PersonaEmailEntry.Text))
            {
                await DisplayAlert("Error", "Por favor ingrese un email válido", "OK");
                return;
            }

            client = new Client
            {
                Name = PersonaNameEntry.Text,
                ContactName = PersonaNameEntry.Text,
                Email = PersonaEmailEntry.Text,
                Phone = PersonaPhoneEntry.Text ?? string.Empty,
                Address = PersonaAddressEntry.Text ?? string.Empty,
                Type = "Persona",
                NotificationPreference = NotificationPicker.SelectedItem?.ToString() ?? "SMS"
            };
        }

        if (_isEditMode && _existingClient != null)
        {
            client.Id = _existingClient.Id;
            client.RegisterDate = _existingClient.RegisterDate;
            client.ActiveTickets = _existingClient.ActiveTickets;
        }

        ClientSaved?.Invoke(this, client);
        await Navigation.PopModalAsync();
    }

    private async void OnCancelClicked(object? sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void OnCloseClicked(object? sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void OnOverlayTapped(object? sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private bool IsValidEmail(string email)
    {
        var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, emailPattern);
    }
}
