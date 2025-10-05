using System.Collections.ObjectModel;
using KSM_ULS.Model;

namespace KSM_ULS.Views;

public partial class DashClientsView : ContentView
{
	public ObservableCollection<Client> AllClients { get; set; }
	public ObservableCollection<Client> FilteredClients { get; set; }

	public DashClientsView()
	{
		InitializeComponent();

		AllClients = new ObservableCollection<Client>();
		FilteredClients = new ObservableCollection<Client>();

		BindingContext = this;
		FilterPicker.SelectedIndex = 0;
	}

	private async void OnNewClientClicked(object? sender, EventArgs e)
	{
		var modal = new RegisterClientModal();
		modal.ClientSaved += OnClientSaved;
		await Navigation.PushModalAsync(modal);
	}

	private async void OnEditClientClicked(object? sender, EventArgs e)
	{
		if (sender is Button button && button.CommandParameter is Client client)
		{
			var modal = new RegisterClientModal(client);
			modal.ClientSaved += OnClientUpdated;
			await Navigation.PushModalAsync(modal);
		}
	}

	private void OnClientSaved(object? sender, Client client)
	{
		client.Id = $"CLI-{(AllClients.Count + 1):000}";
		client.RegisterDate = DateTime.Now;

		AllClients.Insert(0, client);
		ApplyFilters();
	}

	private void OnClientUpdated(object? sender, Client updatedClient)
	{
		var existingClient = AllClients.FirstOrDefault(c => c.Id == updatedClient.Id);
		if (existingClient != null)
		{
			var index = AllClients.IndexOf(existingClient);
			AllClients[index] = updatedClient;
			ApplyFilters();
		}
	}

	private void OnSearchTextChanged(object? sender, TextChangedEventArgs e)
	{
		ApplyFilters();
	}

	private void OnFilterChanged(object? sender, EventArgs e)
	{
		ApplyFilters();
	}

	private void ApplyFilters()
	{
		var searchText = SearchBar?.Text?.ToLower() ?? "";
		var selectedFilter = FilterPicker?.SelectedItem?.ToString() ?? "Todos";

		var filtered = AllClients.Where(c =>
		{
			bool matchesSearch = string.IsNullOrEmpty(searchText) ||
								 c.Name.ToLower().Contains(searchText) ||
								 c.Email.ToLower().Contains(searchText) ||
								 c.ContactName.ToLower().Contains(searchText);

			bool matchesType = selectedFilter == "Todos" || c.Type == selectedFilter;

			return matchesSearch && matchesType;
		}).ToList();

		FilteredClients.Clear();
		foreach (var client in filtered)
		{
			FilteredClients.Add(client);
		}
	}
}
