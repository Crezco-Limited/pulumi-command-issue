using Pulumi.AzureNative.Resources;
using Pulumi.Command.Local;
using Deployment = Pulumi.Deployment;

return await Deployment.RunAsync(() =>
{
   var command = new Command("no-op-command", new()
   {
      Create = "az storage account list"
   });
   
   var rg = new ResourceGroup("my-resource-group", new ResourceGroupArgs
   {
      Location = "uksouth"
   });
});
