using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace MultiTargetLookupGenerator
{
    public partial class Get
    {
        public static List<EntityMetadata> GetEntities(IOrganizationService Service)
        {
            List<EntityMetadata> entities = null;
            try
            {
                var request = new RetrieveAllEntitiesRequest
                {
                    EntityFilters = EntityFilters.All
                };

                var response = (RetrieveAllEntitiesResponse)Service.Execute(request);
                entities = response.EntityMetadata.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return entities;
        }
    }
}
