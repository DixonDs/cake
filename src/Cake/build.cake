#addin "nuget:?package=Cake.Azure&prerelease"
#addin "Cake.Json"

Task("Default")
    .Does(() =>
{
	var parametersFile = File("test.json");
    var json = ParseJsonFromFile(parametersFile);
	
	var creds = AzureLogin("d7093539-83cd-4991-b1b3-aacef74cf097", "57b20f9e-8678-436d-879a-d329b086f21b", "iGoMyVVY58z3UY1AHEQG");
});


RunTarget("Default");