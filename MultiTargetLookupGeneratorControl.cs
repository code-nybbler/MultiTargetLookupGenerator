using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text.RegularExpressions;
using XrmToolBox.Extensibility;
using Label = Microsoft.Xrm.Sdk.Label;

namespace MultiTargetLookupGenerator
{
    public partial class MultiTargetLookupGeneratorControl : PluginControlBase
    {
        private Dictionary<string, Guid> solutions;
        private List<EntityMetadata> entities;
        private string prefix, entity, schemaFormat, solution, schemaName, logicalName;
        private int requirement;

        public MultiTargetLookupGeneratorControl()
        {
            InitializeComponent();
        }
        private void tsb_Close_Click(object sender, EventArgs e)
        {
            CloseTool();
        }
        private void box_Entity_SelectedIndexChanged(object sender, EventArgs e)
        {
            entity = box_Entity.SelectedItem.ToString();
            CheckSelections();
        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            schemaName = prefix + ApplySelectedFormat(txt_Label.Text);
            logicalName = schemaName.ToLower();
            if (CheckFieldNameConflict())
            {
                ShowErrorDialog(new Exception("An attribute with the same logical name already exists."), "Name conflict found");
            }
            else
            {
                ExecuteMethodAsync(CreateLookup, "Creating polymorphic lookup...");
            }            
        }
        private void btn_Publish_Click(object sender, EventArgs e)
        {
            ExecuteMethodAsync(PublishCustomizations, "Publishing customizations...");
        }
        private void box_Solution_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, Guid> solutionKVP = solutions.FirstOrDefault(x => x.Key == box_Solution.Text);

