using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Managers;

namespace GameLoginScreen
{
    public class Login : Script
    {
		[Command("openlogin")]
		public void OpenLogin(Client sender)
		{
			API.triggerClientEvent(sender, "setLoginUiVisible", true);
		}
	}	
}
