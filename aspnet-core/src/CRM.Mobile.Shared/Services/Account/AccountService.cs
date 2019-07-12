using System.Threading.Tasks;
using Abp.Dependency;
using Acr.UserDialogs;
using CRM.ApiClient;
using CRM.ApiClient.Models;
using CRM.Core.DataStorage;
using CRM.Core.Threading;
using CRM.Localization;
using CRM.Services.Navigation;
using CRM.Sessions;
using CRM.Sessions.Dto;
using CRM.ViewModels.Base;
using CRM.Views;

namespace CRM.Services.Account
{
    public class AccountService : IAccountService, ISingletonDependency
    {
        private readonly IDataStorageManager _dataStorageManager;
        private readonly IApplicationContext _applicationContext;
        private readonly ISessionAppService _sessionAppService;
        private readonly IAccessTokenManager _accessTokenManager;
        private readonly INavigationService _navigationService;

        public AccountService(
            IDataStorageManager dataStorageManager,
            IApplicationContext applicationContext,
            ISessionAppService sessionAppService,
            IAccessTokenManager accessTokenManager,
            INavigationService navigationService,
            AbpAuthenticateModel abpAuthenticateModel)
        {
            _dataStorageManager = dataStorageManager;
            _applicationContext = applicationContext;
            _sessionAppService = sessionAppService;
            _accessTokenManager = accessTokenManager;
            _navigationService = navigationService;
            AbpAuthenticateModel = abpAuthenticateModel;
        }

        public AbpAuthenticateModel AbpAuthenticateModel { get; set; }
        public AbpAuthenticateResultModel AuthenticateResultModel { get; set; }

        public async Task LoginUserAsync()
        {
            await WebRequestExecuter.Execute(_accessTokenManager.LoginAsync, AuthenticateSucceed, ex => Task.CompletedTask);
        }

        private async Task AuthenticateSucceed(AbpAuthenticateResultModel result)
        {
            AuthenticateResultModel = result;
            if (AuthenticateResultModel.ShouldResetPassword)
            {
                await UserDialogs.Instance.AlertAsync(L.Localize("ChangePasswordToLogin"), L.Localize("LoginFailed"), L.Localize("Ok"));
                return;
            }

            if (AuthenticateResultModel.RequiresTwoFactorVerification)
            {
                await _navigationService.SetMainPage<SendTwoFactorCodeView>(AuthenticateResultModel);
                return;
            }

            if (string.IsNullOrEmpty(AbpAuthenticateModel.TwoFactorVerificationCode))
            {
                await SaveCredentialsAsync();
            }
            
            await SetCurrentUserInfoAsync();
            await UserConfigurationManager.GetAsync();
            await _navigationService.SetMainPage<MainView>(clearNavigationHistory: true);
        }

        private async Task SaveCredentialsAsync()
        {
            await _dataStorageManager.StoreAsync(DataStorageKey.Username, AbpAuthenticateModel.UserNameOrEmailAddress);
            await _dataStorageManager.StoreAsync(DataStorageKey.TenancyName, _applicationContext.CurrentTenant?.TenancyName);
            await _dataStorageManager.StoreAsync(DataStorageKey.TenantId, _applicationContext.CurrentTenant?.TenantId);
            await _dataStorageManager.StoreAsync(DataStorageKey.Password, AbpAuthenticateModel.Password, true);
        }

        private async Task SetCurrentUserInfoAsync()
        {
            await WebRequestExecuter.Execute(async () =>
                await _sessionAppService.GetCurrentLoginInformations(), GetCurrentUserInfoExecuted);
        }

        private Task GetCurrentUserInfoExecuted(GetCurrentLoginInformationsOutput result)
        {
            _applicationContext.LoginInfo = result;
            return Task.CompletedTask;
        }
    }
}