            if (solutionKVP.Key != null)
            {
                RetrievePublisher(solutionKVP.Value);
                solution = box_Solution.Text;
            }
            CheckSelections();
        }
        private void txt_Label_TextChanged(object sender, EventArgs e)
        {
            CheckSelections();
        }
        private void tsb_LoadEntities_Click(object sender, EventArgs e)
        {
            ClearInputs();
            ExecuteMethod(LoadEntities);
        }
        private void box_Requirement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (box_Requirement.SelectedIndex > -1) requirement = box_Requirement.SelectedIndex == 0 ? 0 : box_Requirement.SelectedIndex + 1;
            CheckSelections();
        }
        private void lst_Format_SelectedIndexChanged(object sender, EventArgs e)
        {
            schemaFormat = lst_Format.SelectedIndex > -1 ? lst_Format.SelectedItem.ToString() : string.Empty;
            CheckSelections();
        }
        private void lst_Targets_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSelections();
        }


        private string ApplySelectedFormat(string source)
        {
            switch (schemaFormat)
            {
                case "camelCase":
                    source = RemovePunctuations(ToCamelCase(source));
                    break;
                case "lowercase":
                    source = RemovePunctuations(source).ToLower();
                    break;
                case "PascalCase":
                    source = RemovePunctuations(source);
                    break;
                case "UPPERCASE":
                    source = RemovePunctuations(source).ToUpper();
                    break;
                default: break;
            }

            return source;
        }
        private bool CheckFieldNameConflict()
        {
            return (entities.Where(e => e.Attributes.Where(a => a.LogicalName == logicalName).FirstOrDefault() != null).FirstOrDefault() != null);
        }
        private bool CheckRelationshipNameConflict(string relName)
        {
            return (entities.Where(e => e.ManyToOneRelationships.Where(r => r.SchemaName.ToLower() == relName).FirstOrDefault() != null).FirstOrDefault() != null);
        }
        private void CheckSelections()
        {
            if (box_Solution.SelectedItem == null || box_Entity.SelectedItem == null || txt_Label.Text.Length == 0 || box_Requirement.SelectedItem == null || lst_Format.SelectedItem == null || lst_Targets.CheckedItems.Count == 0)
            {
                btn_Create.Enabled = false;
            }
            else
            {
                btn_Create.Enabled = true;                
            }
        }
        private void ClearInputs()
        {
            box_Solution.Text = String.Empty;
            box_Entity.Text = String.Empty;
            txt_Label.Text = String.Empty;
            box_Requirement.SelectedItem = null;
        }
        private bool ConfirmCreation()
        {
            try
            {
                // Create the request
                RetrieveAttributeRequest attributeRequest = new RetrieveAttributeRequest
                {
                    EntityLogicalName = entity,
                    LogicalName = logicalName,
                    RetrieveAsIfPublished = true
                };

                // Execute the request
                RetrieveAttributeResponse attributeResponse =
                    (RetrieveAttributeResponse)Service.Execute(attributeRequest);

                Console.WriteLine("Retrieved the attribute {0}.",
                    attributeResponse.AttributeMetadata.SchemaName);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void CreateLookup()
        {
            List<OneToManyRelationshipMetadata> targets = new List<OneToManyRelationshipMetadata>();
            OneToManyRelationshipMetadata newTargetMeta;

            string relName;
            foreach (string target in lst_Targets.CheckedItems)
            {
                relName = prefix + "poly_" + entity + "_" + target;

                // append number to relationship schema if there's a conflict
                for (int i=1; CheckRelationshipNameConflict(relName);)
                {
                    relName += i;
                }

                newTargetMeta = new OneToManyRelationshipMetadata
                {
                    ReferencedEntity = target,
                    ReferencingEntity = entity,
                    SchemaName = relName
                };
                targets.Add(newTargetMeta);
            }

            try
            {
                CreatePolymorphicLookupAttributeRequest multiLookupOrgReq = new CreatePolymorphicLookupAttributeRequest
                {
                    Lookup = new LookupAttributeMetadata()
                    {
                        SchemaName = schemaName,
                        DisplayName = new Label(txt_Label.Text, 1033),
                        RequiredLevel = new AttributeRequiredLevelManagedProperty((AttributeRequiredLevel)requirement)
                    },
                    OneToManyRelationships = targets.ToArray(),
                    SolutionUniqueName = solution
                };

                Service.Execute(multiLookupOrgReq);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
            }
        }
        private void DisableInputs()
        {
            box_Solution.Enabled = false;
            box_Entity.Enabled = false;
            txt_Label.Enabled = false;
            box_Requirement.Enabled = false;
            lst_Format.Enabled = false;
            lst_Targets.Enabled = false;
            btn_Create.Enabled = false;
        }
        private void EnableInputs()
        {
            box_Solution.Enabled = true;
            box_Entity.Enabled = true;
            txt_Label.Enabled = true;
            box_Requirement.Enabled = true;
            lst_Format.Enabled = true;
            lst_Targets.Enabled = true;
        }
        private void ExecuteMethodAsync(Action method, string message)
        {
            DisableInputs();
            WorkAsync(new WorkAsyncInfo
            {
                Message = message,
                Work = (w, e) =>
                {
                    // This code is executed in another thread
                    ExecuteMethod(method);

                    e.Result = 1;
                },
                ProgressChanged = e =>
                {
                    SetWorkingMessage(e.UserState.ToString());
                },
                PostWorkCallBack = e =>
                {
                    // This code is executed in the main thread
                    EnableInputs();
                    btn_Publish.Enabled = !btn_Publish.Enabled;

                    bool created = ConfirmCreation();
                    if (!created)
                    {
                        ShowErrorDialog(new Exception("Field creation failed - Check relationship limitations on selected tables."), "Field creation failed");
                    }
                },
                AsyncArgument = null,
                // Progress information panel size
                MessageWidth = 340,
                MessageHeight = 150
            });
        }
        private void LoadEntities()
        {
            DisableInputs();
            box_Entity.Items.Clear();
            lst_Targets.Items.Clear();

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieving entities...",
                Work = (w, e2) =>
                {
                    // This code is executed in another thread
                    entities = Get.GetEntities(Service);

                    w.ReportProgress(-1, "Entities loaded.");
                    e2.Result = 1;
                },
                ProgressChanged = e2 =>
                {
                    SetWorkingMessage(e2.UserState.ToString());
                },
                PostWorkCallBack = e2 =>
                {
                    // This code is executed in the main thread
                    ExecuteMethod(RetrieveSolutions);                    
                    foreach (var entity in entities)
                    {
                        box_Entity.Items.Add(entity.LogicalName);
                        lst_Targets.Items.Add(entity.LogicalName);
                    }
                    EnableInputs();
                },
                AsyncArgument = null,
                // Progress information panel size
                MessageWidth = 340,
                MessageHeight = 150
            });
        }
        private void MultiTargetLookupGeneratorControl_Load(object sender, EventArgs e)
        {
            solutions = new Dictionary<string, Guid>();
            entities = new List<EntityMetadata>();
        }
        private void MultiTargetLookupGeneratorControl_OnCloseTool(object sender, EventArgs e)
        {

        }
        private void PublishCustomizations()
        {
            PublishXmlRequest PublishRequest = new PublishXmlRequest
            {
                ParameterXml = "<importexportxml><entities><entity>" + entity + "</entity></entities></importexportxml>"
            };
            Service.Execute(PublishRequest);
        }
        private static string RemovePunctuations(string source)
        {
            return Regex.Replace(source, @"[^\w]", string.Empty);
        }
        private void RetrievePublisher(Guid publisherId)
        {
            QueryByAttribute query = new QueryByAttribute
            {
                EntityName = "publisher",
                ColumnSet = new ColumnSet("customizationprefix")
            };

            query.Attributes.Add("publisherid");
            query.Values.Add(publisherId);

            try
            {
                EntityCollection retrievedPublishers = Service.RetrieveMultiple(query);

                if (retrievedPublishers.Entities.Count > 0)
                {
                    prefix = retrievedPublishers.Entities[0]["customizationprefix"].ToString() + "_";
                }
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void RetrieveSolutions()
        {
            solutions.Clear();
            box_Solution.Items.Clear();

            QueryExpression query = new QueryExpression
            {
                EntityName = "solution",
                ColumnSet = new ColumnSet("uniquename", "publisherid"),
                Criteria = new FilterExpression()
            };

            query.Criteria.AddCondition("ismanaged", ConditionOperator.Equal, false);

            try
            {
                foreach (Entity solution in Service.RetrieveMultiple(query).Entities)
                {
                    if (solution["uniquename"].ToString() != "System" && solution["uniquename"].ToString() != "Active" && solution["uniquename"].ToString() != "Basic" && solution["uniquename"].ToString() != "ActivityFeeds" && !string.IsNullOrEmpty(solution["publisherid"].ToString()))
                    {
                        solutions.Add(solution["uniquename"].ToString(), solution.GetAttributeValue<EntityReference>("publisherid").Id);
                        box_Solution.Items.Add(solution["uniquename"]);
                    }
                }
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private string ToCamelCase(string source)
        {
            if (source.Contains(" ")) source = source.Split(' ')[0].ToLower() + string.Join(string.Empty, source.Split(' ').Skip(1).ToArray()).Replace(" ", string.Empty);
            else source = source.ToLower();

            return source;
        }
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
        }
    }
}