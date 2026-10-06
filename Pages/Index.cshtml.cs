using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerPortalWebSite_Net8.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;

        public bool CustomerRewardsEnabled { get; private set; }
        public bool PaymentGatewayEnabled { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void OnGet()
        {
            CustomerRewardsEnabled =
                _configuration.GetValue<bool>(
                    "FeatureFlags:CustomerRewards");

            PaymentGatewayEnabled =
                _configuration.GetValue<bool>(
                    "FeatureFlags:PaymentGateway");
        }
    }
}