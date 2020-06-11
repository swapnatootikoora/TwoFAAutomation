using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoFA.APIRoots
{ 
public partial class GetTokenRoots
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("jsonrpc")]
    public string Jsonrpc { get; set; }

    [JsonProperty("result")]
    public Token_Result Result { get; set; }

    [JsonProperty("time")]
    public double Time { get; set; }

    [JsonProperty("version")]
    public string Version { get; set; }

    [JsonProperty("versionnumber")]
    public string Versionnumber { get; set; }

    [JsonProperty("signature")]
    public string Signature { get; set; }
}

public partial class Token_Result
{
    //[JsonProperty("status")]
    public bool Status { get; set; }

    //[JsonProperty("value")]
    public Value Value { get; set; }
}

public partial class Value
{
    [JsonProperty("log_level")]
    public long LogLevel { get; set; }

    [JsonProperty("menus")]
    public string[] Menus { get; set; }

    [JsonProperty("realm")]
    public string Realm { get; set; }

    [JsonProperty("rights")]
    public string[] Rights { get; set; }

    [JsonProperty("role")]
    public string Role { get; set; }

    [JsonProperty("token")]
    public string Token { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("logout_time")]
    public long LogoutTime { get; set; }

    [JsonProperty("token_page_size")]
    public long TokenPageSize { get; set; }

    [JsonProperty("user_page_size")]
    public long UserPageSize { get; set; }

    [JsonProperty("policy_template_url")]
    public Uri PolicyTemplateUrl { get; set; }

    [JsonProperty("default_tokentype")]
    public string DefaultTokentype { get; set; }

    [JsonProperty("user_details")]
    public bool UserDetails { get; set; }

    [JsonProperty("token_wizard")]
    public bool TokenWizard { get; set; }

    [JsonProperty("token_wizard_2nd")]
    public bool TokenWizard2Nd { get; set; }

    [JsonProperty("dialog_no_token")]
    public bool DialogNoToken { get; set; }

    [JsonProperty("search_on_enter")]
    public bool SearchOnEnter { get; set; }

    [JsonProperty("timeout_action")]
    public string TimeoutAction { get; set; }

    [JsonProperty("hide_welcome")]
    public bool HideWelcome { get; set; }

    [JsonProperty("hide_buttons")]
    public bool HideButtons { get; set; }

    [JsonProperty("show_seed")]
    public bool ShowSeed { get; set; }

    [JsonProperty("subscription_status")]
    public long SubscriptionStatus { get; set; }

    [JsonProperty("qr_image_android")]
    public object QrImageAndroid { get; set; }

    [JsonProperty("qr_image_ios")]
    public object QrImageIos { get; set; }

    [JsonProperty("qr_image_custom")]
    public object QrImageCustom { get; set; }
}
}

