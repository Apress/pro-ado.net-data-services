using System;
using System.Data.Services;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;

[System.ServiceModel.ServiceBehavior(IncludeExceptionDetailInFaults = true)] 
public class CustomSource : DataService<MyDataModel>
{
    // This method is called only once to initialize service-wide policies.
    public static void InitializeService(IDataServiceConfiguration config)
    {
        config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);
        config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);

        config.UseVerboseErrors = true;
    }
}
