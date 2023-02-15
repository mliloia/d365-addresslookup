//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mat
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public enum ColumnMappingState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
	}
	
	/// <summary>
	/// Mapping for columns in a data map.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("columnmapping")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class ColumnMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string ColumnMappingId = "columnmappingid";
			public const string Id = "columnmappingid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportMapId = "importmapid";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ProcessCode = "processcode";
			public const string SourceAttributeName = "sourceattributename";
			public const string SourceEntityName = "sourceentityname";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TargetAttributeName = "targetattributename";
			public const string TargetEntityName = "targetentityname";
			public const string ColumnMapping_ImportMap = "ColumnMapping_ImportMap";
			public const string lk_columnmapping_createdby = "lk_columnmapping_createdby";
			public const string lk_columnmapping_createdonbehalfby = "lk_columnmapping_createdonbehalfby";
			public const string lk_columnmapping_modifiedby = "lk_columnmapping_modifiedby";
			public const string lk_columnmapping_modifiedonbehalfby = "lk_columnmapping_modifiedonbehalfby";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ColumnMapping() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "columnmapping";
		
		public const int EntityTypeCode = 4417;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier of the column mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("columnmappingid")]
		public System.Nullable<System.Guid> ColumnMappingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("columnmappingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ColumnMappingId");
				this.SetAttributeValue("columnmappingid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ColumnMappingId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("columnmappingid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.ColumnMappingId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the column mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the column mapping was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the columnmapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated data map.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importmapid")]
		public Microsoft.Xrm.Sdk.EntityReference ImportMapId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("importmapid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportMapId");
				this.SetAttributeValue("importmapid", value);
				this.OnPropertyChanged("ImportMapId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the column mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the column mapping was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the columnmapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Information about whether the column mapping needs to be processed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processcode")]
		public object ProcessCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("processcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessCode");
				this.SetAttributeValue("processcode", value);
				this.OnPropertyChanged("ProcessCode");
			}
		}
		
		/// <summary>
		/// Name of the source attribute.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourceattributename")]
		public string SourceAttributeName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("sourceattributename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SourceAttributeName");
				this.SetAttributeValue("sourceattributename", value);
				this.OnPropertyChanged("SourceAttributeName");
			}
		}
		
		/// <summary>
		/// Name of the source entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourceentityname")]
		public string SourceEntityName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("sourceentityname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SourceEntityName");
				this.SetAttributeValue("sourceentityname", value);
				this.OnPropertyChanged("SourceEntityName");
			}
		}
		
		/// <summary>
		/// Status of the column mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Mat.ColumnMappingState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Mat.ColumnMappingState)(System.Enum.ToObject(typeof(Mat.ColumnMappingState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
		}
		
		/// <summary>
		/// Reason for the status of the column mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public object StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// Name of the Microsoft Dynamics 365 attribute.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetattributename")]
		public string TargetAttributeName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("targetattributename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TargetAttributeName");
				this.SetAttributeValue("targetattributename", value);
				this.OnPropertyChanged("TargetAttributeName");
			}
		}
		
		/// <summary>
		/// Name of the Microsoft Dynamics 365 entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetentityname")]
		public string TargetEntityName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("targetentityname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TargetEntityName");
				this.SetAttributeValue("targetentityname", value);
				this.OnPropertyChanged("TargetEntityName");
			}
		}
		
		/// <summary>
		/// 1:N LookUpMapping_ColumnMapping
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("LookUpMapping_ColumnMapping")]
		public System.Collections.Generic.IEnumerable<Mat.LookUpMapping> LookUpMapping_ColumnMapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Mat.LookUpMapping>("LookUpMapping_ColumnMapping", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LookUpMapping_ColumnMapping");
				this.SetRelatedEntities<Mat.LookUpMapping>("LookUpMapping_ColumnMapping", null, value);
				this.OnPropertyChanged("LookUpMapping_ColumnMapping");
			}
		}
		
		/// <summary>
		/// N:1 ColumnMapping_ImportMap
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importmapid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ColumnMapping_ImportMap")]
		public Mat.ImportMap ColumnMapping_ImportMap
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Mat.ImportMap>("ColumnMapping_ImportMap", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ColumnMapping_ImportMap");
				this.SetRelatedEntity<Mat.ImportMap>("ColumnMapping_ImportMap", null, value);
				this.OnPropertyChanged("ColumnMapping_ImportMap");
			}
		}
		
		/// <summary>
		/// N:1 lk_columnmapping_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_createdby")]
		public Mat.SystemUser lk_columnmapping_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Mat.SystemUser>("lk_columnmapping_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_columnmapping_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_createdonbehalfby")]
		public Mat.SystemUser lk_columnmapping_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Mat.SystemUser>("lk_columnmapping_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_columnmapping_createdonbehalfby");
				this.SetRelatedEntity<Mat.SystemUser>("lk_columnmapping_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_columnmapping_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_columnmapping_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_modifiedby")]
		public Mat.SystemUser lk_columnmapping_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Mat.SystemUser>("lk_columnmapping_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_columnmapping_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_modifiedonbehalfby")]
		public Mat.SystemUser lk_columnmapping_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Mat.SystemUser>("lk_columnmapping_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_columnmapping_modifiedonbehalfby");
				this.SetRelatedEntity<Mat.SystemUser>("lk_columnmapping_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_columnmapping_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ColumnMapping(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["columnmappingid"] = base.Id;
                        break;
                    case "columnmappingid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}