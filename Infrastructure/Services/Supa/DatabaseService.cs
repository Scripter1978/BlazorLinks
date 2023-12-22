using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Logging;
using Core.Entities;

namespace Infrastructure.Services.Supa;

public class DatabaseService
{
	private readonly Supabase.Client _client;
	private readonly AuthenticationStateProvider _customAuthStateProvider;
	// private readonly ILocalStorageService _localStorage;
	private readonly ILogger<DatabaseService> _logger;
	// private readonly IDialogService _dialogService;

    public DatabaseService(
        Supabase.Client client,
        AuthenticationStateProvider customAuthStateProvider,
        // ILocalStorageService localStorage,
        ILogger<DatabaseService> logger
    // IDialogService dialogService
		)
    {
        logger.LogInformation("------------------- CONSTRUCTOR -------------------");

        _client = client;
        _customAuthStateProvider = customAuthStateProvider;
        // _localStorage = localStorage;
        _logger = logger;
        // _dialogService = dialogService;
    }

    public async Task<IReadOnlyList<TModel>> From<TModel>() where TModel : BaseModelAp, new()
	{
		var modeledResponse = await _client
			.From<TModel>()
			.Where(x => x.IsDeleted == false)
			.Get();
		return modeledResponse.Models;
	}

	public async Task<List<TModel>> Delete<TModel>(TModel item) where TModel : BaseModelAp, new()
	{
		var modeledResponse = await _client
			.From<TModel>()
			.Delete(item);
		return modeledResponse.Models;
	}

	public async Task<List<TModel>?> Insert<TModel>(TModel item) where TModel : BaseModelAp, new()
	{
		Postgrest.Responses.ModeledResponse<TModel> modeledResponse;
		try
		{
			modeledResponse = await _client
				.From<TModel>()
				.Insert(item);
			if (modeledResponse.ResponseMessage is { IsSuccessStatusCode: true })
			{
				return modeledResponse.Models;
			}
			//TODO need to add in how to handle unsuccessful http request. Thinking returning a tuple. 
		}
		catch (Exception ex)
		{
			//TODO Add in how Ex is handled
		}
		
		return null;		
	}

	public async Task<List<TModel>> SoftDelete<TModel>(TModel item) where TModel : BaseModelAp, new()
    {
        var modeledResponse = await _client.Postgrest
			.Table<TModel>()
            .Set(x => x.IsDeleted, true)
            .Set(x => x.UpdateAt, DateTime.Now)
            .Where(x => x.Id == item.Id)
            // .Filter(x => x.Id, Operator.Equals, item.Id)
            .Update();
        return modeledResponse.Models;
    }
}