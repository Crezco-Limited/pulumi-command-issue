using Pulumi;
using Pulumi.Command.Local;

return await Deployment.RunAsync(() =>
{
   var command = new Command("no-op-command", new()
   {
      Create = "az storage account list"
   });
});
