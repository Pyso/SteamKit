//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: gcsystemmsgs.proto
namespace SteamKit2.GC.Internal
{
    [global::ProtoBuf.ProtoContract(Name=@"EGCSystemMsg", EnumPassthru=true)]
    public enum EGCSystemMsg
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgInvalid", Value=0)]
      k_EGCMsgInvalid = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMulti", Value=1)]
      k_EGCMsgMulti = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGenericReply", Value=10)]
      k_EGCMsgGenericReply = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgSystemBase", Value=50)]
      k_EGCMsgSystemBase = 50,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgAchievementAwarded", Value=51)]
      k_EGCMsgAchievementAwarded = 51,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgConCommand", Value=52)]
      k_EGCMsgConCommand = 52,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgStartPlaying", Value=53)]
      k_EGCMsgStartPlaying = 53,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgStopPlaying", Value=54)]
      k_EGCMsgStopPlaying = 54,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgStartGameserver", Value=55)]
      k_EGCMsgStartGameserver = 55,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgStopGameserver", Value=56)]
      k_EGCMsgStopGameserver = 56,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgWGRequest", Value=57)]
      k_EGCMsgWGRequest = 57,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgWGResponse", Value=58)]
      k_EGCMsgWGResponse = 58,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetUserGameStatsSchema", Value=59)]
      k_EGCMsgGetUserGameStatsSchema = 59,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetUserGameStatsSchemaResponse", Value=60)]
      k_EGCMsgGetUserGameStatsSchemaResponse = 60,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetUserStatsDEPRECATED", Value=61)]
      k_EGCMsgGetUserStatsDEPRECATED = 61,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetUserStatsResponse", Value=62)]
      k_EGCMsgGetUserStatsResponse = 62,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgAppInfoUpdated", Value=63)]
      k_EGCMsgAppInfoUpdated = 63,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgValidateSession", Value=64)]
      k_EGCMsgValidateSession = 64,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgValidateSessionResponse", Value=65)]
      k_EGCMsgValidateSessionResponse = 65,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgLookupAccountFromInput", Value=66)]
      k_EGCMsgLookupAccountFromInput = 66,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgSendHTTPRequest", Value=67)]
      k_EGCMsgSendHTTPRequest = 67,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgSendHTTPRequestResponse", Value=68)]
      k_EGCMsgSendHTTPRequestResponse = 68,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgPreTestSetup", Value=69)]
      k_EGCMsgPreTestSetup = 69,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgRecordSupportAction", Value=70)]
      k_EGCMsgRecordSupportAction = 70,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetAccountDetails_DEPRECATED", Value=71)]
      k_EGCMsgGetAccountDetails_DEPRECATED = 71,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgReceiveInterAppMessage", Value=73)]
      k_EGCMsgReceiveInterAppMessage = 73,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgFindAccounts", Value=74)]
      k_EGCMsgFindAccounts = 74,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgPostAlert", Value=75)]
      k_EGCMsgPostAlert = 75,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetLicenses", Value=76)]
      k_EGCMsgGetLicenses = 76,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetUserStats", Value=77)]
      k_EGCMsgGetUserStats = 77,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetCommands", Value=78)]
      k_EGCMsgGetCommands = 78,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetCommandsResponse", Value=79)]
      k_EGCMsgGetCommandsResponse = 79,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgAddFreeLicense", Value=80)]
      k_EGCMsgAddFreeLicense = 80,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgAddFreeLicenseResponse", Value=81)]
      k_EGCMsgAddFreeLicenseResponse = 81,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetIPLocation", Value=82)]
      k_EGCMsgGetIPLocation = 82,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetIPLocationResponse", Value=83)]
      k_EGCMsgGetIPLocationResponse = 83,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgSystemStatsSchema", Value=84)]
      k_EGCMsgSystemStatsSchema = 84,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetSystemStats", Value=85)]
      k_EGCMsgGetSystemStats = 85,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetSystemStatsResponse", Value=86)]
      k_EGCMsgGetSystemStatsResponse = 86,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgSendEmail", Value=87)]
      k_EGCMsgSendEmail = 87,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgSendEmailResponse", Value=88)]
      k_EGCMsgSendEmailResponse = 88,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetEmailTemplate", Value=89)]
      k_EGCMsgGetEmailTemplate = 89,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetEmailTemplateResponse", Value=90)]
      k_EGCMsgGetEmailTemplateResponse = 90,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGrantGuestPass", Value=91)]
      k_EGCMsgGrantGuestPass = 91,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGrantGuestPassResponse", Value=92)]
      k_EGCMsgGrantGuestPassResponse = 92,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetAccountDetails", Value=93)]
      k_EGCMsgGetAccountDetails = 93,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetAccountDetailsResponse", Value=94)]
      k_EGCMsgGetAccountDetailsResponse = 94,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetPersonaNames", Value=95)]
      k_EGCMsgGetPersonaNames = 95,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetPersonaNamesResponse", Value=96)]
      k_EGCMsgGetPersonaNamesResponse = 96,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMultiplexMsg", Value=97)]
      k_EGCMsgMultiplexMsg = 97,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgWebAPIRegisterInterfaces", Value=101)]
      k_EGCMsgWebAPIRegisterInterfaces = 101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgWebAPIJobRequest", Value=102)]
      k_EGCMsgWebAPIJobRequest = 102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgWebAPIJobRequestHttpResponse", Value=104)]
      k_EGCMsgWebAPIJobRequestHttpResponse = 104,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgWebAPIJobRequestForwardResponse", Value=105)]
      k_EGCMsgWebAPIJobRequestForwardResponse = 105,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMemCachedGet", Value=200)]
      k_EGCMsgMemCachedGet = 200,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMemCachedGetResponse", Value=201)]
      k_EGCMsgMemCachedGetResponse = 201,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMemCachedSet", Value=202)]
      k_EGCMsgMemCachedSet = 202,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMemCachedDelete", Value=203)]
      k_EGCMsgMemCachedDelete = 203,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMemCachedStats", Value=204)]
      k_EGCMsgMemCachedStats = 204,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMemCachedStatsResponse", Value=205)]
      k_EGCMsgMemCachedStatsResponse = 205,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgSQLStats", Value=210)]
      k_EGCMsgSQLStats = 210,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgSQLStatsResponse", Value=211)]
      k_EGCMsgSQLStatsResponse = 211,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMasterSetDirectory", Value=220)]
      k_EGCMsgMasterSetDirectory = 220,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMasterSetDirectoryResponse", Value=221)]
      k_EGCMsgMasterSetDirectoryResponse = 221,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMasterSetWebAPIRouting", Value=222)]
      k_EGCMsgMasterSetWebAPIRouting = 222,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMasterSetWebAPIRoutingResponse", Value=223)]
      k_EGCMsgMasterSetWebAPIRoutingResponse = 223,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMasterSetClientMsgRouting", Value=224)]
      k_EGCMsgMasterSetClientMsgRouting = 224,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgMasterSetClientMsgRoutingResponse", Value=225)]
      k_EGCMsgMasterSetClientMsgRoutingResponse = 225,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgSetOptions", Value=226)]
      k_EGCMsgSetOptions = 226,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgSetOptionsResponse", Value=227)]
      k_EGCMsgSetOptionsResponse = 227,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgSystemBase2", Value=500)]
      k_EGCMsgSystemBase2 = 500,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetPurchaseTrustStatus", Value=501)]
      k_EGCMsgGetPurchaseTrustStatus = 501,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetPurchaseTrustStatusResponse", Value=502)]
      k_EGCMsgGetPurchaseTrustStatusResponse = 502,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUpdateSession", Value=503)]
      k_EGCMsgUpdateSession = 503,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGCAccountVacStatusChange", Value=504)]
      k_EGCMsgGCAccountVacStatusChange = 504,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgCheckFriendship", Value=505)]
      k_EGCMsgCheckFriendship = 505,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgCheckFriendshipResponse", Value=506)]
      k_EGCMsgCheckFriendshipResponse = 506,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetPartnerAccountLink", Value=507)]
      k_EGCMsgGetPartnerAccountLink = 507,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgGetPartnerAccountLinkResponse", Value=508)]
      k_EGCMsgGetPartnerAccountLinkResponse = 508,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgVSReportedSuspiciousActivity", Value=509)]
      k_EGCMsgVSReportedSuspiciousActivity = 509
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ESOMsg", EnumPassthru=true)]
    public enum ESOMsg
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_ESOMsg_Create", Value=21)]
      k_ESOMsg_Create = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_ESOMsg_Update", Value=22)]
      k_ESOMsg_Update = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_ESOMsg_Destroy", Value=23)]
      k_ESOMsg_Destroy = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_ESOMsg_CacheSubscribed", Value=24)]
      k_ESOMsg_CacheSubscribed = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_ESOMsg_CacheUnsubscribed", Value=25)]
      k_ESOMsg_CacheUnsubscribed = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_ESOMsg_UpdateMultiple", Value=26)]
      k_ESOMsg_UpdateMultiple = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_ESOMsg_CacheSubscriptionRefresh", Value=28)]
      k_ESOMsg_CacheSubscriptionRefresh = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_ESOMsg_CacheSubscribedUpToDate", Value=29)]
      k_ESOMsg_CacheSubscribedUpToDate = 29
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGCBaseClientMsg", EnumPassthru=true)]
    public enum EGCBaseClientMsg
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCPingRequest", Value=3001)]
      k_EMsgGCPingRequest = 3001,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCPingResponse", Value=3002)]
      k_EMsgGCPingResponse = 3002,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCClientWelcome", Value=4004)]
      k_EMsgGCClientWelcome = 4004,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCServerWelcome", Value=4005)]
      k_EMsgGCServerWelcome = 4005,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCClientHello", Value=4006)]
      k_EMsgGCClientHello = 4006,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCServerHello", Value=4007)]
      k_EMsgGCServerHello = 4007,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCClientConnectionStatus", Value=4009)]
      k_EMsgGCClientConnectionStatus = 4009,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCServerConnectionStatus", Value=4010)]
      k_EMsgGCServerConnectionStatus = 4010
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGCToGCMsg", EnumPassthru=true)]
    public enum EGCToGCMsg
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCToGCMsgMasterAck", Value=150)]
      k_EGCToGCMsgMasterAck = 150,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCToGCMsgMasterAckResponse", Value=151)]
      k_EGCToGCMsgMasterAckResponse = 151,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCToGCMsgRouted", Value=152)]
      k_EGCToGCMsgRouted = 152,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCToGCMsgRoutedReply", Value=153)]
      k_EGCToGCMsgRoutedReply = 153,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCUpdateSubGCSessionInfo", Value=154)]
      k_EMsgGCUpdateSubGCSessionInfo = 154,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCRequestSubGCSessionInfo", Value=155)]
      k_EMsgGCRequestSubGCSessionInfo = 155,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCRequestSubGCSessionInfoResponse", Value=156)]
      k_EMsgGCRequestSubGCSessionInfoResponse = 156,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCToGCMsgMasterStartupComplete", Value=157)]
      k_EGCToGCMsgMasterStartupComplete = 157,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCToGCSOCacheSubscribe", Value=158)]
      k_EMsgGCToGCSOCacheSubscribe = 158,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCToGCSOCacheUnsubscribe", Value=159)]
      k_EMsgGCToGCSOCacheUnsubscribe = 159
    }
  
}
#pragma warning restore 1591
